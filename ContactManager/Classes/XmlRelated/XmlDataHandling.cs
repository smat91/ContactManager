using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Data;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    class XmlDataHandling
    {
        // Dictioary für die verschiedenen Personentypen
        private Dictionary<personType, string> personTypeDict = new Dictionary<personType, string>();

        // Suchterm prüfen
        private bool CheckTerm(XElement referenzElement, personType type, XElement target, string attribute, string term) 
        {

            if (!target.HasElements && target.Parent.Name.LocalName.ToString() != "Log")
            {
                if (attribute == null)
                {
                    // Falls kein Attribut angewählt wurde alle Einträge Prüfen
                    return target.Value.ToString().Contains(term, StringComparison.OrdinalIgnoreCase);
                }
                else
                {
                    // Falls ein Wert übereinstimmt
                    if (target.Value.ToString().Contains(term, StringComparison.OrdinalIgnoreCase))
                    {
                        if (target.HasAttributes && referenzElement.HasAttributes)
                        {
                            // Falls das zu Prüfende XElement, dass dem Attribut entspricht selbst ein Attriut hat
                            // Prüfen ob der Wert des Attribute Type übereinstimmt da der Name bei diesem Element 
                            // nicht eindeutig ist (XElemente Telefon)
                            return target.Attribute("Type").Value == referenzElement.Attribute("Type").Value;
                        }
                        else if (!target.HasAttributes && !referenzElement.HasAttributes)
                        {
                            // Falls das zu Prüfende XElment, dass dem Attribut entspricht selbst kein Attriut hat
                            // Prüfen ob der Wert des Namen übereinstimmt da der Name bei diesem Element 
                            // eindeutig ist
                            return target.Name.LocalName == attribute;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    else
                    {
                        // Falls kein Wert übereinstimmt 
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

        }

        // Methode um alle Spalten zu ermitteln, die der übergebene Datensatz hat
        public XElement[] GetColumns(personType type)
        {
            XmlTemplate xmlTemplate = new XmlTemplate();
            XElement template = null;

            if (type == personType.customer)
            {
                template = xmlTemplate.XelementTemplateCustomer();
            }
            else if (type == personType.employee)
            {
                template = xmlTemplate.XelementTemplateEmployee();
            }
            else if (type == personType.trainee)
            {
                template = xmlTemplate.XelementTemplateTrainee();
            }

            // Liest alle XElemente aus dem ersten XElement das dem gewünschten Typ enspricht,
            // selbst keine Unterelemente haben und nicht zu Log oder MutationsLog gehörten aus
            // (Spalten in der Tabelle)
            return template.Descendants().
                Where(x => !x.HasElements &&
                            x.Name.LocalName.ToString() != "Logs" &&
                            x.Name.LocalName.ToString() != "MutationLogs" &&
                            x.Parent.Name.LocalName.ToString() != "Log" &&
                            x.Parent.Name.LocalName.ToString() != "MutationLog").
                ToArray();
        }

        // Methode um alle Spaltennamen zu ermitteln, die der gewünschte Datensatz hat
        public List<string> GetColumnNames(personType type)
        {
            // Liste für die Spaltennamen
            List<string> columnNames = new List<string>();

            foreach (XElement elemnt in GetColumns(type))
            {
                // Falls es sich um ein Element mit Attributen handelt,
                // wird der Spaltenname aus Element-Namen und Attribut-Wert
                // zusammengesetzt und der List hinzugefügt
                if (elemnt.HasAttributes)
                {
                    columnNames.Add(
                        elemnt.Name.LocalName.ToString() + " " +
                        elemnt.Attribute("Type").Value.ToString());
                }
                // Falls nicht wird Lediglich der Elementname der Liste
                // hinzugefügt
                else
                {
                    columnNames.Add(elemnt.Name.LocalName.ToString());
                }
            }

            return columnNames;
        }

        // Enumeration für die verschiedenen Personentypen
        public enum personType
        {
            customer,
            employee,
            trainee
        }

        public XmlDataHandling()
        {
            // Hinzufügen der verschiedenen Personentyem zum Dictionary
            personTypeDict.Add(personType.customer, "Customer");
            personTypeDict.Add(personType.employee, "Employee");
            personTypeDict.Add(personType.trainee, "Trainee");
        }

        public DataTable XElementToDataTable(ref XDocument xdocument, personType type)
        {
            // neue DataTable erzeugen wird als Datenquelle für DataGridViews beötigt
            DataTable dt = new DataTable();

            // Liest alle XElemente aus dem ersten XElement das dem gewünschten Typ enspricht,
            // selbst keine Unterelemente haben und nicht zu Log gehörten aus (Spalten in der Tabelle)
            XElement[] columns = GetColumns(type);

            // Liste für die Spaltennamen
            var columnNames = GetColumnNames(type);

            // Die Spaltennamen der DataTable hinzufügen
            foreach (string columnName in columnNames)
            {
                if (columnName == "Id")
                {
                    dt.Columns.Add(columnName, typeof(int));
                }
                else
                {
                    dt.Columns.Add(columnName, typeof(string));
                }
            }

            // Die Zeilen der DataTable hinzufügen
            foreach (XElement record in xdocument.Descendants(personTypeDict[type]))
            {
                // Eine neue Zeile hinzufügen
                DataRow newRow = dt.Rows.Add();

                // Die einzelnen Felder der Reihe mit den werden aus dem XML-Tree abfüllen
                foreach (string columnName in columnNames)
                {
                    IEnumerable<XElement> elements = record.DescendantsAndSelf().
                        Elements(columns[columnNames.IndexOf(columnName)].Name).
                        Where(x => !x.HasElements &&
                            x.Name.LocalName.ToString() != "Logs" &&
                            x.Name.LocalName.ToString() != "MutationLogs" &&
                            x.Parent.Name.LocalName.ToString() != "Log" &&
                            x.Parent.Name.LocalName.ToString() != "MutationLog");

                    if (elements.Count() > 1)
                    {
                        newRow[columnName] = (string)elements
                            .Where(x => x.Attribute("Type").Value == columns[columnNames.IndexOf(columnName)].Attribute("Type").Value)
                            .FirstOrDefault();
                    }
                    else 
                    { 
                        newRow[columnName] = (string)elements.FirstOrDefault();
                    }
                }
            }

            return dt;
        }

        public ref XElement IdToXElement(ref XDocument xdocument, personType type, string id)
        {
            // Liest alle XElemente aus die dem gewünschten Typ ensprechen,
            // selbst vom Typ Id sind und deren Wert der gewünschten Id entspricht.
            // anschliessend wird das Parentelement vom Ergebnis das dem gewünschten Typ
            // entpricht selektiert und im Array abgelegt
            XElement[] columns = xdocument.
                Descendants(personTypeDict[type]).
                Descendants().
                Where(x => x.Name.LocalName == "Id" && x.Value.ToString() == id).
                Ancestors(personTypeDict[type]).
                ToArray();

            // Auswahl und rückgabe des ersten Elementes
            return ref columns[0];
        }

        // Löscht ein Element anhand der zugehörigen Id
        public void DeleteElementById(ref XDocument xdocument, personType type, string id) 
        {
            IdToXElement(ref xdocument, type, id).DescendantsAndSelf().Remove();
        }

        public DataTable SearchInXDocument(ref XDocument xdocument, personType type, string searchTerm, string attribute = null)
        {
            // Liest alle XElemente aus dem ersten XElement das dem gewünschten Typ enspricht,
            // selbst keine Unterelemente haben und nicht zu Log gehörten aus (Spalten in der Tabelle)
            XElement[] columns = GetColumns(type);

            // Liste für die Spaltennamen
            var columnNames = GetColumnNames(type);

            // String in Array wandeln
            String[] searchTerms = searchTerm.Split(' ');

            // Prüfen, ob String zusammenhängend ist, wenn nach Attributen gesucht wird
            if (attribute != null && searchTerms.Count() > 1) {
                string message = "Eingabe darf nur aus einem Begriff bestehen, wenn die Attributsuche genutzt wird!";
                string caption = "Fehler in Eingabe erkannt";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                var result = MessageBox.Show(message, caption, buttons);
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    // Setzt die Suche auf Volltext
                    attribute = null;
                }
            }

            // Array für Suchergebnisse erzeugen und initial mit den zu
            // durchsuchenden elementen füllen
            List<XElement> searchResults = xdocument.
                Descendants(personTypeDict[type]).
                ToList();

            // XDokument nach Strings durchsuchen
            foreach (string term in searchTerms)
            {
                searchResults = searchResults.
                    Descendants().
                    Where(x => CheckTerm((attribute != null) ? columns[columnNames.IndexOf(attribute)] : null, type, x, attribute, term)).
                    Ancestors(personTypeDict[type]).
                    Distinct().
                    ToList(); 
            }

            // neue DataTable erzeugen wird als Datenquelle für DataGridViews beötigt
            DataTable dt = new DataTable();

            // Die Spaltennamen der DataTable hinzufügen
            foreach (string columnName in columnNames)
            {
                if (columnName == "Id")
                {
                    dt.Columns.Add(columnName, typeof(int));
                }
                else
                {
                    dt.Columns.Add(columnName, typeof(string));
                }
            }

            // Die Zeilen der DataTable hinzufügen
            foreach (XElement result in searchResults)
            {
                // Eine neue Zeile hinzufügen
                DataRow newRow = dt.Rows.Add();

                // Die einzelnen Felder der Reihe mit den werden aus dem XML-Tree abfüllen
                foreach (string columnName in columnNames)
                {
                    IEnumerable<XElement> elements = result.DescendantsAndSelf().
                        Elements(columns[columnNames.IndexOf(columnName)].Name).
                        Where(x => !x.HasElements &&
                            x.Name.LocalName.ToString() != "Logs" &&
                            x.Name.LocalName.ToString() != "MutationLogs" &&
                            x.Parent.Name.LocalName.ToString() != "Log" &&
                            x.Parent.Name.LocalName.ToString() != "MutationLog");

                    if (elements.Count() > 1)
                    {
                        newRow[columnName] = (string)elements
                            .Where(x => x.Attribute("Type").Value == columns[columnNames.IndexOf(columnName)].Attribute("Type").Value)
                            .FirstOrDefault();
                    }
                    else
                    {
                        newRow[columnName] = (string)elements.FirstOrDefault();
                    }
                }
            }

            return dt;
        }

        // Gibt die Anzahl Datensätze eines gewissen Personentyps zurück
        public int GetNumberOfDataSets(ref XDocument xdocument, personType type)
        {
            return xdocument.Descendants(personTypeDict[type]).Count();
        }

        // Gibt alle Mutationslogs zürock
        public DataTable GetMutationLogs(ref XDocument xdocument)
        {
            // neue DataTable erzeugen wird als Datenquelle für DataGridViews beötigt
            DataTable dt = new DataTable();

            // Array mit Ueberschriften erstellen
            string[] columns = { "Id", "Attribut", "Originalwert", "Aktualwert", "Zeitpunkt", };

            // Die Spaltennamen der DataTable hinzufügen
            foreach (string column in columns)
            {
                if (column == "Id")
                {
                    dt.Columns.Add(column, typeof(int));
                }
                else
                { 
                    dt.Columns.Add(column, typeof(string));
                }
            }

            // Die Zeilen der DataTable hinzufügen
            foreach (XElement record in xdocument.Descendants("MutationLogs").Descendants("MutationLog"))
            {
                // Eine neue Zeile hinzufügen
                DataRow newRow = dt.Rows.Add();

                // Die einzelnen Felder der Reihe mit den werden aus dem XML-Tree abfüllen
                foreach (string column in columns)
                {
                    IEnumerable<XElement> elements = record.DescendantsAndSelf().
                        Elements(column);

                    newRow[column] = (string)elements.FirstOrDefault();
                }
            }

            return dt;
        }

        // Importiert Daten aus einer CSV-Datei
        public void DataImportCsv(ref XDocument xdocument)
        {
            XmlTemplate xmlTemplate = new XmlTemplate();

            // Dialog zur Fileauswahl erzeugen
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Grundeinstellungen am Dialog setzen
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.DefaultExt = "csv";
                openFileDialog.Filter = "CSV Files|*.csv";
                openFileDialog.RestoreDirectory = true;

                // File dialog öffnen
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Pfad des gewählten files einlesen
                    string path = openFileDialog.FileName;

                    // File importieren
                    string[] lines = File.ReadAllLines(path, System.Text.Encoding.UTF8);

                    // Array mit den Header Daten erzeugen
                    string[] headers = lines[0].Split(';').Select(x => x.Trim('\"')).ToArray();

                    // Template-Objekte in die die Daten Abgefüllt werden
                    XElement customer = xmlTemplate.XelementTemplateCustomer();
                    XElement employee = xmlTemplate.XelementTemplateEmployee();
                    XElement trainee = xmlTemplate.XelementTemplateTrainee();

                    // Linie für Linie Einlesen und Objekte erzeugen
                    for (int i = 1; i < lines.Count(); i++)
                    {
                        // Linie aufsplitten
                        string[] lineContent = lines[i].Split(';').Select(x => x.Trim('\"')).ToArray();

                        // Id generieren
                        IEnumerable<XElement> idList =
                            from ids in xdocument.Descendants("Id")
                            orderby int.Parse(ids.Value)
                            select ids;

                        int id = (idList.Count() > 0) ? 1 + (int)idList.Last() : 1;

                        // Werte aus csv abfüllen
                        for (int j = 1; j < lineContent.Count(); j++)
                        {

                            string element = "";
                            string attribute = "";

                            // prüfen ob zulesendes Element leer ist
                            if (lineContent[j].All(char.IsWhiteSpace) || lineContent[j].Length == 0)
                            {
                                continue;
                            }

                            // Prüfen ob Header string aus mehteren Teilen besteht
                            if (headers[j].Any(char.IsWhiteSpace))
                            {
                                element = headers[j].Split(' ')[0];
                                attribute = headers[j].Split(' ')[1];
                            }
                            else
                            {
                                element = headers[j];
                            }

                            // Daten in jeweiliges Objekt abfüllen
                            if (lineContent[0] == "Kunde")
                            {
                                XElement xElementCustomer = customer.Descendants(element)
                                     .Where(x => x.HasAttributes ? x.Attribute("Type").Value == attribute : true)
                                     .FirstOrDefault();
                                if (xElementCustomer != null)
                                {
                                    xElementCustomer.SetValue(lineContent[j]);
                                }
                                else
                                {
                                    string message = $"Attribut {element} im Personentyp {lineContent[0]} nicht vorhanden";
                                    string caption = "Fehler in csv erkannt";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                                    MessageBox.Show(message, caption, buttons);
                                }
                            }
                            else if (lineContent[0] == "Mitarbeiter")
                            {
                                XElement xElementEmployee = employee.Descendants(element)
                                    .Where(x => x.HasAttributes ? x.Attribute("Type").Value == attribute : true)
                                    .FirstOrDefault();

                                if (xElementEmployee != null)
                                {
                                    xElementEmployee.SetValue(lineContent[j]);
                                }
                                else
                                {
                                    string message = $"Attribut {element} im Personentyp {lineContent[0]} nicht vorhanden";
                                    string caption = "Fehler in csv erkannt";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                                    MessageBox.Show(message, caption, buttons);
                                }
                            }
                            else if (lineContent[0] == "Lernender")
                            {
                                XElement xElementTrainee = trainee.Descendants(element)
                                    .Where(x => x.HasAttributes ? x.Attribute("Type").Value == attribute : true)
                                    .FirstOrDefault();

                                if (xElementTrainee != null)
                                {
                                    xElementTrainee.SetValue(lineContent[j]);
                                }
                                else
                                {
                                    string message = $"Attribut {element} im Personentyp {lineContent[0]} nicht vorhanden";
                                    string caption = "Fehler in csv erkannt";
                                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                                    MessageBox.Show(message, caption, buttons);
                                }
                            }
                            else
                            {
                                string message = "Fehler bei csv prüfung ungültiger Eintrag erkannt";
                                string caption = "Fehler in csv erkannt";
                                MessageBoxButtons buttons = MessageBoxButtons.OK;

                                MessageBox.Show(message, caption, buttons);
                                break;
                            }
                        }

                        // id setzen und Objekt dem xdocument hinzufügen
                        if (lineContent[0] == "Kunde")
                        {
                            customer.Descendants("Id")
                                .FirstOrDefault().SetValue(id);
                            xdocument.Descendants("Customers").FirstOrDefault().AddFirst(customer);
                        }
                        else if (lineContent[0] == "Mitarbeiter")
                        {
                            employee.Descendants("Id")
                                .FirstOrDefault().SetValue(id);
                            xdocument.Descendants("Employees").FirstOrDefault().AddFirst(employee);
                        }
                        else if (lineContent[0] == "Lernender")
                        {
                            trainee.Descendants("Id")
                                .FirstOrDefault().SetValue(id);
                            xdocument.Descendants("Trainees").FirstOrDefault().AddFirst(trainee);
                        }

                        // Import abschliessen
                        Form1.Instance.SaveToXml();
                        Form1.Instance.LoadFromXml();
                    }

                }
            }
        }
    }
}

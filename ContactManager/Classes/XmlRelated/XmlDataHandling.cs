using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Data;
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

            // Variable für Landesinfo anlegen 
            CultureInfo culture = new CultureInfo("de-CH", true);

            if (!target.HasElements && target.Parent.Name.LocalName.ToString() != "Log")
            {
                if (attribute == null)
                {
                    // Falls kein Attribut angewählt wurde alle Einträge Prüfen
                    return culture.CompareInfo.IndexOf(target.Value.ToString(), term, CompareOptions.IgnoreCase) >= 0;
                }
                else
                {
                    // Falls ein Wert übereinstimmt
                    if (culture.CompareInfo.IndexOf(target.Value.ToString(), term, CompareOptions.IgnoreCase) >= 0)
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

        // Methode um alle Spalten zu ermitteln, die der gewünschte Datensatz hat
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
            // selbst keine Unterelemente haben und nicht zu Log gehörten aus (Spalten in der Tabelle)
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
                dt.Columns.Add(columnName, typeof(string));
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
                dt.Columns.Add(columnName, typeof(string));
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
                dt.Columns.Add(column, typeof(string));
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
    }
}

﻿using System;
using System.Collections.Generic;
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
                            // nicht eindeutig ist (XElemente Phone)
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
        public XElement[] GetColumns(ref XDocument xdocument, personType type)
        {

            // Liest alle XElemente aus dem ersten XElement das dem gewünschten Typ enspricht,
            // selbst keine Unterelemente haben und nicht zu Log gehörten aus (Spalten in der Tabelle)
            return xdocument.
                Descendants(personTypeDict[type]).FirstOrDefault().
                Descendants().
                Where(x => !x.HasElements && x.Parent.Name.LocalName.ToString() != "Log" && x.Name.LocalName.ToString() != "MutationLog").
                ToArray();
        }

        // Methode um alle Spaltennamen zu ermitteln, die der gewünschte Datensatz hat
        public List<string> GetColumnNames(ref XDocument xdocument, personType type)
        {
            // Liste für die Spaltennamen
            List<string> columnNames = new List<string>();

            foreach (XElement elemnt in GetColumns(ref xdocument, type))
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
            XElement[] columns = GetColumns(ref xdocument, type);

            // Liste für die Spaltennamen
            var columnNames = GetColumnNames(ref xdocument, type);

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
                        Elements(columns[columnNames.IndexOf(columnName)].Name);

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
            XElement[] columns = GetColumns(ref xdocument, type);

            // Liste für die Spaltennamen
            var columnNames = GetColumnNames(ref xdocument, type);

            // String in Array wandeln
            String[] searchTerms = searchTerm.Split(' ');

            // Prüfen, ob String zusammenhängend ist, wenn nach Attributen gesucht wird
            if (attribute != null && searchTerms.Count() > 1) {
                string message = "String must be contiguous if attribute search is used!";
                string caption = "Error Detected in Input";
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
                        Elements(columns[columnNames.IndexOf(columnName)].Name);

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
        public List<string> GetMutationLogs(ref XDocument xdocument)
        {
            List<string> mutationLogs = new List<string>();

            foreach(XElement mutationLog in xdocument.Descendants("MutationLogs").Descendants())
            {
                mutationLogs.Add(mutationLog.Value);
            }

            return mutationLogs;
        }
    }
}

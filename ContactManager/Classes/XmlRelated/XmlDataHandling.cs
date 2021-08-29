using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    class XmlDataHandling
    {
        // Enumeration für die verschiedenen Personentypen
        public enum personType
        {
            customer,
            employee,
            trainee
        }

        // Dictioary für die verschiedenen Personentypen
        private Dictionary<personType, string> personTypeDict = new Dictionary<personType, string>();

        public XmlDataHandling()
        {
            // Hinzufügen der verschiedenen Personentyem zum Dictionary
            personTypeDict.Add(personType.customer, "Customer");
            personTypeDict.Add(personType.employee, "Employee");
            personTypeDict.Add(personType.trainee, "Trainee");
        }

        public DataTable XElementToDataTable(XDocument xdocument, personType type)
        {
            // neue DataTable erzeugen wird als Datenquelle für DataGridViews beötigt
            DataTable dt = new DataTable();

            // Liest alle XElemente aus dem ersten XElement das dem gewünschten Typ enspricht,
            // selbst keine Unterelemente haben und nicht zu Log gehörten aus (Spalten in der Tabelle)
            XElement[] columns = xdocument.
                Descendants(personTypeDict[type]).FirstOrDefault().
                Descendants().
                Where(x => !x.HasElements && x.Parent.Name.LocalName.ToString() != "Log").
                ToArray();

            // Liste für die Spaltennamen
            List<string> columnNames = new List<string>();


            foreach (XElement elemnt in columns)
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
                    newRow[columnName] = (string)record.DescendantsAndSelf().
                        Elements(columns[columnNames.IndexOf(columnName)].Name).FirstOrDefault();
                }
            }

            return dt;
        }

        public ref XElement IdToXElement(XDocument xdocument, personType type, string id)
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

    }
}

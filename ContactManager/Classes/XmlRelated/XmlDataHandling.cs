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
        public enum personType
        {
            customer,
            employee,
            trainee
        }

        private Dictionary<personType, string> personTypeDict = new Dictionary<personType, string>();

        public XmlDataHandling()
        {
            personTypeDict.Add(personType.customer, "Customer");
            personTypeDict.Add(personType.employee, "Employee");
            personTypeDict.Add(personType.trainee, "Trainee");
        }

        public DataTable XElementToDataTable(XDocument xdocument, personType type)
        {
            DataTable dt = new DataTable();

            XElement[] columns = xdocument.
                Descendants(personTypeDict[type]).FirstOrDefault().
                Descendants().
                Where(x => !x.HasElements && x.Parent.Name.LocalName.ToString() != "Log").
                ToArray();

            List<string> columnNames = new List<string>();

            foreach (XElement elemnt in columns)
            {
                if (elemnt.HasAttributes)
                {
                    columnNames.Add(
                        elemnt.Name.LocalName.ToString() + " " +
                        elemnt.Attribute("Type").Value.ToString());
                }
                else
                {
                    columnNames.Add(elemnt.Name.LocalName.ToString());
                }
            }

            foreach (string columnName in columnNames)
            {
                dt.Columns.Add(columnName, typeof(string));
            }

            foreach (XElement record in xdocument.Descendants(personTypeDict[type]))
            {
                DataRow newRow = dt.Rows.Add();
                foreach (string columnName in columnNames)
                {
                    newRow[columnName] = (string)record.DescendantsAndSelf().
                        Elements(columns[columnNames.IndexOf(columnName)].Name).FirstOrDefault();
                }
            }

            return dt;
        }

        public ref XElement DataTableToXElement(XDocument xdocument, personType type, string id)
        {
            XElement[] columns = xdocument.
                Descendants(personTypeDict[type]).
                Descendants().
                Where(x => x.Name.LocalName == "Id" && x.Value.ToString() == id).
                Ancestors(personTypeDict[type]).
                ToArray();

            return ref columns[0];
        }

    }
}

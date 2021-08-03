using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager.Classes.PersonRelated
{
    class Customer : Person
    {
        public string companyName_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("CompanyName")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("CompanyName")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }        }

        public string customerType_
        {
            get
            {
                return  (string)
                  (from element in person_.Descendants("CustomerType")
                   select element).First();
            }

            set
            {
                if (value.Length != 1)
                {
                    const int a = 'A';
                    const int e = 'E';

                    int customerType = char.Parse(value);

                    if (customerType >= a && customerType <= e)
                    {
                        (from element in person_.Descendants("CustomerType")
                         select element).First().SetValue(value);
                    }
                    else 
                    { 
                        throw new ArgumentException("value must be a capital letter and between A and E!");
                    }
                }
                else 
                {
                    throw new ArgumentException("value must contain one character!");
                }
                
            }
        }

             // Mit diesem Befehl wird eine Sammlung von Elementen in der Dokumentenreihenfolge zurückgegeben
        public IEnumerable<XElement> customer_;

        public Customer(ref IEnumerable<XElement> customer)
            : base(ref customer)
        {
            customer_ = customer;
        }

        // Mit diesem Befehl wird ein XElement Template von Customer erzeugt und ausgegenben
        public XElement XelementTemplate()
        {
            XElement customer = base.XelementTemplate();

            // Person Element von Basis nach Customer umbenennen
            customer.Element("Person").Name = "Customer";

            // Neue kundenbezogene Allgemeinattribute hinzufügen
            customer.Descendants("Function").FirstOrDefault()
                .AddAfterSelf(new XElement("CompanyName", ""),
                              new XElement("CustomerType", ""));

            // Neue kundenbezogene Kontaktattribute hinzufügen
            customer.Descendants("Phone")
                .Where(element => (string)element.Attribute("Type") == "Mobile")
                .FirstOrDefault()
                .AddAfterSelf(new XElement("Fax", ""));

            // Neue kundenbezogene Gesprächsattribute hinzufügen
            // Gesprächsnotizen werden über eine eigene Klasse hinzugefügt
            customer.Add(new XElement("Logs", ""));

            return customer;
        }

        public XElement AddLog(string text)
        {
            int count = customer_.Descendants("Logs").Count();     

            customer_.Descendants("Logs")
                .FirstOrDefault()
                .Add(new XElement("Log", 
                        new XElement("TicketId", ++count),
                        new XElement("Date", DateTime.Now.Date), 
                        new XElement("Time", DateTime.Now.TimeOfDay),
                        new XElement("Text", text)
                        )
                );
        }

        public override string ToString()
        {
            return base.ToString() + ", " + companyName_ + ", " + customerType_; //fax, equals methode einfügen, user control infos sammeln
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj) &&
                companyName_ == obj.companyName_        
        }
    }
}

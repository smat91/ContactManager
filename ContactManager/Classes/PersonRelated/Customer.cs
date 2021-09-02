using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Customer : Person
    {
        public string companyName_
        {
            get
            {
                return (string)
                  (from element in customer_.Descendants("CompanyName")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in customer_.Descendants("CompanyName")
                     select element).FirstOrDefault().SetValue(value);
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
                  (from element in customer_.Descendants("CustomerType")
                   select element).FirstOrDefault();
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
                        (from element in customer_.Descendants("CustomerType")
                         select element).FirstOrDefault().SetValue(value);
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

        public string fax_
        {
            get
            {
                return (string)
                  (from element in customer_.Descendants("Fax")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in customer_.Descendants("Fax")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        // Mit diesem Befehl wird eine Sammlung von Elementen in der Dokumentenreihenfolge zurückgegeben
        private XElement customer_;

        public Customer(ref XElement customer)
            : base(ref customer)
        {
            customer_ = customer;
        }

        public void AddLog(string text)
        {
            int count = customer_.Descendants("Log").Count();     

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

        public XElement[] GetLogs()
        {
            return customer_.Descendants("Logs").Elements().ToArray();
        }

        // Mit dieser Methode wird dem XML eine neue Person Customer hinzugefügt
        public virtual void AddToXDocument(ref XDocument personsXml)
        {
            if (base.IdIsUnique(ref personsXml))
            {
                base.SetNewId(ref personsXml);
                personsXml.Descendants("Customers").FirstOrDefault().AddFirst(customer_);
            }
            else
            {
                throw new ArgumentException("Customer with this id is allready existing in XML");
            }
        }

        // Alle Inhalte (bspw. int) wird als String zurückgegeben.
        public override string ToString()
        {
            return base.ToString() + ", " + 
                companyName_ + ", " + 
                customerType_ + ", " + 
                fax_;
        }

        // Hier wird der Vergleich gemacht, ob die Instanzen gleich sind wie im XML, wenn nicht, dann kommt "false"
        public override bool Equals(object obj)
        {
            return obj is Customer customer &&
                base.Equals(customer) &&
                companyName_ == customer.companyName_ &&
                customerType_ == customer.customerType_ &&
                fax_ == customer.fax_;
        }
    }
}

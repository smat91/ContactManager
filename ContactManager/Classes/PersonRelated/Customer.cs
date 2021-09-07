using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
                  (from element in customer_.Descendants("Firmenname")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.Length > 0)
                {
                    (from element in customer_.Descendants("Firmenname")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss mindestens ein Zeichen Enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }        }

        public string customerType_
        {
            get
            {
                return  (string)
                  (from element in customer_.Descendants("Kundentyp")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value.Length == 1)
                {
                    const int a = 'A';
                    const int e = 'E';

                    int customerType = char.Parse(value);

                    if (customerType >= a && customerType <= e)
                    {
                        (from element in customer_.Descendants("Kundentyp")
                         select element).FirstOrDefault().SetValue(value);
                    }
                    else 
                    {
                        string message = "Input must be a capital letter and between A and E!";
                        string caption = "Fehler in Eingabe erkannt";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        MessageBox.Show(message, caption, buttons);
                    }
                }
                else 
                {
                    string message = "Input must be a capital letter and between A and E!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
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

        // lokales XElement customer_ anlegen
        public XElement customer_ { get; private set; }

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
                        new XElement("LogId", ++count),
                        new XElement("Date", DateTime.Now.Date.ToShortDateString()), 
                        new XElement("Time", String.Format("{0:hh}:{0:mm}", DateTime.Now.TimeOfDay)),
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

        // Hier werden Veränderungen am Objekt ausgegeben
        public override List<string> Diff(object obj)
        {
            List<String> diff = base.Diff(obj);

            if (companyName_ != (obj as Customer).companyName_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Firmenname; Wert alt: {(obj as Customer).companyName_}; Wert neu: {companyName_}; Zeitpunkt; {DateTime.Now}");
            }
            if (customerType_ != (obj as Customer).customerType_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Kundentyp; Wert alt: {(obj as Customer).customerType_}; Wert neu: {customerType_}; Zeitpunkt; {DateTime.Now}");
            }
            if (fax_ != (obj as Customer).fax_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Fax; Wert alt: {(obj as Customer).fax_}; Wert neu: {fax_}; Zeitpunkt; {DateTime.Now}");
            }

            return diff;
        }
    }
}

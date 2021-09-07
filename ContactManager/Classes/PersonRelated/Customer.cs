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
                        string message = "Eingabe muss ein Grossbuchstabe von A bis E sein!";
                        string caption = "Fehler in Eingabe erkannt";
                        MessageBoxButtons buttons = MessageBoxButtons.OK;

                        MessageBox.Show(message, caption, buttons);
                    }
                }
                else 
                {
                    string message = "Eingabe muss ein Grossbuchstabe von A bis E sein!";
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
                if (value != null && !value.Any(char.IsLetter))
                {
                    (from element in customer_.Descendants("Fax")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf keine Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
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
                        new XElement("Datum", DateTime.Now.Date.ToShortDateString()), 
                        new XElement("Zeit", String.Format("{0:hh}:{0:mm}", DateTime.Now.TimeOfDay)),
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
                string message = "Datensatz existiert bereits!";
                string caption = "Fehler erkannt";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
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
        public override List<XElement> Diff(object obj)
        {
            List<XElement> diff = base.Diff(obj);

            if (companyName_ != (obj as Customer).companyName_)
            {
                diff.Add(DiffToXElement("Firmenname", (obj as Customer).companyName_.ToString(), companyName_.ToString()));
            }
            if (customerType_ != (obj as Customer).customerType_)
            {
                diff.Add(DiffToXElement("Kundentyp", (obj as Customer).customerType_.ToString(), customerType_.ToString()));
            }
            if (fax_ != (obj as Customer).fax_)
            {
                diff.Add(DiffToXElement("Fax", (obj as Customer).fax_.ToString(), fax_.ToString()));
            }

            return diff;
        }
    }
}

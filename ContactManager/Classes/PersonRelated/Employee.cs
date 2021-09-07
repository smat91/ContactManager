using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Employee : Person
    {
        public string birthday_
        {
            get
            {
                // return gibt einen Int zurück / Descendants liefert eine Sammlung der Nachfahrenelemente für
                // dieses Dokument oder Element in der Reihenfolge der Dokumente.
                return (string)
                  (from element in employee_.Descendants("Geburtsdatum")
                   select element).FirstOrDefault();
            }

            set
            {
                (from element in employee_.Descendants("Geburtsdatum")
                select element).FirstOrDefault().SetValue(value);
            }
        }

        public string department_
        {
            get
            {
                return (string)
                  (from element in employee_.Descendants("Abteilung")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    (from element in employee_.Descendants("Abteilung")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben beinhalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string insuranceNumber_
        {
            get
            {
                return (string)
                    (from element in employee_.Descendants("Versicherungsnummer")
                     select element).FirstOrDefault();
            }

            set
            { 
                if (value != null && value.Length > 0)
                {
                    (from element in employee_.Descendants("Versicherungsnummer")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss mindestens ein Zeichen Enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string citizenship_
        {
            get
            {
                return (string)
                    (from element in employee_.Descendants("Nationalität")
                     select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in employee_.Descendants("Nationalität")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben beinhalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string entryDate_
        {
            get
            {
                return (string)
                  (from element in employee_.Descendants("Eintrittsdatum")
                   select element).FirstOrDefault();
            }

            set
            {
                var cultureInfo = new CultureInfo("de-CH", true);


                (from element in employee_.Descendants("Eintrittsdatum")
                select element).FirstOrDefault().SetValue(value);
            }
        }

        public string seperationDate_
        {
            get
            {
                return (string)
                  (from element in employee_.Descendants("Austrittsdatum")
                   select element).FirstOrDefault();
            }

            set
            {
                if (entryDate_ != null)
                {
                    (from element in employee_.Descendants("Austrittsdatum")
                     select element).FirstOrDefault().SetValue(value);
                }
                else 
                {
                    string message = "Eingabe muss grösser als das Eintrittsdatum sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public int levelOfEmployment_
        {
             get
            {
                return (int)
                    (from element in employee_.Descendants("Beschäftigungsgrad")
                     select element).FirstOrDefault();
            }

            set
            {
                if (value > 0)
                {
                    (from element in employee_.Descendants("Beschäftigungsgrad")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss grösser als 0 sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public int level_
        {
             get
            {
                return (int)
                    (from element in employee_.Descendants("Kaderstufe")
                     select element).FirstOrDefault();
            }

            set
            {
                if (value >= 0 && value <= 5)
                {
                    (from element in employee_.Descendants("Kaderstufe")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss grösser, gleich 0 und kleiner, gleich 5 sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string phonePrivat_
        {
            get
            {
                return (string)
                  (from element in employee_.Descendants("Telefon").
                   Where(x => x.Attribute("Type").Value == "Privat")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in employee_.Descendants("Telefon").
                     Where(x => x.Attribute("Type").Value == "Privat")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nicht leer sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        // lokales XElement employee_ anlegen
        public XElement employee_ { get; private set; }

        public Employee(ref XElement employee)
            : base(ref employee)
        {
            employee_ = employee;
        }

        // Mit dieser Methode wird dem XML eine neue Person Employee hinzugefügt
        public virtual void AddToXDocument(ref XDocument personsXml)
        {
            if (base.IdIsUnique(ref personsXml))
            {
                base.SetNewId(ref personsXml);
                personsXml.Descendants("Employees").FirstOrDefault().AddFirst(employee_);
            }
            else
            {
                throw new ArgumentException("Employee with this id is allready existing in XML");
            }
        }

        // Hier wird der Vergleich gemacht, ob die Instanzen gleich sind wie im XML, wenn nicht, dann kommt "false"
        public override bool Equals(object obj)
        {
            return obj is Employee employee &&
                   base.Equals(employee) &&
                   birthday_ == employee.birthday_ &&
                   department_ == employee.department_ &&
                   insuranceNumber_ == employee.insuranceNumber_ &&
                   citizenship_ == employee.citizenship_ &&
                   entryDate_ == employee.entryDate_ &&
                   seperationDate_ == employee.seperationDate_ &&
                   levelOfEmployment_ == employee.levelOfEmployment_ &&
                   level_ == employee.level_ &&
                   phonePrivat_ == employee.phonePrivat_;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + 
                birthday_ + ", " +
                department_ + ", " + 
                insuranceNumber_ + ", " +
                citizenship_ + ", " + 
                entryDate_ + ", " +
                seperationDate_ + ", " + 
                levelOfEmployment_ + ", " +
                level_ + ", " +
                phonePrivat_;
        }

    }
}

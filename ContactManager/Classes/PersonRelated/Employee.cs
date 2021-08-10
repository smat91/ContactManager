using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager.Classes.PersonRelated
{
    public class Employee : Person
    {
        public DateTime birthday_
        {
            get
            {
                // return gibt einen Int zurück / Descendants liefert eine Sammlung der Nachfahrenelemente für
                // dieses Dokument oder Element in der Reihenfolge der Dokumente.
                return (DateTime)
                  (from element in person_.Descendants("DateOfBirth")
                   select element).First();
            }

            set
            {
                (from element in person_.Descendants("DateOfBirth")
                select element).First().SetValue(value);
            }
        }

        public string department_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Department")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Department")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string insuranceNumber_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("InsuranceNumber")
                     select element).First();
            }

            set
            { 
                if (value != null)
                {
                    (from element in person_.Descendants("InsuranceNumber")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string citizenship_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("Citizenship")
                     select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Citizenship")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public DateTime entryDate_
        {
            get
            {
                return (DateTime)
                  (from element in person_.Descendants("EntryDate")
                   select element).First();
            }

            set
            {
                (from element in person_.Descendants("EntryDate")
                select element).First().SetValue(value);
            }
        }

        public DateTime seperationDate_
        {
            get
            {
                return (DateTime)
                  (from element in person_.Descendants("SeperationDate")
                   select element).First();
            }

            set
            {
                if (value > entryDate_)
                {
                    (from element in person_.Descendants("SeperationDate")
                     select element).First().SetValue(value);
                }
                else 
                {
                    throw new ArgumentException("value cannot be smaller or equal to entry date!");
                }
            }
        }

        public int levelOfEmployment_
        {
             get
            {
                return (int)
                    (from element in person_.Descendants("LevelOfEmployment")
                     select element).First();
            }

            set
            {
                if (value > 0)
                {
                    (from element in person_.Descendants("LevelOfEmployment")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value must be greater than 0");
                }
            }
        }

        public int level_
        {
             get
            {
                return (int)
                    (from element in person_.Descendants("Level")
                     select element).First();
            }

            set
            {
                if (value >= 0 && value <= 5)
                {
                    (from element in person_.Descendants("Level")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value must be greater or equal to 0 and smaller or equal to 5");
                }
            }
        }

        public string phonePrivat_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Phone<Privat>")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Phone<Privat>")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        // Mit diesem Befehl wird eine Sammlung von Elementen in der Dokumentenreihenfolge zurückgegeben
        public IEnumerable<XElement> employee_;

        public Employee(ref IEnumerable<XElement> employee)
            : base(ref employee)
        {
            employee_ = employee;
        }

        // Mit diesem Befehl wird ein XElement Template von Person erzeugt und ausgegenben
        public override XElement XelementTemplate()
        {
            XElement employee = base.XelementTemplate();

            // Person Element von Basis nach Customer umbenennen
            employee.Element("Person").Name = "Employee";

            // Neue mitarbeiterbezogene Allgemeinattribute hinzufügen
            employee.Descendants("Function").FirstOrDefault()
                .AddAfterSelf(new XElement("DateOfBirth", ""),
                              new XElement("Department", ""),
                              new XElement("InsuranceNumber", ""),
                              new XElement("Citizenship", ""),
                              new XElement("EntryDate", ""),
                              new XElement("SeparationDate", ""),
                              new XElement("LevelOfEmployment", ""),
                              new XElement("Level", ""));

            // Neue mitarbeiterbezogene Kontaktattribute hinzufügen
            employee.Descendants("Phone")
                .Where(element => (string)element.Attribute("Type") == "Mobile")
                .FirstOrDefault()
                .AddAfterSelf(new XElement("Phone", "",
                                    new XAttribute("Type", "Privat")));

            return employee;
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
                birthday_.ToShortDateString() + ", " +
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

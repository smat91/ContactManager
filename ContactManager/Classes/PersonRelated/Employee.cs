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

        public DateTime birthday_
        {
            get
            {
                return (DateTime)
                  (from element in person_.Descendants("DateOfBirth")
                   select element).First();
            }

            set
            {
                (from element in person_.Descendants("DateOfBirth")
                 select element).First().SetValue(value);
            }
        }public string insuranceNumber_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("InsuranceNumber"
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
                retung(string)
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
                (from element in person_.Descendants("SeperationDate")
                 select element).First().SetValue(value);
            }
        }

        public int levelOfEmployment_
        {
             get
            {
                // return gibt einen Int zurück / Descendants liefert eine Sammlung der Nachfahrenelemente für
                // dieses Dokument oder Element in der Reihenfolge der Dokumente.
                return (int)
                    (from element in person_.Descendants("LevelOfEmployment")
                     select element).First();
            }

            set
            {
                
                    (from element in person_.Descendants("LevelOfEmployment")
                     select element).First().SetValue(value);
            }
        }

        public int level_
        {
             get
            {
                // return gibt einen Int zurück / Descendants liefert eine Sammlung der Nachfahrenelemente für
                // dieses Dokument oder Element in der Reihenfolge der Dokumente.
                return (int)
                    (from element in person_.Descendants("Level")
                     select element).First();
            }

            set
            {
                
                    (from element in person_.Descendants("Level")
                     select element).First().SetValue(value);
            }
        }



        public Employee(ref IEnumerable<XElement> person)
            : base(ref person)
        {
            employee_ = Employee;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + department_ + ", " + birthday_.ToShortDateString() + ", " + insuranceNumber_ ", " + citizenship_ + ", " + citizenship_ + ", " + entryDate_ + ", " + seperetionDate_ + ", " + levelOfEmployment_ + ", " + level_;
        }

        
        // Mit diesem Befehl wird ein XElement Template von Person erzeugt und ausgegenben
        public XElement XelementTemplate()
        {
            return new XElement("Employee",
                            new XElement("DateOfBirth", ""),
                            new XElement("Department", ""),
                            new XElement("InsuranceNumber", ""),
                            new XElement("Citizenship", ""),
                            new XElement("EntryDate", ""),
                            new XElement("SeparationDate", ""),
                            new XElement("LevelOfEmployment", ""),
                            new XElement("Level", "");
        }

         // Hier wird der Vergleich gemacht, ob die Instanzen gleich sind wie im XML, wenn nicht, dann kommt "false"
        public override bool Equals(object obj)
        {
            return base.Equals(obj) &&
                companyName_ == obj.companyName_ &&
                customerType_ == obj.customerType_ &&
                fax_ == obj.fax_;
        }
    }
}

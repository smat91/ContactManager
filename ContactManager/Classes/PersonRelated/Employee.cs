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
        public string departement_
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
        }

        public Employee(ref IEnumerable<XElement> person)
            : base(ref person)
        {
        }

        public override string ToString()
        {
            return base.ToString() + ", " + Department + ", " + birthday_.ToShortDateString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Person
    {
        public string firstname_ 
        {
            get 
            {
                return (string)
                  (from element in person_.Descendants("Firstname")
                   select element).First();
            }

            set 
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Firstname")
                     select element).First().SetValue(value);
                }
                else
                { 
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string lastname_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Lastname")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Lastname")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public IEnumerable<XElement> person_;

        public Person(ref IEnumerable<XElement> person)
        {
            person_ = person;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   firstname_ == person.firstname_ &&
                   lastname_ == person.lastname_;
        }

        public override string ToString()
        {
            return firstname_ + ", " + lastname_;
        }

    }
}

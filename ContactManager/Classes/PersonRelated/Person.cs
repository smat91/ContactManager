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
        public int id_
        {
            get
            {
                return (int)
                    (from element in person_.Descendants("Id")
                     select element).First();
            }

            set
            {
                if (value != null) //Int immer true, was brauchen wir hier?
                {
                    (from element in person_.Descendants("Id")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string state_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("State")
                     select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("State")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string salutation_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("Salutation")
                     select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Salutation")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }

        
        }
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

        public string sex_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Sex")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Sex")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string function_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Function")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Function")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string street_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Street")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Street")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public int number_
        {
            get
            {
                return (int)
                  (from element in person_.Descendants("Number")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Number")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string city_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("City")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("City")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public int zip_
        {
            get
            {
                return (int)
                  (from element in person_.Descendants("Zip")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Zip")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }


        public string phoneBusiness_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Phone<business>")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Phone<business>")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string phoneMob_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Phone<mobile>")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Phone<mobile>")
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

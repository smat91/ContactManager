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
        // Variable für "ID" erstellt. Wird von XML bezogen | weitere Variablen folgen
        public int id_
        {
            // Get- und Set-Methode vorbereitet. Bezogen auf XML
            get
            {
                // return gibt einen Int zurück / Descendants liefert eine Sammlung der Nachfahrenelemente für
                // dieses Dokument oder Element in der Reihenfolge der Dokumente.
                return (int)
                    (from element in person_.Descendants("Id")
                     select element).First();
            }

            set
            {
                
                    (from element in person_.Descendants("Id")
                     select element).First().SetValue(value);
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
                // Mit If-Schleife wird überprüft, ob ein Wert angegeben worden ist, wenn nicht, dann wird ein ArgumentException ausgeworfen
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

        public string title_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Titel")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Titel")
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
                    (from element in person_.Descendants("Number")
                     select element).First().SetValue(value);
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

                (from element in person_.Descendants("Zip")
                 select element).First().SetValue(value);
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

        public string eMail_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("EMail")
                   select element).First();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("EMail")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        // Mit diesem Befehl wird eine Sammlung von Elementen in der Dokumentenreihenfolge zurückgegeben
        public IEnumerable<XElement> person_;

        public Person(ref IEnumerable<XElement> person)
        {
            person_ = person;
        }

        // Hier wird der Vergleich gemacht, ob die Instanzen gleich sind wie im XML, wenn nicht, dann kommt "false"
        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   id_ == person.id_ &&
                   state_ == person.state_ &&
                   salutation_ == person.salutation_ &&
                   title_ == person.title_ &&
                   firstname_ == person.firstname_ &&
                   lastname_ == person.lastname_ &&
                   sex_ == person.sex_ &&
                   function_ == person.function_ &&
                   street_ == person.street_ &&
                   number_ == person.number_ &&
                   city_ == person.city_ &&
                   zip_ == person.zip_ &&
                   phoneBusiness_ == person.phoneBusiness_ &&
                   phoneMob_ == person.phoneMob_&&
                   eMail_ == person.eMail_;


        }

        // Alle Inhalte (bspw. int) wird als String zurückgegeben.
        public override string ToString()
        {
            return id_ + ", " + state_ + ", " + salutation_ + ", " + title_ + ", " + firstname_ + ", " + lastname_ + ", " + sex_ + ", " +
                function_ + ", " + street_ + " " + number_ + ", " + zip_ + ", " + city_ + ", " + phoneBusiness_ + ", " + phoneMob_ + ", " + eMail_;
        }

    }
}

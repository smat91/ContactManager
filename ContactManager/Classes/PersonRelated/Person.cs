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
                     select element).FirstOrDefault();
            }

            private set
            {
                (from element in person_.Descendants("Id")
                    select element).FirstOrDefault().SetValue(value);
            }
               
        }

        public string state_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("State")
                     select element).FirstOrDefault();
            }

            set
            {
                // Mit If-Schleife wird überprüft, ob ein Wert angegeben worden ist, wenn nicht, dann wird ein ArgumentException ausgeworfen
                if (value != null)
                {
                    (from element in person_.Descendants("State")
                     select element).FirstOrDefault().SetValue(value);
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
                     select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Salutation")
                     select element).FirstOrDefault().SetValue(value);
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
                  (from element in person_.Descendants("Title")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Title")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set 
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Firstname")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Lastname")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Sex")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Function")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Street")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public string number_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Number")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Number")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("City")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {

                (from element in person_.Descendants("Zip")
                 select element).FirstOrDefault().SetValue(value);
            }
        }

        public string country_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Country")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Country")
                     select element).FirstOrDefault().SetValue(value);
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
                  (from element in person_.Descendants("Phone").
                   Where(x => x.Attribute("Type").Value == "Business")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Phone").
                   Where(x => x.Attribute("Type").Value == "Business")
                     select element).FirstOrDefault().SetValue(value);
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
                  (from element in person_.Descendants("Phone").
                   Where(x => x.Attribute("Type").Value == "Mobile")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("Phone").
                   Where(x => x.Attribute("Type").Value == "Mobile")
                     select element).FirstOrDefault().SetValue(value);
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
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null)
                {
                    (from element in person_.Descendants("EMail")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        // XElement mit den personenbezogenen Daten
        private XElement person_;

        public Person(ref XElement person)
        {
            person_ = person;
        }

        // Mit dieser Methode wird geprüt ob die eigene Id einzigartig ist
        public virtual bool IdIsUnique (ref XDocument personsXml)
        {
            IEnumerable<XElement> idList =
                from id in personsXml.Descendants("Id")
                where id == person_.Element("Id")
                select id;

            return (idList.Count() == 0) ? true : false;
        }

        // Mit dieser Methode wird eine neue id generiert
        public virtual void SetNewId(ref XDocument personsXml)
        {
            IEnumerable<XElement> idList =
                from ids in personsXml.Descendants("Id")
                orderby int.Parse(ids.Value)
                select ids;

            id_ = 1 + (int)idList.Last();
        }

        // Prüfen ob mindestens Name und Vorname eingegeben wurden
        public bool CheckMinimalInforamtion() 
        {
            return firstname_.Length >= 2 && lastname_.Length >= 2; 
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
                   country_ == person.country_ &&
                   phoneBusiness_ == person.phoneBusiness_ &&
                   phoneMob_ == person.phoneMob_&&
                   eMail_ == person.eMail_;
        }

        // Alle Inhalte (bspw. int) wird als String zurückgegeben.
        public override string ToString()
        {
            return  id_ + ", " + 
                    state_ + ", " + 
                    salutation_ + ", " + 
                    title_ + ", " + 
                    firstname_ + ", " + 
                    lastname_ + ", " + 
                    sex_ + ", " +
                    function_ + ", " + 
                    street_ + " " + 
                    number_ + ", " + 
                    zip_ + ", " + 
                    city_ + ", " +
                    country_ + ", " +
                    phoneBusiness_ + ", " + 
                    phoneMob_ + ", " + 
                    eMail_;
        }

    }
}

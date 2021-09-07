using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                    (from element in person_.Descendants("Status")
                     select element).FirstOrDefault();
            }

            set
            {
                (from element in person_.Descendants("Status")
                    select element).FirstOrDefault().SetValue(value);
            }
        }

        public string salutation_
        {
            get
            {
                return (string)
                    (from element in person_.Descendants("Begrüssung")
                     select element).FirstOrDefault();
            }

            set
            {
                (from element in person_.Descendants("Begrüssung")
                    select element).FirstOrDefault().SetValue(value);
            }        
        }

        public string title_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Titel")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    (from element in person_.Descendants("Titel")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }
        public string firstname_ 
        {
            get 
            {
                return (string)
                  (from element in person_.Descendants("Vorname")
                   select element).FirstOrDefault();
            }

            set 
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in person_.Descendants("Vorname")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string lastname_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Nachname")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in person_.Descendants("Nachname")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string sex_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Geschlecht")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in person_.Descendants("Geschlecht")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string function_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Funktion")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && !value.Any(char.IsDigit))
                {
                    (from element in person_.Descendants("Funktion")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string street_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Strasse")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in person_.Descendants("Strasse")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string number_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Nummer")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.Length > 0)
                {
                    (from element in person_.Descendants("Nummer")
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

        public string city_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Ort")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in person_.Descendants("Ort")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public int zip_
        {
            get
            {
                return (int)
                  (from element in person_.Descendants("PLZ")
                   select element).FirstOrDefault();
            }

            set
            { 
                if (value >= 1000)
                {
                    (from element in person_.Descendants("PLZ")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss grösser, gleich 1000 sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
                (from element in person_.Descendants("PLZ")
                 select element).FirstOrDefault().SetValue(value);
            }
        }

        public string country_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Land")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && value.All(char.IsLetter))
                {
                    (from element in person_.Descendants("Land")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe darf nur Buchstaben enthalten!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public string phoneBusiness_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Telefon").
                   Where(x => x.Attribute("Type").Value == "geschäftlich")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && !value.Any(char.IsLetter))
                {
                    (from element in person_.Descendants("Telefon").
                    Where(x => x.Attribute("Type").Value == "geschäftlich")
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

        public string phoneMob_
        {
            get
            {
                return (string)
                  (from element in person_.Descendants("Telefon").
                   Where(x => x.Attribute("Type").Value == "mobil")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value != null && !value.Any(char.IsLetter))
                {
                    (from element in person_.Descendants("Telefon").
                   Where(x => x.Attribute("Type").Value == "mobil")
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
                if (value != null && new EmailAddressAttribute().IsValid(value))
                {
                    (from element in person_.Descendants("EMail")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss eine Emailadresse sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
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

        // Hier werden Veränderungen am Objekt ausgegeben
        public virtual List<string> Diff(object obj)
        {
            List<string> diff = new List<string>();

            if (id_ != (obj as Person).id_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Id; Wert alt: {(obj as Person).id_}; Wert neu: {id_}; Zeitpunkt; {DateTime.Now}");
            }
            if (state_ != (obj as Person).state_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Status; Wert alt: {(obj as Person).state_}; Wert neu: {state_}; Zeitpunkt; {DateTime.Now}");
            }
            if (salutation_ != (obj as Person).salutation_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Anrede; Wert alt: {(obj as Person).salutation_}; Wert neu: {salutation_}; Zeitpunkt; {DateTime.Now}");
            }
            if (title_ != (obj as Person).title_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Titel; Wert alt: {(obj as Person).title_}; Wert neu: {title_}; Zeitpunkt; {DateTime.Now}");
            }
            if (firstname_ != (obj as Person).firstname_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Vorname; Wert alt: {(obj as Person).firstname_}; Wert neu: {firstname_}; Zeitpunkt; {DateTime.Now}");
            }
            if (lastname_ != (obj as Person).lastname_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Nachname; Wert alt: {(obj as Person).lastname_}; Wert neu: {lastname_}; Zeitpunkt; {DateTime.Now}");
            }
            if (sex_ != (obj as Person).sex_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Geschlecht; Wert alt: {(obj as Person).sex_}; Wert neu: {sex_}; Zeitpunkt; {DateTime.Now}");
            }
            if (function_ != (obj as Person).function_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Funktion; Wert alt: {(obj as Person).function_}; Wert neu: {function_}; Zeitpunkt; {DateTime.Now}");
            }
            if (street_ != (obj as Person).street_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Strasse; Wert alt: {(obj as Person).street_}; Wert neu: {street_}; Zeitpunkt; {DateTime.Now}");
            }
            if (number_ != (obj as Person).number_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Hausnummer; Wert alt: {(obj as Person).number_}; Wert neu: {number_}; Zeitpunkt; {DateTime.Now}");
            }
            if (city_ != (obj as Person).city_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Ort; Wert alt: {(obj as Person).city_}; Wert neu: {city_}; Zeitpunkt; {DateTime.Now}");
            }
            if (zip_ != (obj as Person).zip_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: PLZ; Wert alt: {(obj as Person).zip_}; Wert neu: {zip_}; Zeitpunkt; {DateTime.Now}");
            }
            if (country_ != (obj as Person).country_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Land; Wert alt: {(obj as Person).country_}; Wert neu: {country_}; Zeitpunkt; {DateTime.Now}");
            }
            if (phoneBusiness_ != (obj as Person).phoneBusiness_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Telefon geschäftlich; Wert alt: {(obj as Person).phoneBusiness_}; Wert neu: {phoneBusiness_}; Zeitpunkt; {DateTime.Now}");
            }
            if (phoneMob_ != (obj as Person).phoneMob_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: Telefon mobil; Wert alt: {(obj as Person).phoneMob_}; Wert neu: {phoneMob_}; Zeitpunkt; {DateTime.Now}");
            }
            if (eMail_ != (obj as Person).eMail_)
            {
                diff.Add($"Personen Id: {id_}; Attribut: E-Mail; Wert alt: {(obj as Person).eMail_}; Wert neu: {eMail_}; Zeitpunkt; {DateTime.Now}");
            }

            return diff;
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

        // Mit dieser Methode werden die Einträge für den Mutations-Log erstellt
        public void AddLog(List<string> diff, Object person )
        {
            foreach (string mutationLog in diff) 
            {
                (person as XElement).Descendants("MutationLogs")
                    .FirstOrDefault()
                    .Add(new XElement("MutationLog", mutationLog));
            }

        }
    }
}

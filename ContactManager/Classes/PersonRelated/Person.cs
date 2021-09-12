using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Person
    {
        // Property von "ID". Wird von XML bezogen und in XML geschrieben
        // für die folgenden Properties gilt das selbe Prinzip
        public int id_
        {
            
            get
            {
                // Descendants liefert eine Sammlung der Nachfahrenelemente für
                // des im Konstruktor übergebenen XElemtent zurück.
                // Mit dem String der Descendants über geben wird, werden nur
                // Elemente mit diesem Namen zurück gegeben.
                // Mit FirstOrDefault wird auf das erste Element das zurückgegeben wird
                // zugegriffen.
                return (int)
                    (from element in person_.Descendants("Id")
                     select element).FirstOrDefault();
            }

            private set
            {
                // Siehe get nur das hier noch mit set Value der Wert des Elements
                // geschrieben wird
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
                if (value != null && (!value.Any(char.IsDigit) || value == title_))
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
                if (value != null && (value.All(char.IsLetter) || value == sex_))
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
                if (value != null && (!value.Any(char.IsDigit) || value == function_))
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
                if (value != null && (value.All(char.IsLetter) || value == street_))
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
                if (value != null && (value.Length > 0 || value == number_))
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
                if (value != null && (!value.Any(char.IsDigit) || value == city_))
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
                if (value != null && (value.All(char.IsLetter) || value == country_))
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
                if (value != null && (!value.Any(char.IsLetter) || value == phoneBusiness_))
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
                if (value != null && (!value.Any(char.IsLetter) || value == phoneMob_))
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
                Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");

                if (value != null && (regex.Match(value).Success || value == eMail_))
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

        // Kontsruktor für Person
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

            id_ = (idList.Count() > 0) ? 1 + (int)idList.Last() : 1;
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
        public virtual List<XElement> Diff(object obj)
        {
            List<XElement> diff = new List<XElement>();

            if (id_ != (obj as Person).id_)
            {
                diff.Add(DiffToXElement("Id", (obj as Person).id_.ToString(), id_.ToString()));
            }
            if (state_ != (obj as Person).state_)
            {
                diff.Add(DiffToXElement("Status", (obj as Person).state_.ToString(), state_.ToString()));
            }
            if (salutation_ != (obj as Person).salutation_)
            {
                diff.Add(DiffToXElement("Anrede", (obj as Person).salutation_.ToString(), salutation_.ToString()));

            }
            if (title_ != (obj as Person).title_)
            {
                diff.Add(DiffToXElement("Titel", (obj as Person).title_.ToString(), title_.ToString()));

            }
            if (firstname_ != (obj as Person).firstname_)
            {
                diff.Add(DiffToXElement("Vorname", (obj as Person).firstname_.ToString(), firstname_.ToString()));

            }
            if (lastname_ != (obj as Person).lastname_)
            {
                diff.Add(DiffToXElement("Nachname", (obj as Person).lastname_.ToString(), lastname_.ToString()));

            }
            if (sex_ != (obj as Person).sex_)
            {
                diff.Add(DiffToXElement("Geschlecht", (obj as Person).sex_.ToString(), sex_.ToString()));

            }
            if (function_ != (obj as Person).function_)
            {
                diff.Add(DiffToXElement("Funktion", (obj as Person).function_.ToString(), function_.ToString()));

            }
            if (street_ != (obj as Person).street_)
            {
                diff.Add(DiffToXElement("Strasse", (obj as Person).street_.ToString(), street_.ToString()));

            }
            if (number_ != (obj as Person).number_)
            {
                diff.Add(DiffToXElement("Nummer", (obj as Person).number_.ToString(), number_.ToString()));

            }
            if (city_ != (obj as Person).city_)
            {
                diff.Add(DiffToXElement("Ort", (obj as Person).city_.ToString(), city_.ToString()));

            }
            if (zip_ != (obj as Person).zip_)
            {
                diff.Add(DiffToXElement("PLZ", (obj as Person).zip_.ToString(), zip_.ToString()));

            }
            if (country_ != (obj as Person).country_)
            {
                diff.Add(DiffToXElement("Land", (obj as Person).country_.ToString(), country_.ToString()));

            }
            if (phoneBusiness_ != (obj as Person).phoneBusiness_)
            {
                diff.Add(DiffToXElement("Tel. gschäftlich", (obj as Person).phoneBusiness_.ToString(), phoneBusiness_.ToString()));

            }
            if (phoneMob_ != (obj as Person).phoneMob_)
            {
                diff.Add(DiffToXElement("Tel. mobil", (obj as Person).phoneMob_.ToString(), phoneMob_.ToString()));

            }
            if (eMail_ != (obj as Person).eMail_)
            {
                diff.Add(DiffToXElement("Email", (obj as Person).eMail_.ToString(), eMail_.ToString()));
            }

            return diff;
        }

        // hier wird das Xelement für die Mutations-Logs erzeugt
        protected internal XElement DiffToXElement(string attribute, string valueOriginal, string valueEdited) {
            return new XElement("MutationLog",
                        new XElement("Id", id_.ToString()),
                        new XElement("Attribut", attribute),
                        new XElement("Originalwert", valueOriginal),
                        new XElement("Aktualwert", valueEdited),
                        new XElement("Zeitpunkt", DateTime.Now.ToString())
                       );
        }

        // Mit dieser Methode werden die Einträge für den Mutations-Log erstellt
        public void AddLog(List<XElement> diff, Object person)
        {
            foreach (XElement mutationLog in diff)
            {
                (person as XElement).Descendants("MutationLogs")
                    .FirstOrDefault()
                    .Add(mutationLog);
            }
        }

        // Alle Inhalte als String zurückgegeben
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

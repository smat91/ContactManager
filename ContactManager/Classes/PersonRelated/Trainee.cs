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
    public class Trainee : Employee
    {
        // siehe Kommentare zu Properties in Person.cs
        public int numberOfTraineeYears_
        {
            get
            {
                return (int)
                  (from element in trainee_.Descendants("Lehrjahre")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value > 0 && value <= 4)
                {
                    (from element in trainee_.Descendants("Lehrjahre")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss grösser 0 und kleiner, gleich 4 sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        public int currentTraineeYear_
        {
            get
            {
                return (int)
                  (from element in trainee_.Descendants("Lehrjahr")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value > 0 && value <= numberOfTraineeYears_)
                {
                    (from element in trainee_.Descendants("Lehrjahr")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    string message = "Eingabe muss grösser 0 und kleiner, gleich Lehrjahre sein!";
                    string caption = "Fehler in Eingabe erkannt";
                    MessageBoxButtons buttons = MessageBoxButtons.OK;

                    MessageBox.Show(message, caption, buttons);
                }
            }
        }

        // lokales XElement trainee_ anlegen
        public XElement trainee_ { get; private set; }

        // Konstruktor für Trainee
        public Trainee(ref XElement trainee)
            : base(ref trainee)
        {
            trainee_ = trainee;
        }

        // Mit dieser Methode wird dem XML eine neue Person Trainee hinzugefügt
        public virtual void AddToXDocument(ref XDocument personsXml)
        {
            // Prüfen ob die Id des Objektes einzigartig ist und wenn ja,
            // das Objekt dem XDocumten hinzufügen
            if (base.IdIsUnique(ref personsXml))
            {
                base.SetNewId(ref personsXml);
                personsXml.Descendants("Trainees").FirstOrDefault().AddFirst(trainee_);
            }
            else
            {
                string message = "Datensatz existiert bereits!";
                string caption = "Fehler erkannt";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
        }

        // Hier wird der Vergleich gemacht, ob die Instanzen gleich sind
        public override bool Equals(object obj)
        {
            return obj is Trainee trainee &&
                   base.Equals(trainee) &&
                   numberOfTraineeYears_ == trainee.numberOfTraineeYears_ &&
                   currentTraineeYear_ == trainee.currentTraineeYear_;
        }

        // Hier werden Veränderungen am Objekt ausgegeben
        public override List<XElement> Diff(object obj)
        {
            List<XElement> diff = base.Diff(obj);

            if (numberOfTraineeYears_ != (obj as Trainee).numberOfTraineeYears_)
            {
                diff.Add(DiffToXElement("Lehrjahre", (obj as Trainee).numberOfTraineeYears_.ToString(), numberOfTraineeYears_.ToString()));
            }
            if (currentTraineeYear_ != (obj as Trainee).currentTraineeYear_)
            {
                diff.Add(DiffToXElement("Lehrjahr", (obj as Trainee).currentTraineeYear_.ToString(), currentTraineeYear_.ToString()));
            }

            return diff;
        }

        // Alle Inhalte als String zurückgegeben
        public override string ToString()
        {
            return base.ToString() + ", " + 
                numberOfTraineeYears_ + ", " + 
                currentTraineeYear_;
        }
    }
}

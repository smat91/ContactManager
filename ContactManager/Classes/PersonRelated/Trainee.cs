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

        public Trainee(ref XElement trainee)
            : base(ref trainee)
        {
            trainee_ = trainee;
        }

        // Mit dieser Methode wird dem XML eine neue Person Trainee hinzugefügt
        public virtual void AddToXDocument(ref XDocument personsXml)
        {
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

        // Hier wird der Vergleich gemacht, ob die Instanzen gleich sind wie im XML, wenn nicht, dann kommt "false"
        public override bool Equals(object obj)
        {
            return obj is Trainee trainee &&
                   base.Equals(trainee) &&
                   numberOfTraineeYears_ == trainee.numberOfTraineeYears_ &&
                   currentTraineeYear_ == trainee.currentTraineeYear_;
        }

        public override string ToString()
        {
            return base.ToString() + ", " + 
                numberOfTraineeYears_ + ", " + 
                currentTraineeYear_;
        }
    }
}

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
                  (from element in trainee_.Descendants("NumberOfTraineeYears")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value > 0)
                {
                    (from element in trainee_.Descendants("NumberOfTraineeYears")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value must be greater than 0");
                }
            }
        }

        public int currentTraineeYear_
        {
            get
            {
                return (int)
                  (from element in trainee_.Descendants("CurrentTraineeYear")
                   select element).FirstOrDefault();
            }

            set
            {
                if (value > 0 && value <= numberOfTraineeYears_)
                {
                    (from element in trainee_.Descendants("CurrentTraineeYear")
                     select element).FirstOrDefault().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value must be greater than 0 and smaller or equal to numberOfTraineeYears_");
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
                personsXml.Element("Trainees").AddFirst(trainee_);
            }
            else
            {
                throw new ArgumentException("Trainee with this id is already existing in XML");
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager.Classes.PersonRelated
{
    class Trainee : Employee
    {
        public int numberOfTraineeYears_
        {
            get
            {
                return (int)
                  (from element in trainee_.Descendants("NumberOfTraineeYears")
                   select element).First();
            }

            set
            {
                if (value > 0)
                {
                    (from element in trainee_.Descendants("NumberOfTraineeYears")
                     select element).First().SetValue(value);
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
                   select element).First();
            }

            set
            {
                if (value > 0 && value <= numberOfTraineeYears_)
                {
                    (from element in trainee_.Descendants("CurrentTraineeYear")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value must be greater than 0 and smaller or equal to numberOfTraineeYears_");
                }
            }
        }

        // Mit diesem Befehl wird eine Sammlung von Elementen in der Dokumentenreihenfolge zurückgegeben
        private IEnumerable<XElement> trainee_;

        public Trainee(ref IEnumerable<XElement> trainee)
            : base(ref trainee)
        {
            trainee_ = trainee;
        }

        // Mit dieser Methode wird ein XElement Template von Employee erzeugt und ausgegenben
        public override XElement XelementTemplate()
        {
            XElement trainee = base.XelementTemplate();

            // Person Element von Basis nach Customer umbenennen
            trainee.Element("Person").Name = "Trainee";

            // Neue mitarbeiterbezogene Allgemeinattribute hinzufügen
            trainee.Descendants("Function").FirstOrDefault()
                .AddAfterSelf(new XElement("NumberOfTraineeYears", ""),
                              new XElement("CurrentTraineeYear", ""));

            return trainee;
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

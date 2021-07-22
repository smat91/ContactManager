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
                  (from element in person_.Descendants("NumberOfTraineeYears")
                   select element).First();
            }

            set
            {
                if (value != 0)
                {
                    (from element in person_.Descendants("NumberOfTraineeYears")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }

        public int currentTraineeYear_
        {
            get
            {
                return (int)
                  (from element in person_.Descendants("CurrentTraineeYear")
                   select element).First();
            }

            set
            {
                if (value != 0)
                {
                    (from element in person_.Descendants("CurrentTraineeYear")
                     select element).First().SetValue(value);
                }
                else
                {
                    throw new ArgumentException("value cannot be null!");
                }
            }
        }


        public Trainee(ref IEnumerable<XElement> person)
            : base(ref person)
        {
        }

        public override string ToString()
        {
            return base.ToString() + ", " + numberOfTraineeYears_ + ", " + currentTraineeYear_;
        }
    }
}

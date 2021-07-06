using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ContactManager
{
    public class Trainee : Employee
    {
        [XmlElement("MaxTraineeYear", DataType = "int")]
        public int MaxTraineeYear { get; set; }
        [XmlElement("CurrentTraineeYear", DataType = "int")]
        public int CurrentTraineeYear { get; set; }

        public Trainee()
        {
        }

        public Trainee(string flirstname, string lastname, DateTime birthday, int employeeNumber, int maxTraineeYear, int currentTraineeYear) 
            : base(flirstname, lastname, birthday, employeeNumber)
        {
            MaxTraineeYear = maxTraineeYear;
            CurrentTraineeYear = currentTraineeYear;
        }

        public void IncraseTraineeYear() {
            if (CurrentTraineeYear < MaxTraineeYear) {
                CurrentTraineeYear += 1;
            }
        }

        public override string ToString()
        {
            return base.ToString() + ", " + MaxTraineeYear + ", " + CurrentTraineeYear;
        }
    }
}

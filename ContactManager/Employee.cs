using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ContactManager
{
    public class Employee : Person
    {
        [XmlElement("EmployeeNumber", DataType = "int")]
        public int EmployeeNumber { get; set; }
        [XmlElement("Birthday", DataType = "date")]
        public DateTime Birthday { get; set; }


        public Employee(string flirstname, string lastname, DateTime birthday, int employeeNumber)
            : base(flirstname, lastname)
        {
            EmployeeNumber = employeeNumber;
            Birthday = birthday;
        }

        public Employee()
        {
        }

        public override string ToString()
        {
            return base.ToString() + ", " + EmployeeNumber + ", " + Birthday.ToShortDateString();
        }
    }
}

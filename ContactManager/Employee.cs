using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Employee : Person
    {
        public int EmployeeNumber { get; set; }
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

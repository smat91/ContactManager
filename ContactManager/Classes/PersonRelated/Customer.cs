using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Customer : Person
    {
        public int CustomerNumber { get; set; }
        public string Company { get; set; }

        public Customer(string flirstname, string lastname, int customerNumber, string company) 
            : base(flirstname, lastname)
        {
            CustomerNumber = customerNumber;
            Company = company;
        }

        public Customer()
        {
        }

        public override string ToString()
        {
            return base.ToString() + ", " + CustomerNumber + ", " + Company;
        }
    }
}

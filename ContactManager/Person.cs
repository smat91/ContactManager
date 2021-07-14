using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public Person(string flirstname, string lastname)
        {
            Firstname = flirstname;
            Lastname = lastname;
        }

        public Person()
        {
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Firstname == person.Firstname &&
                   Lastname == person.Lastname;
        }

        public override string ToString()
        {
            return Firstname + ", " + Lastname;
        }

    }
}

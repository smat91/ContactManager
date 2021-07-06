using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ContactManager
{
    [XmlInclude(typeof(Employee)), 
     XmlInclude(typeof(Customer)),
     XmlInclude(typeof(Trainee)),]
    public class Person
    {
        [XmlElement("Firstname", DataType = "string")]
        public string Firstname { get; set; }
        [XmlElement("Lastname", DataType = "string")]
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

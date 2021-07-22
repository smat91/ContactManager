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
        public string firstname_ {
            get { return (string)person_.Descendants("Firstname").FirstOrDefault();} 
            
            set { }}

        public string lastname_ { get; set; }

        private IEnumerable<XElement> person_;

        public Person(ref IEnumerable<XElement> person)
        {
            person_ = person;
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   firstname_ == person.firstname_ &&
                   lastname_ == person.lastname_;
        }

        public override string ToString()
        {
            return firstname_ + ", " + lastname_;
        }

    }
}

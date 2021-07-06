using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;


namespace ContactManager
{
    [XmlRoot("PersonData")]
    [XmlInclude(typeof(Person))]
    public class PersonData
    {
        [XmlElement("Listname")]
        public string Listname { get; set; }

        [XmlArray("Persons")]
        [XmlArrayItem("PersonTypes")]
        public List<List<Person>> Persons = new List<List<Person>>();

        [XmlArray("Persons")]
        [XmlArrayItem("Customers")]
        List<Person> Customers = new List<Person>();

        [XmlArray("Persons")]
        [XmlArrayItem("Employees")]
        List<Person> Employees = new List<Person>();

        [XmlArray("Persons")]
        [XmlArrayItem("Trainees")]
        List<Person> Trainees = new List<Person>();

        public PersonData() {
            Persons.Add(Customers);
            Persons.Add(Employees);
            Persons.Add(Trainees);
        }

        public PersonData(string name)
        {
            this.Listname = name;
        }

        public void AddPerson(Person person)
        {
            if (person is Trainee) {
                Trainees.Add(person);
            } else if (person is Customer) { 
                Customers.Add(person);
            } else if (person is Employee) {
                Employees.Add(person);
            }
        }
    }
}

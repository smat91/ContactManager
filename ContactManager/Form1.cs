using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        public PersonData personsList = new PersonData();
        public FileStream fs;
        public XmlSerializer serializer = new XmlSerializer(typeof(PersonData),
            new Type[]{ typeof(Person), typeof(Employee), typeof(Customer), typeof(Trainee) });

        public Form1()
        {
            InitializeComponent();
            AddData();
        }

        private void CmdDemo_Click(object sender, EventArgs e)
        {
        
        }

        private void AddData() {
            personsList.Listname = "test";
            personsList.AddPerson(new Customer("Anna", "Bolika", 1000, "Techmed"));
            personsList.AddPerson(new Customer("Anna", "Bolika", 1000, "Techmed"));
            personsList.AddPerson(new Customer("Anna", "Bolika", 1000, "Techmed"));
            personsList.AddPerson(new Employee("Mario", "Meister", new DateTime(1991, 08, 09), 555));
            personsList.AddPerson(new Employee("Mario", "Meister", new DateTime(1991, 08, 09), 555));
            personsList.AddPerson(new Employee("Mario", "Meister", new DateTime(1991, 08, 09), 555));
            personsList.AddPerson(new Trainee("Tobias", "Renn", new DateTime(2000, 03, 12), 555, 4, 3));
            personsList.AddPerson(new Trainee("Tobias", "Renn", new DateTime(2000, 03, 12), 555, 4, 3));
            personsList.AddPerson(new Trainee("Tobias", "Renn", new DateTime(2000, 03, 12), 555, 4, 3));
        }

        private void CmdSerialize_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Personenliste.xml", FileMode.Create);
            serializer.Serialize(fs, personsList);
            fs.Close();
            personsList = null;
        }

        private void CmdDeserlialize_Click(object sender, EventArgs e)
        {
            fs = new FileStream("Personenliste.xml", FileMode.Open);
            personsList = (PersonData)serializer.Deserialize(fs);
            fs.Close();
        }
    }
}

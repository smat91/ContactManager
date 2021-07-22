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
using System.Xml.Linq;

namespace ContactManager
{
    public partial class Form1 : Form
    {
        public XDocument xdocument = XDocument.Load("..\\..\\..\\Persons.xml");

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            IEnumerable<XElement> persons = xdocument.Elements();
            foreach (var person in persons)
            {
                TxtOutput.Text = person + "\r\n";
            }
        }

        private void CmdReadCustomers_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            IEnumerable<XElement> persons = xdocument.Elements();
            foreach (XElement customer in persons.Descendants ("Customer"))
            {
                TxtOutput.Text = customer + "\r\n";
            }
        }

        private void CmdReadEmployees_Click(object sender, EventArgs e)
        {
            //TxtOutput.Clear();
            //IEnumerable<XElement> persons = xdocument.Elements();
            
            //XElement employees in persons.Descendants("Employees"));

            //from address in xelement.Elements("Employee")
            //where (string)address.Element("Address").Element("City") == "Alta"
            //select address;

            //Employee e1 = new Person(ref persons);

        }

        private void CmdReadTrainees_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            IEnumerable<XElement> persons = xdocument.Elements();
            foreach (XElement trainee in persons.Descendants("Trainee"))
            {
                TxtOutput.Text = trainee + "\r\n";
            }
        }
    }
}

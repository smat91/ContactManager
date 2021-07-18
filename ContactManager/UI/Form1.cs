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
            IEnumerable<XElement> customers = xdocument.Elements();
            foreach (XElement customer in customers.Descendants ("Customer"))
            {
                TxtOutput.Text = customer + "\r\n";
            }
        }

        private void CmdReadEmployees_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            IEnumerable<XElement> employees = xdocument.Elements();
            foreach (XElement employee in employees.Descendants("Employee"))
            {
                TxtOutput.Text = employee + "\r\n";
            }
        }

        private void CmdReadTrainees_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();
            IEnumerable<XElement> trainees = xdocument.Elements();
            foreach (XElement trainee in trainees.Descendants("Trainee"))
            {
                TxtOutput.Text = trainee + "\r\n";
            }
        }
    }
}

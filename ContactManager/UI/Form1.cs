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
        public XDocument xdocument = XDocument.Load("..\\..\\..\\XmlData\\Persons.xml");

        private XmlTemplate xmlTemplate = new XmlTemplate();

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
            IEnumerable<XElement> customer = xmlTemplate.XelementTemplateCustomer().Elements();
            foreach (var person in customer)
            {
                TxtOutput.Text += person + "\r\n";
            }
        }

        private void CmdReadEmployees_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            XElement customerTemplate = xmlTemplate.XelementTemplateCustomer();
            Customer c1 = new Customer(ref customerTemplate);

            c1.id_ = 1;

            c1.AddLog("dsfgkjdsfjöglkjfsdägökljfddsögkdfmvsödslkgmbvfdäblkvm");

            TxtOutput.Text += c1.id_;

            foreach (var person in customerTemplate.Descendants())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }
    }
}

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
        public const string filePath = "..\\..\\..\\XmlData\\Persons.xml";
        public XDocument xdocument = XDocument.Load(filePath);

        private XmlTemplate xmlTemplate = new XmlTemplate();

        public Form1()
        {
            InitializeComponent();
        }

        private void SaveToXml()
        {
            xdocument.Save(filePath);
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

            c1.AddToXml(ref xdocument);


            SaveToXml();

            foreach (var person in customerTemplate.Descendants())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }

        private void CmdReadTrainees_Click(object sender, EventArgs e)
        {
            IEnumerable<XElement> idList =
                from ids in xdocument.Descendants("Id")
                orderby int.Parse(ids.Value)
                select ids;

            TxtOutput.Text += 1 + (int)idList.Last();

        }
    }
}

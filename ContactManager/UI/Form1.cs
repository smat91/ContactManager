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

        DataTable dt = new DataTable();

        private XmlTemplate xmlTemplate = new XmlTemplate();
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();

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
            dataGridView1.DataSource = xmlDataHandling.XElementToDataTable(xdocument, XmlDataHandling.personType.customer);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            string selectedId = dataGridView1.SelectedCells[0].Value.ToString();

            Customer c2 = new Customer(ref xmlDataHandling.DataTableToXElement(xdocument, XmlDataHandling.personType.customer, selectedId));


            c2.firstname_ = "dada";
            c2.lastname_ = "gugus";

            foreach (var person in xmlDataHandling.DataTableToXElement(xdocument, XmlDataHandling.personType.customer, selectedId).Descendants())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }
    }
}

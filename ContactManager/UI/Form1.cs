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

        private XmlTemplate xmlTemplate = new XmlTemplate();                // Objekt um die XML-Templates zu erstellen
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();    // Objekt um XML-Daten zu handeln

        public Form1()
        {
            InitializeComponent();

            // Fügt der Combobox die verfügbaren Attribue hinzu
            foreach (string columnName in xmlDataHandling.GetColumnNames(ref xdocument, XmlDataHandling.personType.customer)) 
            { 
                comboBoxAttribut.Items.Add(columnName);
            }
        }

        private void SaveToXml()
        {
            xdocument.Save(filePath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            // Lädt alle Elemente aus xdocument
            IEnumerable<XElement> persons = xdocument.Elements();   

            // Gibt alle Elemente in persons aus
            foreach (var person in persons)
            {
                TxtOutput.Text = person + "\r\n";
            }
        }

        private void CmdReadCustomers_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            // Erzeugt ein neues XElement vom Typ Customer
            XElement customer = xmlTemplate.XelementTemplateCustomer();

            // Gibt alle Elemente in customer aus
            foreach (var person in customer.Elements())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }

        private void CmdReadEmployees_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            // Erzeugt ein neues XElement vom Typ Customer
            XElement customerTemplate = xmlTemplate.XelementTemplateCustomer();

            // Erzeugt ein neues objekt vom Typ Customer das vorhin erstelle Template
            // muss als Referenz mitgegeben werden
            Customer c1 = new Customer(ref customerTemplate);

            // Fügt das customer Objekt c1 dem XDocument hinzu
            c1.AddToXDocument(ref xdocument);

            // Speichert das XDocument als XML ab
            SaveToXml();

            // Gibt alle Elemente in customerTemplate aus
            foreach (var person in customerTemplate.Descendants())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }

        private void CmdReadTrainees_Click(object sender, EventArgs e)
        {
            // Fügt dem DataGridView eine Datenquelle hinzu
            // Der Methode wird das XDoument und der Personentyp übergeben
            // anschliessend werden die Daten aus dem XDocument so aufbereitet,
            // dass die dem DataGridView als DataSource übergeben werden können.
            dataGridView1.DataSource = xmlDataHandling.XElementToDataTable(ref xdocument, XmlDataHandling.personType.customer);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            // ID aus selektierter Zeile aus dem Data Grid View auslesen
            // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
            string selectedId = dataGridView1.SelectedCells[0].Value.ToString();

            // Erzeugt ein neues objekt vom Typ Customer hanhand der ID kann das 
            // bestehende XElement aus dem XDocument ausgelesen werden
            Customer c2 = new Customer(ref xmlDataHandling.IdToXElement(ref xdocument, XmlDataHandling.personType.customer, selectedId));


            c2.firstname_ = "dada";
            c2.lastname_ = "gugus";

            // Gibt alle Elemente im Ausgelesenen XElement aus
            foreach (var person in xmlDataHandling.IdToXElement(ref xdocument, XmlDataHandling.personType.customer, selectedId).Elements())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = xmlDataHandling.SearchInXDocument(
                ref xdocument, XmlDataHandling.personType.customer, txtSearch.Text, (string)comboBoxAttribut.SelectedItem);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // ID aus selektierter Zeile aus dem Data Grid View auslesen
            // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
            string selectedId = dataGridView1.SelectedCells[0].Value.ToString();

            xmlDataHandling.DeleteElementById(ref xdocument, XmlDataHandling.personType.customer, selectedId);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            TxtOutput.Clear();

            // ID aus selektierter Zeile aus dem Data Grid View auslesen
            // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
            string selectedId = dataGridView1.SelectedCells[0].Value.ToString();

            // Erzeugt ein neues objekt vom Typ Customer hanhand der ID kann das 
            // bestehende XElement aus dem XDocument ausgelesen werden
            Customer c2 = new Customer(ref xmlDataHandling.IdToXElement(ref xdocument, XmlDataHandling.personType.customer, selectedId));

            foreach (var log in c2.GetLogs())
            {
                TxtOutput.Text += log + "\r\n";
            }
        }
    }
}

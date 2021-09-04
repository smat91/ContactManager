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
        static Form1 _obj;
        public int sideBarStatus = 0;

        public static Form1 Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Form1();
                }
                return _obj;
            }
        }

        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = value; }
        }

        public Button Homebutton
        {
            get { return CmdHome; }
            set { CmdHome = value; }
        }

        public const string filePath = "..\\..\\..\\XmlData\\Persons.xml";
        public XDocument xdocument = XDocument.Load(filePath);

        private XmlTemplate xmlTemplate = new XmlTemplate();                // Objekt um die XML-Templates zu erstellen
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();    // Objekt um XML-Daten zu handeln


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            PanelContainer.Controls["UCHome"].BringToFront();
            CmdHome.Visible = true;
            sideBarStatus = 0;

            this.panel2.BackColor = ColorTranslator.FromHtml("#9B59B6");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmdHome.Visible = true;
            _obj = this;

            UI.UCHome uc = new UI.UCHome();
            uc.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(uc);

        }

        private void CmdKunde_Click(object sender, EventArgs e)
        {
            
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCCustomer"))
            {
                UI.UCCustomer un = new UI.UCCustomer(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCCustomer"].BringToFront();
            Form1.Instance.CmdHome.Visible = true;
            sideBarStatus = 1;

            this.panel2.BackColor = ColorTranslator.FromHtml("#FDC006");

        }

        private void CmdMitarbeiter_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCEmployee"))
            {
                UI.UCEmployee un = new UI.UCEmployee(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCEmployee"].BringToFront();
            Form1.Instance.CmdHome.Visible = true;
            sideBarStatus = 2;

            this.panel2.BackColor = ColorTranslator.FromHtml("#019587");
        }

        private void CmdLernende_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCTrainee"))
            {
                UI.UCTrainee un = new UI.UCTrainee(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCTrainee"].BringToFront();
            Form1.Instance.CmdHome.Visible = true;
            sideBarStatus = 3;

            this.panel2.BackColor = ColorTranslator.FromHtml("#02A8F4");
        }

        private void CmdReset_Click(object sender, EventArgs e)
        {
            TxtSearch.Clear();
            //Combobox leeren!
        }

        private void CmdNew_Click(object sender, EventArgs e)
        {
            switch (sideBarStatus)
            {
                // case customer
                case 1:
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCNewCustomer"))
                    {
                        UI.UCNewCustomer un = new UI.UCNewCustomer();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(un);
                    }
                    Form1.Instance.PnlContainer.Controls["UCNewCustomer"].BringToFront();
                    Form1.Instance.CmdHome.Visible = true;
                    break;

                // case employee
                case 2:
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCNewEmployee"))
                    {
                        UI.UCNewEmployee un = new UI.UCNewEmployee();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(un);
                    }
                    Form1.Instance.PnlContainer.Controls["UCNewEmployee"].BringToFront();
                    Form1.Instance.CmdHome.Visible = true;
                    break;

                // case trainee
                case 3:
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCNewTrainee"))
                    {
                        UI.UCNewTrainee un = new UI.UCNewTrainee();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(un);
                    }
                    Form1.Instance.PnlContainer.Controls["UCNewTrainee"].BringToFront();
                    Form1.Instance.CmdHome.Visible = true;
                    break;
            }    
        }

        private void CmdEdit_Click(object sender, EventArgs e)
        {
            switch (sideBarStatus) {
                // case customer
                case 1:
                    // ID aus selektierter Zeile aus dem Data Grid View auslesen
                    // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
                    string selectedId = (Form1.Instance.PnlContainer.Controls["UCCustomer"].Controls["DgvCustomer"] as DataGridView).SelectedCells[0].Value.ToString();

                    // Erzeugt ein neues objekt vom Typ Customer hanhand der ID kann das 
                    // bestehende XElement aus dem XDocument ausgelesen werden
                    Customer c = new Customer(ref xmlDataHandling.IdToXElement(ref xdocument, XmlDataHandling.personType.customer, selectedId));

                    // Prüfen ob Form erzeugt werden muss und gegebenenfalls erzeugen
                    if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCEditCustomer"))
                    {
                        UI.UCEditCustomer un = new UI.UCEditCustomer();
                        un.Dock = DockStyle.Fill;
                        Form1.Instance.PnlContainer.Controls.Add(un);
                    }

                    // Der Form das zu bearbeitende customer Objekt übergebeb
                    (Form1.Instance.PnlContainer.Controls["UCEditCustomer"] as UI.UCEditCustomer).SetCustomer(ref c);

                    // Die Form in den Vordergrund bringen und anzeigen
                    Form1.Instance.PnlContainer.Controls["UCEditCustomer"].BringToFront();
                    Form1.Instance.CmdHome.Visible = true;
                    break;

                // case employee
                case 2:

                    break;

                // case trainee
                case 3:

                    break;

                // default 
                default: 
                    break;
            }
        }
              
        // Design: Farben ändern sich beim Hovern
        private void CmdKunde_MouseEnter(object sender, EventArgs e)
        {
           this.CmdKunde.BackColor = ColorTranslator.FromHtml("#FDC006");
        }
        private void CmdKunde_MouseLeave(object sender, EventArgs e)
        {
            this.CmdKunde.BackColor = ColorTranslator.FromHtml("#33334C");
        }

        private void CmdMitarbeiter_MouseEnter(object sender, EventArgs e)
        {
            this.CmdMitarbeiter.BackColor = ColorTranslator.FromHtml("#019587");
        }
        private void CmdMitarbeiter_MouseLeave(object sender, EventArgs e)
        {
            this.CmdMitarbeiter.BackColor = ColorTranslator.FromHtml("#33334C");
        }

        private void CmdLernende_MouseEnter(object sender, EventArgs e)
        {
            this.CmdLernende.BackColor = ColorTranslator.FromHtml("#02A8F4");
        }
        private void CmdLernende_MouseLeave(object sender, EventArgs e)
        {
            this.CmdLernende.BackColor = ColorTranslator.FromHtml("#33334C");
        }
        private void CmdHome_MouseEnter(object sender, EventArgs e)
        {
            this.CmdHome.BackColor = ColorTranslator.FromHtml("#9B59B6");
        }
        private void CmdHome_MouseLeave(object sender, EventArgs e)
        {
            this.CmdHome.BackColor = ColorTranslator.FromHtml("#33334C");
        }

    }
}

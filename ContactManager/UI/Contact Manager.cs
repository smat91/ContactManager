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
using System.Xml.Schema;


namespace ContactManager
{

    public partial class Form1 : Form
    {
        static Form1 obj_;
        public int sideBarStatus = 0;

        public static Form1 Instance
        {
            get
            {
                if (obj_ == null)
                {
                    obj_ = new Form1();
                }
                return obj_;
            }
        }

        public Panel PnlContainerMain
        {
            get { return PanelContainerMain; }
            set { PanelContainerMain = value; }
        }

        public Panel PnlContainerTop
        {
            get { return PanelContainerTop; }
            set { PanelContainerTop = value; }
        }

        public Button Homebutton
        {
            get { return CmdHome; }
            set { CmdHome = value; }
        }

        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)}\ContactManager\";
        private string fileName = @"Persons.xml";
        private XDocument xdocument;
        private XDocument xdocumentOriginal;

        public void LoadFromXml()
        {
            XDocument xdocumentTemp = XDocument.Load($"{filePath}{fileName}");
            xdocument.ReplaceNodes(xdocumentTemp.Elements());
        }

        public void SaveToXml()
        {
            xdocument.Save($"{filePath}{fileName}");
            XDocument xdocumentTemp = XDocument.Load($"{filePath}{fileName}");
            xdocumentOriginal.ReplaceNodes(xdocumentTemp.Elements());
        }

        public Form1()
        {
            // prüfen ob File existiert und falls nötig erstellen
            if (!File.Exists($"{filePath}{fileName}"))
            {
                // XDocument template erstellen
                XDocument template = new XDocument(
                                            new XElement("Persons",
                                                new XElement("Customers", ""),
                                                new XElement("Employees", ""),
                                                new XElement("Trainees", "")
                                                ));

                // prüfen ob Pfad existiert und falls nötig erstellen
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }

                // XDocument template als Persons.xml abspeichern
                template.Save($"{filePath}{fileName}");
            }

            xdocument = XDocument.Load($"{filePath}{fileName}");
            xdocumentOriginal = XDocument.Load($"{filePath}{fileName}");

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadFromXml();

            obj_ = this;

            if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCDashboard"))
            {
                UI.UCDashboard un = new UI.UCDashboard(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerMain.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCDashboard"].BringToFront();
            (Form1.Instance.PnlContainerMain.Controls["UCDashboard"] as UI.UCDashboard).LoadDashboard();
            Form1.Instance.PnlContainerTop.Hide();
            sideBarStatus = 0;

            this.PanelContainerTop.BackColor = ColorTranslator.FromHtml("#33334c");
            this.PanelContainerMain.BackColor = ColorTranslator.FromHtml("#9B59B6");

            {
                // Contact Manager From zentriet einrichten
                int breite = Screen.PrimaryScreen.Bounds.Width;
                int höhe = Screen.PrimaryScreen.Bounds.Height;

                int x = breite - this.Width;
                int y = höhe - this.Height;

                this.Location = new Point(x / 2, y / 2);
            }
        }

        private void CmdHome_Click(object sender, EventArgs e)
        {
            LoadFromXml();

            if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCDashboard"))
            {
                UI.UCDashboard un = new UI.UCDashboard(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerMain.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCDashboard"].BringToFront();
            (Form1.Instance.PnlContainerMain.Controls["UCDashboard"] as UI.UCDashboard).LoadDashboard();
            Form1.Instance.PnlContainerTop.Hide();
            sideBarStatus = 0;

            this.PanelContainerTop.BackColor = ColorTranslator.FromHtml("#33334c");
            this.PanelContainerMain.BackColor = ColorTranslator.FromHtml("#9B59B6");
        }

        private void CmdKunde_Click(object sender, EventArgs e)
        {
            LoadFromXml();

            if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCCustomer"))
            {
                UI.UCCustomer un = new UI.UCCustomer(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerMain.Controls.Add(un);
            }

            if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarResults"))
            {
                UI.UCTopBarResults un = new UI.UCTopBarResults(ref xdocument, ref xdocumentOriginal);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerTop.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCCustomer"].BringToFront();
            (Form1.Instance.PnlContainerMain.Controls["UCCustomer"] as UI.UCCustomer).RefreshData();
            Form1.Instance.PnlContainerTop.Show();
            Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
            sideBarStatus = 1;

            this.PnlContainerMain.BackColor = ColorTranslator.FromHtml("#FDC006");
            this.PanelContainerTop.BackColor = ColorTranslator.FromHtml("#FDC006");
        }

        private void CmdMitarbeiter_Click(object sender, EventArgs e)
        {
            LoadFromXml();

            if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCEmployee"))
            {
                UI.UCEmployee un = new UI.UCEmployee(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerMain.Controls.Add(un);
            }

            if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarResults"))
            {
                UI.UCTopBarResults un = new UI.UCTopBarResults(ref xdocument, ref xdocumentOriginal);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerTop.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCEmployee"].BringToFront();
            (Form1.Instance.PnlContainerMain.Controls["UCEmployee"] as UI.UCEmployee).RefreshData();
            Form1.Instance.PnlContainerTop.Show();
            Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
            sideBarStatus = 2;

            this.PnlContainerMain.BackColor = ColorTranslator.FromHtml("#019587");
            this.PanelContainerTop.BackColor = ColorTranslator.FromHtml("#019587");
        }

        private void CmdLernende_Click(object sender, EventArgs e)
        {
            LoadFromXml();

            if (!Form1.Instance.PnlContainerMain.Controls.ContainsKey("UCTrainee"))
            {
                UI.UCTrainee un = new UI.UCTrainee(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerMain.Controls.Add(un);
            }

            if (!Form1.Instance.PnlContainerTop.Controls.ContainsKey("UCTopBarResults"))
            {
                UI.UCTopBarResults un = new UI.UCTopBarResults(ref xdocument, ref xdocumentOriginal);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerTop.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCTrainee"].BringToFront();
            (Form1.Instance.PnlContainerMain.Controls["UCTrainee"] as UI.UCTrainee).RefreshData();
            Form1.Instance.PnlContainerTop.Show();
            Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
            sideBarStatus = 3;

            this.PnlContainerMain.BackColor = ColorTranslator.FromHtml("#02A8F4");
            this.PanelContainerTop.BackColor = ColorTranslator.FromHtml("#02A8F4");
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

        private void PicExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CmdXmlDataImport_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.DefaultExt = "xml";
                openFileDialog.Filter = "XML Files|*.xml";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Pfad des gewählten files einlesen
                    string path = openFileDialog.FileName;

                    // File importieren
                    XDocument xdocumentImport = XDocument.Load(path);

                    // XML Schemaset erzeugen
                    XmlSchemaSet schemas = new XmlSchemaSet();
                    schemas.Add("", XmlReader.Create(new StringReader(Properties.Resources.Persons)));

                    // importiertes File prüfen
                    bool errors = false;
                    xdocumentImport.Validate(schemas, (o, ex) =>
                                            {
                                                string message = "Fehler bei XML prüfung:\n\r" + ex.Message;
                                                string caption = "Fehler in XML erkannt";
                                                MessageBoxButtons buttons = MessageBoxButtons.OK;

                                                MessageBox.Show(message, caption, buttons);
                                                errors = true;
                                            });

                    // falls File in ordnung ist import abschliessen
                    if (!errors)
                    {
                        xdocument.ReplaceNodes(xdocumentImport.Elements());
                        SaveToXml();
                        LoadFromXml();
                        (Form1.Instance.PnlContainerMain.Controls["UCDashboard"] as UI.UCDashboard).LoadDashboard();
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

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

        private const string filePath = "..\\..\\..\\XmlData\\Persons.xml";
        private XDocument xdocument = XDocument.Load(filePath);

        public void LoadFromXml()
        {
            XDocument xdocumentTemp = XDocument.Load(filePath);
            xdocument.ReplaceNodes(xdocumentTemp.Elements());
        }

        public void SaveToXml()
        {
            xdocument.Save(filePath);
        }

        public Form1()
        {
            LoadFromXml();
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
            Form1.Instance.PnlContainerTop.Hide();
            sideBarStatus = 0;

            this.PanelContainerTop.BackColor = ColorTranslator.FromHtml("#33334c");
            this.PanelContainerMain.BackColor = ColorTranslator.FromHtml("#9B59B6");
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
                UI.UCTopBarResults un = new UI.UCTopBarResults(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerTop.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCCustomer"].BringToFront();
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
                UI.UCTopBarResults un = new UI.UCTopBarResults(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerTop.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCEmployee"].BringToFront();
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
                UI.UCTopBarResults un = new UI.UCTopBarResults(ref xdocument);
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainerTop.Controls.Add(un);
            }

            Form1.Instance.PnlContainerMain.Controls["UCTrainee"].BringToFront();
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
    }
}

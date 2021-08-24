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
        
        public XDocument xdocument = XDocument.Load("..\\..\\..\\XmlData\\Persons.xml");

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
            CmdHome.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CmdHome.Visible = false;
            _obj = this;

            UCHome uc = new UCHome();
            uc.Dock = DockStyle.Fill;
            PanelContainer.Controls.Add(uc);
        }

        private void CmdKunde_Click(object sender, EventArgs e)
        {
            if (!Form1.Instance.PnlContainer.Controls.ContainsKey("UCCustomer"))
            {
                UCCustomer un = new UCCustomer();
                un.Dock = DockStyle.Fill;
                Form1.Instance.PnlContainer.Controls.Add(un);
            }
            Form1.Instance.PnlContainer.Controls["UCCustomer"].BringToFront();
            Form1.Instance.CmdHome.Visible = true;

        }

        private void CmdNew_Click(object sender, EventArgs e)
        {

        }
    }
}

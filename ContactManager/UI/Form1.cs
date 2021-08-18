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
        
        public XDocument xdocument = XDocument.Load("..\\..\\..\\XmlData\\Persons.xml");

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

        private void CmdHome_Click(object sender, EventArgs e)
        {
            /*if (CmdHome.Enabled = true) 
            {
                CmdHome.BackColor = Color.Red;  //Beispiel 
                CmdHome.ForeColor = Color.White;
            }*/
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}

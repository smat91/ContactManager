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

namespace ContactManager.UI
{
    public partial class UCNew : UserControl
    {
        public UCNew()
        {
            InitializeComponent();
        }

        private XmlTemplate xmlTemplate = new XmlTemplate();

        private void UCNew_Load(object sender, EventArgs e)
        {
            XElement customerTemplate = xmlTemplate.XelementTemplateCustomer();
            Customer c1 = new Customer(ref customerTemplate);

            c1.firstname_ = "Test";

            TxtOutput.Text += c1.id_;

            foreach (var person in customerTemplate.Descendants())
            {
                TxtOutput.Text += person + "\r\n";
            }
        }
    }
}

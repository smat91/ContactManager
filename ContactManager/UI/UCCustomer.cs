using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager.UI
{
    public partial class UCCustomer : UserControl
    {
        private XDocument xdocument_;
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();

        public UCCustomer(ref XDocument xdocument)
        {
            InitializeComponent();
            xdocument_ = xdocument;
        }
        
        private void UCCustomer_Load(object sender, EventArgs e)
        {
            DgvCustomer.DataSource = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);
        }
    }
}

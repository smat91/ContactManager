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
    public partial class UCEmployee : UserControl
    {

        private XDocument xdocument_;
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();
        public UCEmployee(ref XDocument xdocument)
        {
            InitializeComponent();
            xdocument_ = xdocument;
        }

        private void UCEmployee_Load(object sender, EventArgs e)
        {
            DgvEmployee.DataSource = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.employee);
        }
    }
}

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
            RefreshData();
        }

        // siehe UCCustomer
        public void RefreshData()
        {
            var dt = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.employee);

            if (dt.Columns.Count > 0)
            {
                dt.DefaultView.Sort = "Id ASC";
                DgvEmployee.DataSource = dt;
            }
        }
    }
}

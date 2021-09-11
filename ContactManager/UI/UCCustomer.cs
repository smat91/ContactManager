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
            RefreshData();
        }

        // Anzeige Daten aktualisieren
        public void RefreshData()
        {
            var dt = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);

            // falls Daten anzuzeigen sind diese noch vor Anzeige sortieren
            if (dt.Columns.Count > 0)
            {
                dt.DefaultView.Sort = "Id ASC";
                DgvCustomer.DataSource = dt;
            }
        }
    }
}

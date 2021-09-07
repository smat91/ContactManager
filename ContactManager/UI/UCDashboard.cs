using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ContactManager.UI
{
    public partial class UCDashboard : UserControl
    {
        private XDocument xdocument_;
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();    // Objekt um XML-Daten zu handeln

        public UCDashboard(ref XDocument xdocument)
        {
            InitializeComponent();
            xdocument_ = xdocument;
        }

        public void LoadDashboard()
        {
            LblNumberOfCustomers.Text = $" {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.customer)}";

            LblNumberOfEmployees.Text = $" {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.employee)}";

            LblNumberOfTrainees.Text = $" {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.trainee)}";

            DvgMutationLogs.Rows.Clear();
            foreach (string mutationLog in xmlDataHandling.GetMutationLogs(ref xdocument_))
            {
                DvgMutationLogs.Rows.Add(mutationLog);
            }
        }

        private void LblNumberOfCustomers_Click(object sender, EventArgs e)
        {

        }
    }
}

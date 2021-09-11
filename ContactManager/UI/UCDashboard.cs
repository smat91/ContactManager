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
            // Anzahl Datensätze zum jeweiligen Personentyp ermitteln
            LblNumberOfCustomers.Text = $" {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.customer)}";

            LblNumberOfEmployees.Text = $" {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.employee)}";

            LblNumberOfTrainees.Text = $" {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.trainee)}";

            // Daten zu Mutationslogs soritert anzeigen
            var dt = xmlDataHandling.GetMutationLogs(ref xdocument_);
            if (dt.Columns.Count > 0)
            {
                dt.DefaultView.Sort = "Zeitpunkt DESC";
                DvgMutationLogs.DataSource = dt;

                // Spaltenbreite festlegen
                DvgMutationLogs.Columns[0].FillWeight = 8;      // Spaltenbreite in % für Id
                DvgMutationLogs.Columns[1].FillWeight = 23;     // Spaltenbreite in % für Attribut
                DvgMutationLogs.Columns[3].FillWeight = 23;     // Spaltenbreite in % für Originalwert
                DvgMutationLogs.Columns[4].FillWeight = 23;     // Spaltenbreite in % für Aktualwert
                DvgMutationLogs.Columns[2].FillWeight = 23;     // Spaltenbreite in % für Zeitpunkt
            }
        }
    }
}

﻿using System;
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

        private void UCDashboard_Load(object sender, EventArgs e)
        {
            LblNumberOfCustomers.Text = $"Anzahl Kunden im System: {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.customer)}";

            LblNumberOfEmployees.Text = $"Anzahl Angestellte im System: {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.employee)}";

            LblNumberOfTrainees.Text = $"Anzahl Lehrnende im System: {xmlDataHandling.GetNumberOfDataSets(ref xdocument_, XmlDataHandling.personType.trainee)}";
        }
    }
}

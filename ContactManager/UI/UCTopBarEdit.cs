using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager.UI
{
    public partial class UCTopBarEdit : UserControl
    {
        private XDocument xdocument_;
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();

        public UCTopBarEdit(ref XDocument xdocument)
        {
            InitializeComponent();
            xdocument_ = xdocument;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            Form1.Instance.SaveToXml();
            ReloadDataAndView();
        }

        private void CmdCancle_Click(object sender, EventArgs e)
        {
            Form1.Instance.LoadFromXml();
            ReloadDataAndView();
        }

        private void ReloadDataAndView() 
        {
            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    Form1.Instance.PnlContainerMain.Controls["UCCustomer"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
                    break;

                    (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].Controls["DgvCustomer"] as DataGridView).DataSource =
                        xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);

                // case employee
                case 2:
                    Form1.Instance.PnlContainerMain.Controls["UCEmployee"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
                    break;

                    (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].Controls["DgvEmployee"] as DataGridView).DataSource =
                        xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.employee);

                // case trainee
                case 3:
                    Form1.Instance.PnlContainerMain.Controls["UCTrainee"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
                    break;

                    (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].Controls["DgvTrainee"] as DataGridView).DataSource =
                        xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.trainee);

                // default 
                default:
                    break;
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager.UI
{
    public partial class UCTopBarEdit : UserControl
    {
        private XDocument xdocument_;
        private Object person_;
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();

        public UCTopBarEdit(ref XDocument xdocument, Object person)
        {
            InitializeComponent();
            xdocument_ = xdocument;
            person_ = person;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //Prüfen, ob Vor-und Nachname der Person eingegeben wurde
            if ((person_ as Person).CheckMinimalInforamtion())
            {
                Form1.Instance.SaveToXml();
                ReloadDataAndView();
            }
            else
            {
                string message = "At least firstname and lastname must be set";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
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

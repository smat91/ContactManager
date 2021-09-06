using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ContactManager.UI
{
    public partial class UCTopBarEdit : UserControl
    {
        private XDocument xdocument_;
        private Object person_;
        private Object personOriginal_;
        private XmlDataHandling xmlDataHandling = new XmlDataHandling();

        public UCTopBarEdit(ref XDocument xdocument)
        {
            InitializeComponent();
            xdocument_ = xdocument;
        }

        public void SetPersonObject(Object personEdit)
        {
            person_ = personEdit;
            personOriginal_ = personEdit;
        }

        public void SetPersonObject(Object personEdit, Object personOrigianl)
        {
            person_ = personEdit;
            personOriginal_ = personOrigianl;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            //Prüfen, ob Vor-und Nachname der Person eingegeben wurde
            if ((person_ as Person).CheckMinimalInforamtion())
            {
                // Prüfen ob Änderungen geloggt werden müssen
                if (!person_.Equals(personOriginal_))
                {
                    if (person_ is Customer)
                    {
                        (person_ as Customer).AddLog(
                            (person_ as Customer).Diff(personOriginal_), (person_ as Customer).customer_);
                    }
                    else if (person_ is Employee)
                    {
                        (person_ as Employee).AddLog(
                            (person_ as Employee).Diff(personOriginal_), (person_ as Employee).employee_);
                    }
                    else if (person_ is Trainee)
                    {
                        (person_ as Trainee).AddLog(
                            (person_ as Trainee).Diff(personOriginal_), (person_ as Trainee).trainee_);
                    }
                }

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
            ReloadDataAndView();
        }

        private void ReloadDataAndView() 
        {
            Form1.Instance.LoadFromXml();

            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    Form1.Instance.PnlContainerMain.Controls["UCCustomer"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
                    (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].Controls["DgvCustomer"] as DataGridView).DataSource =
                     xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);

                    break;
                    
                // case employee
                case 2:
                    Form1.Instance.PnlContainerMain.Controls["UCEmployee"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
                    (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].Controls["DgvEmployee"] as DataGridView).DataSource =
                        xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.employee);
                    break;

                // case trainee
                case 3:
                    Form1.Instance.PnlContainerMain.Controls["UCTrainee"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();
                    (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].Controls["DgvTrainee"] as DataGridView).DataSource =
                        xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.trainee);
                    break;

                // default 
                default:
                    break;
            }
        }
    }
}

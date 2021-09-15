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

        // Personen Objekte setzen Methode für Neuerstellugn
        public void SetPersonObject(Object personEdit)
        {
            person_ = personEdit;
            personOriginal_ = personEdit;
        }

        // Personen Objekte setzen Methode für Bearbeitung
        public void SetPersonObject(Object personEdit, Object personOrigianl)
        {
            person_ = personEdit;
            personOriginal_ = personOrigianl;
        }

        private void CmdCancle_Click(object sender, EventArgs e)
        {
            ReloadDataAndView();
        }

        // Bearbeitung speichern
        private void CmdSave_Click(object sender, EventArgs e)
        {
            //Prüfen, ob die Pflichfelder, für das Anlegen einer Person, ausgefüllt worden sind
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

                string message = "Die Daten wurden erfolgreich gespeichert!";
                string caption = "Gespeichert";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);

                ReloadDataAndView();
            }
            else
            {
                string message = "Mindestens die mit * markierten Felder müssen ausgefüllt werden!";
                string caption = "Fehler in Eingabe erkannt";
                MessageBoxButtons buttons = MessageBoxButtons.OK;

                MessageBox.Show(message, caption, buttons);
            }
        }

        // Jeweilige Übersichtsanzeige neu laden und deren Inhalt aktualisieren
        private void ReloadDataAndView() 
        {
            Form1.Instance.LoadFromXml();

            switch (Form1.Instance.sideBarStatus)
            {
                // case customer
                case 1:
                    Form1.Instance.PnlContainerMain.Controls["UCCustomer"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();

                    var dtCustomer = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.customer);

                    if (dtCustomer.Columns.Count > 0)
                    {
                        dtCustomer.DefaultView.Sort = "Id ASC";
                        (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].Controls["DgvCustomer"] as DataGridView).DataSource = dtCustomer;
                        (Form1.Instance.PnlContainerMain.Controls["UCCustomer"].Controls["DgvCustomer"] as DataGridView).AutoResizeColumns();
                    }
                    break;
                    
                // case employee
                case 2:
                    Form1.Instance.PnlContainerMain.Controls["UCEmployee"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();

                    var dtEmployee = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.employee);

                    if (dtEmployee.Columns.Count > 0)
                    {
                        dtEmployee.DefaultView.Sort = "Id ASC";
                        (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].Controls["DgvEmployee"] as DataGridView).DataSource = dtEmployee;
                        (Form1.Instance.PnlContainerMain.Controls["UCEmployee"].Controls["DgvEmployee"] as DataGridView).AutoResizeColumns();
                    }
                    break;

                // case trainee
                case 3:
                    Form1.Instance.PnlContainerMain.Controls["UCTrainee"].BringToFront();
                    Form1.Instance.PnlContainerTop.Controls["UCTopBarResults"].BringToFront();

                    var dtTrainee = xmlDataHandling.XElementToDataTable(ref xdocument_, XmlDataHandling.personType.trainee);

                    if (dtTrainee.Columns.Count > 0)
                    {
                        dtTrainee.DefaultView.Sort = "Id ASC";
                        (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].Controls["DgvTrainee"] as DataGridView).DataSource = dtTrainee;
                        (Form1.Instance.PnlContainerMain.Controls["UCTrainee"].Controls["DgvTrainee"] as DataGridView).AutoResizeColumns();
                    }
                    break;

                // default 
                default:
                    break;
            }
        }
    }
}

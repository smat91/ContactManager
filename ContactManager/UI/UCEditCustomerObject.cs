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
    public partial class UCEditCustomerObject : UserControl
    {
        private Customer customer_ = null;
        private XElement[] logs_ = null;
        public UCEditCustomerObject()
        {
            InitializeComponent();
        }

        public void SetCustomer(ref Customer customer)
        {
            customer_ = customer;
            SetControllStartValues();
        }

        private void SetControllStartValues()
        {
            if (customer_ != null)
            {
                // Controlls abfüllen
                CmbState.SelectedIndex = CmbState.FindString(customer_.state_);
                CmbSalutation.SelectedIndex = CmbSalutation.FindString(customer_.salutation_);
                TxtTitle.Text = customer_.title_;
                TxtFirstname.Text = customer_.firstname_;
                TxtLastname.Text = customer_.lastname_;
                TxtSex.Text = customer_.sex_;
                TxtFunction.Text = customer_.function_;
                TxtCompanyName.Text = customer_.companyName_;
                CmbCustomerType.SelectedIndex = CmbCustomerType.FindString(customer_.customerType_);
                TxtStreet.Text = customer_.street_;
                TxtNumber.Text = customer_.number_;
                TxtCity.Text = customer_.city_;
                NumZip.Value = customer_.zip_;
                TxtCountry.Text = customer_.country_;
                TxtPhoneBussines.Text = customer_.phoneBusiness_;
                TxtPhoneMobile.Text = customer_.phoneMob_;
                TxtFax.Text = customer_.fax_;
                TxtEmail.Text = customer_.eMail_;

                GetLogs();

                CmdShowLog.Enabled = (DgvLogs.SelectedCells.Count > 0);
            }
            else 
            {
                return;
            }
        }

        // Werte aus Comboboxen in customer Objekt aktualisieren
        private void ComboBoxIndexChanged(object sender, EventArgs e)
        {
            if (sender == CmbState) 
            {
                customer_.state_ = CmbState.SelectedItem.ToString();
            } 
            else if (sender == CmbSalutation) 
            {
                customer_.salutation_ = CmbSalutation.SelectedItem.ToString();
            }
            else if (sender == CmbCustomerType)
            {
                customer_.customerType_ = CmbCustomerType.SelectedItem.ToString();
            }
        }

        // Werte aus NummericUpDown in customer Objekt aktualisieren
        private void NummericUpDownChanged(object sender, EventArgs e)
        {
            if (sender == NumZip)
            {
                customer_.zip_ = (int)NumZip.Value;
            }

        }

        // Werte aus Textfeldern in customer Objekt aktualisieren
        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (sender == TxtTitle)
            {
                customer_.title_ = TxtTitle.Text;
            }
            else if (sender == TxtFirstname)
            {
                customer_.firstname_ = TxtFirstname.Text;
            }
            else if (sender == TxtLastname)
            {
                customer_.lastname_ = TxtLastname.Text;
            }
            else if (sender == TxtSex)
            {
                customer_.sex_ = TxtSex.Text;
            }
            else if (sender == TxtFunction)
            {
                customer_.function_ = TxtFunction.Text;
            }
            else if (sender == TxtCompanyName)
            {
                customer_.companyName_ = TxtCompanyName.Text;
            }
            else if (sender == TxtStreet)
            {
                customer_.street_ = TxtStreet.Text;
            }
            else if (sender == TxtNumber)
            {
                customer_.number_ = TxtNumber.Text;
            }
            else if (sender == TxtCity)
            {
                customer_.city_ = TxtCity.Text;
            }
            else if (sender == TxtCountry)
            {
                customer_.country_ = TxtCountry.Text;
            }
            else if (sender == TxtPhoneBussines)
            {
                customer_.phoneBusiness_ = TxtPhoneBussines.Text;
            }
            else if (sender == TxtPhoneMobile)
            {
                customer_.phoneMob_ = TxtPhoneMobile.Text;
            }
            else if (sender == TxtFax)
            {
                customer_.fax_ = TxtFax.Text;
            }
            else if (sender == TxtEmail)
            {
                customer_.eMail_ = TxtEmail.Text;
            }
        }

        private void GetLogs()
        {
            // liest alle Logs aus dem Customer Objekt aus
            logs_ = customer_.GetLogs();

            // neue DataTable erzeugen wird als Datenquelle für DataGridViews beötigt
            DataTable dt = new DataTable();

            // Die Spaltennamen der DataTable hinzufügen
            dt.Columns.Add("Id", typeof(string));
            dt.Columns.Add("Datum", typeof(string));
            dt.Columns.Add("Zeit", typeof(string));

            // Die Zeilen der DataTable hinzufügen
            foreach (XElement Log in logs_)
            {
                // Eine neue Zeile hinzufügen
                DataRow newRow = dt.Rows.Add();

                // Die einzelnen Felder der Reihe mit den werden aus dem XML-Tree abfüllen
                newRow[0] = (string)Log.Elements("LogId").FirstOrDefault();
                newRow[1] = (string)Log.Elements("Date").FirstOrDefault();
                newRow[2] = (string)Log.Elements("Time").FirstOrDefault();
            }

            DgvLogs.DataSource = dt;
        }

        private void CmdShowLog_Click(object sender, EventArgs e)
        {
            // ID aus selektierter Zeile aus dem Data Grid View auslesen
            // Die ID steht in der ersten zelle deshalb --> SelectedCells[0]
            string selectedId = DgvLogs.SelectedCells[0].Value.ToString();

            // Log hanhand der Id auslesen
            XElement log = logs_.Elements()
                .Where(x => x.Value == selectedId)
                .Ancestors()                
                .FirstOrDefault();

            // Textfeld leeren
            TxtLog.Clear();

            // Log anzeigen
            TxtLog.Text = log.Element("Text").Value;

            // Elemente ein / ausblenden
            TxtLog.ReadOnly = true;
            TxtLog.Visible = true;
            CmdCloseLog.Visible = true;
            CmdNewLog.Visible = false;
            CmdShowLog.Visible = false;
            DgvLogs.Visible = false;
            CmdNewLog.Visible = false;
            CmdSave.Visible = false;
            CmdCancle.Visible = false;
        }

        private void CmdCloseLog_Click(object sender, EventArgs e)
        {
            // Elemente ein / ausblenden
            TxtLog.Visible = false;
            CmdCloseLog.Visible = false;
            CmdNewLog.Visible = false;
            CmdSave.Visible = false;
            CmdCancle.Visible = false;
            CmdNewLog.Visible = true;
            CmdShowLog.Visible = true;
            DgvLogs.Visible = true;
        }

        private void CmdNewLog_Click(object sender, EventArgs e)
        {
            // Textfeld leeren
            TxtLog.Clear();

            // Elemente ein / ausblenden
            TxtLog.ReadOnly = false;
            TxtLog.Visible = true;
            CmdCloseLog.Visible = false;
            CmdNewLog.Visible = false;
            CmdShowLog.Visible = false;
            DgvLogs.Visible = false;
            CmdSave.Visible = true;
            CmdCancle.Visible = true;
        }

        private void CmdSave_Click(object sender, EventArgs e)
        {
            // Log speichern
            customer_.AddLog(TxtLog.Text);

            // Logs neu laden
            GetLogs();

            // Elemente ein / ausblenden
            TxtLog.Visible = false;
            CmdCloseLog.Visible = false;
            CmdNewLog.Visible = false;
            CmdSave.Visible = false;
            CmdCancle.Visible = false;
            CmdNewLog.Visible = true;
            CmdShowLog.Visible = true;
            DgvLogs.Visible = true;
        }

        private void CmdCancle_Click(object sender, EventArgs e)
        {
            // Elemente ein / ausblenden
            TxtLog.Visible = false;
            CmdCloseLog.Visible = false;
            CmdNewLog.Visible = false;
            CmdSave.Visible = false;
            CmdCancle.Visible = false;
            CmdNewLog.Visible = true;
            CmdShowLog.Visible = true;
            DgvLogs.Visible = true;
        }

        private void DgvLogs_SelectionChanged(object sender, EventArgs e)
        {
            CmdShowLog.Enabled = (DgvLogs.SelectedCells.Count > 0);
        }
    }
}

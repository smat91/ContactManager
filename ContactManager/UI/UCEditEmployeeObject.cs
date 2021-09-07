using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class UCEditEmployeeObject : UserControl
    {
        private Employee employee_ = null;
        public UCEditEmployeeObject()
        {
            InitializeComponent();
        }

        public void SetEmployee(ref Employee employee)
        {
            employee_ = employee;
            SetControllStartValues();
        }

        private void SetControllStartValues()
        {
            if (employee_ != null)
            {
                // Controlls abfüllen
                CmbState.SelectedIndex = CmbState.FindString(employee_.state_);
                CmbSalutation.SelectedIndex = CmbSalutation.FindString(employee_.salutation_);
                TxtTitle.Text = employee_.title_;
                TxtFirstname.Text = employee_.firstname_;
                TxtLastname.Text = employee_.lastname_;
                TxtSex.Text = employee_.sex_;
                TxtFunction.Text = employee_.function_;
                TxtDateOfBirth.Text = employee_.birthday_;
                CmbDepartment.SelectedIndex = CmbDepartment.FindString(employee_.department_);
                TxtInsuranceNumber.Text = employee_.insuranceNumber_;
                TxtCitizenship.Text = employee_.citizenship_;
                TxtEntryDate.Text = employee_.entryDate_;
                TxtSeparationDate.Text = employee_.seperationDate_;
                NumLevelOfEmployment.Value = employee_.levelOfEmployment_;
                NumLevel.Value = employee_.level_;
                TxtStreet.Text = employee_.street_;
                TxtNumber.Text = employee_.number_;
                TxtCity.Text = employee_.city_;
                NumZip.Value = employee_.zip_;
                TxtCountry.Text = employee_.country_;
                TxtPhoneBussines.Text = employee_.phoneBusiness_;
                TxtPhoneMobile.Text = employee_.phoneMob_;
                TxtPhonePrivate.Text = employee_.phonePrivat_;
                TxtEmail.Text = employee_.eMail_;
            }
            else
            {
                return;
            }
        }

        // Werte aus Comboboxen in employee Objekt aktualisieren
        private void ComboBoxIndexChanged(object sender, EventArgs e)
        {
            if (sender == CmbState)
            {
                employee_.state_ = CmbState.SelectedItem.ToString();
            }
            else if (sender == CmbSalutation)
            {
                employee_.salutation_ = CmbSalutation.SelectedItem.ToString();
            }
        }

        // Werte aus NummericUpDown in employee Objekt aktualisieren
        private void NummericUpDownChanged(object sender, EventArgs e)
        {
            if (sender == NumZip)
            {
                employee_.zip_ = (int)NumZip.Value;
            }
            else if (sender == NumLevelOfEmployment)
            {
                employee_.levelOfEmployment_ = (int)NumLevelOfEmployment.Value;
            }
            else if (sender == NumLevel)
            {
                employee_.level_ = (int)NumLevel.Value;
            }

        }


        // Werte aus Textfeldern in employee Objekt aktualisieren
        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (sender == TxtTitle)
            {
                employee_.title_ = TxtTitle.Text;
            }
            else if (sender == TxtFirstname)
            {
                employee_.firstname_ = TxtFirstname.Text;
            }
            else if (sender == TxtLastname)
            {
                employee_.lastname_ = TxtLastname.Text;
            }
            else if (sender == TxtSex)
            {
                employee_.sex_ = TxtSex.Text;
            }
            else if (sender == TxtFunction)
            {
                employee_.function_ = TxtFunction.Text;
            }
            else if (sender == TxtDateOfBirth)
            {
                employee_.birthday_ = TxtDateOfBirth.Text;
            }
            else if (sender == TxtInsuranceNumber)
            {
                employee_.insuranceNumber_ = TxtInsuranceNumber.Text;
            }
            else if (sender == TxtCitizenship)
            {
                employee_.citizenship_ = TxtCitizenship.Text;
            }
            else if (sender == TxtEntryDate)
            {
                employee_.entryDate_ = TxtEntryDate.Text;
            }
            else if (sender == TxtSeparationDate)
            {
                employee_.seperationDate_ = TxtSeparationDate.Text;
            }
            else if (sender == TxtStreet)
            {
                employee_.street_ = TxtStreet.Text;
            }
            else if (sender == TxtNumber)
            {
                employee_.number_ = TxtNumber.Text;
            }
            else if (sender == TxtCity)
            {
                employee_.city_ = TxtCity.Text;
            }
            else if (sender == TxtCountry)
            {
                employee_.country_ = TxtCountry.Text;
            }
            else if (sender == TxtPhoneBussines)
            {
                employee_.phoneBusiness_ = TxtPhoneBussines.Text;
            }
            else if (sender == TxtPhoneMobile)
            {
                employee_.phoneMob_ = TxtPhoneMobile.Text;
            }
            else if (sender == TxtPhonePrivate)
            {
                employee_.phonePrivat_ = TxtPhonePrivate.Text;
            }
            else if (sender == TxtEmail)
            {
                employee_.eMail_ = TxtEmail.Text;
            }
        }
    }
}

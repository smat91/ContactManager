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
    public partial class UCEditTraineeObject : UserControl
    {
        private Trainee trainee_ = null;
        public UCEditTraineeObject()
        {
            InitializeComponent();
        }

        public void SetTrainee(ref Trainee trainee)
        {
            trainee_ = trainee;
            SetControllStartValues();
        }

        private void SetControllStartValues()
        {
            if (trainee_ != null)
            {
                // Controlls abfüllen
                CmbState.SelectedIndex = CmbState.FindString(trainee_.state_);
                CmbSalutation.SelectedIndex = CmbSalutation.FindString(trainee_.salutation_);
                TxtTitle.Text = trainee_.title_;
                TxtFirstname.Text = trainee_.firstname_;
                TxtLastname.Text = trainee_.lastname_;
                TxtSex.Text = trainee_.sex_;
                TxtFunction.Text = trainee_.function_;
                TxtDateOfBirth.Text = trainee_.birthday_;
                TxtDepartment.Text = trainee_.department_;
                TxtInsuranceNumber.Text = trainee_.insuranceNumber_;
                TxtCitizenship.Text = trainee_.citizenship_;
                TxtEntryDate.Text = trainee_.entryDate_;
                NumNumberOfTraineeYears.Value = trainee_.numberOfTraineeYears_;
                TxtSeparationDate.Text = trainee_.seperationDate_;
                NumLevelOfEmployment.Value = trainee_.levelOfEmployment_;
                NumLevel.Value = trainee_.level_;
                TxtStreet.Text = trainee_.street_;
                TxtNumber.Text = trainee_.number_;
                TxtCity.Text = trainee_.city_;
                NumZip.Value = trainee_.zip_;
                TxtCountry.Text = trainee_.country_;
                TxtPhoneBussines.Text = trainee_.phoneBusiness_;
                TxtPhoneMobile.Text = trainee_.phoneMob_;
                TxtPhonePrivate.Text = trainee_.phonePrivat_;
                TxtEmail.Text = trainee_.eMail_;
                NumCurrentTraineeYear.Value = trainee_.currentTraineeYear_;
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
                trainee_.state_ = CmbState.SelectedItem.ToString();
            }
            else if (sender == CmbSalutation)
            {
                trainee_.salutation_ = CmbSalutation.SelectedItem.ToString();
            }
        }

        // Werte aus NummericUpDown in employee Objekt aktualisieren
        private void NummericUpDownChanged(object sender, EventArgs e)
        {
            if (sender == NumZip)
            {
                trainee_.zip_ = (int)NumZip.Value;
            }
            else if (sender == NumLevelOfEmployment)
            {
                trainee_.levelOfEmployment_ = (int)NumLevelOfEmployment.Value;
            }
            else if (sender == NumLevel)
            {
                trainee_.level_ = (int)NumLevel.Value;
            }
            else if (sender == NumNumberOfTraineeYears)
            {
                trainee_.numberOfTraineeYears_ = (int)NumNumberOfTraineeYears.Value;
            }
            else if (sender == NumCurrentTraineeYear)
            {
                trainee_.currentTraineeYear_ = (int)NumCurrentTraineeYear.Value;
            }
        }


        // Werte aus Textfeldern in employee Objekt aktualisieren
        private void TextBoxChanged(object sender, EventArgs e)
        {
            if (sender == TxtTitle)
            {
                trainee_.title_ = TxtTitle.Text;
            }
            else if (sender == TxtFirstname)
            {
                trainee_.firstname_ = TxtFirstname.Text;
            }
            else if (sender == TxtLastname)
            {
                trainee_.lastname_ = TxtLastname.Text;
            }
            else if (sender == TxtSex)
            {
                trainee_.sex_ = TxtSex.Text;
            }
            else if (sender == TxtFunction)
            {
                trainee_.function_ = TxtFunction.Text;
            }
            else if (sender == TxtDateOfBirth)
            {
                trainee_.birthday_ = TxtDateOfBirth.Text;
            }
            else if (sender == TxtDepartment)
            {
                trainee_.department_ = TxtDepartment.Text;
            }
            else if (sender == TxtInsuranceNumber)
            {
                trainee_.insuranceNumber_ = TxtInsuranceNumber.Text;
            }
            else if (sender == TxtCitizenship)
            {
                trainee_.citizenship_ = TxtCitizenship.Text;
            }
            else if (sender == TxtEntryDate)
            {
                trainee_.entryDate_ = TxtEntryDate.Text;
            }
            else if (sender == TxtSeparationDate)
            {
                trainee_.seperationDate_ = TxtSeparationDate.Text;
            }
            else if (sender == TxtStreet)
            {
                trainee_.street_ = TxtStreet.Text;
            }
            else if (sender == TxtNumber)
            {
                trainee_.number_ = TxtNumber.Text;
            }
            else if (sender == TxtCity)
            {
                trainee_.city_ = TxtCity.Text;
            }
            else if (sender == TxtCountry)
            {
                trainee_.country_ = TxtCountry.Text;
            }
            else if (sender == TxtPhoneBussines)
            {
                trainee_.phoneBusiness_ = TxtPhoneBussines.Text;
            }
            else if (sender == TxtPhoneMobile)
            {
                trainee_.phoneMob_ = TxtPhoneMobile.Text;
            }
            else if (sender == TxtPhonePrivate)
            {
                trainee_.phonePrivat_ = TxtPhonePrivate.Text;
            }
            else if (sender == TxtEmail)
            {
                trainee_.eMail_ = TxtEmail.Text;
            }
        }
    }
}

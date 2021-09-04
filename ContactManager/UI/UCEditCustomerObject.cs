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
    public partial class UCEditCustomerObject : UserControl
    {
        private Customer customer_ = null;
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
    }
}

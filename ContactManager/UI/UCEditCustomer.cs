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
    public partial class UCEditCustomer : UserControl
    {
        private Customer customer_ = null;
        public UCEditCustomer()
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
            else {
                return;
            }
        }

        private void CmbState_SelectedIndexChanged(object sender, EventArgs e)
        {
            customer_.state_ = CmbState.SelectedItem.ToString();
        }
    }
}

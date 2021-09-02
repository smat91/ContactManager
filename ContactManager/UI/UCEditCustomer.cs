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
        private Customer customer_;
        public UCEditCustomer()
        {
            InitializeComponent();
        }

        public void SetCustomer(ref Customer customer)
        {
            customer_ = customer;
        }

        private void UCEditCustomer_Load(object sender, EventArgs e)
        {

        }


    }
}

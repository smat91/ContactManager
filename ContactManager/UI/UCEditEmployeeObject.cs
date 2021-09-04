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
        }
    }
}

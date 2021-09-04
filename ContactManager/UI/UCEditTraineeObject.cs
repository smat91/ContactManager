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
        }
    }
}

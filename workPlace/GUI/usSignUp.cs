using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class usSignUp : UserControl
    {
        public usSignUp()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fSignUpInfo fSignUpInfo1 = new fSignUpInfo();
            fSignUpInfo1.Show();
        }
    }
}

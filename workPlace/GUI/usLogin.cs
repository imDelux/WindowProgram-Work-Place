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
    public partial class usLogin : UserControl
    {
        public usLogin()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            fChooseRole fChooseRole1 = new fChooseRole();
            fChooseRole1.ShowDialog();
        }
        private void btnForgotpass_Click(object sender, EventArgs e)
        {

        }
    }
}

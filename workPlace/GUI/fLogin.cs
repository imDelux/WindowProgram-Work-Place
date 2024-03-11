using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace GUI
{
    public partial class fLogin : KryptonForm
    {
        public fLogin()
        {
            InitializeComponent();
            lblLine1.Hide();
            lblLine2.Hide();
        }

        private void kryptonGroup1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            lblLine2.Hide();
            lblLine1.Show();
        }
        private void btnSignup_Click(object sender, EventArgs e)
        {

            lblLine1.Hide();
            lblLine2.Show();
        }
    }
}

using EntityModel;
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
            // Get login data
            Person person = new Person() { Email = txtEmail.Text, Password = txtPassword.Text };

            // Hide login form
            this.TopLevelControl.Hide();

            // Display choose role form
            fChooseRole fChooseRole1 = new fChooseRole(person);
            fChooseRole1.ShowDialog();

            // Show login form
            if (this.TopLevelControl != null)
            {
                this.TopLevelControl.Show();
            }
        }

        private void btnForgotpass_Click(object sender, EventArgs e)
        {

        }
    }
}

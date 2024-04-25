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
    public partial class usSignUp : UserControl
    {
        public usSignUp()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // Get person in form of object
            Person person = new Person("", "", 0, txtPhonenum.Text, txtEmail.Text, "", txtPassword.Text);

            fSignUpInfo fSignUpInfo1 = new fSignUpInfo(person);
            fSignUpInfo1.ShowDialog();
        }
    }
}

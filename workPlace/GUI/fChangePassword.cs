using DAO;
using EntityModel;
using Krypton.Toolkit;
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
    public partial class fChangePassword : KryptonForm
    {
        // Store data
        Person currentChangingPerson = null;
        string table = string.Empty;
        PersonDAO personDAO = new PersonDAO();

        public fChangePassword()
        {
            InitializeComponent();
        }

        public fChangePassword(Person person, string table)
        {
            InitializeComponent();
            this.currentChangingPerson = person;
            this.table = table;
        }

        /// <summary>
        /// Adjust user password when the confirm button is clicked on
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Check valid
            if (txtOldPassword.Text != currentChangingPerson.Password || txtNewPassword.Text != txtRewriteNewPassword.Text)
            {
                MessageBox.Show("Invalid data", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            currentChangingPerson.Password = txtNewPassword.Text;
            if (personDAO.Update(currentChangingPerson, table) == "Successful")
            {
                MessageBox.Show("Change password succesfully", "Notification", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

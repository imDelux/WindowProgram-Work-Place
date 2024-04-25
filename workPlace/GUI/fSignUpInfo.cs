using EntityModel;
using DAO;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fSignUpInfo : KryptonForm
    {
        // Indicate who is sign up
        Person currentPerson;
        PersonDAO personDAO = new PersonDAO();

        public fSignUpInfo()
        {
            InitializeComponent();
        }

        // When a person is transfered
        public fSignUpInfo(Person person)
        {
            InitializeComponent();
            currentPerson = person;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            currentPerson.Name = txtName.Text;
            currentPerson.PersonID = txtPersonID.Text;
            currentPerson.Age = int.Parse(txtAge.Text);
            currentPerson.Location = txtLocation.Text;

            // Try to add person to the database
            string result = personDAO.Add(currentPerson, (rbtnHirer.Checked == true ? "Hirer" : "Worker"));

            // Check result 
            if (result == "Successful")
            {
                MessageBox.Show("Successful", "Notification");
                this.Close();
            }
            else
            {
                // Base on what error return
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}

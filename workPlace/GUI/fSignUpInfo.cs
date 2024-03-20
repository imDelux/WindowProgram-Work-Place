using Data;
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
    public partial class fSignUpInfo : KryptonForm
    {
        // Indicate who is sign up
        Person currentPerson;

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
            currentPerson.Gender = rbtnMale.Checked ? true : false;
            currentPerson.BirthDate = dtpBirth.Value;
            currentPerson.Location = txtLocation.Text;
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        } 
    }
}

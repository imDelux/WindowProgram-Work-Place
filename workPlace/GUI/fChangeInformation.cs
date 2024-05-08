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
    public partial class fChangeInformation : KryptonForm
    {
        //Store data
        Person currentChangingPerson = null;
        string table = string.Empty;
        PersonDAO personDAO = new PersonDAO();


        public fChangeInformation()
        {
            InitializeComponent();
        }

        public fChangeInformation(Person person, string table)
        {
            InitializeComponent();
            this.table = table;
            this.currentChangingPerson = person;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            currentChangingPerson.Name = txtName.Text;
            currentChangingPerson.Age = int.Parse(txtAge.Text);
            currentChangingPerson.Telephone = txtTelephone.Text;
            currentChangingPerson.Email = txtEmail.Text;
            currentChangingPerson.Location = txtLocation.Text;

            if (personDAO.Update(currentChangingPerson, table) == "Successful")
            {
                MessageBox.Show("Change password succesfully", "Notification", MessageBoxButtons.OK);
                this.Close();
            }
        }
    }
}

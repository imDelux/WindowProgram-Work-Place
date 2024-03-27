using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucProfile : UserControl
    {
        // Displaying person
        Person displayingPerson = null;

        public ucProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display information about a specific person
        /// </summary>
        /// <param name="person"></param>
        /// <param name="type">False is worker, True is hirer</param>
        public ucProfile(Person person, bool type)
        {
            InitializeComponent();

            displayingPerson = person;
            if (type == true)
            {
                this.lblUserSkill.Visible = false;
            }
            DataSetter();
        }

        private void DataSetter()
        {
            // Error detect
            if (displayingPerson == null) { return; }

            lblName.Text = displayingPerson.Name;
            lblOverrallRating.Text = "Rate: 7.9/10.0";
            lblBirthDate.Text = "Birth Date: " + displayingPerson.BirthDate.ToShortDateString();
            lblPhone.Text = "Phone: " + displayingPerson.Telephone;
            lblEmail.Text = "Email: " + displayingPerson.Email;
            lblLocation.Text = "Location: " + displayingPerson.Location;
        }

        private void lblUserSkill_Click(object sender, EventArgs e)
        {
            fWorkerSkills fWorkerSkills = new fWorkerSkills(displayingPerson);
            fWorkerSkills.ShowDialog();
        }
    }
}

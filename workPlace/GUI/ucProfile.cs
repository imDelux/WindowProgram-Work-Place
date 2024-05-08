using DAO;
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
using System.IO;

namespace GUI
{
    public partial class ucProfile : UserControl
    {
        // Hirer or Worker will be displayed
        Person displayingPerson = null;
        Worker displayingWorker = null;
        PersonDAO personDAO =  new PersonDAO();
        WorkerDAO workerDAO = new WorkerDAO();
        EvaluateDAO evaluateDAO = new EvaluateDAO();
        DbConnection dbConnection = new DbConnection();

        public ucProfile()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display information about a specific person
        /// </summary>
        /// <param name="person"></param>
        public ucProfile(Person person)
        {
            InitializeComponent();

            displayingPerson = person;
            this.lblSkill.Visible = false;
            this.cbActive.Visible = false;

            DataSetter();
        }

        public ucProfile(Worker worker)
        {
            InitializeComponent();

            displayingWorker = worker;
            displayingPerson = worker;  // in order to use datasetter with var person

            DataSetter();
        }

        private void DataSetter()
        {
            // Error detect
            if (displayingPerson == null && displayingWorker == null) { return; }

            // Display avatar
            if (personDAO.LoadAvatar(displayingPerson) != null)
            {
                picUserAvatar.Image = personDAO.LoadAvatar(displayingPerson);
            }   

            lblName.Text = displayingPerson.Name;
            lblAge.Text = "Age: " + displayingPerson.Age.ToString();
            lblPhone.Text = "Phone: " + displayingPerson.Telephone;
            lblEmail.Text = "Email: " + displayingPerson.Email;
            lblLocation.Text = "Location: " + displayingPerson.Location;

            // In case worker
            if (displayingWorker != null)
            {
                cbActive.Checked = displayingWorker.IsActive == true;
            }

            // Get review of user
            List<Evaluate> evaluatesOfUser;
            if (displayingWorker != null)
            {
                evaluatesOfUser = dbConnection.FetchEvaluateOfAWorker(displayingPerson.PersonID);
            }
            else
            {
                evaluatesOfUser = dbConnection.FetchEvaluateOfAHirer(displayingPerson.PersonID);
            }

            if (evaluatesOfUser.Count > 0)
            {
                lblNoReviewNotification.Visible = false;
                foreach (Evaluate eval in evaluatesOfUser)
                {
                    ucReview fReview = new ucReview(eval);
                    fpnlReviewContainer.Controls.Add(fReview);
                }
            }

            // Average user point 
            lblOverrallRating.Text = string.Format("Rate: {0}/10.0 ({1})", evaluateDAO.AveragePoint(evaluatesOfUser).ToString(), evaluatesOfUser.Count.ToString());
        }

        /// <summary>
        /// Adjust skill
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSkill_Click(object sender, EventArgs e)
        {
            fAddSkill fAddSkill = new fAddSkill(displayingWorker);
            fAddSkill.ShowDialog();
        }

        private void cbActive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to switch active mode?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                cbActive.Checked = !cbActive.Checked;
                return;
            }

            displayingWorker.IsActive = cbActive.Checked;
            if (workerDAO.SwitchActiveMode(displayingWorker) == "Successful")
            {
                MessageBox.Show("Adjust successfully", "Notification");
            }
            else
            {
                MessageBox.Show("Error", "Notification");
            }
        }

        // Upload new avatar
        private void picUserAvatar_Click(object sender, EventArgs e)
        {
            // Error detect
            if (displayingPerson == null && displayingWorker == null) { return; }

            fUploadAvatar fUploadAvatar = new fUploadAvatar(displayingPerson);
            picUserAvatar.Image.Dispose();
            fUploadAvatar.ShowDialog();
        }
    }
}

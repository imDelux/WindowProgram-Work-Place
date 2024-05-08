using DAO;
using EntityModel;
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
    public partial class fWorkerInfo : KryptonForm
    {
        // Store data
        Worker currentWorker = null;
        Person currentHirer = null;
        bool isForHirer;
        DAO.DbConnection connection = new DAO.DbConnection();
        PersonDAO personDAO = new PersonDAO();
        EvaluateDAO evaluateDAO = new EvaluateDAO();

        // Post context
        Post currentAppliedPost;
        JobDAO jobDAO = new JobDAO();
        PostDAO postDAO = new PostDAO();

        public fWorkerInfo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Form works as a worker's information preview
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="hirer"></param>
        public fWorkerInfo(Worker worker, Person hirer)
        {
            InitializeComponent();
            this.currentWorker = worker;
            this.currentHirer = hirer;
            isForHirer = true;

            DataSetter();
        }


        /// <summary>
        /// Form works as a hirer's information preview
        /// </summary>
        /// <param name="hirer"></param>
        public fWorkerInfo(Person hirer)
        {
            InitializeComponent();
            this.currentHirer = hirer;
            isForHirer = false;

            DataSetter();
        }

        /// <summary>
        /// Post context
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="post"></param>
        public fWorkerInfo(Worker worker, Post post)
        {
            InitializeComponent();
            this.currentWorker = worker;
            this.currentAppliedPost = post;
            isForHirer = true;

            DataSetter();
            PostContext();
        }

        private void DataSetter()
        {
            // Error detect
            if (currentWorker == null && currentHirer == null) { return; }

            // Get the avatar first
            if (currentWorker != null && personDAO.LoadAvatar(currentWorker) != null)
            {
                picUserAvatar.Image = personDAO.LoadAvatar(currentWorker);
            }
            else if (currentHirer != null && personDAO.LoadAvatar(currentHirer) != null)
            {
                picUserAvatar.Image = personDAO.LoadAvatar(currentHirer);
            }

            // Check to see who's infor will be displayed
            Person person;
            if (isForHirer)
            {
                person = currentWorker;
            }
            else
            {
                person = currentHirer;
            }

            // Basic information
            lblName.Text = person.Name;
            lblAge.Text = "Age: " + person.Age.ToString();
            lblPhone.Text = "Phone: " + person.Telephone;
            lblEmail.Text = "Email: " + person.Email;
            lblLocation.Text = "Location: " + person.Location;
            
            // Skill
            if (!isForHirer)
            {
                pnlSkillContainer.Visible = false;
                btnHire.Visible = false;
            }
            else
            {
                pnlSkillContainer.Visible = true;
                lblSkillname.Text = currentWorker.SkillName;
                lblSkillDescription.Text = currentWorker.SkillDescription;
            }

            // Review
            // Get review of user
            List<Evaluate> evaluatesOfUser;
            if (isForHirer)
            {
                evaluatesOfUser = connection.FetchEvaluateOfAWorker(currentWorker.PersonID);
            }
            else
            {
                evaluatesOfUser = connection.FetchEvaluateOfAHirer(currentHirer.PersonID);
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

        private void PostContext()
        {
            btnHire.Text = "Accept";
            btnHire.Click -= btnHire_Click;
            btnHire.Click += btnAccept_Click;
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            fJobDisplay fHireMessage = new fJobDisplay(currentWorker, currentHirer);
            fHireMessage.ShowDialog();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Generate job equivalent to post
            Job nJob = new Job();
            nJob.HirerID = currentAppliedPost.HirerID;
            nJob.WorkerID = currentWorker.PersonID;
            nJob.JobName = currentAppliedPost.Title;
            nJob.JobDescription = currentAppliedPost.Description;
            nJob.Date = currentAppliedPost.Date;
            nJob.Wage = currentAppliedPost.Wage;
            nJob.IsMorning = currentAppliedPost.IsMorning;
            nJob.IsAccepted = true;
            nJob.IsRejected = false;
            nJob.IsComplete = false;
            nJob.IsCanceled = false;
            nJob.IsEvaluated = false;
            nJob.IsWorkerRated = false;
            nJob.IsRead = true;

            // Add job
            if (jobDAO.Add(nJob) == "Successful")
            {
                // Delete post 
                postDAO.Delete(currentAppliedPost);

                // Notify
                MessageBox.Show("You hired this worker!", "Notification");
                this.Close();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class fJobDetail : KryptonForm
    {
        // Store current display job
        Job currentDisplayingJob = null;
        JobDAO jobDAO = new JobDAO();
        bool isEvaluate = false;
        bool isWorker = false;

        // Get the hirer name by access to database
        DAO.DbConnection dbConn = new DAO.DbConnection();

        public fJobDetail()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dislay a job in summary
        /// </summary>
        /// <param name="job"></param>
        /// <param name="isEvaluate">To know if the context is for review</param>
        public fJobDetail(Job job, bool isEvaluate, bool isWorker)
        {
            InitializeComponent();
            this.currentDisplayingJob = job;
            this.isEvaluate = isEvaluate;
            this.isWorker = isWorker;
            DataSetter();
        }

        private void DataSetter()
        {
            lblRemainUserName.Text = dbConn.FetchPerson(currentDisplayingJob.HirerID, "Hirer").Name;
            lblJobName.Text = currentDisplayingJob.JobName;
            lblJobDescript.Text = currentDisplayingJob.JobDescription;
            lblJobDate.Text = currentDisplayingJob.Date.ToShortDateString() + (currentDisplayingJob.IsMorning ? " (morning}" : " (afternoon)");
            lblJobWage.Text = currentDisplayingJob.Wage.ToString() + "$";
            cbDone.Checked = currentDisplayingJob.IsComplete;
            cbCancel.Checked = currentDisplayingJob.IsCanceled;

            // If the job is rejected --> display delete button to delete job from view & disable check boxes
            // If the job is completed or cancel --> can not adjust this field anymore
            // If the job is haven't accepted --> the same
            bool enable = !(currentDisplayingJob.IsComplete || currentDisplayingJob.IsCanceled || currentDisplayingJob.IsRejected || !currentDisplayingJob.IsAccepted);
            cbDone.Enabled = enable;
            cbCancel.Enabled = enable;
            btnDelete.Visible = currentDisplayingJob.IsRejected;         

            // If the job is being watched in evaluation context --> hide some redundant information
            if (isEvaluate)
            {
                lblRemainUserName.Visible = false;
                lblHirerNameHeader.Visible = false;
                lblJobStatusHead.Visible = false;
                cbDone.Visible = false;
                cbCancel.Visible = false;
                btnDelete.Visible = false;
                btnRate.Visible = false;

                // Then move the panel up a little bit 
                pnlContainer.Location = new System.Drawing.Point(12, 12);
            }

            // If the job is being watched by worker --> cannot check the cancel checkbox & done checkbox
            cbCancel.Enabled = !isWorker && enable;
            cbDone.Enabled = !isWorker && enable;

            // If the job is being watched by worker & isEvaluated & haven't been evaluated by worker--> give evaluated back by show btnRate
            // But if the job is cancel --> cannot give review
            btnRate.Visible = isWorker && currentDisplayingJob.IsEvaluated && !currentDisplayingJob.IsWorkerRated && !currentDisplayingJob.IsCanceled;
        }

        /// <summary>
        /// Change the job status if the job is done. Or if the job is rejected
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbStatus_Click(object sender, EventArgs e)
        {
            // Ask before change job status
            if (MessageBox.Show("The job is done ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                cbDone.Checked = false;
                return;
            }

            // If the result is YES
            currentDisplayingJob.IsComplete = true;

            // Give a review
            fReview fReview = new fReview(currentDisplayingJob, 
                isWorker ? dbConn.FetchWorker_ID(currentDisplayingJob.WorkerID) : dbConn.FetchPerson(currentDisplayingJob.HirerID, "Hirer"), isWorker);
            fReview.ShowDialog();
            currentDisplayingJob.IsEvaluated = true;

            // Update job status
            jobDAO.Update_Complete(currentDisplayingJob);
            jobDAO.Update_Evaluate(currentDisplayingJob);

            // Notifify
            MessageBox.Show("Thanks for leaving a comment", "Notification");

            this.Close();
        }

        /// <summary>
        /// For hirer to cancel job
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel the job?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                cbCancel.Checked = false;
                return;
            }

            // Set cancel status and notify
            currentDisplayingJob.IsCanceled = true;
            jobDAO.Update_Cancel(currentDisplayingJob);
            MessageBox.Show("Job canceled", "Notification");

            // Ask to review
            if (MessageBox.Show("Do you want to leave a review ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            // Review form
            fReview fReview = new fReview(currentDisplayingJob, dbConn.FetchPerson(currentDisplayingJob.HirerID, "Hirer"), false);
            fReview.ShowDialog();
            currentDisplayingJob.IsEvaluated = true;
            currentDisplayingJob.IsComplete = true;
            jobDAO.Update_Complete(currentDisplayingJob);
            jobDAO.Update_Evaluate(currentDisplayingJob);
            this.Close();
        }

        /// <summary>
        /// For worker to rate hirer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRate_Click(object sender, EventArgs e)
        {
            Person person = isWorker ? dbConn.FetchWorker_ID(currentDisplayingJob.WorkerID) : dbConn.FetchPerson(currentDisplayingJob.HirerID, "Hirer");
            fReview reviewForm = new fReview(currentDisplayingJob, person, true);
            reviewForm.ShowDialog();

            currentDisplayingJob.IsWorkerRated = true;
            jobDAO.Update_WorkerRate(currentDisplayingJob);
            // Notifify
            MessageBox.Show("Thanks for leaving a comment", "Notification");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            currentDisplayingJob.IsComplete = true;
            jobDAO.Update_Complete(currentDisplayingJob);
            // Notifify
            MessageBox.Show("Deleted", "Notification");
            this.Close();
        }
    }
}

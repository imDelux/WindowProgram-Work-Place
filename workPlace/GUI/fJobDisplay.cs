using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using EntityModel;
using Krypton.Toolkit;

namespace GUI
{
    public partial class fJobDisplay : KryptonForm
    { 
        Job job = null;
        Worker worker = null;
        Person hirer = null;
        JobDAO jobDAO = new JobDAO();

        public fJobDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displaying a new form to input a new job. Usually used by hirer
        /// </summary>
        /// <param name="worker">Who is offered</param>
        /// <param name="hirer">Who offers</param>
        public fJobDisplay(Worker worker, Person hirer)
        {
            InitializeComponent();
            this.worker = worker;
            this.hirer = hirer;

            // Add event to add new job to database to button
            btnConfirm.Click += btnHire_Click;

            // Hide first input line in form
            this.lblPerson.Visible = false;
            this.txtPersonName.Visible = false;

            // Hide reject button
            this.btnReject.Visible = false;

            // Move container pannel and header
            this.pnlContainer.Location = new System.Drawing.Point(this.pnlContainer.Location.X, this.pnlContainer.Location.Y - 20);
            this.lblThumbnail.Location = new System.Drawing.Point(this.lblThumbnail.Location.X, 0);
        }

        /// <summary>
        /// Displaying an inputed job
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="hirer"></param>
        /// <param name="job"></param>
        public fJobDisplay(Worker worker, Person hirer, Job job, bool isWorker)
        {
            InitializeComponent();
            
            // Update internal attribute
            this.worker = worker;
            this.hirer = hirer;
            this.job = job;

            // Adjust click event of confirm button
            this.btnConfirm.Click += btnAccept_Click;

            // Set data of job onto form
            DataSetter(isWorker);
        }

        /// <summary>
        /// Set data onto form. Depend on situation, data will be different
        /// </summary>
        /// <param name="isWorker"></param>
        private void DataSetter(bool isWorker)
        {
            txtJobname.Text = job.JobName;
            txtJobDes.Text = job.JobDescription;
            txtWage.Text = job.Wage.ToString() + "$";
            btnDate.Text = job.Date.ToShortDateString();
            if (job.IsMorning)
            {
                rbtnMorning.Checked = true;
            }
            else
            {
                rbtnAfternoon.Checked = true;
            }

            txtPersonName.Enabled = false;
            txtJobname.Enabled = false;
            txtJobDes.Enabled = false;
            txtWage.Enabled = false;
            btnDate.Enabled = false;
            rbtnMorning.Enabled = false;
            rbtnAfternoon.Enabled = false;

            if (isWorker)
            {
                this.btnConfirm.Text = "Accept";
                lblThumbnail.Text = "New Offer";
                lblPerson.Text = "From";
                txtPersonName.Text = hirer.Name;
            }
        }

        // If the using person is worker then confirm button's event will be this
        // In order to accept the job
        private void btnAccept_Click(object sender, EventArgs e)
        {
            // Check valid
            if (this.job == null) { return; }

            // Make sure user want to accept
            if (MessageBox.Show("Are you sure?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Return if result is no
                return;
            }

            // Use accept function in jobDAO to update in database
            jobDAO.Update_Accept(job);
            this.Close();
        }

        // If the using person is hirer then confirm button's event will be this
        // In order to form a new offer to worker
        private void btnHire_Click(object sender, EventArgs e)
        {
            Job newOffer = new Job();
            // Get job information
            newOffer.HirerID = this.hirer.PersonID;
            newOffer.WorkerID = this.worker.PersonID;
            newOffer.JobName = txtJobname.Text;
            newOffer.JobDescription = txtJobDes.Text;
            newOffer.Date = DateTime.Parse(btnDate.Text);
            newOffer.Wage = int.Parse(txtWage.Text);
            if (rbtnMorning.Checked)
            {
                newOffer.IsMorning = true;
            }
            else if (rbtnAfternoon.Checked)
            {
                newOffer.IsMorning = false;
            }
            newOffer.IsAccepted = false;
            newOffer.IsRejected = false;
            newOffer.IsComplete = false;
            newOffer.IsCanceled = false;
            newOffer.IsEvaluated = false;
            newOffer.IsWorkerRated = false;
            newOffer.IsRead = false;

            // Add new job to database
            if (jobDAO.Add(newOffer) == "Successful") 
            {
                MessageBox.Show("Message sent", "Notification");
                this.Close();
            }
            else
            {
                MessageBox.Show("Error, try again later or contact dev.", "Notification");
            }
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Choose job date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDate_Click(object sender, EventArgs e)
        {
            DateTime jobDate = new DateTime();
            fChooseJobDate fChooseDate = new fChooseJobDate(worker, jobDate);
            fChooseDate.ShowDialog();
            btnDate.Text = fChooseJobDate.jobDate.ToShortDateString();
        }

        /// <summary>
        /// Reject the job. Used by worker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnReject_Click(object sender, EventArgs e)
        {
            // Check valid
            if (this.job == null) { return; }

            // Make sure user want to accept
            if (MessageBox.Show("Are you sure?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                // Return if result is no
                return;
            }

            // Use accept function in jobDAO to update in database
            jobDAO.Update_Reject(job);
            this.Close();
        }

        /// <summary>
        /// Click to see the hirer information
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtPersonName_Click(object sender, EventArgs e)
        {
            if (hirer == null) { return; }
            fWorkerInfo fHirerInfor = new fWorkerInfo(hirer);
            fHirerInfor.ShowDialog();
        }
    }
}

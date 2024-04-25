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
        Person worker = null;
        Person hirer = null;
        JobDAO jobDAO = new JobDAO();

        public fJobDisplay()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Displaying a new form to input a new job. Ussually used by hirer
        /// </summary>
        /// <param name="worker">Who is offered</param>
        /// <param name="hirer">Who offers</param>
        public fJobDisplay(Person worker, Person hirer)
        {
            InitializeComponent();
            this.worker = worker;
            this.hirer = hirer;

            // Add event to add new job to database to button
            btnConfirm.Click += btnHire_Click;

            // Hide first input line in form
            this.lblPerson.Visible = false;
            this.txtPersonName.Visible = false;

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
        public fJobDisplay(Person worker, Person hirer, Job job, bool isWorker)
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
            txtWage.Text = job.Wage.ToString();
            dtpDateJob.Value = job.Date;

            txtPersonName.Enabled = false;
            txtJobname.Enabled = false;
            txtJobDes.Enabled = false;
            txtWage.Enabled = false;
            dtpDateJob.Enabled = false;

            if (isWorker)
            {
                this.btnConfirm.Text = "Accept";
                lblThumbnail.Text = "New Offer";
                lblPerson.Text = "From";
                txtPersonName.Text = hirer.Name;
            }
        }

        // If the using person is worker then confirm button's event will be this
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
        private void btnHire_Click(object sender, EventArgs e)
        {
            Job newOffer = new Job();
            // Get job information
            newOffer.HirerID = this.hirer.PersonID;
            newOffer.WorkerID = this.worker.PersonID;
            newOffer.JobName = txtJobname.Text;
            newOffer.JobDescription = txtJobDes.Text;
            newOffer.Date = dtpDateJob.Value;
            newOffer.Wage = int.Parse(txtWage.Text);
            newOffer.IsMorning = true;
            newOffer.IsAccepted = false;
            newOffer.IsRejected = false;
            newOffer.IsComplete = false;
            newOffer.IsEvaluated = false;
            newOffer.IsPaid = false;
            newOffer.IsRead = false;

            // Add new job to database
            jobDAO.Add(newOffer);
            this.Close();
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

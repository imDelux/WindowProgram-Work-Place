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
            this.worker = worker;
            this.hirer = hirer;
            this.job = job;

            DataSetter(isWorker);
        }

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
                lblThumbnail.Text = "New Offer";
                lblPerson.Text = "From";
                txtPersonName.Text = hirer.Name;
            }
        }

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
            newOffer.Accept = false;
            newOffer.JobStatus = false;
            newOffer.PaidStatus = false;

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

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
    public partial class fHireMessage : KryptonForm
    { 
        Person worker = null;
        Person hirer = null;
        JobDAO jobDAO = new JobDAO();

        public fHireMessage()
        {
            InitializeComponent();
        }

        public fHireMessage(Person worker, Person hirer)
        {
            InitializeComponent();
            this.worker = worker;
            this.hirer = hirer;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
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
        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

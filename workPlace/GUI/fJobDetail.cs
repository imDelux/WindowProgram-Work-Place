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

        // Get the hirer name by access to database
        DAO.DbConnection dbConn = new DAO.DbConnection();

        public fJobDetail()
        {
            InitializeComponent();
        }

        public fJobDetail(Job job)
        {
            InitializeComponent();
            this.currentDisplayingJob = job;
            DataSetter();
        }

        private void DataSetter()
        {
            lblHirerName.Text = dbConn.FetchPerson(currentDisplayingJob.HirerID, "Hirer").Name;
            lblJobName.Text = currentDisplayingJob.JobName;
            lblJobDescript.Text = currentDisplayingJob.JobDescription;
            lblJobDate.Text = currentDisplayingJob.Date.ToShortDateString();
            lblJobWage.Text = currentDisplayingJob.Wage.ToString() + "$";
            cbPaid.Checked = (currentDisplayingJob.IsPaid == true ? true : false);
            cbStatus.Checked = (currentDisplayingJob.IsComplete == true ? true : false);
        }
    }
}

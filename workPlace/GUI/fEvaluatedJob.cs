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
    public partial class fEvaluatedJob : KryptonForm
    {
        Job currentDisplayingJob = null;

        // Get the hirer name by access to database
        DAO.DbConnection dbConn = new DAO.DbConnection();

        public fEvaluatedJob()
        {
            InitializeComponent();
        }

        private void DataSetter()
        {
            lblRemainUserName.Text = dbConn.FetchPerson(currentDisplayingJob.HirerID, "Hirer").Name;
            lblJobName.Text = currentDisplayingJob.JobName;
            lblJobDescript.Text = currentDisplayingJob.JobDescription;
            lblJobDate.Text = currentDisplayingJob.Date.ToShortDateString() + (currentDisplayingJob.IsMorning ? " (morning}" : " (afternoon)");
            lblJobWage.Text = currentDisplayingJob.Wage.ToString() + "$";
            lblRate.Text = "@@@@@@@@@@@@@@@@@@@@@";
            lblComment.Text = "###################";
        }
    }
}

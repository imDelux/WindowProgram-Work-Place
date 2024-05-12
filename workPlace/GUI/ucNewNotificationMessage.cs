using DAO;
using EntityModel;
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
    public partial class ucNewNotificationMessage : UserControl
    {
        // Object handle: job or ...
        Job jobInNotification = null;
        Worker currentUsingWorker = null;
        DAO.DbConnection dbConnection = new DAO.DbConnection();
        JobDAO JobDAO = new JobDAO();

        public ucNewNotificationMessage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display new job offer notification
        /// </summary>
        /// <param name="newJob"></param>
        public ucNewNotificationMessage(Worker worker,Job newJob)
        {
            InitializeComponent();
            this.jobInNotification = newJob;
            this.currentUsingWorker = worker;
            ChangeContent();
        }

        public void ChangeContent()
        {
            lblJobName.Text = jobInNotification.JobName;
            lblJobDescription.Text = jobInNotification.JobDescription;
            lblWage.Text = jobInNotification.Wage.ToString() + "$";
            lblDate.Text = jobInNotification.Date.Day.ToString() + "/" + jobInNotification.Date.Month.ToString();
            
            // Black the content's title color if haven't read jet (default)
            // if the content is read --> change into gray
            if (jobInNotification.IsRead)
            {
                this.lblJobName.ForeColor = Color.Gray;
            }
        }

        // Display the job information when click on the notification
        private void ucNewNotificationMessage_Click(object sender, EventArgs e)
        {
            fJobDisplay fJobDisplay = new fJobDisplay(currentUsingWorker, dbConnection.FetchPerson(jobInNotification.HirerID, "hirer"),jobInNotification, true);
            fJobDisplay.ShowDialog();
            // Remark the job message as read by worker
            jobInNotification.IsRead = true;
            JobDAO.Update_Read(jobInNotification);
        }
    }
}

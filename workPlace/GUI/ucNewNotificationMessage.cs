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
        Person currentUsingWorker = null;
        DAO.DbConnection dbConnection = new DAO.DbConnection();

        public ucNewNotificationMessage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Display new job offer notification
        /// </summary>
        /// <param name="newJob"></param>
        public ucNewNotificationMessage(Person worker,Job newJob)
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
            lblWage.Text = jobInNotification.Wage.ToString();
            lblDate.Text = jobInNotification.Date.Day.ToString() + "/" + jobInNotification.Date.Month.ToString();
            
        }

        private void ucNewNotificationMessage_Click(object sender, EventArgs e)
        {
            fJobDisplay fJobDisplay = new fJobDisplay(currentUsingWorker, dbConnection.FetchPerson(jobInNotification.HirerID, "hirer"),jobInNotification, true);
            fJobDisplay.ShowDialog();
        }
    }
}

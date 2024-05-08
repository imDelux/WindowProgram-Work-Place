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
    public partial class ucHiringCard : UserControl
    {
        // Store data
        Worker currentHoldingWorker = null;
        Job currentHoldingJob = null;
        DAO.PersonDAO personDAO = new DAO.PersonDAO();

        public ucHiringCard()
        {
            InitializeComponent();
        }

        public ucHiringCard(Worker worker, Job job)
        {
            InitializeComponent();

            currentHoldingJob = job;
            currentHoldingWorker = worker;
            DataSetter();
        }

        private void DataSetter()
        {
            if (currentHoldingJob == null || currentHoldingWorker == null) { return; }

            // Load worker's avatar
            if (personDAO.LoadAvatar(currentHoldingWorker) != null)
            {
                picAvatar.Image = personDAO.LoadAvatar(currentHoldingWorker);
            }

            // Worker basic information
            lblWorkerName.Text = currentHoldingWorker.Name;
            lblWorkerAge.Text = "Age: " + currentHoldingWorker.Age.ToString();
            lblLocation.Text = currentHoldingWorker.Location;

            // Job information
            lblJobName.Text = currentHoldingJob.JobName;
            lblJobDesciption.Text = currentHoldingJob.JobDescription;
            lblJobDate.Text = currentHoldingJob.Date.ToShortDateString();

            // Job status
            // 1st case: not response yet
            if (!currentHoldingJob.IsAccepted && !currentHoldingJob.IsRejected)
            {
                picJobStatus.Image = Properties.Resources.jobOnWaiting;
            }
            // 2nd case: on going
            else if (currentHoldingJob.IsAccepted &&  !currentHoldingJob.IsComplete) 
            {
                picJobStatus.Image = Properties.Resources.jobOnGoing;
            }
            // 3rd case: reject
            else if (currentHoldingJob.IsRejected)
            {
                picJobStatus.Image = Properties.Resources.jobRejected;
            }
        }

        private void lblJobName_Click(object sender, EventArgs e)
        {
            fJobDetail fJob = new fJobDetail(currentHoldingJob, false, false);
            fJob.ShowDialog();
        }
    }
}

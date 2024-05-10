using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucHiring : UserControl
    {
        // Store data
        Person currentUsingHirer = null;

        // Fetch data
        DAO.DbConnection connection = new DAO.DbConnection();

        public ucHiring()
        {
            InitializeComponent();
        }

        public ucHiring(Person hirer)
        {
            InitializeComponent();

            currentUsingHirer = hirer;
            DataSetter();
        }

        private void DataSetter()
        {
            // Fetch job list of hirer from database
            List<Job> jobOfHirer;
            jobOfHirer = connection.FetchJobList(currentUsingHirer, false);


            // Display job on on going page
            List<Job> onGoingJob = jobOfHirer.Where(x => (!x.IsComplete)).ToList();
            lblNoJobNotificationOnGoing.Visible = onGoingJob.Count == 0;
            foreach (Job job in onGoingJob)
            {
                ucHiringCard ucHiringCard = new ucHiringCard(connection.FetchWorker_ID(job.WorkerID), job);
                fpnlOnGoing.Controls.Add(ucHiringCard);
            }

            // Display job on complete page
            List<Job> completeJob = jobOfHirer.Where(x => (x.IsComplete && !x.IsCanceled && !x.IsRejected)).ToList();
            lblNoJobNotificationComplete.Visible = completeJob.Count == 0;
            foreach (Job job in completeJob)
            {
                ucHiringCard ucHiringCard = new ucHiringCard(connection.FetchWorker_ID(job.WorkerID), job);
                fpnlComplete.Controls.Add(ucHiringCard);
            }

            // Display job on cancel page
            List<Job> cancelJob = jobOfHirer.Where(x => (x.IsCanceled)).ToList();
            lblNoJobNotificationCancel.Visible = cancelJob.Count == 0;
            foreach (Job job in cancelJob)
            {
                ucHiringCard ucHiringCard = new ucHiringCard(connection.FetchWorker_ID(job.WorkerID), job);
                fpnlCancel.Controls.Add(ucHiringCard);
            }

            // Display job on rejected page
            List<Job> rejectedJob = jobOfHirer.Where(x => (x.IsRejected && x.IsComplete)).ToList();
            lblNoRejectedJobNotification.Visible = rejectedJob.Count == 0;
            foreach (Job job in rejectedJob)
            {
                ucHiringCard ucHiringCard = new ucHiringCard(connection.FetchWorker_ID(job.WorkerID), job);
                fpnlRejected.Controls.Add(ucHiringCard);
            }

            // Display favourite worker list
            List<Worker> favouriteWorker = connection.FetchFavouriteWorkerList(currentUsingHirer.PersonID);
            lblNoFavouriteNotification.Visible = favouriteWorker.Count == 0;
            foreach(Worker worker in favouriteWorker)
            {
                ucWorker ucWorker = new ucWorker(worker, currentUsingHirer);
                fpnlFavourite.Controls.Add(ucWorker);
            }
        }
    }
}

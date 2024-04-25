using DAO;
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
    public partial class ucNotification : UserControl
    {
        // Current displaying worker
        Person currentUsingWorker = null;  
        List<Job> jobsOfWorker = new List<Job>();
        DAO.DbConnection dbConn = new DAO.DbConnection();

        public ucNotification()
        {
            InitializeComponent();
        }

        public ucNotification(Person worker)
        {
            InitializeComponent();
            this.currentUsingWorker = worker;
            DataSetter();
        }

        private void DataSetter()
        {
            // Get job list from database
            jobsOfWorker = dbConn.FetchJobList(currentUsingWorker, true);

            // Put notification on flow pannel
            foreach(Job job in jobsOfWorker)
            {
                // Job haven't been accepted 
                if (job.IsAccepted == false)
                {
                    ucNewNotificationMessage newJobOffer = new ucNewNotificationMessage(currentUsingWorker ,job);
                    fpnlNewJobNotificationContainer.Controls.Add(newJobOffer);
                }
            }
        }
    }
}

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
            // Fetch data from database
            List<Job> jobOfHirer;
            jobOfHirer = connection.FetchJobList(currentUsingHirer, false);

            // Filter out haven't done job
            jobOfHirer = jobOfHirer.Where(x => (!x.IsComplete)).ToList();

            // Display each job in flow panel
            lblNoJobNotification.Visible = jobOfHirer.Count == 0;
            foreach(Job job in jobOfHirer)
            {
                ucHiringCard ucHiringCard = new ucHiringCard(connection.FetchWorker_ID(job.WorkerID), job);
                fpnlContainer.Controls.Add(ucHiringCard);
            }
        }
    }
}

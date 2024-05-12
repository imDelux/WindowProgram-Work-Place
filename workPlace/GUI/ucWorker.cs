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
    public partial class ucWorker : UserControl
    {
        // Who is being displayed
        Worker currentDisplayWorker;
        Person currentUsingHirer;
        PersonDAO personDAO = new PersonDAO();

        // Post context
        Post currentPostApplied;

        public ucWorker()
        {
            InitializeComponent();
        }

        public ucWorker(Worker worker, Person hirer)
        {
            InitializeComponent();
            this.currentDisplayWorker = worker;
            this.currentUsingHirer = hirer;
            DataSetter();
        }
        
        // Post context
        public ucWorker(Worker worker, Post post)
        {
            InitializeComponent();
            this.currentDisplayWorker = worker;
            currentPostApplied = post;
            DataSetter();
            PostContext();
        }

        private void DataSetter()
        {
            // Check for invalid case
            if (currentDisplayWorker == null) { return; }

            // Set data
            if (personDAO.LoadAvatar(currentDisplayWorker) != null)
            {
                picAvatar.Image = personDAO.LoadAvatar(currentDisplayWorker);
            }
            lblSkill.Text = currentDisplayWorker.SkillName;
            lblRating.Text = SummarizeData.CalculateAveragePoint(currentDisplayWorker).ToString() + "/10.0";
            lblAvgWage.Text = currentDisplayWorker.ExpectedWage.ToString() + "$";
            lblAge.Text = "Age: " + currentDisplayWorker.Age;
            lblLocation.Text = "Location: " + currentDisplayWorker.Location;
        }

        // Adjust the button events when the using context is POST (worker apply for job)
        private void PostContext()
        {
            picAvatar.Click -= picAvatar_Click;
            picAvatar.Click += picAvatar_Click_PostContext;
        }

        // Display the worker information

        private void picAvatar_Click(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo(currentDisplayWorker, currentUsingHirer);
            fWorkerInfo.ShowDialog();
        }

        private void picAvatar_Click_PostContext(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo(currentDisplayWorker, currentPostApplied);
            fWorkerInfo.ShowDialog();
        }
    }
}

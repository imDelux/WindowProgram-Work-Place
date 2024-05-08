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
            lblAvgWage.Text = currentDisplayWorker.ExpectedWage.ToString() + "$";
            lblAge.Text = "Age: " + currentDisplayWorker.Age;
            lblLocation.Text = "Location: " + currentDisplayWorker.Location;
        }

        private void picAvatar_Click(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo(currentDisplayWorker, currentUsingHirer);
            fWorkerInfo.ShowDialog();
        }
    }
}

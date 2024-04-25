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
    public partial class fWorkerInfo : KryptonForm
    {
        // Current worker
        Person currentDisplayingWorker = null;
        Person currentUsingHirer = null;
        DbConnection connection = new DbConnection();

        public fWorkerInfo()
        {
            InitializeComponent();
        }

        public fWorkerInfo(Person worker, Person hirer)
        {
            InitializeComponent();
            this.currentDisplayingWorker = worker;
            this.currentUsingHirer = hirer;
            DataSetter();
        }

        private void DataSetter()
        {
            // Error detect
            if (currentDisplayingWorker == null) { return; }

            // Worker basic information
            lblName.Text = currentDisplayingWorker.Name;
            lblAge.Text = currentDisplayingWorker.Age.ToString();
            lblPhone.Text = currentDisplayingWorker.Telephone;
            lblEmail.Text = currentDisplayingWorker.Email;
            lblLocation.Text = currentDisplayingWorker.Location;
            
            // Skill
        }

        private void btnHire_Click(object sender, EventArgs e)
        {
            fJobDisplay fHireMessage = new fJobDisplay(currentDisplayingWorker, currentUsingHirer);
            fHireMessage.ShowDialog();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

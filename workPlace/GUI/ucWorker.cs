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
        Person currentDisplayWorker;
        Person currentUsingHirer;

        public ucWorker()
        {
            InitializeComponent();
        }

        public ucWorker(Person worker, Person hirer)
        {
            InitializeComponent();
            this.currentDisplayWorker = worker;
            this.currentUsingHirer = hirer;
            DataSetter();
        }

        private void lblWokerName_Click(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo(currentDisplayWorker, currentUsingHirer);
            fWorkerInfo.ShowDialog();
        }

        private void DataSetter()
        {
            // Check for invalid case
            if (currentDisplayWorker == null) { return; }
            
            // Set data
            lblWokerName.Text = currentDisplayWorker.Name;
            lblAge.Text = "Age: " + currentDisplayWorker.Age;
            lblLocation.Text = "Location: " + currentDisplayWorker.Location;
        }
    }
}

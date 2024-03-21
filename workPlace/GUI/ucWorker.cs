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
        public ucWorker()
        {
            InitializeComponent();
        }

        private void lblWokerName_Click(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo();
            fWorkerInfo.DataSetter(currentDisplayWorker);
            fWorkerInfo.ShowDialog();
        }

        public void DataSetter(Worker worker)
        {
            // Check for invalid case
            if (worker == null) { return; }

            // Set current displaying worker
            currentDisplayWorker = worker;
            
            // Set data
            lblWokerName.Text = worker.Name;
            lblAge.Text = "Age: " + (DateTime.Now.Year - worker.BirthDate.Year).ToString();
            lblLocation.Text = "Location: " + worker.Location;
        }
    }
}

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

        public ucWorker()
        {
            InitializeComponent();
        }

        public ucWorker(Person worker)
        {
            InitializeComponent();
            this.currentDisplayWorker = worker;
            DataSetter();
        }

        private void lblWokerName_Click(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo(currentDisplayWorker);
            fWorkerInfo.ShowDialog();
        }

        private void DataSetter()
        {
            // Check for invalid case
            if (currentDisplayWorker == null) { return; }
            
            // Set data
            lblWokerName.Text = currentDisplayWorker.Name;
            lblAge.Text = "Age: " + (DateTime.Now.Year - currentDisplayWorker.BirthDate.Year).ToString();
            lblLocation.Text = "Location: " + currentDisplayWorker.Location;
        }
    }
}

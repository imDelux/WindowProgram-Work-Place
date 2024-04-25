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
    public partial class ucEvent : UserControl
    {
        Job currentJobHold = null;

        public ucEvent()
        {
            InitializeComponent();
        }

        public ucEvent(Job jobEvent)
        {
            InitializeComponent();
            this.currentJobHold = jobEvent;

            if (jobEvent.Date.Day == DateTime.Now.Day || jobEvent.Date.Day == DateTime.Now.Day + 1)  
            {
                Incoming();
            }

            if (jobEvent.IsEvaluated)
            {
                Evaluated();
            }
        }

        private void ucEvent_Click(object sender, EventArgs e)
        {
            fJobDetail fJobDetail = new fJobDetail(currentJobHold);
            fJobDetail.ShowDialog();
        }

        public void Evaluated()
        {
            this.BackColor = Color.Yellow;
        }

        public void Incoming()
        {
            this.BackColor = Color.Red;
        }
    }
}

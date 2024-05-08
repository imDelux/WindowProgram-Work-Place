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

        public ucEvent(Job jobEvent, bool isHirer)
        {
            InitializeComponent();
            this.currentJobHold = jobEvent;

            if (isHirer)
            {
                // keep color
                this.Click -= ucEvent_Click;
            }
            else  // not hirer --> for worker
            {
                if (jobEvent.Date.Day == DateTime.Now.Day || jobEvent.Date.Day == DateTime.Now.Day + 1)
                {
                    Incoming();
                }
                if (jobEvent.IsComplete)
                {
                    Done();
                }
                if (jobEvent.IsEvaluated && !jobEvent.IsCanceled)
                {
                    Evaluated();
                }
                if (jobEvent.IsComplete && jobEvent.IsCanceled)
                {
                    Cancel();
                }
            }
        }

        private void ucEvent_Click(object sender, EventArgs e)
        {
            fJobDetail fJobDetail = new fJobDetail(currentJobHold, false, true);
            fJobDetail.ShowDialog();
        }

        private void Evaluated()
        {
            this.BackColor = Color.Yellow;
        }

        private void Incoming()
        {
            this.BackColor = Color.Orange;
        }

        private void Done()
        {
            this.BackColor = Color.LightGreen;
        }

        private void Cancel()
        {
            this.BackColor = Color.Red;
        }
    }
}

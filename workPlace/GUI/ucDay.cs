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
    public partial class ucDay : UserControl
    {
        DateTime holdingDay = DateTime.MinValue;
        bool isHirer = false; // indicate this schedule for hirer or worker

        public ucDay(DateTime holdingDay, bool isHirer)
        {
            InitializeComponent();
            this.holdingDay = holdingDay;
            this.isHirer = isHirer;
        }

        // Clear all control to enter blank mode
        public void Blank()
        {
            this.Controls.Clear();
        }

        // Change day number on label
        public void Day(int day)
        {
            btnContainer.Text = day.ToString();
            // Adjust holding day of uc
            holdingDay = holdingDay.AddDays(-holdingDay.Day + day);

            // Add click event for ucDAY if current user is hirer
            if (isHirer)
            {
                this.btnContainer.Click += btnContainer_Click;
            }
        }

        // Highlight day
        public void Highlight()
        {
            this.BackColor = Color.MediumPurple ;
        }

        // Add an event onto a day in schedule
        // Event display will be different if user is hirer
        public void AddEvent(Job job, bool forHirer)
        {
            ucEvent ucEvent = new ucEvent(job, forHirer);
            if (job.IsMorning)
            {
                fpnlEventContainerMorning.Controls.Add(ucEvent);
            }
            else
            {
                fpnlEventContainerNight.Controls.Add(ucEvent);
            }
        }

        private void btnContainer_Click(object sender, EventArgs e)
        {
            fChooseJobDate.jobDate = this.holdingDay;
            ((Form)this.TopLevelControl).Close();
        }
    }
}

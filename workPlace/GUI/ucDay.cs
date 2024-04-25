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
        public ucDay()
        {
            InitializeComponent();
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
        }

        // Highlight day
        public void Highlight()
        {

        }

        // Add an event onto a day in schedule
        public void AddEvent(Job job)
        {
            ucEvent ucEvent = new ucEvent(job);
            fpnlEventContainerMorning.Controls.Add(ucEvent);
        }
    }
}

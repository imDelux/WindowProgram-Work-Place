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
            lblDay.Text = day.ToString();
        }
    }
}

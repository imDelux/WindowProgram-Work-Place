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
    public partial class fChooseJobDate : KryptonForm
    {
        static public DateTime jobDate = DateTime.Now;
        public fChooseJobDate(Worker worker, DateTime dateJob)
        {
            InitializeComponent();
            ucSchedule ucScheduleOfWorker = new ucSchedule(worker, true);
            ucScheduleOfWorker.Dock = DockStyle.Fill;
            this.Controls.Add(ucScheduleOfWorker);
        }
    }
}

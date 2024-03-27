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
    public partial class ucNotification : UserControl
    {
        // Current displaying worker
        Person currentWorker = null;

        public ucNotification()
        {
            InitializeComponent();
        }

        public ucNotification(Person worker)
        {
            InitializeComponent();
            this.currentWorker = worker;
        }
    }
}

using Data;
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
    public partial class fWorkerInfo : KryptonForm
    {
        public fWorkerInfo()
        {
            InitializeComponent();
        }

        private void fWorkerInfo_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                ucSkill skill = new ucSkill();
                fpnlSkills.Controls.Add(skill);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void DataSetter(Worker worker)
        {
            ucBasicInfoWorker.DataSetter(worker);
        }
    }
}

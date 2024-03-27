using EntityModel;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fWorkerSkills : KryptonForm
    {        
        public fWorkerSkills()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            // New skill will be stored here
            Skill newSkill = new Skill();

            fAddSkill fAddSkill = new fAddSkill(newSkill);
            fAddSkill.ShowDialog();
        }
    }
}

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
    public partial class fAddSkill : KryptonForm
    {
        // Current adding skill
        Skill skill;

        public fAddSkill()
        {
            InitializeComponent();
        }

        public fAddSkill(Skill newSkill)
        {
            InitializeComponent();
            cbSkillName.DataSource = Enum.GetValues(typeof(SkillName));
            skill = newSkill;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            skill.SkillName = (SkillName)cbSkillName.SelectedItem;
            skill.ExpectedWage = int.Parse(txtExpectedWage.Text);
            skill.SkillDescription = txtSkillDescription.Text;
        }
    }
}

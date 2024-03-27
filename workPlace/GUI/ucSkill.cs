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
    public partial class ucSkill : UserControl
    {
        // Current displaying skill
        Skill currentSkill;

        public ucSkill()
        {
            InitializeComponent();
        }

        public ucSkill(Skill skill)
        {
            InitializeComponent();
            this.currentSkill = skill;
            DataSetter();
        }

        private void DataSetter()
        {
            btnSkillNameContainer.Text = currentSkill.SkillName.ToString();
            btnSkillDescribeContainer.Text = currentSkill.SkillDescription.ToString();
            lblExpectedWage.Text = "Expected Wage: " + currentSkill.ExpectedWage.ToString() + "$";
        }
    }
}

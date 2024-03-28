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
        bool editable;

        public ucSkill()
        {
            InitializeComponent();
        }

        public ucSkill(Skill skill, bool editable)
        {
            InitializeComponent();
            this.currentSkill = skill;
            this.editable = editable;
            DataSetter();
        }

        private void DataSetter()
        {
            // Error detect
            if (currentSkill ==  null) { return; }

            // Hide edit button in case can't edit
            if (!editable) { picEdit.Visible = false; }

            // Set data
            btnSkillNameContainer.Text = currentSkill.SkillName.ToString();
            btnSkillDescribeContainer.Text = currentSkill.SkillDescription.ToString();
            lblExpectedWage.Text = "Expected Wage: " + currentSkill.ExpectedWage.ToString() + "$";
        }
    }
}

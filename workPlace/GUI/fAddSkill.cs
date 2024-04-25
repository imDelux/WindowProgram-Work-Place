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
        DAO.DbConnection dbConnection = new DAO.DbConnection();
        List<CategorySkill> catList = new List<CategorySkill>();

        public fAddSkill()
        {
            InitializeComponent();
        }

        public fAddSkill(Skill newSkill)
        {
            InitializeComponent();

            skill = newSkill;
            catList = dbConnection.FetchSkillCategory();
            dbConnection.FillSkill(catList);

            cbbSkillCategory.DataSource = catList;
            cbbSkillCategory.DisplayMember = "CategoryName";
            ChangeSkillData();
        }

        private void ChangeSkillData()
        {
            cbbSkillName.DataSource = ((CategorySkill)cbbSkillCategory.SelectedItem).SkillList;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            skill.SkillCategory = ((CategorySkill)cbbSkillCategory.SelectedValue).CategoryName;
            skill.SkillName = cbbSkillName.SelectedValue.ToString();
            skill.ExpectedWage = int.Parse(txtExpectedWage.Text);
            skill.SkillDescription = txtSkillDescription.Text;

            this.DialogResult = DialogResult.OK;
        }

        private void cbbSkillCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            ChangeSkillData();
        }
    }
}

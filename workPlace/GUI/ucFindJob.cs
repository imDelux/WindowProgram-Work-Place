using DAO;
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
    public partial class ucFindJob : UserControl
    {
        // Store
        Worker currentUsingWorker = null;
        DbConnection dbConnection = new DbConnection();
        CategorySkill currentPost = null;
        List<CategorySkill> skillList = null;
        List<Post> postOfCategory = null;

        public ucFindJob()
        {
            InitializeComponent();
        }

        public ucFindJob(Worker worker)
        {
            InitializeComponent();
            this.currentUsingWorker = worker;

            GetCategorySkill();
            SetCategorySkill();
            cbbSkillField.SelectedIndex = 0;
            GetPostOfCat(currentPost);
            SetPost();
        }

        private void GetCategorySkill()
        {
            skillList = dbConnection.FetchSkillCategory();
        }

        private void SetCategorySkill()
        {
            cbbSkillField.DataSource = skillList;
            cbbSkillField.DisplayMember = "Type";
            cbbSkillField.SelectedIndexChanged += cbbSkillField_SelectedIndexChanged;
            currentPost = (CategorySkill)cbbSkillField.SelectedItem;
        }

        private void GetPostOfCat(CategorySkill category)
        {
            postOfCategory = dbConnection.FetchPostOfACategory(category);
        }

        private void SetPost()
        {
            fpnlPostContainer.Controls.Clear();
            lblSkillFieldHeader.Text = currentPost.Type;
            foreach (Post post in postOfCategory)
            {
                ucJobCard ucJobCard = new ucJobCard(currentUsingWorker, post, false);
                fpnlPostContainer.Controls.Add(ucJobCard);
            }
            // If have post then hide the label notification
            lblNoPostNotification.Visible = (postOfCategory.Count == 0);
        }

        private void cbbSkillField_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPost = ((CategorySkill)cbbSkillField.SelectedItem);
            GetPostOfCat(currentPost);
            SetPost();
        }
    }
}

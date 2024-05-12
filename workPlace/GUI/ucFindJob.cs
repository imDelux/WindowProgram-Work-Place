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
        // Store data
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

            // Get and the skill category 
            GetCategorySkill();
            SetCategorySkill();
            // Set the 1st post preview
            cbbSkillField.SelectedIndex = 0;
            // Set posts
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

        /// <summary>
        /// Get posts equivalent to the category
        /// </summary>
        /// <param name="category"></param>
        private void GetPostOfCat(CategorySkill category)
        {
            postOfCategory = dbConnection.FetchPostOfACategory(category);
        }

        /// <summary>
        /// Set posts onto form
        /// </summary>
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

        // Refresh the page based on worker's choice
        private void cbbSkillField_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentPost = ((CategorySkill)cbbSkillField.SelectedItem);
            GetPostOfCat(currentPost);
            SetPost();
        }
    }
}

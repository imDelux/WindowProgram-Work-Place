using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Windows.Forms;
using DAO;
using EntityModel;
using Krypton.Toolkit;

namespace GUI
{
    public partial class fPostJob : KryptonForm
    {
        // Store data
        Person currentUser;
        Post currentPost;            // if it does have
        List<CategorySkill> skillList;
        PostDAO postDAO = new PostDAO();
        DAO.DbConnection dbConnection = new DAO.DbConnection();

        public fPostJob()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Dislay form for the hirer to post a new job request
        /// </summary>
        /// <param name="hirer"></param>
        public fPostJob(Person hirer)
        {
            InitializeComponent();
            this.currentUser = hirer;
            HirerSetting();
        }

        /// <summary>
        /// Display the inputed post information for the worker
        /// </summary>
        /// <param name="worker"></param>
        /// <param name="post"></param>
        public fPostJob(Worker worker, Post post)
        {
            InitializeComponent();
            this.currentUser = worker;
            this.currentPost = post;
            WorkerSetting();
        }

        private void WorkerSetting()
        {
            PostDataSetter();
        }

        /// <summary>
        /// Set data onto form
        /// </summary>
        private void PostDataSetter()
        {
            // Fill data
            txtJobTilte.Text = currentPost.Title;
            txtJobDescription.Text = currentPost.Description;
            txtWage.Text = currentPost.Wage.ToString();
            dtpJobDate.Value = currentPost.Date;
            cbbSkillField.Items.Add(currentPost.SkillType);
            cbbSkillField.SelectedIndex = 0;
            rbtnMorning.Checked = currentPost.IsMorning;
            rbtnNight.Checked = !currentPost.IsMorning;

            // Unable
            txtJobTilte.Enabled = false;
            txtJobDescription.Enabled = false;
            txtWage.Enabled = false;
            dtpJobDate.Enabled = false;
            cbbSkillField.Enabled = false;
            rbtnMorning.Enabled = false;
            rbtnNight.Enabled = false;

            // Change click event
            btnNext.Click += btnApply_Click;
        }

        /// <summary>
        /// Setting for hirer
        /// </summary>
        private void HirerSetting()
        {
            // Get the category list
            GetCategorySkill();
            // Set up the category list
            SkillFieldSet();
            // Set confirm button event
            btnNext.Click += btnNext_Click;
        }

        // Get category fields from database
        private void GetCategorySkill()
        {
            skillList = dbConnection.FetchSkillCategory();
        }

        // Bind the category field into combo box
        private void SkillFieldSet()
        {
            cbbSkillField.DataSource = skillList;
            cbbSkillField.DisplayMember = "Type";
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Event button for hirer --> post the job request
        private void btnNext_Click(object sender, EventArgs e)
        {
            Post nPost = new Post();

            nPost.HirerID = currentUser.PersonID;
            nPost.Title = txtJobTilte.Text;
            nPost.Description = txtJobDescription.Text;
            nPost.Date = dtpJobDate.Value;
            nPost.IsMorning = rbtnMorning.Checked;
            nPost.SkillType = ((CategorySkill)cbbSkillField.SelectedItem).Type;
            nPost.Wage = int.Parse(txtWage.Text);

            postDAO.Add(nPost);
            MessageBox.Show("Successfully", "Notification");
            this.Close();
        }

        // Event button for workre --> apply job
        private void btnApply_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to apply this job ?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            postDAO.Apply(currentPost, currentUser.ToWorker());
            MessageBox.Show("Applied", "Notification", MessageBoxButtons.YesNo);
            this.Close();
        }

        // Display profile of hirer
        private void ptbAvatar_Click(object sender, EventArgs e)
        {
            if (currentPost == null) { return; }
            fWorkerInfo fHirerInfo = new fWorkerInfo(dbConnection.FetchPerson(currentPost.HirerID, "Hirer"));
            fHirerInfo.ShowDialog();

        }
    }
}

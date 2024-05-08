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

        public fPostJob(Person hirer)
        {
            InitializeComponent();
            this.currentUser = hirer;
            HirerSetting();
        }

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

        private void HirerSetting()
        {
            GetCategorySkill();
            SkillFieldSet();
            btnNext.Click += btnNext_Click;
        }

        private void GetCategorySkill()
        {
            skillList = dbConnection.FetchSkillCategory();
        }

        private void SkillFieldSet()
        {
            cbbSkillField.DataSource = skillList;
            cbbSkillField.DisplayMember = "Type";
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

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

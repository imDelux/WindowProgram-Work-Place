using DAO;
using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucJobCard : UserControl
    {
        // Store 
        Person currentUser = null;
        Post currentPost = null;
        bool isHirer = false;
        List<Worker> appliedWorkers = new List<Worker>();
        DbConnection dbConnection = new DbConnection();

        public ucJobCard()
        {
            InitializeComponent();
        }

        public ucJobCard(Person currentUser, Post post, bool isHirer)
        {
            InitializeComponent();
            this.currentUser = currentUser;
            this.currentPost = post;
            this.isHirer = isHirer;

            GetApplyList();
            SetData();
        }

        private void GetApplyList()
        {
            appliedWorkers = dbConnection.FetchApplyWorker(currentPost.ID);
        }

        private void SetData()
        {
            if (currentPost == null) return;

            lblJobName.Text = currentPost.Title;
            lblJobDate.Text = currentPost.Date.ToShortDateString();
            lblJobDescription.Text = currentPost.Description;
            lblSkillField.Text = "Required Skill: " + currentPost.SkillType;
            lblJobWage.Text = currentPost.Wage.ToString() + "$";   
            lblAppliedNumber.Text = "Applied: " + appliedWorkers.Count.ToString();

            if (isHirer)
            {
                lblJobName.Click += picApplyListView_Click;
                picDemo.Click += picApplyListView_Click;    
            }
            else
            {
                lblJobName.Click += picJobDetail_Click;
                picDemo.Click += picJobDetail_Click;
            }
        }

        /// <summary>
        /// For hirer when click into job
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picApplyListView_Click(object sender, EventArgs e)
        {
            fPostApplyView fPostApplyView = new fPostApplyView(currentPost, appliedWorkers);
            fPostApplyView.ShowDialog();
        }

        /// <summary>
        /// For worker when click into job
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void picJobDetail_Click(object sender, EventArgs e)
        {
            fPostJob fPostJob = new fPostJob(currentUser.ToWorker(), currentPost);
            fPostJob.ShowDialog();
        }
    }
}

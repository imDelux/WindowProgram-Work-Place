using DAO;
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
    public partial class fPostApplyView : KryptonForm
    {
        Post currentDisplayingPost = null;
        List<Worker> appliedWorkerList = null;  
        PostDAO postDAO = new PostDAO();
        DbConnection dbConnection = new DbConnection();

        public fPostApplyView()
        {
            InitializeComponent();
        }

        public fPostApplyView(Post post, List<Worker> appliedWorker)
        {
            InitializeComponent();
            this.currentDisplayingPost = post;
            this.appliedWorkerList = appliedWorker;

            DataSetter();
        }

        private void DataSetter()
        {
            // Post information
            txtJobTilte.Text = currentDisplayingPost.Title;
            txtJobDescription.Text = currentDisplayingPost.Description;
            txtJobDate.Text = currentDisplayingPost.Date.ToShortDateString();
            txtSkillRequired.Text = currentDisplayingPost.SkillType;
            txtWage.Text = currentDisplayingPost.Wage.ToString();
            rbtnMorning.Checked = currentDisplayingPost.IsMorning;
            rbtnNight.Checked = !currentDisplayingPost.IsMorning;

            // Unable post information
            txtJobTilte.Enabled = false;
            txtJobDescription.Enabled = false;
            txtJobDate.Enabled = false;
            txtSkillRequired.Enabled = false;
            txtWage.Enabled = false;
            rbtnMorning.Enabled = false;
            rbtnNight.Enabled = false;

            // Display apply worker
            lblApplyHeader.Text = "Applied: " + appliedWorkerList.Count.ToString();
            fpnlWorkerList.Controls.Clear();
            if (appliedWorkerList.Count > 0 ) 
            {
                lblNoApllied.Visible = false;
            }
            foreach(Worker worker in  appliedWorkerList)
            {
                ucWorker ucWorker = new ucWorker(worker, dbConnection.FetchPerson(currentDisplayingPost.HirerID, "Hirer"));
                fpnlWorkerList.Controls.Add(ucWorker);
            }
        }

        private void btnDeletePost_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Notification", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }
            postDAO.Delete(currentDisplayingPost);
            this.Close();
        }
    }
}

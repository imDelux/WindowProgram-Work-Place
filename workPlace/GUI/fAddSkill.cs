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
    public partial class fAddSkill : KryptonForm
    {
        // Current data
        Worker currentUsingWorker = null;
        List<CategorySkill> catList = new List<CategorySkill>();
        WorkerDAO WorkerDAO = new WorkerDAO();
        DAO.DbConnection dbConnection = new DAO.DbConnection();

        public fAddSkill()
        {
            InitializeComponent();
        }

        public fAddSkill(Worker worker)
        {
            InitializeComponent();
            currentUsingWorker = worker;

            GetCategorySkill();
            DataSetter();
        }

        private void GetCategorySkill()
        {
            catList = dbConnection.FetchSkillCategory();
        }

        /// <summary>
        /// Set data onto form
        /// </summary>
        private void DataSetter()
        {
            if (currentUsingWorker != null)
            {
                cbbSkillCategory.DataSource = catList;
                cbbSkillCategory.DisplayMember = "Type";

                // Get index of skill type
                int index = 0;
                for (int i = 0; i < catList.Count; ++i)
                {
                    if(currentUsingWorker.SkillType == catList[i].Id)
                    {
                        index = i;
                        break;
                    }
                }

                // Display data
                cbbSkillCategory.SelectedIndex = index;
                txtSkillName.Text = currentUsingWorker.SkillName;
                txtSkillDescription.Text = currentUsingWorker.SkillDescription;
                txtExpectedWage.Text = currentUsingWorker.ExpectedWage.ToString();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Adjust worker's skill if user click on confirm button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Get data
            currentUsingWorker.SkillName = txtSkillName.Text;
            currentUsingWorker.SkillDescription = txtSkillDescription.Text;
            currentUsingWorker.SkillType = ((CategorySkill)cbbSkillCategory.SelectedItem).Id;
            currentUsingWorker.ExpectedWage = int.Parse(txtExpectedWage.Text);

            if (WorkerDAO.UpdateSkill(currentUsingWorker) == "Successful")
            {
                MessageBox.Show("Adjust successfully", "Notification");
            }
            else
            {
                MessageBox.Show("Error", "Notification");
            }
        }
    }
}

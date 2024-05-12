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
    public partial class ucHomeCategoryChoose : UserControl
    {
        List<CategorySkill> categorySkills = new List<CategorySkill>();
        DAO.DbConnection dbConnection = new DAO.DbConnection();
        Person currentUsingHirer = null;

        public ucHomeCategoryChoose(Person hirer)
        {
            InitializeComponent();
            currentUsingHirer = hirer;

            DataSetter();
            SetCategoryCardEvent();
        }
        
        private void DataSetter()
        {
            categorySkills = dbConnection.FetchSkillCategory();
            foreach(CategorySkill cat in categorySkills)
            {
                ucCategoryCard uc = new ucCategoryCard();
                uc.DataSetter(cat);
                fpnlCategoryContainer.Controls.Add(uc);
            }
        }

        private void SetCategoryCardEvent()
        {
            foreach (ucCategoryCard uc in fpnlCategoryContainer.Controls)
            {
                uc.btnGoto.Click += ucCategoryCard_Click;
            }
        }

        /// <summary>
        /// Go to main form of a specific skill category
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucCategoryCard_Click(object sender, EventArgs e)
        {
            KryptonButton btn = sender as KryptonButton;
            ucCategoryCard ucCategoryCard = btn.Parent as ucCategoryCard;
            if (ucCategoryCard != null)
            {
                ucHomeSpecificCategory ucHomeSpecificCategory = new ucHomeSpecificCategory(currentUsingHirer, ucCategoryCard.currentDisplayingCategory);
                this.Controls.Clear();
                ucHomeSpecificCategory.Dock = DockStyle.Fill;
                this.Controls.Add(ucHomeSpecificCategory);
            }
        }
    }
}

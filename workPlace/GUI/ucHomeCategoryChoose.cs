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
    public partial class ucHomeCategoryChoose : UserControl
    {
        List<CategorySkill> categorySkills = new List<CategorySkill>();
        DAO.DbConnection dbConnection = new DAO.DbConnection();

        public ucHomeCategoryChoose()
        {
            InitializeComponent();

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
                uc.Click += ucCategoryCard_Click;
                foreach(Control control in uc.Controls)
                {
                    if (control != null)
                    {
                        control.Click += ucCategoryCard_Click;
                    }
                }
            }
        }

        private void ucCategoryCard_Click(object sender, EventArgs e)
        {
            ucHomeSpecificCategory ucHomeSpecificCategory = new ucHomeSpecificCategory();
            this.Controls.Clear();
            ucHomeSpecificCategory.Dock = DockStyle.Fill;
            this.Controls.Add(ucHomeSpecificCategory);
        }
    }
}

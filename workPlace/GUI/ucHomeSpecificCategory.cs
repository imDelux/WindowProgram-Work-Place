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
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucHomeSpecificCategory : UserControl
    {
        Person currentUsingHirer = null;
        CategorySkill category = null;
        DbConnection dbConn = new DbConnection();

        public ucHomeSpecificCategory()
        {
            InitializeComponent();
        }

        public ucHomeSpecificCategory(Person hirer, CategorySkill category)
        {
            InitializeComponent();
            this.currentUsingHirer = hirer;
            this.category = category;
            this.lblCategory.Text = category.Type.ToString();
            GenerateDynamicUserControl();
        }

        private void GenerateDynamicUserControl()
        {
            fpnlContainer.Controls.Clear();

            // Get the worker list from database
            List<Worker> listWorker = dbConn.FetchWorkerList(category);
            listWorker = listWorker.Where(x => x.IsActive == true).ToList();   

            // Generate user control
            for (int i = 0; i < listWorker.Count; i++) 
            {
                ucWorker workerPreview = new ucWorker(listWorker[i], currentUsingHirer);
                fpnlContainer.Controls.Add(workerPreview);
            }
        }
    }
}

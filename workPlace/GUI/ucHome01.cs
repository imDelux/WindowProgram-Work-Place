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
    public partial class ucHome01 : UserControl
    {
        Person currentUsingHirer = null;
        DbConnection dbConn = new DbConnection();

        public ucHome01()
        {
            InitializeComponent();
        }

        public ucHome01(Person hirer)
        {
            InitializeComponent();
            this.currentUsingHirer = hirer;
            //GenerateDynamicUserControl();
        }

        //private void GenerateDynamicUserControl()
        //{
        //    fpnlContainer.Controls.Clear();

        //    // Get the worker list from database
        //    List<Skill> listCategory = dbConn.FetchSkillList();

        //    // Generate user control
        //    for (int i = 0; i < listCategory.Count; i++)
        //    {
        //        ucWorker workerPreview = new ucWorker(listCategory[i], currentUsingHirer);
        //        fpnlContainer.Controls.Add(workerPreview);
        //    }
        //}
    }
}

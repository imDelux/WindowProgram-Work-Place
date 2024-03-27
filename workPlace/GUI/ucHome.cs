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
    public partial class ucHome : UserControl
    {
        DbConnection dbConn = new DbConnection();

        public ucHome()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            fpnlContainer.Controls.Clear();

            // Get the worker list from database
            List<Person> listWorker = dbConn.FetchWorkerList();

            // Generate user control
            for (int i = 0; i < listWorker.Count; i++) 
            {
                ucWorker workerPreview = new ucWorker(listWorker[i]);
                fpnlContainer.Controls.Add(workerPreview);
            }
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}

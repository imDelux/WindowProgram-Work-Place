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
    public partial class fReview : KryptonForm
    {
        // Store data
        Job currentEvaluateJob = null;
        Person currentReviewer = null;
        bool isWorker = false;

        // Database access
        EvaluateDAO evaluateDAO = new EvaluateDAO();

        public fReview()
        {
            InitializeComponent();
        }

        public fReview(Job evaluateJob, Person commenter, bool isWorker)
        {
            InitializeComponent();

            this.currentEvaluateJob = evaluateJob;
            this.currentReviewer = commenter;
            this.isWorker = isWorker;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Evaluate newEvaluate = new Evaluate();

            newEvaluate.JobID = currentEvaluateJob.JobID;
            newEvaluate.IsWorker = isWorker;
            newEvaluate.CommenterID = currentReviewer.PersonID;
            newEvaluate.Comment = txtDescription.Text;
            newEvaluate.Point = float.Parse(txtPoint.Text);

            evaluateDAO.Add(newEvaluate);
            this.Close();
        }
    }
}

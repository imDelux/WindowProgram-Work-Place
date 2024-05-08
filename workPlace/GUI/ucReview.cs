using DAO;
using EntityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class ucReview : UserControl
    {
        // Store data
        Evaluate currentDisplayingEvaluate = new Evaluate();
        DAO.DbConnection dbConnection = new DAO.DbConnection();
        PersonDAO personDAO = new PersonDAO();

        public ucReview()
        {
            InitializeComponent();
        }

        public ucReview(Evaluate evaluate)
        {
            InitializeComponent();
            this.currentDisplayingEvaluate = evaluate;
            DataSetter();
        }

        private void DataSetter()
        {
            if (currentDisplayingEvaluate == null) return;

            Person person = dbConnection.FetchPerson(currentDisplayingEvaluate.CommenterID, (currentDisplayingEvaluate.IsWorker ? "Worker" : "Hirer"));
            if (personDAO.LoadAvatar(person) != null)
            {
                picAvatar.Image = personDAO.LoadAvatar(person);
            }

            lblReviewerName.Text = person.Name;
            lblReviewRating.Text = "Rate: " + currentDisplayingEvaluate.Point.ToString() + "/10.0";
            lblComment.Text = currentDisplayingEvaluate.Comment;
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            fJobDetail fJobDetail = new fJobDetail();
            fJobDetail.ShowDialog();
        }
    }
}

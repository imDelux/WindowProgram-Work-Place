using DAO;
using EntityModel;
using GUI.Properties;
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
    public partial class fEvaluatedJob : KryptonForm
    {
        // Store data
        Evaluate currentDisplayingEvaluate = null;

        // Database access
        DAO.DbConnection dbConn = new DAO.DbConnection();
        EvaluateDAO evaluateDAO = new EvaluateDAO(); 

        public fEvaluatedJob()
        {
            InitializeComponent();
        }

        public fEvaluatedJob(Evaluate evaluate)
        {
            InitializeComponent();
            this.currentDisplayingEvaluate = evaluate;
            DataSetter();
        }

        /// <summary>
        /// Set data of the evaluated job onto form
        /// </summary>
        private void DataSetter()
        {
            // Get job from database
            Job currentDisplayingJob = dbConn.FetchJob_ID(currentDisplayingEvaluate.JobID);

            // Load job data onto form
            lblJobName.Text = currentDisplayingJob.JobName;
            lblJobDescript.Text = currentDisplayingJob.JobDescription;
            lblJobDate.Text = currentDisplayingJob.Date.ToShortDateString() + (currentDisplayingJob.IsMorning ? " (morning}" : " (afternoon)");
            lblJobWage.Text = currentDisplayingJob.Wage.ToString() + "$";

            // Load evaluate data
            lblRate.Text = currentDisplayingEvaluate.Point.ToString() + "/10.0";
            lblComment.Text = currentDisplayingEvaluate.Comment;

            // Load image of evaluate
            ImageSetter();
        }

        /// <summary>
        /// Set images of the review onto form
        /// </summary>
        private void ImageSetter()
        {
            List<Image> reviewImages = evaluateDAO.GetReviewImages(currentDisplayingEvaluate.JobID);
            if (reviewImages == null) return;

            List<PictureBox> pictureBoxes = new List<PictureBox>() { picPhoto1, picPhoto2, picPhoto3 };
            for (int i = 0; i < reviewImages.Count; i++)
            {
                pictureBoxes[i].Image = reviewImages[i];
                pictureBoxes[i].Cursor = Cursors.Hand;
                pictureBoxes[i].Click += DisplayImage;
            }
        }

        /// <summary>
        /// When an image is clicked --> display image in bigger size 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayImage(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox == null || pictureBox.Image == null) return;

            fImageDisplay fImageDisplay = new fImageDisplay(pictureBox.Image);
            fImageDisplay.ShowDialog();
        }
    }
}

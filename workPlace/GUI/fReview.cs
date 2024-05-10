using DAO;
using EntityModel;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            if (isWorker)
            {
                AdjustFormForWorker();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            Evaluate newEvaluate = new Evaluate();

            newEvaluate.JobID = currentEvaluateJob.JobID;
            newEvaluate.IsWorker = isWorker;
            newEvaluate.CommenterID = currentReviewer.PersonID;
            newEvaluate.Comment = txtDescription.Text;
            newEvaluate.Point = float.Parse(txtPoint.Text);

            // Add information of review into database (without image)
            evaluateDAO.Add(newEvaluate);

            // Add image path into database
            if (!isWorker)
            {
                SaveImage();
            }

            this.Close();
        }

        private void AdjustFormForWorker()
        {
            lblAddPhoto.Visible = false;
            tlpnlPhoto.Visible = false;
            btnConfirm.Location = new Point(btnConfirm.Location.X, btnConfirm.Location.Y - 150);
            this.Size = new Size(this.Size.Width, this.Size.Height - 150);
        }

        private void picPhoto_Click(object sender, EventArgs e)
        {
            UploadImage(sender as PictureBox);
        }

        private bool UploadImage(PictureBox pictureBox)
        {
            OpenFileDialog avatarChoosingWindow = new OpenFileDialog();
            avatarChoosingWindow.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (avatarChoosingWindow.ShowDialog() == DialogResult.OK)
            {
                //avatarFilePath = avatarChoosingWindow.FileName;
                //pictureBox.Image = new Bitmap(avatarChoosingWindow.FileName);
                pictureBox.ImageLocation = avatarChoosingWindow.FileName;
            }
            if (pictureBox.ImageLocation !=  null) return true;
            else return false;
        }

        private void SaveImage()
        {
            int count = 1;
            List<PictureBox> pictureBoxes = new List<PictureBox>() { picPhoto1, picPhoto2, picPhoto3 };
            foreach (PictureBox pictureBox in pictureBoxes)
            {
                if (pictureBox.ImageLocation != null)
                {
                    string pathDes = Path.Combine(Environment.CurrentDirectory, @"EvaluatePhotos\", @"eval_" + (count++).ToString() + "_" + currentEvaluateJob.JobID + Path.GetExtension(pictureBox.ImageLocation));
                    System.IO.File.Copy(pictureBox.ImageLocation, pathDes, true);
                }
            }
        }
    }
}

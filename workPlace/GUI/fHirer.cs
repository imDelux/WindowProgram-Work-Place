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
    public partial class fHirer : KryptonForm
    {
        // Current hirer user
        Person currentHirer = null;

        public fHirer()
        {
            InitializeComponent();
        }

        public fHirer(Person hirer)
        {
            InitializeComponent();
            currentHirer = hirer;
        }

        private void fWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit ?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void fHirer_Load(object sender, EventArgs e)
        {
            // Load home
            ucHomeCategoryChoose uc = new ucHomeCategoryChoose(currentHirer);
            AddUC(uc);
        }

        #region Dashboard button event

        private void AddUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            uc.Dock = DockStyle.Fill;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHomeCategoryChoose uc = new ucHomeCategoryChoose(currentHirer);
            AddUC(uc);
        }

        private void btnHiring_Click(object sender, EventArgs e)
        {
            ucHiring uc = new ucHiring(currentHirer);
            AddUC(uc);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucProfile uc = new ucProfile(currentHirer);
            AddUC(uc);
        }     
        private void btnPost_Click(object sender, EventArgs e)
        {
            ucPost uc = new ucPost(currentHirer);
            AddUC(uc);
        }
        #endregion

        #region Exit and LogOut Event
        private void picExit_MouseLeave(object sender, EventArgs e)
        {
            KryptonPictureBox clickedPic = sender as KryptonPictureBox;
            if (clickedPic != null)
            {
                clickedPic.Size = new Size(clickedPic.Size.Width - 2, clickedPic.Size.Height - 2);
            }
        }

        private void picExit_MouseEnter(object sender, EventArgs e)
        {
            KryptonPictureBox clickedPic = sender as KryptonPictureBox;
            if (clickedPic != null)
            {
                clickedPic.Size = new Size(clickedPic.Size.Width + 2, clickedPic.Size.Height + 2);
            }
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion
    }
}

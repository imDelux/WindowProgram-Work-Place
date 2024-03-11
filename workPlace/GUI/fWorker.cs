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
    public partial class fWorker : KryptonForm
    {
        public fWorker()
        {
            InitializeComponent();
        }


        #region Form Event
        private void fWorker_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to quit ?", "Closing", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
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
            this.Close();
        }


        #endregion

        
    }
}

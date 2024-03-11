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

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            //KryptonButton clickedBtn = sender as KryptonButton;
            //if (clickedBtn != null)
            //{
            //    //clickedBtn.BackColor = Color.FromArgb(174, 165, 199);
                
            //    clickedBtn.StateCommon.Back.Color1 = Color.FromArgb(174, 165, 199);
            //    clickedBtn.StateCommon.Back.Color2 = Color.FromArgb(174, 165, 199);
            //    //clickedBtn.StateNormal.Content.ShortText.Color1 = Color.White;
            //}
        }

        private void btnSchedule_Leave(object sender, EventArgs e)
        {
            //KryptonButton clickedBtn = sender as KryptonButton;
            //if (clickedBtn != null)
            //{
            //    clickedBtn.StateNormal.Back.Color1 = Color.Transparent;
            //    clickedBtn.StateNormal.Back.Color2 = Color.Transparent;
            //}
        }
    }
}

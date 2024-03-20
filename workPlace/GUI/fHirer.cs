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
        public fHirer()
        {
            InitializeComponent();
        }

        private void fHirer_Load(object sender, EventArgs e)
        {
            ucHome uc = new ucHome();
            AddUC(uc);
        }

        #region Dashboard button event

        private void AddUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            ucHome uc = new ucHome();
            AddUC(uc);
        }

        private void btnHiring_Click(object sender, EventArgs e)
        {
            ucHiring uc = new ucHiring();
            AddUC(uc);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            ucProfile uc = new ucProfile();
            AddUC(uc);
        }

        #endregion

        private void picExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

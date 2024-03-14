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

        static fHirer obj;

        public static fHirer Instance
        {
            get
            {
                if (obj == null)
                {
                    obj = new fHirer();
                }
                return obj;
            }
        }

        public Panel PnlContainer { get; set; }

        public fHirer()
        {
            InitializeComponent();
        }

        private void picExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void picLogOut_Click(object sender, EventArgs e)
        {
            this.Close();       
        }

        private void AddUC(UserControl uc)
        {
            uc.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(uc);
            uc.BringToFront();
        }

        private void fHirer_Load(object sender, EventArgs e)
        {
            ucHome uc = new ucHome();
            AddUC(uc);
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
    }
}

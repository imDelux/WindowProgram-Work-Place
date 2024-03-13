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
    public partial class ucProfile : UserControl
    {
        public ucProfile()
        {
            InitializeComponent();
        }

        private void usProfile_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                this.fpnlReviewContainer.Controls.Add(new ucReview());
            }
        }

        private void lblUserSkill_Click(object sender, EventArgs e)
        {
            fWorkerSkills fWorkerSkills = new fWorkerSkills();
            fWorkerSkills.ShowDialog();
        }
    }
}

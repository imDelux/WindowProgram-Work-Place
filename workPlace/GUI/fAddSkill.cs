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
    public partial class fAddSkill : KryptonForm
    {
        // Current adding skill
        DAO.DbConnection dbConnection = new DAO.DbConnection();
        List<CategorySkill> catList = new List<CategorySkill>();

        public fAddSkill()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
        }
    }
}

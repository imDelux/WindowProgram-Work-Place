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
    public partial class ucWorker : UserControl
    {
        public ucWorker()
        {
            InitializeComponent();
        }

        #region Getter & Setter

        private Image _avt;
        private string _workername, _age, _place, _skill;

        [Category("Edit Properties")]

        public Image Avt
        {
            get { return _avt; }
            set { _avt = value; picAvatar.Image = value; }
        }

        [Category("Edit Properties")]

        public string WorkerName
        {
            get { return _workername; }
            set { _workername = value; }
        }

        private void lblWokerName_Click(object sender, EventArgs e)
        {
            fWorkerInfo fWorkerInfo = new fWorkerInfo();
            fWorkerInfo.ShowDialog();
        }

        [Category("Edit Properties")]

        public string Age
        {
            get { return _age; }
            set { _age = value; }
        }

        [Category("Edit Properties")]

        public string Place
        {
            get { return _place; }
            set { _place = value; }
        }

        [Category("Edit Properties")]

        public string Skill
        {
            get { return _skill; }
            set { _skill = value; }
        }

        #endregion
    }
}

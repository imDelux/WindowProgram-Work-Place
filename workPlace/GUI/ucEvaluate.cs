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
    public partial class ucEvaluate : UserControl
    {
        public ucEvaluate()
        {
            InitializeComponent();
        }

        #region Getter & Setter

        private Image _avt;
        private string _workername, _rate, _cmt;

        [Category("Edit Properties")]

        public Image Avt
        {
            get { return _avt; }
            set { _avt = value; picAvt.Image = value; }
        }

        [Category("Edit Properties")]

        public string WorkerName
        {
            get { return _workername; }
            set { _workername = value; }
        }

        [Category("Edit Properties")]

        public string Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }

        [Category("Edit Properties")]

        public string Comment
        {
            get { return _cmt; }
            set { _cmt = value; }
        }

        #endregion
    }
}

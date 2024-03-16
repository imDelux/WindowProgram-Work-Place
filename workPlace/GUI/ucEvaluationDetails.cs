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
    public partial class ucEvaluationDetails : UserControl
    {
        public ucEvaluationDetails()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            flpContainer.Controls.Clear();

            ucEvaluate[] listItems = new ucEvaluate[20];

            string[] workername = new string[20];
            string[] rate = new string[20];
            string[] cmt = new string[20];
            Image[] avt = new Image[20];

            for (int i = 0; i < listItems.Length; i++)
            {
                listItems[i] = new ucEvaluate();

                listItems[i].Avt = avt[i];
                listItems[i].WorkerName = workername[i];
                listItems[i].Rate = rate[i];
                listItems[i].Comment = cmt[i];

                flpContainer.Controls.Add(listItems[i]);
            }
        }


        private void ucEvaluationDetails_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}

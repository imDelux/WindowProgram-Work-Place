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
    public partial class ucHome : UserControl
    {
        public ucHome()
        {
            InitializeComponent();
        }

        private void GenerateDynamicUserControl()
        {
            flpContainer.Controls.Clear();

            ucWorker[] listItems = new ucWorker[20];

            string[]workername = new string[20];
            string[]age = new string[20];
            string[]place = new string[20];
            string[]skill = new string[20];
            Image[]avt = new Image[20];

            for (int i = 0; i<listItems.Length; i++)
            {
                listItems[i] = new ucWorker();

                listItems[i].Avt = avt[i];
                listItems[i].WorkerName = workername[i];
                listItems[i].Age = age[i];
                listItems[i].Place = place[i];
                listItems[i].Skill = skill[i];

                flpContainer.Controls.Add(listItems[i]);
                listItems[i].BringToFront();
                //listItems[i].Click += new System.EventHandler(this.UserControl_Click)
            }
        }

        private void ucHome_Load(object sender, EventArgs e)
        {
            GenerateDynamicUserControl();
        }
    }
}

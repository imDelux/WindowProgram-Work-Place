using Data;
using EntityModel;
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
    public partial class ucBasicInfo : UserControl
    {
        public ucBasicInfo()
        {
            InitializeComponent();
        }

        public void DataSetter(Worker worker)
        {
            lblWokerName.Text = worker.Name;
            lblGender.Text = (worker.Gender == true ? "Male" : "Female");
            lblBirth.Text = worker.BirthDate.ToShortDateString();
            lblTelephone.Text = worker.Telephone;
            lblEmail.Text = worker.Email;
            lblLocation.Text = worker.Location;
        }
    }
}

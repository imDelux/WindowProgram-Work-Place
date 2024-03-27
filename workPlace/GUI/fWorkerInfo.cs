using DAO;
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
    public partial class fWorkerInfo : KryptonForm
    {
        // Current worker
        Person worker = null;
        DbConnection connection = new DbConnection();

        public fWorkerInfo()
        {
            InitializeComponent();
        }

        public fWorkerInfo(Person worker)
        {
            InitializeComponent();
            this.worker = worker;
            DataSetter();
        }

        private void DataSetter()
        {
            // Error detect
            if (worker == null) { return; }

            // Worker basic information
            lblWokerName.Text = worker.Name;
            lblGender.Text = (worker.Gender == true ? "Male" : "Female");
            lblBirth.Text = worker.BirthDate.ToShortDateString();
            lblTelephone.Text = worker.Telephone;
            lblEmail.Text = worker.Email;
            lblLocation.Text = worker.Location;

            // Generate skill list
            List<Skill> skillList = connection.FetchSkillList(worker.PersonID);
            fpnlSkills.Controls.Clear();
            foreach (Skill skill in skillList)
            {
                ucSkill ithskill = new ucSkill(skill);
                fpnlSkills.Controls.Add(ithskill);
            }
        }

        private void btnHire_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

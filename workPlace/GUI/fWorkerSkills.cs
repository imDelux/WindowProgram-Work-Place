using DAO;
using EntityModel;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fWorkerSkills : KryptonForm
    {
        // Input a person to display that person's skills
        Person currentWorker;
        SkillDAO skillDAO = new SkillDAO();
        DbConnection connection = new DbConnection();

        public fWorkerSkills()
        {
            InitializeComponent();
        }

        public fWorkerSkills(Person worker)
        {
            InitializeComponent();
            currentWorker = worker;
            DataSetter();
        }

        private void DataSetter()
        {
            // Error detect
            if (currentWorker == null) { return; }

            // Get skill list of current worker
            List<Skill> skillList = connection.FetchSkillList(currentWorker.PersonID);

            // Generate uc Skill
            fpnlSkillContainer.Controls.Clear();
            foreach (Skill skill in skillList)
            {
                ucSkill ithskill = new ucSkill(skill, false);
                fpnlSkillContainer.Controls.Add(ithskill);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAdd_Click(object sender, EventArgs e)
        {
            // New skill will be stored here
            Skill newSkill = new Skill();

            fAddSkill fAddSkill = new fAddSkill(newSkill);
            DialogResult addSkillResult = fAddSkill.ShowDialog();

            // Check if user has chosen to add new skill    
            if (addSkillResult == DialogResult.OK)
            {
                skillDAO.Add(newSkill, currentWorker);
                DataSetter();
            }
        }
    }
}

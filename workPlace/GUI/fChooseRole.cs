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
    public partial class fChooseRole : KryptonForm
    {
        // Current login user
        Person currentPerson;
        WorkerDAO workerDAO = new WorkerDAO();
        HirerDAO hirerDAO = new HirerDAO();

        /// <summary>
        /// Current choosing role, choose worker make this var false, choose hirer make this var true
        /// Default is worker
        /// </summary>
        bool role = false; 

        public fChooseRole()
        {
            InitializeComponent();
        }

        public fChooseRole(Person person)
        {
            InitializeComponent();
            this.currentPerson = person;
        }

        private void btnWorker_Click(object sender, EventArgs e)
        {
            role = false;
        }

        private void btnHirer_Click(object sender, EventArgs e)
        {
            role = true;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            // Worker case
            if (!role)
            {
                Person worker = workerDAO.FetchBasicInformation(currentPerson, "Worker");
                if (worker != null)
                {
                    fWorker workerMain = new fWorker();
                    workerMain.Show();
                }
            }
            // Hirer case
            else if (role)
            {
                Person hirer = hirerDAO.FetchBasicInformation(currentPerson, "Hirer");
            }
        }
    }
}

using DAO;
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
    public partial class ucPost : UserControl
    {
        // Store data
        Person currentUsingHirer = null;
        List<Post> posts = null;
        DbConnection dbConnection = new DbConnection();

        public ucPost()
        {
            InitializeComponent();
        }

        public ucPost(Person hirer)
        {
            InitializeComponent();
            this.currentUsingHirer = hirer;

            GetData();
            SetData();
        }

        private void GetData()
        {
            if (currentUsingHirer == null) { return; }
            posts = dbConnection.FetchPostListOfAHirer(currentUsingHirer.PersonID);
        }

        private void SetData()
        {
            lblNoPostNotification.Visible = posts.Count == 0;
            foreach (Post post in posts)
            {
                ucJobCard ucJobCard = new ucJobCard(currentUsingHirer, post, true);
                fpnlPostContainer.Controls.Add(ucJobCard);
            }
        }

        private void picAddPost_Click(object sender, EventArgs e)
        {
            fPostJob form = new fPostJob(currentUsingHirer);
            form.ShowDialog();
        }
    }
}

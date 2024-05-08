using EntityModel;
using Krypton.Toolkit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class fUploadAvatar : KryptonForm
    {
        Person currentChangingAvaterPerson = null;
        string avatarFilePath = "";

        public fUploadAvatar()
        {
            InitializeComponent();
        }

        public fUploadAvatar(Person person)
        {
            InitializeComponent();
            this.currentChangingAvaterPerson = person;
        }

        // Upload image into picture box
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog avatarChoosingWindow = new OpenFileDialog();
            avatarChoosingWindow.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp;";
            if (avatarChoosingWindow.ShowDialog() == DialogResult.OK)
            {
                avatarFilePath = avatarChoosingWindow.FileName;
                picAvatar.Image = new Bitmap(avatarChoosingWindow.FileName);
            }
        }

        // Save avatar to the avatar folder
        private void btnSave_Click(object sender, EventArgs e)
        {
            System.IO.File.Copy(avatarFilePath, Path.Combine(Environment.CurrentDirectory, @"Avatars\", @"avt_" + currentChangingAvaterPerson.PersonID + Path.GetExtension(avatarFilePath)), true);
            this.Close();
        }
    }
}

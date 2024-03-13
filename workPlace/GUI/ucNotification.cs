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
    public partial class ucNotification : UserControl
    {
        public ucNotification()
        {
            InitializeComponent();
        }

        private void usNotification_Load(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 10;  i++)
            {
                ucNewNotificationMessage usNewNotificationMessage = new ucNewNotificationMessage();
                usNewNotificationMessage.ChangeContent("Person " + i + " want to hire you");
                this.fpnlNewJobNotificationContainer.Controls.Add(usNewNotificationMessage);
            }

            for (i = 0;i < 10; i++)
            {
                ucNewNotificationMessage usNewNotificationMessage = new ucNewNotificationMessage();
                usNewNotificationMessage.ChangeContent("New evaluate on Job " + i);
                this.fpnlNewEvaluateNotificationContainer.Controls.Add(usNewNotificationMessage);
            }

            for (i = 0; i < 3; i++)
            {
                ucIncomingNotificationMessage usIncomingNotificationMessage = new ucIncomingNotificationMessage();
                usIncomingNotificationMessage.ChangeContent(i + ":30 3/13/2024: Fix plumber");
                this.fpnlIncomingNotificationContainer.Controls.Add(usIncomingNotificationMessage);
            }
        }
    }
}

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
    public partial class usNotification : UserControl
    {
        public usNotification()
        {
            InitializeComponent();
        }

        private void usNotification_Load(object sender, EventArgs e)
        {
            int i = 0;
            for (i = 0; i < 10;  i++)
            {
                usNewNotificationMessage usNewNotificationMessage = new usNewNotificationMessage();
                usNewNotificationMessage.ChangeContent("Person " + i + " want to hire you");
                this.fpnlNewJobNotification.Controls.Add(usNewNotificationMessage);
            }

            for (i = 0;i < 10; i++)
            {
                usNewNotificationMessage usNewNotificationMessage = new usNewNotificationMessage();
                usNewNotificationMessage.ChangeContent("New evaluate on Job " + i);
                this.fpnlNewEvaluateNotification.Controls.Add(usNewNotificationMessage);
            }

            for (i = 0; i < 3; i++)
            {
                usIncomingNotificationMessage usIncomingNotificationMessage = new usIncomingNotificationMessage();
                usIncomingNotificationMessage.ChangeContent(i + ":30 3/13/2024: Fix plumber");
                this.fpnlIncomingNotification.Controls.Add(usIncomingNotificationMessage);
            }
        }
    }
}

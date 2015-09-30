using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Development
{
    public partial class Form1 : Form
    {
        EmailSendClass emailSend = new EmailSendClass();
        LogInClass logIn = new LogInClass();
  
        public Form1()
        {
            InitializeComponent();
            ControlsMenuStrip.Visible = false;
            this.Size = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            IPAddressTextBox.Text = "IP Address";
            SocketTextBox.Text = "Socket";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EmailHeadTextBox_TextChanged(object sender, EventArgs e)
        {
            emailSend.MailSubject = EmailHeadTextBox.Text;
        }

        private void EmailBodyTextBox_TextChanged(object sender, EventArgs e)
        {
            emailSend.MailBody = EmailBodyTextBox.Text;
        }

        private void SendEmailButton_Click(object sender, EventArgs e)
        {
            emailSend.SendEmail();
        }

        private void UserNametextBox_TextChanged(object sender, EventArgs e)
        {
            logIn.UserName = UserNametextBox.Text;
        }

        private void PassCodetextBox_TextChanged(object sender, EventArgs e)
        {
            logIn.PassCode = PassCodetextBox.Text;
        }

        private void LogInbutton_Click(object sender, EventArgs e)
        {
            bool isValidated = logIn.ValidateUser();
            if (isValidated)
            {
                ControlsMenuStrip.Visible = true;
                this.Size = new System.Drawing.Size(750, 550);
                this.MinimumSize = new System.Drawing.Size(750, 550);
                this.MaximumSize = new System.Drawing.Size(750, 550);
                FirstPagePanel.Visible = false;
                EmailSendingPanel.Visible = true;
            }
            else
            {
                // TBD....
            }

            if(isValidated)
            {

            }
            else
            {

            }
        }

        private void chatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmailSendingPanel.Visible = false;
            FirstPagePanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            ChatPanel.Visible = true;
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            EmailSendingPanel.Visible = true;
        }

        private void databaseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            EmailSendingPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            DatabaseAppPanel.Visible = true;
        }

        private void realtimeGraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            EmailSendingPanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            RealTimeGraphPanel.Visible = true;
        }

        // Go back to first page
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            UserNametextBox.Text = ""; // Clear the username
            PassCodetextBox.Text = ""; // Clear the passcode
            ChatPanel.Visible = false;
            EmailSendingPanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            FirstPagePanel.Visible = true;
            ControlsMenuStrip.Visible = false; // Hide the controls from user
        }
    }
}

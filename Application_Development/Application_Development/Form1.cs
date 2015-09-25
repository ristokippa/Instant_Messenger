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
  
        public Form1()
        {
            InitializeComponent();
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
    }
}

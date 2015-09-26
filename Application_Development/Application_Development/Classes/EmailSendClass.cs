using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;

namespace Application_Development
{
    class EmailSendClass
    {
        private string mailSubject = "";
        private string mailBody = "";

        // Accessor methods (properties)
        public string MailSubject
        {
            set { mailSubject = value; }
        }

        public string MailBody
        {
            set { mailBody = value; }
        }

        public EmailSendClass()
        {

        }

        public void SendEmail()
        {
            try
            {
                MailMessage eMail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                eMail.From = new MailAddress("risto.kippa@gmail.com");
                eMail.To.Add("risto.kippa@gmail.com");
                eMail.Subject = mailSubject;
                eMail.Body = mailBody;

                smtpServer.Port = 587;
                smtpServer.Credentials = new System.Net.NetworkCredential("risto.kippa@gmail.com", "minaolen");
                smtpServer.EnableSsl = true;

                smtpServer.Send(eMail);
            }
            catch (Exception ex)
            {

            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Application_Development
{
    public partial class Form1 : Form
    {
        EmailSendClass emailSend = new EmailSendClass();
        LogInClass logIn = new LogInClass();
        Classes.ChatClass chatInstance = new Classes.ChatClass();

        Thread TimerThread;

        private string ServerIPAddress = ""; // Value comes from Chat panel interface
        private int ServerSocket = 0;        // Value comes from Chat panel interface
            
        public Form1()
        {
            InitializeComponent();
            ControlsMenuStrip.Visible = false;
            this.Size = new System.Drawing.Size(300, 250);
            this.MinimumSize = new System.Drawing.Size(300, 250);
            this.MaximumSize = new System.Drawing.Size(300, 250);
            IPAddressTextBox.Text = "IP Address";
            SocketTextBox.Text = "Socket";
            MachineIPAddressComboBox.Text = "Machine IP addresses";

            // Create a new clock
            Classes.TimerClass timerInstance = new Classes.TimerClass();
            Classes.DisplayClock displayClockInstance = new Classes.DisplayClock(RealTimeTextBox);

            // Subscribe to the clock
            displayClockInstance.Subscribe(timerInstance);
            TimerThread = new Thread(timerInstance.RunClock);
            TimerThread.Start();
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
                this.Size = new System.Drawing.Size(1000, 700);
                this.MinimumSize = new System.Drawing.Size(1000, 700);
                this.MaximumSize = new System.Drawing.Size(1000, 700);
                FirstPagePanel.Visible = false;
                EmailSendingPanel.Visible = true;
            }
            else
            {
                // TBD....
            }

            if (isValidated)
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
            WebBrowserPanel.Visible = false;
            ChatPanel.Visible = true;
        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            WebBrowserPanel.Visible = false;
            EmailSendingPanel.Visible = true;
        }

        private void databaseAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            EmailSendingPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            WebBrowserPanel.Visible = false;
            DatabaseAppPanel.Visible = true;
        }

        private void realtimeGraphsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            EmailSendingPanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            WebBrowserPanel.Visible = false;
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

        private void GetIPButton_Click(object sender, EventArgs e)
        {
            chatInstance.GetMachineIP();
            MachineIPAddressComboBox.Items.Clear();
            MachineIPAddressComboBox.Items.Add(Classes.GlobalsSecond.IPAddress[0]);
            MachineIPAddressComboBox.Items.Add(Classes.GlobalsSecond.IPAddress[1]);
        }

        private void IPAddressTextBox_TextChanged(object sender, EventArgs e)
        {
            ServerIPAddress = IPAddressTextBox.Text;
        }

        private void SocketTextBox_TextChanged(object sender, EventArgs e)
        {
            string serverSocket = SocketTextBox.Text;
            try
            {
                // Try and catch added in case conversion error happens. For example user gives "string" instead of number
                ServerSocket = Convert.ToInt32(serverSocket);
            }
            catch
            {
                // Set to default port 10000
                ServerSocket = 10000;
            }
        }

        private void webBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FirstPagePanel.Visible = false;
            ChatPanel.Visible = false;
            EmailSendingPanel.Visible = false;
            DatabaseAppPanel.Visible = false;
            RealTimeGraphPanel.Visible = false;
            WebBrowserPanel.Visible = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose(); // Clean up any resources being used
        }

        // Below is simple webbrowser usage inside the form
        private void WebBrowserGoButton_Click(object sender, EventArgs e)
        {
            string WebPage = BrowserSearchTextBox.Text.Trim();
            WebBrowserUsing.Navigate(WebPage);
        }

        private void WebBrowserHomeButton_Click(object sender, EventArgs e)
        {
            WebBrowserUsing.GoHome();
        }

        private void WebBrowserBackButton_Click(object sender, EventArgs e)
        {
            if(WebBrowserUsing.CanGoBack)
            {
                WebBrowserUsing.GoBack();
            }
        }

        private void WebBrowserForwardButton_Click(object sender, EventArgs e)
        {
            if (WebBrowserUsing.CanGoForward)
            {
                WebBrowserUsing.GoForward();
            }
        }

        private void WebBrowserRefreshButton_Click(object sender, EventArgs e)
        {
            WebBrowserUsing.Refresh();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            TimerThread.Abort();
        }
    }  
}

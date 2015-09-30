namespace Application_Development
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailHeadTextBox = new System.Windows.Forms.TextBox();
            this.EmailBodyTextBox = new System.Windows.Forms.TextBox();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.FirstPagePanel = new System.Windows.Forms.Panel();
            this.PasscodeLabel = new System.Windows.Forms.Label();
            this.UserNameLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.PassCodetextBox = new System.Windows.Forms.TextBox();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.EmailSendingPanel = new System.Windows.Forms.Panel();
            this.ChatPanel = new System.Windows.Forms.Panel();
            this.ConnectToServerButton = new System.Windows.Forms.Button();
            this.SocketTextBox = new System.Windows.Forms.TextBox();
            this.IPAddressTextBox = new System.Windows.Forms.TextBox();
            this.SendToServerButton = new System.Windows.Forms.Button();
            this.ToServerLabel = new System.Windows.Forms.Label();
            this.FromServerLabel = new System.Windows.Forms.Label();
            this.ToServerTextBox = new System.Windows.Forms.TextBox();
            this.FromServerTextBox = new System.Windows.Forms.TextBox();
            this.ControlsMenuStrip = new System.Windows.Forms.MenuStrip();
            this.controlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realtimeGraphsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DatabaseAppPanel = new System.Windows.Forms.Panel();
            this.RealTimeGraphPanel = new System.Windows.Forms.Panel();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FirstPagePanel.SuspendLayout();
            this.EmailSendingPanel.SuspendLayout();
            this.ChatPanel.SuspendLayout();
            this.ControlsMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // EmailHeadTextBox
            // 
            this.EmailHeadTextBox.Location = new System.Drawing.Point(13, 112);
            this.EmailHeadTextBox.Name = "EmailHeadTextBox";
            this.EmailHeadTextBox.Size = new System.Drawing.Size(186, 20);
            this.EmailHeadTextBox.TabIndex = 0;
            this.EmailHeadTextBox.TextChanged += new System.EventHandler(this.EmailHeadTextBox_TextChanged);
            // 
            // EmailBodyTextBox
            // 
            this.EmailBodyTextBox.Location = new System.Drawing.Point(13, 76);
            this.EmailBodyTextBox.Name = "EmailBodyTextBox";
            this.EmailBodyTextBox.Size = new System.Drawing.Size(186, 20);
            this.EmailBodyTextBox.TabIndex = 1;
            this.EmailBodyTextBox.TextChanged += new System.EventHandler(this.EmailBodyTextBox_TextChanged);
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.Location = new System.Drawing.Point(87, 174);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(75, 23);
            this.SendEmailButton.TabIndex = 2;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.UseVisualStyleBackColor = true;
            this.SendEmailButton.Click += new System.EventHandler(this.SendEmailButton_Click);
            // 
            // FirstPagePanel
            // 
            this.FirstPagePanel.Controls.Add(this.PasscodeLabel);
            this.FirstPagePanel.Controls.Add(this.UserNameLabel);
            this.FirstPagePanel.Controls.Add(this.button1);
            this.FirstPagePanel.Controls.Add(this.LogInbutton);
            this.FirstPagePanel.Controls.Add(this.PassCodetextBox);
            this.FirstPagePanel.Controls.Add(this.UserNametextBox);
            this.FirstPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstPagePanel.Location = new System.Drawing.Point(0, 24);
            this.FirstPagePanel.Name = "FirstPagePanel";
            this.FirstPagePanel.Size = new System.Drawing.Size(772, 471);
            this.FirstPagePanel.TabIndex = 3;
            // 
            // PasscodeLabel
            // 
            this.PasscodeLabel.AutoSize = true;
            this.PasscodeLabel.Location = new System.Drawing.Point(14, 102);
            this.PasscodeLabel.Name = "PasscodeLabel";
            this.PasscodeLabel.Size = new System.Drawing.Size(54, 13);
            this.PasscodeLabel.TabIndex = 5;
            this.PasscodeLabel.Text = "Passcode";
            // 
            // UserNameLabel
            // 
            this.UserNameLabel.AutoSize = true;
            this.UserNameLabel.Location = new System.Drawing.Point(14, 70);
            this.UserNameLabel.Name = "UserNameLabel";
            this.UserNameLabel.Size = new System.Drawing.Size(55, 13);
            this.UserNameLabel.TabIndex = 4;
            this.UserNameLabel.Text = "Username";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // LogInbutton
            // 
            this.LogInbutton.Location = new System.Drawing.Point(181, 102);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(75, 23);
            this.LogInbutton.TabIndex = 2;
            this.LogInbutton.Text = "Login";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // PassCodetextBox
            // 
            this.PassCodetextBox.Location = new System.Drawing.Point(75, 102);
            this.PassCodetextBox.Name = "PassCodetextBox";
            this.PassCodetextBox.Size = new System.Drawing.Size(100, 20);
            this.PassCodetextBox.TabIndex = 1;
            this.PassCodetextBox.TextChanged += new System.EventHandler(this.PassCodetextBox_TextChanged);
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(75, 70);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNametextBox.TabIndex = 0;
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            // 
            // EmailSendingPanel
            // 
            this.EmailSendingPanel.Controls.Add(this.EmailHeadTextBox);
            this.EmailSendingPanel.Controls.Add(this.SendEmailButton);
            this.EmailSendingPanel.Controls.Add(this.EmailBodyTextBox);
            this.EmailSendingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailSendingPanel.Location = new System.Drawing.Point(0, 0);
            this.EmailSendingPanel.Name = "EmailSendingPanel";
            this.EmailSendingPanel.Size = new System.Drawing.Size(772, 495);
            this.EmailSendingPanel.TabIndex = 3;
            this.EmailSendingPanel.Visible = false;
            // 
            // ChatPanel
            // 
            this.ChatPanel.Controls.Add(this.ConnectToServerButton);
            this.ChatPanel.Controls.Add(this.SocketTextBox);
            this.ChatPanel.Controls.Add(this.IPAddressTextBox);
            this.ChatPanel.Controls.Add(this.SendToServerButton);
            this.ChatPanel.Controls.Add(this.ToServerLabel);
            this.ChatPanel.Controls.Add(this.FromServerLabel);
            this.ChatPanel.Controls.Add(this.ToServerTextBox);
            this.ChatPanel.Controls.Add(this.FromServerTextBox);
            this.ChatPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ChatPanel.Location = new System.Drawing.Point(0, 24);
            this.ChatPanel.Name = "ChatPanel";
            this.ChatPanel.Size = new System.Drawing.Size(772, 471);
            this.ChatPanel.TabIndex = 6;
            this.ChatPanel.Visible = false;
            // 
            // ConnectToServerButton
            // 
            this.ConnectToServerButton.Location = new System.Drawing.Point(290, 23);
            this.ConnectToServerButton.Name = "ConnectToServerButton";
            this.ConnectToServerButton.Size = new System.Drawing.Size(123, 23);
            this.ConnectToServerButton.TabIndex = 7;
            this.ConnectToServerButton.Text = "Connect To Server";
            this.ConnectToServerButton.UseVisualStyleBackColor = true;
            // 
            // SocketTextBox
            // 
            this.SocketTextBox.Location = new System.Drawing.Point(54, 49);
            this.SocketTextBox.Name = "SocketTextBox";
            this.SocketTextBox.Size = new System.Drawing.Size(219, 20);
            this.SocketTextBox.TabIndex = 6;
            // 
            // IPAddressTextBox
            // 
            this.IPAddressTextBox.Location = new System.Drawing.Point(54, 23);
            this.IPAddressTextBox.Name = "IPAddressTextBox";
            this.IPAddressTextBox.Size = new System.Drawing.Size(219, 20);
            this.IPAddressTextBox.TabIndex = 5;
            // 
            // SendToServerButton
            // 
            this.SendToServerButton.Location = new System.Drawing.Point(492, 429);
            this.SendToServerButton.Name = "SendToServerButton";
            this.SendToServerButton.Size = new System.Drawing.Size(75, 23);
            this.SendToServerButton.TabIndex = 4;
            this.SendToServerButton.Text = "Send";
            this.SendToServerButton.UseVisualStyleBackColor = true;
            // 
            // ToServerLabel
            // 
            this.ToServerLabel.AutoSize = true;
            this.ToServerLabel.Location = new System.Drawing.Point(378, 86);
            this.ToServerLabel.Name = "ToServerLabel";
            this.ToServerLabel.Size = new System.Drawing.Size(57, 13);
            this.ToServerLabel.TabIndex = 3;
            this.ToServerLabel.Text = "To Server:";
            // 
            // FromServerLabel
            // 
            this.FromServerLabel.AutoSize = true;
            this.FromServerLabel.Location = new System.Drawing.Point(51, 86);
            this.FromServerLabel.Name = "FromServerLabel";
            this.FromServerLabel.Size = new System.Drawing.Size(67, 13);
            this.FromServerLabel.TabIndex = 2;
            this.FromServerLabel.Text = "From Server:";
            // 
            // ToServerTextBox
            // 
            this.ToServerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToServerTextBox.Location = new System.Drawing.Point(381, 105);
            this.ToServerTextBox.Multiline = true;
            this.ToServerTextBox.Name = "ToServerTextBox";
            this.ToServerTextBox.Size = new System.Drawing.Size(303, 318);
            this.ToServerTextBox.TabIndex = 1;
            // 
            // FromServerTextBox
            // 
            this.FromServerTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FromServerTextBox.Location = new System.Drawing.Point(51, 105);
            this.FromServerTextBox.Multiline = true;
            this.FromServerTextBox.Name = "FromServerTextBox";
            this.FromServerTextBox.Size = new System.Drawing.Size(303, 318);
            this.FromServerTextBox.TabIndex = 0;
            // 
            // ControlsMenuStrip
            // 
            this.ControlsMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlsToolStripMenuItem});
            this.ControlsMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.ControlsMenuStrip.Name = "ControlsMenuStrip";
            this.ControlsMenuStrip.Size = new System.Drawing.Size(772, 24);
            this.ControlsMenuStrip.TabIndex = 6;
            this.ControlsMenuStrip.Text = "Controls";
            // 
            // controlsToolStripMenuItem
            // 
            this.controlsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.emailToolStripMenuItem,
            this.chatToolStripMenuItem,
            this.databaseAppToolStripMenuItem,
            this.realtimeGraphsToolStripMenuItem,
            this.logoutToolStripMenuItem});
            this.controlsToolStripMenuItem.Name = "controlsToolStripMenuItem";
            this.controlsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.controlsToolStripMenuItem.Text = "Controls";
            // 
            // emailToolStripMenuItem
            // 
            this.emailToolStripMenuItem.Name = "emailToolStripMenuItem";
            this.emailToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.emailToolStripMenuItem.Text = "Email";
            this.emailToolStripMenuItem.Click += new System.EventHandler(this.emailToolStripMenuItem_Click);
            // 
            // chatToolStripMenuItem
            // 
            this.chatToolStripMenuItem.Name = "chatToolStripMenuItem";
            this.chatToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.chatToolStripMenuItem.Text = "Chat";
            this.chatToolStripMenuItem.Click += new System.EventHandler(this.chatToolStripMenuItem_Click);
            // 
            // databaseAppToolStripMenuItem
            // 
            this.databaseAppToolStripMenuItem.Name = "databaseAppToolStripMenuItem";
            this.databaseAppToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.databaseAppToolStripMenuItem.Text = "Database application";
            this.databaseAppToolStripMenuItem.Click += new System.EventHandler(this.databaseAppToolStripMenuItem_Click);
            // 
            // realtimeGraphsToolStripMenuItem
            // 
            this.realtimeGraphsToolStripMenuItem.Name = "realtimeGraphsToolStripMenuItem";
            this.realtimeGraphsToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.realtimeGraphsToolStripMenuItem.Text = "Realtime graphs";
            this.realtimeGraphsToolStripMenuItem.Click += new System.EventHandler(this.realtimeGraphsToolStripMenuItem_Click);
            // 
            // DatabaseAppPanel
            // 
            this.DatabaseAppPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DatabaseAppPanel.Location = new System.Drawing.Point(0, 24);
            this.DatabaseAppPanel.Name = "DatabaseAppPanel";
            this.DatabaseAppPanel.Size = new System.Drawing.Size(772, 471);
            this.DatabaseAppPanel.TabIndex = 6;
            this.DatabaseAppPanel.Visible = false;
            // 
            // RealTimeGraphPanel
            // 
            this.RealTimeGraphPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RealTimeGraphPanel.Location = new System.Drawing.Point(0, 24);
            this.RealTimeGraphPanel.Name = "RealTimeGraphPanel";
            this.RealTimeGraphPanel.Size = new System.Drawing.Size(772, 471);
            this.RealTimeGraphPanel.TabIndex = 0;
            this.RealTimeGraphPanel.Visible = false;
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 495);
            this.Controls.Add(this.RealTimeGraphPanel);
            this.Controls.Add(this.DatabaseAppPanel);
            this.Controls.Add(this.FirstPagePanel);
            this.Controls.Add(this.ChatPanel);
            this.Controls.Add(this.ControlsMenuStrip);
            this.Controls.Add(this.EmailSendingPanel);
            this.MainMenuStrip = this.ControlsMenuStrip;
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FirstPagePanel.ResumeLayout(false);
            this.FirstPagePanel.PerformLayout();
            this.EmailSendingPanel.ResumeLayout(false);
            this.EmailSendingPanel.PerformLayout();
            this.ChatPanel.ResumeLayout(false);
            this.ChatPanel.PerformLayout();
            this.ControlsMenuStrip.ResumeLayout(false);
            this.ControlsMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailHeadTextBox;
        private System.Windows.Forms.TextBox EmailBodyTextBox;
        private System.Windows.Forms.Button SendEmailButton;
        private System.Windows.Forms.Panel FirstPagePanel;
        private System.Windows.Forms.Button LogInbutton;
        private System.Windows.Forms.TextBox PassCodetextBox;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.Panel EmailSendingPanel;
        private System.Windows.Forms.Label PasscodeLabel;
        private System.Windows.Forms.Label UserNameLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel ChatPanel;
        private System.Windows.Forms.Button SendToServerButton;
        private System.Windows.Forms.Label ToServerLabel;
        private System.Windows.Forms.Label FromServerLabel;
        private System.Windows.Forms.TextBox ToServerTextBox;
        private System.Windows.Forms.TextBox FromServerTextBox;
        private System.Windows.Forms.MenuStrip ControlsMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem controlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem emailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chatToolStripMenuItem;
        private System.Windows.Forms.TextBox SocketTextBox;
        private System.Windows.Forms.TextBox IPAddressTextBox;
        private System.Windows.Forms.Button ConnectToServerButton;
        private System.Windows.Forms.ToolStripMenuItem databaseAppToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realtimeGraphsToolStripMenuItem;
        private System.Windows.Forms.Panel DatabaseAppPanel;
        private System.Windows.Forms.Panel RealTimeGraphPanel;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
    }
}


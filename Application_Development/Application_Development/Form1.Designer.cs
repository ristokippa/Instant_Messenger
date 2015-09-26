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
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PassCodetextBox = new System.Windows.Forms.TextBox();
            this.LogInbutton = new System.Windows.Forms.Button();
            this.EmailSendingPanel = new System.Windows.Forms.Panel();
            this.FirstPagePanel.SuspendLayout();
            this.EmailSendingPanel.SuspendLayout();
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
            this.FirstPagePanel.Controls.Add(this.LogInbutton);
            this.FirstPagePanel.Controls.Add(this.PassCodetextBox);
            this.FirstPagePanel.Controls.Add(this.UserNametextBox);
            this.FirstPagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FirstPagePanel.Location = new System.Drawing.Point(0, 0);
            this.FirstPagePanel.Name = "FirstPagePanel";
            this.FirstPagePanel.Size = new System.Drawing.Size(658, 390);
            this.FirstPagePanel.TabIndex = 3;
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.Location = new System.Drawing.Point(127, 139);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(100, 20);
            this.UserNametextBox.TabIndex = 0;
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            // 
            // PassCodetextBox
            // 
            this.PassCodetextBox.Location = new System.Drawing.Point(127, 174);
            this.PassCodetextBox.Name = "PassCodetextBox";
            this.PassCodetextBox.Size = new System.Drawing.Size(100, 20);
            this.PassCodetextBox.TabIndex = 1;
            this.PassCodetextBox.TextChanged += new System.EventHandler(this.PassCodetextBox_TextChanged);
            // 
            // LogInbutton
            // 
            this.LogInbutton.Location = new System.Drawing.Point(233, 137);
            this.LogInbutton.Name = "LogInbutton";
            this.LogInbutton.Size = new System.Drawing.Size(75, 23);
            this.LogInbutton.TabIndex = 2;
            this.LogInbutton.Text = "Login";
            this.LogInbutton.UseVisualStyleBackColor = true;
            this.LogInbutton.Click += new System.EventHandler(this.LogInbutton_Click);
            // 
            // EmailSendingPanel
            // 
            this.EmailSendingPanel.Controls.Add(this.EmailHeadTextBox);
            this.EmailSendingPanel.Controls.Add(this.SendEmailButton);
            this.EmailSendingPanel.Controls.Add(this.EmailBodyTextBox);
            this.EmailSendingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EmailSendingPanel.Location = new System.Drawing.Point(0, 0);
            this.EmailSendingPanel.Name = "EmailSendingPanel";
            this.EmailSendingPanel.Size = new System.Drawing.Size(658, 390);
            this.EmailSendingPanel.TabIndex = 3;
            this.EmailSendingPanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 390);
            this.Controls.Add(this.EmailSendingPanel);
            this.Controls.Add(this.FirstPagePanel);
            this.Name = "Form1";
            this.Text = "Client";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FirstPagePanel.ResumeLayout(false);
            this.FirstPagePanel.PerformLayout();
            this.EmailSendingPanel.ResumeLayout(false);
            this.EmailSendingPanel.PerformLayout();
            this.ResumeLayout(false);

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
    }
}


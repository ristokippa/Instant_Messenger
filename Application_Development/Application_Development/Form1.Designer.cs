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
            this.EmailBodyTextBox.Location = new System.Drawing.Point(13, 147);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.SendEmailButton);
            this.Controls.Add(this.EmailBodyTextBox);
            this.Controls.Add(this.EmailHeadTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailHeadTextBox;
        private System.Windows.Forms.TextBox EmailBodyTextBox;
        private System.Windows.Forms.Button SendEmailButton;
    }
}


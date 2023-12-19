
namespace Garden_AID
{
    partial class Verification
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
            this.securitybox = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textinPanel = new System.Windows.Forms.Label();
            this.EnterOTP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.numberDisplay = new System.Windows.Forms.Label();
            this.SHownbrInverify = new System.Windows.Forms.Label();
            this.textshowinverify = new System.Windows.Forms.Label();
            this.CodeNotFound = new System.Windows.Forms.LinkLabel();
            this.ContinueButton = new System.Windows.Forms.Button();
            this.Verify = new System.Windows.Forms.Label();
            this.CheckButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // securitybox
            // 
            this.securitybox.AutoSize = true;
            this.securitybox.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.securitybox.Location = new System.Drawing.Point(45, 34);
            this.securitybox.Name = "securitybox";
            this.securitybox.Size = new System.Drawing.Size(234, 30);
            this.securitybox.TabIndex = 0;
            this.securitybox.Text = "Enter Verfication Code";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textinPanel);
            this.panel1.Location = new System.Drawing.Point(45, 79);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(466, 51);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Your code is 4 digit in length";
            // 
            // textinPanel
            // 
            this.textinPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textinPanel.AutoSize = true;
            this.textinPanel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textinPanel.Location = new System.Drawing.Point(0, 0);
            this.textinPanel.Name = "textinPanel";
            this.textinPanel.Size = new System.Drawing.Size(461, 20);
            this.textinPanel.TabIndex = 0;
            this.textinPanel.Text = "Please check your phone or email for a text message with your code.";
            // 
            // EnterOTP
            // 
            this.EnterOTP.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.EnterOTP.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EnterOTP.Location = new System.Drawing.Point(45, 161);
            this.EnterOTP.Name = "EnterOTP";
            this.EnterOTP.PlaceholderText = "Enter code";
            this.EnterOTP.Size = new System.Drawing.Size(156, 33);
            this.EnterOTP.TabIndex = 2;
            this.EnterOTP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterOTP_KeyPress);
            this.EnterOTP.Leave += new System.EventHandler(this.EnterOTP_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.numberDisplay);
            this.panel2.Controls.Add(this.SHownbrInverify);
            this.panel2.Controls.Add(this.textshowinverify);
            this.panel2.Location = new System.Drawing.Point(207, 152);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(304, 51);
            this.panel2.TabIndex = 3;
            // 
            // numberDisplay
            // 
            this.numberDisplay.AutoSize = true;
            this.numberDisplay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numberDisplay.Location = new System.Drawing.Point(10, 24);
            this.numberDisplay.Name = "numberDisplay";
            this.numberDisplay.Size = new System.Drawing.Size(0, 20);
            this.numberDisplay.TabIndex = 5;
            // 
            // SHownbrInverify
            // 
            this.SHownbrInverify.AutoSize = true;
            this.SHownbrInverify.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SHownbrInverify.Location = new System.Drawing.Point(3, 27);
            this.SHownbrInverify.Name = "SHownbrInverify";
            this.SHownbrInverify.Size = new System.Drawing.Size(0, 20);
            this.SHownbrInverify.TabIndex = 4;
            // 
            // textshowinverify
            // 
            this.textshowinverify.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textshowinverify.AutoSize = true;
            this.textshowinverify.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textshowinverify.Location = new System.Drawing.Point(3, 0);
            this.textshowinverify.Name = "textshowinverify";
            this.textshowinverify.Size = new System.Drawing.Size(156, 20);
            this.textshowinverify.TabIndex = 4;
            this.textshowinverify.Text = "We sent your code to :";
            // 
            // CodeNotFound
            // 
            this.CodeNotFound.AutoSize = true;
            this.CodeNotFound.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeNotFound.Location = new System.Drawing.Point(45, 339);
            this.CodeNotFound.Name = "CodeNotFound";
            this.CodeNotFound.Size = new System.Drawing.Size(226, 21);
            this.CodeNotFound.TabIndex = 4;
            this.CodeNotFound.TabStop = true;
            this.CodeNotFound.Text = "Didn\'t get a code? Send Again...";
            this.CodeNotFound.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.CodeNotFound_LinkClicked);
            // 
            // ContinueButton
            // 
            this.ContinueButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContinueButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContinueButton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContinueButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ContinueButton.Location = new System.Drawing.Point(376, 328);
            this.ContinueButton.Name = "ContinueButton";
            this.ContinueButton.Size = new System.Drawing.Size(135, 40);
            this.ContinueButton.TabIndex = 0;
            this.ContinueButton.Text = "Continue";
            this.ContinueButton.UseVisualStyleBackColor = false;
            this.ContinueButton.Click += new System.EventHandler(this.ContinueButton_Click);
            // 
            // Verify
            // 
            this.Verify.AutoSize = true;
            this.Verify.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Verify.ForeColor = System.Drawing.Color.DarkGreen;
            this.Verify.Location = new System.Drawing.Point(45, 197);
            this.Verify.Name = "Verify";
            this.Verify.Size = new System.Drawing.Size(0, 20);
            this.Verify.TabIndex = 5;
            // 
            // CheckButton
            // 
            this.CheckButton.BackColor = System.Drawing.SystemColors.Desktop;
            this.CheckButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CheckButton.Font = new System.Drawing.Font("Segoe UI Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CheckButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CheckButton.Location = new System.Drawing.Point(45, 255);
            this.CheckButton.Name = "CheckButton";
            this.CheckButton.Size = new System.Drawing.Size(75, 29);
            this.CheckButton.TabIndex = 6;
            this.CheckButton.Text = "Check";
            this.CheckButton.UseVisualStyleBackColor = false;
            this.CheckButton.Click += new System.EventHandler(this.CheckButton_Click);
            // 
            // Verification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 451);
            this.Controls.Add(this.CheckButton);
            this.Controls.Add(this.Verify);
            this.Controls.Add(this.ContinueButton);
            this.Controls.Add(this.CodeNotFound);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.EnterOTP);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.securitybox);
            this.Name = "Verification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Verification";
            this.Load += new System.EventHandler(this.Verification_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label securitybox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label textinPanel;
        private System.Windows.Forms.TextBox EnterOTP;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SHownbrInverify;
        private System.Windows.Forms.Label textshowinverify;
        private System.Windows.Forms.LinkLabel CodeNotFound;
        private System.Windows.Forms.Button ContinueButton;
        private System.Windows.Forms.Label numberDisplay;
        private System.Windows.Forms.Label Verify;
        private System.Windows.Forms.Button CheckButton;
    }
}
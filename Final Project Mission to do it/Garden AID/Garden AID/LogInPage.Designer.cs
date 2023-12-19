
namespace Garden_AID
{
    partial class LogInPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInPage));
            this.email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Paassword = new System.Windows.Forms.TextBox();
            this.showpass = new System.Windows.Forms.CheckBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.Createbutton = new System.Windows.Forms.Button();
            this.Emailandphn = new System.Windows.Forms.ErrorProvider(this.components);
            this.passworderror = new System.Windows.Forms.ErrorProvider(this.components);
            this.ExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Emailandphn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // email
            // 
            this.email.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.email.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email.Location = new System.Drawing.Point(208, 111);
            this.email.Name = "email";
            this.email.PlaceholderText = "Email Address or Phone Number";
            this.email.Size = new System.Drawing.Size(302, 33);
            this.email.TabIndex = 1;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            this.email.Leave += new System.EventHandler(this.email_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 1;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Paassword
            // 
            this.Paassword.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.Paassword.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Paassword.Location = new System.Drawing.Point(208, 164);
            this.Paassword.Name = "Paassword";
            this.Paassword.PlaceholderText = "Password";
            this.Paassword.Size = new System.Drawing.Size(302, 33);
            this.Paassword.TabIndex = 2;
            this.Paassword.UseSystemPasswordChar = true;
            this.Paassword.TextChanged += new System.EventHandler(this.Paassword_TextChanged);
            this.Paassword.Leave += new System.EventHandler(this.Paassword_Leave);
            // 
            // showpass
            // 
            this.showpass.AutoSize = true;
            this.showpass.Location = new System.Drawing.Point(402, 203);
            this.showpass.Name = "showpass";
            this.showpass.Size = new System.Drawing.Size(108, 19);
            this.showpass.TabIndex = 3;
            this.showpass.Text = "Show Password";
            this.showpass.UseVisualStyleBackColor = true;
            this.showpass.CheckedChanged += new System.EventHandler(this.showpass_CheckedChanged);
            // 
            // loginbutton
            // 
            this.loginbutton.BackColor = System.Drawing.Color.DodgerBlue;
            this.loginbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginbutton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.loginbutton.Location = new System.Drawing.Point(208, 238);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(302, 53);
            this.loginbutton.TabIndex = 0;
            this.loginbutton.Text = "Log In";
            this.loginbutton.UseVisualStyleBackColor = false;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.linkLabel1.Location = new System.Drawing.Point(297, 294);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(131, 17);
            this.linkLabel1.TabIndex = 4;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Forgotten Password?";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Createbutton
            // 
            this.Createbutton.BackColor = System.Drawing.Color.LimeGreen;
            this.Createbutton.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Createbutton.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Createbutton.Location = new System.Drawing.Point(249, 332);
            this.Createbutton.Name = "Createbutton";
            this.Createbutton.Size = new System.Drawing.Size(224, 49);
            this.Createbutton.TabIndex = 5;
            this.Createbutton.Text = "Create New Account";
            this.Createbutton.UseVisualStyleBackColor = false;
            this.Createbutton.Click += new System.EventHandler(this.Createbutton_Click);
            // 
            // Emailandphn
            // 
            this.Emailandphn.ContainerControl = this;
            // 
            // passworderror
            // 
            this.passworderror.ContainerControl = this;
            // 
            // ExitButton
            // 
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(756, 406);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(32, 32);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton.TabIndex = 18;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LogInPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.Createbutton);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.showpass);
            this.Controls.Add(this.Paassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.email);
            this.Name = "LogInPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In Page";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Emailandphn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passworderror)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Paassword;
        private System.Windows.Forms.CheckBox showpass;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button Createbutton;
        private System.Windows.Forms.ErrorProvider Emailandphn;
        private System.Windows.Forms.ErrorProvider passworderror;
        private System.Windows.Forms.PictureBox ExitButton;
    }
}


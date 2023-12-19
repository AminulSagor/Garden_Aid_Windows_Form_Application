
namespace Garden_AID
{
    partial class ForgottenPassword
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgottenPassword));
            this.SearchIcon = new System.Windows.Forms.PictureBox();
            this.searchID = new System.Windows.Forms.TextBox();
            this.TextSlide = new System.Windows.Forms.Panel();
            this.TextshowlinetwoPass = new System.Windows.Forms.Label();
            this.TextshowForgetpass = new System.Windows.Forms.Label();
            this.CodeSend = new System.Windows.Forms.Button();
            this.CodeInputbar = new System.Windows.Forms.TextBox();
            this.CodeSubmit = new System.Windows.Forms.Button();
            this.NewPassBox = new System.Windows.Forms.TextBox();
            this.RetypePass = new System.Windows.Forms.TextBox();
            this.PassSubmit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.showBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).BeginInit();
            this.TextSlide.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            this.SuspendLayout();
            // 
            // SearchIcon
            // 
            this.SearchIcon.Image = ((System.Drawing.Image)(resources.GetObject("SearchIcon.Image")));
            this.SearchIcon.Location = new System.Drawing.Point(474, 13);
            this.SearchIcon.Name = "SearchIcon";
            this.SearchIcon.Size = new System.Drawing.Size(32, 32);
            this.SearchIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.SearchIcon.TabIndex = 9;
            this.SearchIcon.TabStop = false;
            this.SearchIcon.Click += new System.EventHandler(this.SearchIcon_Click);
            // 
            // searchID
            // 
            this.searchID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.searchID.Location = new System.Drawing.Point(13, 13);
            this.searchID.Name = "searchID";
            this.searchID.PlaceholderText = "Enter email or phone number";
            this.searchID.Size = new System.Drawing.Size(455, 33);
            this.searchID.TabIndex = 10;
            this.searchID.TextChanged += new System.EventHandler(this.searchID_TextChanged);
            // 
            // TextSlide
            // 
            this.TextSlide.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TextSlide.Controls.Add(this.TextshowlinetwoPass);
            this.TextSlide.Controls.Add(this.TextshowForgetpass);
            this.TextSlide.Location = new System.Drawing.Point(13, 87);
            this.TextSlide.Name = "TextSlide";
            this.TextSlide.Size = new System.Drawing.Size(524, 74);
            this.TextSlide.TabIndex = 11;
            // 
            // TextshowlinetwoPass
            // 
            this.TextshowlinetwoPass.AutoSize = true;
            this.TextshowlinetwoPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextshowlinetwoPass.Location = new System.Drawing.Point(4, 35);
            this.TextshowlinetwoPass.Name = "TextshowlinetwoPass";
            this.TextshowlinetwoPass.Size = new System.Drawing.Size(508, 21);
            this.TextshowlinetwoPass.TabIndex = 1;
            this.TextshowlinetwoPass.Text = "We well send a 6 digit code to your registered phone number and email.";
            // 
            // TextshowForgetpass
            // 
            this.TextshowForgetpass.AutoSize = true;
            this.TextshowForgetpass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextshowForgetpass.Location = new System.Drawing.Point(4, 4);
            this.TextshowForgetpass.Name = "TextshowForgetpass";
            this.TextshowForgetpass.Size = new System.Drawing.Size(211, 21);
            this.TextshowForgetpass.TabIndex = 0;
            this.TextshowForgetpass.Text = "We have found your account.";
            // 
            // CodeSend
            // 
            this.CodeSend.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.CodeSend.FlatAppearance.BorderSize = 0;
            this.CodeSend.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodeSend.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodeSend.Location = new System.Drawing.Point(13, 185);
            this.CodeSend.Name = "CodeSend";
            this.CodeSend.Size = new System.Drawing.Size(126, 41);
            this.CodeSend.TabIndex = 12;
            this.CodeSend.Text = "Send code";
            this.CodeSend.UseVisualStyleBackColor = false;
            // 
            // CodeInputbar
            // 
            this.CodeInputbar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CodeInputbar.Location = new System.Drawing.Point(13, 271);
            this.CodeInputbar.Name = "CodeInputbar";
            this.CodeInputbar.PlaceholderText = "Enter code here...";
            this.CodeInputbar.Size = new System.Drawing.Size(222, 33);
            this.CodeInputbar.TabIndex = 13;
            // 
            // CodeSubmit
            // 
            this.CodeSubmit.BackColor = System.Drawing.SystemColors.Desktop;
            this.CodeSubmit.FlatAppearance.BorderSize = 0;
            this.CodeSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CodeSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CodeSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.CodeSubmit.Location = new System.Drawing.Point(256, 271);
            this.CodeSubmit.Name = "CodeSubmit";
            this.CodeSubmit.Size = new System.Drawing.Size(126, 33);
            this.CodeSubmit.TabIndex = 14;
            this.CodeSubmit.Text = "Verify";
            this.CodeSubmit.UseVisualStyleBackColor = false;
            this.CodeSubmit.Click += new System.EventHandler(this.CodeSubmit_Click);
            // 
            // NewPassBox
            // 
            this.NewPassBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NewPassBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NewPassBox.Location = new System.Drawing.Point(226, 382);
            this.NewPassBox.Name = "NewPassBox";
            this.NewPassBox.PlaceholderText = "Enter new password";
            this.NewPassBox.Size = new System.Drawing.Size(299, 33);
            this.NewPassBox.TabIndex = 15;
            this.NewPassBox.UseSystemPasswordChar = true;
            this.NewPassBox.TextChanged += new System.EventHandler(this.NewPassBox_TextChanged);
            // 
            // RetypePass
            // 
            this.RetypePass.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.RetypePass.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RetypePass.Location = new System.Drawing.Point(226, 430);
            this.RetypePass.Name = "RetypePass";
            this.RetypePass.PlaceholderText = "Re-type password";
            this.RetypePass.Size = new System.Drawing.Size(299, 33);
            this.RetypePass.TabIndex = 16;
            this.RetypePass.UseSystemPasswordChar = true;
            this.RetypePass.TextChanged += new System.EventHandler(this.RetypePass_TextChanged);
            // 
            // PassSubmit
            // 
            this.PassSubmit.BackColor = System.Drawing.SystemColors.Desktop;
            this.PassSubmit.FlatAppearance.BorderSize = 0;
            this.PassSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PassSubmit.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PassSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PassSubmit.Location = new System.Drawing.Point(311, 492);
            this.PassSubmit.Name = "PassSubmit";
            this.PassSubmit.Size = new System.Drawing.Size(126, 33);
            this.PassSubmit.TabIndex = 17;
            this.PassSubmit.Text = "Submit";
            this.PassSubmit.UseVisualStyleBackColor = false;
            this.PassSubmit.Click += new System.EventHandler(this.PassSubmit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(504, 167);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // showBox1
            // 
            this.showBox1.AutoSize = true;
            this.showBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.showBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.showBox1.Location = new System.Drawing.Point(597, 443);
            this.showBox1.Name = "showBox1";
            this.showBox1.Size = new System.Drawing.Size(109, 19);
            this.showBox1.TabIndex = 19;
            this.showBox1.Text = "Show password";
            this.showBox1.UseVisualStyleBackColor = false;
            this.showBox1.CheckedChanged += new System.EventHandler(this.showBox1_CheckedChanged);
            // 
            // ForgottenPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(756, 648);
            this.Controls.Add(this.showBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.PassSubmit);
            this.Controls.Add(this.RetypePass);
            this.Controls.Add(this.NewPassBox);
            this.Controls.Add(this.CodeSubmit);
            this.Controls.Add(this.CodeInputbar);
            this.Controls.Add(this.CodeSend);
            this.Controls.Add(this.TextSlide);
            this.Controls.Add(this.searchID);
            this.Controls.Add(this.SearchIcon);
            this.Name = "ForgottenPassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ForgottenPassword";
            this.Load += new System.EventHandler(this.ForgottenPassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SearchIcon)).EndInit();
            this.TextSlide.ResumeLayout(false);
            this.TextSlide.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox SearchIcon;
        private System.Windows.Forms.TextBox searchID;
        private System.Windows.Forms.Panel TextSlide;
        private System.Windows.Forms.Label TextshowlinetwoPass;
        private System.Windows.Forms.Label TextshowForgetpass;
        private System.Windows.Forms.Button CodeSend;
        private System.Windows.Forms.TextBox CodeInputbar;
        private System.Windows.Forms.Button CodeSubmit;
        private System.Windows.Forms.TextBox NewPassBox;
        private System.Windows.Forms.TextBox RetypePass;
        private System.Windows.Forms.Button PassSubmit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.CheckBox showBox1;
    }
}
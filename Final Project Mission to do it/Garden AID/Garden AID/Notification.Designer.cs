
namespace Garden_AID
{
    partial class Notification
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
            this.Accept = new System.Windows.Forms.Button();
            this.Reject = new System.Windows.Forms.Button();
            this.ViewPic = new System.Windows.Forms.DataGridView();
            this.displayPic = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DisplayName = new System.Windows.Forms.Label();
            this.displayNarsery = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ViewPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Accept
            // 
            this.Accept.BackColor = System.Drawing.SystemColors.Highlight;
            this.Accept.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Accept.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Accept.Location = new System.Drawing.Point(316, 488);
            this.Accept.Name = "Accept";
            this.Accept.Size = new System.Drawing.Size(84, 33);
            this.Accept.TabIndex = 0;
            this.Accept.Text = "Accept";
            this.Accept.UseVisualStyleBackColor = false;
            // 
            // Reject
            // 
            this.Reject.BackColor = System.Drawing.Color.Crimson;
            this.Reject.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Reject.ForeColor = System.Drawing.SystemColors.Control;
            this.Reject.Location = new System.Drawing.Point(445, 488);
            this.Reject.Name = "Reject";
            this.Reject.Size = new System.Drawing.Size(84, 33);
            this.Reject.TabIndex = 1;
            this.Reject.Text = "Reject";
            this.Reject.UseVisualStyleBackColor = false;
            // 
            // ViewPic
            // 
            this.ViewPic.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewPic.Location = new System.Drawing.Point(12, 236);
            this.ViewPic.Name = "ViewPic";
            this.ViewPic.RowTemplate.Height = 25;
            this.ViewPic.Size = new System.Drawing.Size(388, 198);
            this.ViewPic.TabIndex = 2;
            // 
            // displayPic
            // 
            this.displayPic.Location = new System.Drawing.Point(12, 131);
            this.displayPic.Name = "displayPic";
            this.displayPic.Size = new System.Drawing.Size(188, 99);
            this.displayPic.TabIndex = 3;
            this.displayPic.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(224, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(260, 85);
            this.dataGridView1.TabIndex = 6;
            // 
            // DisplayName
            // 
            this.DisplayName.AutoSize = true;
            this.DisplayName.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DisplayName.Location = new System.Drawing.Point(12, 12);
            this.DisplayName.Name = "DisplayName";
            this.DisplayName.Size = new System.Drawing.Size(0, 25);
            this.DisplayName.TabIndex = 7;
            // 
            // displayNarsery
            // 
            this.displayNarsery.AutoSize = true;
            this.displayNarsery.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.displayNarsery.Location = new System.Drawing.Point(12, 47);
            this.displayNarsery.Name = "displayNarsery";
            this.displayNarsery.Size = new System.Drawing.Size(0, 20);
            this.displayNarsery.TabIndex = 8;
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 551);
            this.Controls.Add(this.displayNarsery);
            this.Controls.Add(this.DisplayName);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.displayPic);
            this.Controls.Add(this.ViewPic);
            this.Controls.Add(this.Reject);
            this.Controls.Add(this.Accept);
            this.Name = "Notification";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ViewPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.displayPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Accept;
        private System.Windows.Forms.Button Reject;
        private System.Windows.Forms.DataGridView ViewPic;
        private System.Windows.Forms.PictureBox displayPic;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label DisplayName;
        private System.Windows.Forms.Label displayNarsery;
    }
}
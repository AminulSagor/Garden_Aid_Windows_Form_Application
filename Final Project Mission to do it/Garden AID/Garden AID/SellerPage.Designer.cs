
namespace Garden_AID
{
    partial class SellerPage
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
            this.NurseryNameWrite = new System.Windows.Forms.TextBox();
            this.TextinSellerPage = new System.Windows.Forms.Label();
            this.InputPic = new System.Windows.Forms.TextBox();
            this.ForBrowserSeller = new System.Windows.Forms.Button();
            this.SellerContinuePage = new System.Windows.Forms.Button();
            this.DisplayImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage)).BeginInit();
            this.SuspendLayout();
            // 
            // NurseryNameWrite
            // 
            this.NurseryNameWrite.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.NurseryNameWrite.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NurseryNameWrite.Location = new System.Drawing.Point(53, 66);
            this.NurseryNameWrite.Name = "NurseryNameWrite";
            this.NurseryNameWrite.PlaceholderText = "Enter nursery name";
            this.NurseryNameWrite.Size = new System.Drawing.Size(269, 33);
            this.NurseryNameWrite.TabIndex = 2;
            // 
            // TextinSellerPage
            // 
            this.TextinSellerPage.AutoSize = true;
            this.TextinSellerPage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.TextinSellerPage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TextinSellerPage.Location = new System.Drawing.Point(53, 128);
            this.TextinSellerPage.Name = "TextinSellerPage";
            this.TextinSellerPage.Size = new System.Drawing.Size(403, 21);
            this.TextinSellerPage.TabIndex = 1;
            this.TextinSellerPage.Text = "Attach picture of your nursery for verification [At Most 5]";
            // 
            // InputPic
            // 
            this.InputPic.Location = new System.Drawing.Point(53, 168);
            this.InputPic.Name = "InputPic";
            this.InputPic.Size = new System.Drawing.Size(400, 23);
            this.InputPic.TabIndex = 3;
            // 
            // ForBrowserSeller
            // 
            this.ForBrowserSeller.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ForBrowserSeller.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForBrowserSeller.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ForBrowserSeller.Location = new System.Drawing.Point(53, 211);
            this.ForBrowserSeller.Name = "ForBrowserSeller";
            this.ForBrowserSeller.Size = new System.Drawing.Size(98, 34);
            this.ForBrowserSeller.TabIndex = 3;
            this.ForBrowserSeller.Text = "Browse";
            this.ForBrowserSeller.UseVisualStyleBackColor = false;
            this.ForBrowserSeller.Click += new System.EventHandler(this.ForBrowserSeller_Click);
            // 
            // SellerContinuePage
            // 
            this.SellerContinuePage.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.SellerContinuePage.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SellerContinuePage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SellerContinuePage.Location = new System.Drawing.Point(339, 355);
            this.SellerContinuePage.Name = "SellerContinuePage";
            this.SellerContinuePage.Size = new System.Drawing.Size(114, 46);
            this.SellerContinuePage.TabIndex = 0;
            this.SellerContinuePage.Text = "Submit";
            this.SellerContinuePage.UseVisualStyleBackColor = false;
            this.SellerContinuePage.Click += new System.EventHandler(this.SellerContinuePage_Click);
            // 
            // DisplayImage
            // 
            this.DisplayImage.Location = new System.Drawing.Point(381, 211);
            this.DisplayImage.Name = "DisplayImage";
            this.DisplayImage.Size = new System.Drawing.Size(72, 37);
            this.DisplayImage.TabIndex = 4;
            this.DisplayImage.TabStop = false;
            // 
            // SellerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.DisplayImage);
            this.Controls.Add(this.SellerContinuePage);
            this.Controls.Add(this.ForBrowserSeller);
            this.Controls.Add(this.InputPic);
            this.Controls.Add(this.TextinSellerPage);
            this.Controls.Add(this.NurseryNameWrite);
            this.Name = "SellerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SellerPage";
            this.Load += new System.EventHandler(this.SellerPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DisplayImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NurseryNameWrite;
        private System.Windows.Forms.Label TextinSellerPage;
        private System.Windows.Forms.TextBox InputPic;
        private System.Windows.Forms.Button ForBrowserSeller;
        private System.Windows.Forms.Button SellerContinuePage;
        private System.Windows.Forms.PictureBox DisplayImage;
    }
}
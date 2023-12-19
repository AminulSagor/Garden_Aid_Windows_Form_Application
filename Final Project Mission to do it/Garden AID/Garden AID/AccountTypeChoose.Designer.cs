
namespace Garden_AID
{
    partial class AccountTypeChoose
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
            this.TypeChooseTitle = new System.Windows.Forms.Panel();
            this.textShowinType = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.ContinueInType = new System.Windows.Forms.Button();
            this.TypeChooseTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // TypeChooseTitle
            // 
            this.TypeChooseTitle.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TypeChooseTitle.Controls.Add(this.textShowinType);
            this.TypeChooseTitle.Location = new System.Drawing.Point(12, 53);
            this.TypeChooseTitle.Name = "TypeChooseTitle";
            this.TypeChooseTitle.Size = new System.Drawing.Size(244, 60);
            this.TypeChooseTitle.TabIndex = 0;
            // 
            // textShowinType
            // 
            this.textShowinType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textShowinType.AutoSize = true;
            this.textShowinType.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textShowinType.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textShowinType.Location = new System.Drawing.Point(0, 15);
            this.textShowinType.Name = "textShowinType";
            this.textShowinType.Size = new System.Drawing.Size(239, 25);
            this.textShowinType.TabIndex = 0;
            this.textShowinType.Text = "Choose your accout type : ";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Buyer",
            "Seller",
            "Delivery Man"});
            this.comboBox1.Location = new System.Drawing.Point(288, 73);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(232, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.Text = "------Choose account type------";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // ContinueInType
            // 
            this.ContinueInType.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ContinueInType.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContinueInType.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ContinueInType.Location = new System.Drawing.Point(361, 348);
            this.ContinueInType.Name = "ContinueInType";
            this.ContinueInType.Size = new System.Drawing.Size(159, 55);
            this.ContinueInType.TabIndex = 0;
            this.ContinueInType.Text = "Continue";
            this.ContinueInType.UseVisualStyleBackColor = false;
            this.ContinueInType.Click += new System.EventHandler(this.ContinueInType_Click);
            // 
            // AccountTypeChoose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.ContinueInType);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.TypeChooseTitle);
            this.Name = "AccountTypeChoose";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountTypeChoose";
            this.Load += new System.EventHandler(this.AccountTypeChoose_Load);
            this.TypeChooseTitle.ResumeLayout(false);
            this.TypeChooseTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TypeChooseTitle;
        private System.Windows.Forms.Label textShowinType;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ContinueInType;
    }
}
namespace WinFormProject.WinFormCode
{
    partial class UCExperience
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCExperience));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.lblTitleAndCompany = new System.Windows.Forms.Label();
            this.lblLocationAndPeriod = new System.Windows.Forms.Label();
            this.rtxtAchievement = new System.Windows.Forms.RichTextBox();
            this.btnDelete = new Guna.UI2.WinForms.Guna2CircleButton();
            this.SuspendLayout();
            // 
            // lblTitleAndCompany
            // 
            this.lblTitleAndCompany.AutoSize = true;
            this.lblTitleAndCompany.BackColor = System.Drawing.Color.White;
            this.lblTitleAndCompany.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitleAndCompany.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitleAndCompany.Location = new System.Drawing.Point(22, 23);
            this.lblTitleAndCompany.Name = "lblTitleAndCompany";
            this.lblTitleAndCompany.Size = new System.Drawing.Size(234, 37);
            this.lblTitleAndCompany.TabIndex = 91;
            this.lblTitleAndCompany.Text = "Title, Company";
            // 
            // lblLocationAndPeriod
            // 
            this.lblLocationAndPeriod.AutoSize = true;
            this.lblLocationAndPeriod.BackColor = System.Drawing.Color.White;
            this.lblLocationAndPeriod.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLocationAndPeriod.ForeColor = System.Drawing.Color.Gray;
            this.lblLocationAndPeriod.Location = new System.Drawing.Point(22, 74);
            this.lblLocationAndPeriod.Name = "lblLocationAndPeriod";
            this.lblLocationAndPeriod.Size = new System.Drawing.Size(255, 23);
            this.lblLocationAndPeriod.TabIndex = 92;
            this.lblLocationAndPeriod.Text = "Location - (StartDate - EndDate)";
            // 
            // rtxtAchievement
            // 
            this.rtxtAchievement.BackColor = System.Drawing.Color.White;
            this.rtxtAchievement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtAchievement.Location = new System.Drawing.Point(22, 109);
            this.rtxtAchievement.Name = "rtxtAchievement";
            this.rtxtAchievement.Size = new System.Drawing.Size(750, 101);
            this.rtxtAchievement.TabIndex = 94;
            this.rtxtAchievement.Text = "";
            // 
            // btnDelete
            // 
            this.btnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelete.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageSize = new System.Drawing.Size(24, 24);
            this.btnDelete.Location = new System.Drawing.Point(732, 22);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.ShadowDecoration.CustomizableEdges = customizableEdges1;
            this.btnDelete.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDelete.Size = new System.Drawing.Size(40, 40);
            this.btnDelete.TabIndex = 99;
            // 
            // UCExperience
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.rtxtAchievement);
            this.Controls.Add(this.lblLocationAndPeriod);
            this.Controls.Add(this.lblTitleAndCompany);
            this.Name = "UCExperience";
            this.Size = new System.Drawing.Size(794, 237);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitleAndCompany;
        private Label lblLocationAndPeriod;
        private RichTextBox rtxtAchievement;
        private Guna.UI2.WinForms.Guna2CircleButton btnDelete;
    }
}

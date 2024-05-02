namespace WinFormProject.WinFormCode
{
    partial class FFindApplicant
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFindApplicant));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnSubBody = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblListApplicant = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.AutoSize = true;
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.pnSubBody);
            this.pnBody.Controls.Add(this.guna2CircleButton1);
            this.pnBody.Controls.Add(this.lblListApplicant);
            this.pnBody.Controls.Add(this.txtSearch);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1233, 847);
            this.pnBody.TabIndex = 3;
            // 
            // pnSubBody
            // 
            this.pnSubBody.Location = new System.Drawing.Point(44, 174);
            this.pnSubBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnSubBody.Name = "pnSubBody";
            this.pnSubBody.Size = new System.Drawing.Size(1143, 276);
            this.pnSubBody.TabIndex = 4;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(45, 45);
            this.guna2CircleButton1.Location = new System.Drawing.Point(1122, 104);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(65, 48);
            this.guna2CircleButton1.TabIndex = 44;
            // 
            // lblListApplicant
            // 
            this.lblListApplicant.AutoSize = true;
            this.lblListApplicant.BackColor = System.Drawing.Color.White;
            this.lblListApplicant.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListApplicant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListApplicant.Location = new System.Drawing.Point(53, 39);
            this.lblListApplicant.Name = "lblListApplicant";
            this.lblListApplicant.Size = new System.Drawing.Size(308, 42);
            this.lblListApplicant.TabIndex = 3;
            this.lblListApplicant.Text = "List Of Applicants";
            // 
            // txtSearch
            // 
            this.txtSearch.AutoRoundedCorners = true;
            this.txtSearch.BorderRadius = 23;
            this.txtSearch.CustomizableEdges = customizableEdges2;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.Location = new System.Drawing.Point(44, 104);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search for applicants";
            this.txtSearch.SelectedText = "";
            this.txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            this.txtSearch.Size = new System.Drawing.Size(1059, 48);
            this.txtSearch.TabIndex = 43;
            // 
            // FFindApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1233, 847);
            this.Controls.Add(this.pnBody);
            this.Name = "FFindApplicant";
            this.Text = "FFindApplicant";
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel pnBody;
        private FlowLayoutPanel pnSubBody;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label lblListApplicant;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
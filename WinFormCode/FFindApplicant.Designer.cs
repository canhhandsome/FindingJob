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
            pnBody = new Panel();
            pnSubBody = new FlowLayoutPanel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            lblListApplicant = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(pnSubBody);
            pnBody.Controls.Add(guna2CircleButton1);
            pnBody.Controls.Add(lblListApplicant);
            pnBody.Controls.Add(txtSearch);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1233, 847);
            pnBody.TabIndex = 3;
            // 
            // pnSubBody
            // 
            pnSubBody.AutoScroll = true;
            pnSubBody.Location = new Point(44, 174);
            pnSubBody.Margin = new Padding(3, 4, 3, 4);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(1143, 660);
            pnSubBody.TabIndex = 4;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Cursor = Cursors.Hand;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Transparent;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.ImageSize = new Size(45, 45);
            guna2CircleButton1.Location = new Point(1122, 104);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges1;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(65, 48);
            guna2CircleButton1.TabIndex = 44;
            // 
            // lblListApplicant
            // 
            lblListApplicant.AutoSize = true;
            lblListApplicant.BackColor = Color.White;
            lblListApplicant.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblListApplicant.ForeColor = SystemColors.ControlText;
            lblListApplicant.Location = new Point(53, 39);
            lblListApplicant.Name = "lblListApplicant";
            lblListApplicant.Size = new Size(308, 42);
            lblListApplicant.TabIndex = 3;
            lblListApplicant.Text = "List Of Applicants";
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 23;
            txtSearch.CustomizableEdges = customizableEdges2;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(44, 104);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for applicants";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges3;
            txtSearch.Size = new Size(1059, 48);
            txtSearch.TabIndex = 43;
            // 
            // FFindApplicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1233, 847);
            Controls.Add(pnBody);
            Name = "FFindApplicant";
            Text = "FFindApplicant";
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnBody;
        private FlowLayoutPanel pnSubBody;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Label lblListApplicant;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
namespace WinFormProject
{
    partial class UCApplicant
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnProfile = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            guna2ShadowPanel2 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            lblDateT = new Label();
            ptbApplicantPicture = new PictureBox();
            lblApplicantNameT = new Label();
            lblEmailT = new Label();
            btnDecline = new Guna.UI2.WinForms.Guna2Button();
            btnApprove = new Guna.UI2.WinForms.Guna2Button();
            guna2ShadowPanel1.SuspendLayout();
            guna2ShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).BeginInit();
            SuspendLayout();
            // 
            // btnProfile
            // 
            btnProfile.BorderRadius = 10;
            btnProfile.CustomizableEdges = customizableEdges1;
            btnProfile.DisabledState.BorderColor = Color.DarkGray;
            btnProfile.DisabledState.CustomBorderColor = Color.DarkGray;
            btnProfile.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnProfile.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnProfile.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.White;
            btnProfile.Location = new Point(279, 335);
            btnProfile.Name = "btnProfile";
            btnProfile.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnProfile.Size = new Size(92, 37);
            btnProfile.TabIndex = 12;
            btnProfile.Text = "Profile";
            btnProfile.Click += btnProfile_Click;
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(guna2ShadowPanel2);
            guna2ShadowPanel1.Controls.Add(btnDecline);
            guna2ShadowPanel1.Controls.Add(btnApprove);
            guna2ShadowPanel1.Controls.Add(btnProfile);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.White;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(418, 386);
            guna2ShadowPanel1.TabIndex = 12;
            // 
            // guna2ShadowPanel2
            // 
            guna2ShadowPanel2.BackColor = Color.Transparent;
            guna2ShadowPanel2.Controls.Add(lblDateT);
            guna2ShadowPanel2.Controls.Add(ptbApplicantPicture);
            guna2ShadowPanel2.Controls.Add(lblApplicantNameT);
            guna2ShadowPanel2.Controls.Add(lblEmailT);
            guna2ShadowPanel2.FillColor = Color.MistyRose;
            guna2ShadowPanel2.Location = new Point(15, 14);
            guna2ShadowPanel2.Name = "guna2ShadowPanel2";
            guna2ShadowPanel2.Radius = 10;
            guna2ShadowPanel2.ShadowColor = Color.Black;
            guna2ShadowPanel2.Size = new Size(390, 313);
            guna2ShadowPanel2.TabIndex = 13;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = Color.FromArgb(64, 64, 64);
            lblDateT.Location = new Point(16, 14);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(45, 19);
            lblDateT.TabIndex = 13;
            lblDateT.Text = "Date: ";
            // 
            // ptbApplicantPicture
            // 
            ptbApplicantPicture.Location = new Point(101, 39);
            ptbApplicantPicture.Margin = new Padding(3, 2, 3, 2);
            ptbApplicantPicture.Name = "ptbApplicantPicture";
            ptbApplicantPicture.Size = new Size(192, 192);
            ptbApplicantPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbApplicantPicture.TabIndex = 14;
            ptbApplicantPicture.TabStop = false;
            // 
            // lblApplicantNameT
            // 
            lblApplicantNameT.AutoSize = true;
            lblApplicantNameT.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicantNameT.ForeColor = SystemColors.ControlText;
            lblApplicantNameT.Location = new Point(101, 238);
            lblApplicantNameT.Name = "lblApplicantNameT";
            lblApplicantNameT.Size = new Size(192, 30);
            lblApplicantNameT.TabIndex = 12;
            lblApplicantNameT.Text = "Applicant's Name:";
            lblApplicantNameT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailT
            // 
            lblEmailT.AutoSize = true;
            lblEmailT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailT.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmailT.Location = new Point(167, 278);
            lblEmailT.Name = "lblEmailT";
            lblEmailT.Size = new Size(54, 25);
            lblEmailT.TabIndex = 11;
            lblEmailT.Text = "Email";
            lblEmailT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnDecline
            // 
            btnDecline.BorderRadius = 10;
            btnDecline.CustomizableEdges = customizableEdges3;
            btnDecline.DisabledState.BorderColor = Color.DarkGray;
            btnDecline.DisabledState.CustomBorderColor = Color.DarkGray;
            btnDecline.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnDecline.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnDecline.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecline.ForeColor = Color.White;
            btnDecline.Location = new Point(50, 335);
            btnDecline.Name = "btnDecline";
            btnDecline.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnDecline.Size = new Size(92, 37);
            btnDecline.TabIndex = 12;
            btnDecline.Text = "Decline";
            btnDecline.Click += btnAnswer_Click;
            // 
            // btnApprove
            // 
            btnApprove.BorderRadius = 10;
            btnApprove.CustomizableEdges = customizableEdges5;
            btnApprove.DisabledState.BorderColor = Color.DarkGray;
            btnApprove.DisabledState.CustomBorderColor = Color.DarkGray;
            btnApprove.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnApprove.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnApprove.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.White;
            btnApprove.Location = new Point(164, 335);
            btnApprove.Name = "btnApprove";
            btnApprove.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnApprove.Size = new Size(92, 37);
            btnApprove.TabIndex = 12;
            btnApprove.Text = "Approve";
            btnApprove.Click += btnAnswer_Click;
            // 
            // UCApplicant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCApplicant";
            Size = new Size(418, 386);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel2.ResumeLayout(false);
            guna2ShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnProfile;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel2;
        private Label lblDateT;
        private PictureBox ptbApplicantPicture;
        private Label lblApplicantNameT;
        private Label lblEmailT;
        private Guna.UI2.WinForms.Guna2Button btnDecline;
        private Guna.UI2.WinForms.Guna2Button btnApprove;
    }
}

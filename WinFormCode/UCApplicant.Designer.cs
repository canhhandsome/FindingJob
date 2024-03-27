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
            panel1 = new Panel();
            ptbApplicantPicture = new PictureBox();
            btnApprove = new ReaLTaiizor.Controls.CyberButton();
            btnProfile = new ReaLTaiizor.Controls.CyberButton();
            btnDecline = new ReaLTaiizor.Controls.CyberButton();
            lblDateT = new Label();
            lblJobT = new Label();
            lblApplicantNameT = new Label();
            lblDate = new Label();
            lblJob = new Label();
            lblApplicantName = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 232, 223);
            panel1.Controls.Add(ptbApplicantPicture);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnDecline);
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblJobT);
            panel1.Controls.Add(lblApplicantNameT);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblJob);
            panel1.Controls.Add(lblApplicantName);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 235);
            panel1.TabIndex = 3;
            // 
            // ptbApplicantPicture
            // 
            ptbApplicantPicture.Location = new Point(15, 13);
            ptbApplicantPicture.Name = "ptbApplicantPicture";
            ptbApplicantPicture.Size = new Size(175, 191);
            ptbApplicantPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbApplicantPicture.TabIndex = 10;
            ptbApplicantPicture.TabStop = false;
            // 
            // btnApprove
            // 
            btnApprove.Alpha = 20;
            btnApprove.BackColor = Color.Transparent;
            btnApprove.Background = true;
            btnApprove.Background_WidthPen = 4F;
            btnApprove.BackgroundPen = true;
            btnApprove.ColorBackground = Color.FromArgb(176, 226, 243);
            btnApprove.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnApprove.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnApprove.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnApprove.ColorLighting = Color.FromArgb(128, 128, 255);
            btnApprove.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnApprove.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnApprove.Cursor = Cursors.Hand;
            btnApprove.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnApprove.Effect_1 = true;
            btnApprove.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnApprove.Effect_1_Transparency = 25;
            btnApprove.Effect_2 = true;
            btnApprove.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnApprove.Effect_2_Transparency = 20;
            btnApprove.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.ForeColor = Color.FromArgb(46, 54, 71);
            btnApprove.Lighting = true;
            btnApprove.LinearGradient_Background = false;
            btnApprove.LinearGradientPen = false;
            btnApprove.Location = new Point(672, 163);
            btnApprove.Margin = new Padding(3, 4, 3, 4);
            btnApprove.Name = "btnApprove";
            btnApprove.PenWidth = 15;
            btnApprove.Rounding = true;
            btnApprove.RoundingInt = 20;
            btnApprove.Size = new Size(122, 56);
            btnApprove.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnApprove.TabIndex = 9;
            btnApprove.Tag = "Cyber";
            btnApprove.TextButton = "Approve";
            btnApprove.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnApprove.Timer_Effect_1 = 1;
            btnApprove.Timer_RGB = 300;
            btnApprove.Click += btnAnswer_Click;
            // 
            // btnProfile
            // 
            btnProfile.Alpha = 20;
            btnProfile.BackColor = Color.Transparent;
            btnProfile.Background = true;
            btnProfile.Background_WidthPen = 4F;
            btnProfile.BackgroundPen = true;
            btnProfile.ColorBackground = Color.FromArgb(176, 226, 243);
            btnProfile.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnProfile.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnProfile.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnProfile.ColorLighting = Color.FromArgb(128, 128, 255);
            btnProfile.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnProfile.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnProfile.Cursor = Cursors.Hand;
            btnProfile.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnProfile.Effect_1 = true;
            btnProfile.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnProfile.Effect_1_Transparency = 25;
            btnProfile.Effect_2 = true;
            btnProfile.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnProfile.Effect_2_Transparency = 20;
            btnProfile.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = Color.FromArgb(46, 54, 71);
            btnProfile.Lighting = true;
            btnProfile.LinearGradient_Background = false;
            btnProfile.LinearGradientPen = false;
            btnProfile.Location = new Point(809, 163);
            btnProfile.Margin = new Padding(3, 4, 3, 4);
            btnProfile.Name = "btnProfile";
            btnProfile.PenWidth = 15;
            btnProfile.Rounding = true;
            btnProfile.RoundingInt = 20;
            btnProfile.Size = new Size(122, 56);
            btnProfile.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnProfile.TabIndex = 9;
            btnProfile.Tag = "Cyber";
            btnProfile.TextButton = "Profile";
            btnProfile.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnProfile.Timer_Effect_1 = 1;
            btnProfile.Timer_RGB = 300;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnDecline
            // 
            btnDecline.Alpha = 20;
            btnDecline.BackColor = Color.Transparent;
            btnDecline.Background = true;
            btnDecline.Background_WidthPen = 4F;
            btnDecline.BackgroundPen = true;
            btnDecline.ColorBackground = Color.FromArgb(176, 226, 243);
            btnDecline.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnDecline.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnDecline.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnDecline.ColorLighting = Color.FromArgb(128, 128, 255);
            btnDecline.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnDecline.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnDecline.Cursor = Cursors.Hand;
            btnDecline.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDecline.Effect_1 = true;
            btnDecline.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDecline.Effect_1_Transparency = 25;
            btnDecline.Effect_2 = true;
            btnDecline.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDecline.Effect_2_Transparency = 20;
            btnDecline.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecline.ForeColor = Color.FromArgb(46, 54, 71);
            btnDecline.Lighting = true;
            btnDecline.LinearGradient_Background = false;
            btnDecline.LinearGradientPen = false;
            btnDecline.Location = new Point(534, 163);
            btnDecline.Margin = new Padding(3, 4, 3, 4);
            btnDecline.Name = "btnDecline";
            btnDecline.PenWidth = 15;
            btnDecline.Rounding = true;
            btnDecline.RoundingInt = 20;
            btnDecline.Size = new Size(122, 56);
            btnDecline.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDecline.TabIndex = 9;
            btnDecline.Tag = "Decline";
            btnDecline.TextButton = "Decline";
            btnDecline.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDecline.Timer_Effect_1 = 5;
            btnDecline.Timer_RGB = 300;
            btnDecline.Click += btnAnswer_Click;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = SystemColors.ControlText;
            lblDateT.Location = new Point(271, 88);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(69, 30);
            lblDateT.TabIndex = 7;
            lblDateT.Text = "Date: ";
            // 
            // lblJobT
            // 
            lblJobT.AutoSize = true;
            lblJobT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobT.ForeColor = SystemColors.ControlText;
            lblJobT.Location = new Point(260, 49);
            lblJobT.Name = "lblJobT";
            lblJobT.Size = new Size(58, 30);
            lblJobT.TabIndex = 6;
            lblJobT.Text = "Job: ";
            // 
            // lblApplicantNameT
            // 
            lblApplicantNameT.AutoSize = true;
            lblApplicantNameT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApplicantNameT.ForeColor = SystemColors.ControlText;
            lblApplicantNameT.Location = new Point(395, 13);
            lblApplicantNameT.Name = "lblApplicantNameT";
            lblApplicantNameT.Size = new Size(192, 30);
            lblApplicantNameT.TabIndex = 5;
            lblApplicantNameT.Text = "Applicant's Name: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(196, 88);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(69, 30);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date: ";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblJob.ForeColor = SystemColors.ControlText;
            lblJob.Location = new Point(196, 49);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(58, 30);
            lblJob.TabIndex = 1;
            lblJob.Text = "Job: ";
            // 
            // lblApplicantName
            // 
            lblApplicantName.AutoSize = true;
            lblApplicantName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApplicantName.ForeColor = SystemColors.ControlText;
            lblApplicantName.Location = new Point(196, 13);
            lblApplicantName.Name = "lblApplicantName";
            lblApplicantName.Size = new Size(192, 30);
            lblApplicantName.TabIndex = 0;
            lblApplicantName.Text = "Applicant's Name: ";
            // 
            // UCApplicant
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCApplicant";
            Size = new Size(950, 235);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblDate;
        private Label lblJob;
        private Label lblApplicantName;
        private Label lblDateT;
        private Label lblJobT;
        private Label lblApplicantNameT;
        private ReaLTaiizor.Controls.CyberButton btnProfile;
        private ReaLTaiizor.Controls.CyberButton btnDecline;
        private ReaLTaiizor.Controls.CyberButton btnApprove;
        private PictureBox ptbApplicantPicture;
    }
}

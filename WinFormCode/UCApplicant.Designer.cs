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
            panel2 = new Panel();
            lblDateT = new Label();
            ptbApplicantPicture = new PictureBox();
            lblApplicantNameT = new Label();
            lblEmailT = new Label();
            btnApprove = new ReaLTaiizor.Controls.CyberButton();
            btnProfile = new ReaLTaiizor.Controls.CyberButton();
            btnDecline = new ReaLTaiizor.Controls.CyberButton();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 232, 223);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(btnDecline);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(410, 386);
            panel1.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDateT);
            panel2.Controls.Add(ptbApplicantPicture);
            panel2.Controls.Add(lblApplicantNameT);
            panel2.Controls.Add(lblEmailT);
            panel2.Location = new Point(10, 9);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(387, 316);
            panel2.TabIndex = 11;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = Color.FromArgb(64, 64, 64);
            lblDateT.Location = new Point(11, 10);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(45, 19);
            lblDateT.TabIndex = 7;
            lblDateT.Text = "Date: ";
            // 
            // ptbApplicantPicture
            // 
            ptbApplicantPicture.Location = new Point(101, 39);
            ptbApplicantPicture.Margin = new Padding(3, 2, 3, 2);
            ptbApplicantPicture.Name = "ptbApplicantPicture";
            ptbApplicantPicture.Size = new Size(192, 192);
            ptbApplicantPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbApplicantPicture.TabIndex = 10;
            ptbApplicantPicture.TabStop = false;
            // 
            // lblApplicantNameT
            // 
            lblApplicantNameT.AutoSize = true;
            lblApplicantNameT.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblApplicantNameT.ForeColor = SystemColors.ControlText;
            lblApplicantNameT.Location = new Point(101, 242);
            lblApplicantNameT.Name = "lblApplicantNameT";
            lblApplicantNameT.Size = new Size(192, 30);
            lblApplicantNameT.TabIndex = 5;
            lblApplicantNameT.Text = "Applicant's Name:";
            lblApplicantNameT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmailT
            // 
            lblEmailT.AutoSize = true;
            lblEmailT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmailT.ForeColor = Color.FromArgb(64, 64, 64);
            lblEmailT.Location = new Point(167, 282);
            lblEmailT.Name = "lblEmailT";
            lblEmailT.Size = new Size(54, 25);
            lblEmailT.TabIndex = 1;
            lblEmailT.Text = "Email";
            lblEmailT.TextAlign = ContentAlignment.MiddleCenter;
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
            btnApprove.Location = new Point(149, 334);
            btnApprove.Name = "btnApprove";
            btnApprove.PenWidth = 15;
            btnApprove.Rounding = true;
            btnApprove.RoundingInt = 20;
            btnApprove.Size = new Size(107, 42);
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
            btnProfile.Location = new Point(273, 334);
            btnProfile.Name = "btnProfile";
            btnProfile.PenWidth = 15;
            btnProfile.Rounding = true;
            btnProfile.RoundingInt = 20;
            btnProfile.Size = new Size(107, 42);
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
            btnDecline.Location = new Point(25, 334);
            btnDecline.Name = "btnDecline";
            btnDecline.PenWidth = 15;
            btnDecline.Rounding = true;
            btnDecline.RoundingInt = 20;
            btnDecline.Size = new Size(107, 42);
            btnDecline.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDecline.TabIndex = 9;
            btnDecline.Tag = "Decline";
            btnDecline.TextButton = "Decline";
            btnDecline.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDecline.Timer_Effect_1 = 5;
            btnDecline.Timer_RGB = 300;
            btnDecline.Click += btnAnswer_Click;
            // 
            // UCApplicant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCApplicant";
            Size = new Size(410, 386);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbApplicantPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblEmailT;
        private Label lblDateT;
        private Label lblApplicantNameT;
        private ReaLTaiizor.Controls.CyberButton btnProfile;
        private ReaLTaiizor.Controls.CyberButton btnDecline;
        private ReaLTaiizor.Controls.CyberButton btnApprove;
        private PictureBox ptbApplicantPicture;
        private Panel panel2;
    }
}

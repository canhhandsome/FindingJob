namespace WinFormProject
{
    partial class FAlertView
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
            lblContent = new Label();
            lblSubject = new Label();
            lblDateT = new Label();
            lblDate = new Label();
            llFromT = new Label();
            lblFrom = new Label();
            lblSubjectT = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblContentT = new Label();
            btnDone = new ReaLTaiizor.Controls.CyberButton();
            lblJob = new Label();
            lblJobT = new Label();
            btnInterview = new ReaLTaiizor.Controls.CyberButton();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(9, 172);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(83, 25);
            lblContent.TabIndex = 35;
            lblContent.Text = "Content:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(9, 126);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(78, 25);
            lblSubject.TabIndex = 34;
            lblSubject.Text = "Subject:";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(106, 87);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(55, 25);
            lblDateT.TabIndex = 33;
            lblDateT.Text = "Date:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(9, 87);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(55, 25);
            lblDate.TabIndex = 32;
            lblDate.Text = "Date:";
            // 
            // llFromT
            // 
            llFromT.AutoSize = true;
            llFromT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            llFromT.Location = new Point(106, 49);
            llFromT.Name = "llFromT";
            llFromT.Size = new Size(59, 25);
            llFromT.TabIndex = 31;
            llFromT.Text = "From:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFrom.Location = new Point(9, 49);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(59, 25);
            lblFrom.TabIndex = 30;
            lblFrom.Text = "From:";
            // 
            // lblSubjectT
            // 
            lblSubjectT.AutoSize = true;
            lblSubjectT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubjectT.Location = new Point(106, 126);
            lblSubjectT.Name = "lblSubjectT";
            lblSubjectT.Size = new Size(78, 25);
            lblSubjectT.TabIndex = 40;
            lblSubjectT.Text = "Subject:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(lblContentT);
            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel1.Location = new Point(106, 172);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(750, 177);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // lblContentT
            // 
            lblContentT.AutoSize = true;
            lblContentT.BackColor = Color.White;
            lblContentT.Dock = DockStyle.Fill;
            lblContentT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContentT.Location = new Point(3, 0);
            lblContentT.Name = "lblContentT";
            lblContentT.Size = new Size(65, 21);
            lblContentT.TabIndex = 0;
            lblContentT.Text = "Content";
            // 
            // btnDone
            // 
            btnDone.Alpha = 20;
            btnDone.BackColor = Color.Transparent;
            btnDone.Background = true;
            btnDone.Background_WidthPen = 4F;
            btnDone.BackgroundPen = true;
            btnDone.ColorBackground = Color.FromArgb(176, 226, 243);
            btnDone.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnDone.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnDone.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnDone.ColorLighting = Color.FromArgb(128, 128, 255);
            btnDone.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnDone.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnDone.Cursor = Cursors.Hand;
            btnDone.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDone.Effect_1 = true;
            btnDone.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDone.Effect_1_Transparency = 25;
            btnDone.Effect_2 = true;
            btnDone.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDone.Effect_2_Transparency = 20;
            btnDone.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = Color.FromArgb(46, 54, 71);
            btnDone.Lighting = true;
            btnDone.LinearGradient_Background = false;
            btnDone.LinearGradientPen = false;
            btnDone.Location = new Point(736, 461);
            btnDone.Name = "btnDone";
            btnDone.PenWidth = 15;
            btnDone.Rounding = true;
            btnDone.RoundingInt = 20;
            btnDone.Size = new Size(120, 40);
            btnDone.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDone.TabIndex = 44;
            btnDone.Tag = "Decline";
            btnDone.TextButton = "Done";
            btnDone.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDone.Timer_Effect_1 = 5;
            btnDone.Timer_RGB = 300;
            btnDone.Click += btnDone_Click;
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblJob.Location = new Point(12, 16);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(50, 25);
            lblJob.TabIndex = 34;
            lblJob.Text = "Job: ";
            // 
            // lblJobT
            // 
            lblJobT.AutoSize = true;
            lblJobT.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobT.Location = new Point(106, 5);
            lblJobT.Name = "lblJobT";
            lblJobT.Size = new Size(67, 37);
            lblJobT.TabIndex = 40;
            lblJobT.Text = "Job:";
            // 
            // btnInterview
            // 
            btnInterview.Alpha = 20;
            btnInterview.BackColor = Color.Transparent;
            btnInterview.Background = true;
            btnInterview.Background_WidthPen = 4F;
            btnInterview.BackgroundPen = true;
            btnInterview.ColorBackground = Color.FromArgb(176, 226, 243);
            btnInterview.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnInterview.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnInterview.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnInterview.ColorLighting = Color.FromArgb(128, 128, 255);
            btnInterview.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnInterview.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnInterview.Cursor = Cursors.Hand;
            btnInterview.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnInterview.Effect_1 = true;
            btnInterview.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnInterview.Effect_1_Transparency = 25;
            btnInterview.Effect_2 = true;
            btnInterview.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnInterview.Effect_2_Transparency = 20;
            btnInterview.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnInterview.ForeColor = Color.FromArgb(46, 54, 71);
            btnInterview.Lighting = true;
            btnInterview.LinearGradient_Background = false;
            btnInterview.LinearGradientPen = false;
            btnInterview.Location = new Point(610, 461);
            btnInterview.Name = "btnInterview";
            btnInterview.PenWidth = 15;
            btnInterview.Rounding = true;
            btnInterview.RoundingInt = 20;
            btnInterview.Size = new Size(120, 40);
            btnInterview.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnInterview.TabIndex = 44;
            btnInterview.Tag = "Decline";
            btnInterview.TextButton = "Interview";
            btnInterview.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnInterview.Timer_Effect_1 = 5;
            btnInterview.Timer_RGB = 300;
            btnInterview.Visible = false;
            btnInterview.Click += btnInterview_Click;
            // 
            // FAlertView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(872, 513);
            Controls.Add(btnInterview);
            Controls.Add(btnDone);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblJobT);
            Controls.Add(lblSubjectT);
            Controls.Add(lblJob);
            Controls.Add(lblContent);
            Controls.Add(lblSubject);
            Controls.Add(lblDateT);
            Controls.Add(lblDate);
            Controls.Add(llFromT);
            Controls.Add(lblFrom);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAlertView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAlertView";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblContent;
        private Label lblSubject;
        private Label lblDateT;
        private Label lblDate;
        private Label llFromT;
        private Label lblFrom;
        private Label lblSubjectT;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblContentT;
        private ReaLTaiizor.Controls.CyberButton btnDone;
        private Label lblJob;
        private Label lblJobT;
        private ReaLTaiizor.Controls.CyberButton btnInterview;
    }
}
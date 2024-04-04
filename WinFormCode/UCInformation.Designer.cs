namespace WinFormProject
{
    partial class UCInformation
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
            btnCompanyDetail = new ReaLTaiizor.Controls.CyberButton();
            ptbCompanyPicture = new PictureBox();
            lblDateEndT = new Label();
            lblDateEnd = new Label();
            lblDateT = new Label();
            lblDate = new Label();
            lblNameT = new Label();
            lblContent = new Label();
            lblFromT = new Label();
            lblForm = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 232, 223);
            panel1.Controls.Add(btnCompanyDetail);
            panel1.Controls.Add(ptbCompanyPicture);
            panel1.Controls.Add(lblDateEndT);
            panel1.Controls.Add(lblDateEnd);
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblNameT);
            panel1.Controls.Add(lblContent);
            panel1.Controls.Add(lblFromT);
            panel1.Controls.Add(lblForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 180);
            panel1.TabIndex = 7;
            panel1.Click += panel1_Click;
            // 
            // btnCompanyDetail
            // 
            btnCompanyDetail.Alpha = 20;
            btnCompanyDetail.BackColor = Color.Transparent;
            btnCompanyDetail.Background = true;
            btnCompanyDetail.Background_WidthPen = 4F;
            btnCompanyDetail.BackgroundPen = true;
            btnCompanyDetail.ColorBackground = Color.FromArgb(176, 226, 243);
            btnCompanyDetail.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnCompanyDetail.ColorLighting = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.Cursor = Cursors.Hand;
            btnCompanyDetail.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCompanyDetail.Effect_1 = true;
            btnCompanyDetail.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.Effect_1_Transparency = 25;
            btnCompanyDetail.Effect_2 = true;
            btnCompanyDetail.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCompanyDetail.Effect_2_Transparency = 20;
            btnCompanyDetail.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompanyDetail.ForeColor = Color.FromArgb(46, 54, 71);
            btnCompanyDetail.Lighting = true;
            btnCompanyDetail.LinearGradient_Background = false;
            btnCompanyDetail.LinearGradientPen = false;
            btnCompanyDetail.Location = new Point(765, 106);
            btnCompanyDetail.Margin = new Padding(3, 4, 3, 4);
            btnCompanyDetail.Name = "btnCompanyDetail";
            btnCompanyDetail.PenWidth = 15;
            btnCompanyDetail.Rounding = true;
            btnCompanyDetail.RoundingInt = 20;
            btnCompanyDetail.Size = new Size(171, 56);
            btnCompanyDetail.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCompanyDetail.TabIndex = 46;
            btnCompanyDetail.Tag = "Decline";
            btnCompanyDetail.TextButton = "Company Detail";
            btnCompanyDetail.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCompanyDetail.Timer_Effect_1 = 5;
            btnCompanyDetail.Timer_RGB = 300;
            btnCompanyDetail.Click += btnCompanyDetail_Click;
            // 
            // ptbCompanyPicture
            // 
            ptbCompanyPicture.Location = new Point(15, 13);
            ptbCompanyPicture.Margin = new Padding(3, 2, 3, 2);
            ptbCompanyPicture.Name = "ptbCompanyPicture";
            ptbCompanyPicture.Size = new Size(150, 139);
            ptbCompanyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCompanyPicture.TabIndex = 1;
            ptbCompanyPicture.TabStop = false;
            // 
            // lblDateEndT
            // 
            lblDateEndT.AutoSize = true;
            lblDateEndT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateEndT.Location = new Point(685, 13);
            lblDateEndT.Name = "lblDateEndT";
            lblDateEndT.Size = new Size(69, 30);
            lblDateEndT.TabIndex = 0;
            lblDateEndT.Text = "Date: ";
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateEnd.Location = new Point(568, 13);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(111, 30);
            lblDateEnd.TabIndex = 0;
            lblDateEnd.Text = "Date End: ";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(310, 67);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(69, 30);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(173, 67);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(143, 30);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date Publish: ";
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameT.Location = new Point(248, 117);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(82, 30);
            lblNameT.TabIndex = 0;
            lblNameT.Text = "Name: ";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(173, 117);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(82, 30);
            lblContent.TabIndex = 0;
            lblContent.Text = "Name: ";
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFromT.Location = new Point(248, 17);
            lblFromT.Name = "lblFromT";
            lblFromT.Size = new Size(69, 30);
            lblFromT.TabIndex = 0;
            lblFromT.Text = "From:";
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblForm.Location = new Point(173, 17);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(69, 30);
            lblForm.TabIndex = 0;
            lblForm.Text = "From:";
            // 
            // UCInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCInformation";
            Size = new Size(968, 180);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lblDate;
        public Label lblContent;
        public Label lblForm;
        public Label lblDateT;
        public Label lblFromT;
        public Label lblNameT;
        private PictureBox ptbCompanyPicture;
        public Label lblDateEndT;
        public Label lblDateEnd;
        private ReaLTaiizor.Controls.CyberButton btnCompanyDetail;
    }
}

namespace WinFormProject
{
    partial class UCJob
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
            btnApplicants = new ReaLTaiizor.Controls.CyberButton();
            btnDelete = new ReaLTaiizor.Controls.CyberButton();
            btnEdit = new ReaLTaiizor.Controls.CyberButton();
            lblStatusT = new Label();
            lblEndT = new Label();
            lblDateT = new Label();
            lblStatus = new Label();
            lblEnd = new Label();
            lblJobNameT = new Label();
            lblDate = new Label();
            lblJobName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 232, 223);
            panel1.Controls.Add(btnApplicants);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Controls.Add(lblStatusT);
            panel1.Controls.Add(lblEndT);
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblStatus);
            panel1.Controls.Add(lblEnd);
            panel1.Controls.Add(lblJobNameT);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblJobName);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 5, 3, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(710, 159);
            panel1.TabIndex = 0;
            // 
            // btnApplicants
            // 
            btnApplicants.Alpha = 20;
            btnApplicants.BackColor = Color.Transparent;
            btnApplicants.Background = true;
            btnApplicants.Background_WidthPen = 4F;
            btnApplicants.BackgroundPen = true;
            btnApplicants.ColorBackground = Color.FromArgb(176, 226, 243);
            btnApplicants.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnApplicants.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnApplicants.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnApplicants.ColorLighting = Color.FromArgb(128, 128, 255);
            btnApplicants.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnApplicants.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnApplicants.Cursor = Cursors.Hand;
            btnApplicants.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnApplicants.Effect_1 = true;
            btnApplicants.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnApplicants.Effect_1_Transparency = 25;
            btnApplicants.Effect_2 = true;
            btnApplicants.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnApplicants.Effect_2_Transparency = 20;
            btnApplicants.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplicants.ForeColor = Color.FromArgb(46, 54, 71);
            btnApplicants.Lighting = true;
            btnApplicants.LinearGradient_Background = false;
            btnApplicants.LinearGradientPen = false;
            btnApplicants.Location = new Point(338, 110);
            btnApplicants.Name = "btnApplicants";
            btnApplicants.PenWidth = 15;
            btnApplicants.Rounding = true;
            btnApplicants.RoundingInt = 20;
            btnApplicants.Size = new Size(107, 42);
            btnApplicants.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnApplicants.TabIndex = 10;
            btnApplicants.Tag = "Cyber";
            btnApplicants.TextButton = "Applicants";
            btnApplicants.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnApplicants.Timer_Effect_1 = 1;
            btnApplicants.Timer_RGB = 300;
            btnApplicants.Click += btnApplicants_Click;
            // 
            // btnDelete
            // 
            btnDelete.Alpha = 20;
            btnDelete.BackColor = Color.Transparent;
            btnDelete.Background = true;
            btnDelete.Background_WidthPen = 4F;
            btnDelete.BackgroundPen = true;
            btnDelete.ColorBackground = Color.FromArgb(176, 226, 243);
            btnDelete.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnDelete.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnDelete.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnDelete.ColorLighting = Color.FromArgb(128, 128, 255);
            btnDelete.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnDelete.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnDelete.Effect_1 = true;
            btnDelete.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDelete.Effect_1_Transparency = 25;
            btnDelete.Effect_2 = true;
            btnDelete.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnDelete.Effect_2_Transparency = 20;
            btnDelete.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.FromArgb(46, 54, 71);
            btnDelete.Lighting = true;
            btnDelete.LinearGradient_Background = false;
            btnDelete.LinearGradientPen = false;
            btnDelete.Location = new Point(464, 110);
            btnDelete.Name = "btnDelete";
            btnDelete.PenWidth = 15;
            btnDelete.Rounding = true;
            btnDelete.RoundingInt = 20;
            btnDelete.Size = new Size(107, 42);
            btnDelete.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDelete.TabIndex = 10;
            btnDelete.Tag = "Cyber";
            btnDelete.TextButton = "Done";
            btnDelete.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDelete.Timer_Effect_1 = 1;
            btnDelete.Timer_RGB = 300;
            // 
            // btnEdit
            // 
            btnEdit.Alpha = 20;
            btnEdit.BackColor = Color.Transparent;
            btnEdit.Background = true;
            btnEdit.Background_WidthPen = 4F;
            btnEdit.BackgroundPen = true;
            btnEdit.ColorBackground = Color.FromArgb(176, 226, 243);
            btnEdit.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnEdit.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnEdit.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnEdit.ColorLighting = Color.FromArgb(128, 128, 255);
            btnEdit.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnEdit.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnEdit.Effect_1 = true;
            btnEdit.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnEdit.Effect_1_Transparency = 25;
            btnEdit.Effect_2 = true;
            btnEdit.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnEdit.Effect_2_Transparency = 20;
            btnEdit.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = Color.FromArgb(46, 54, 71);
            btnEdit.Lighting = true;
            btnEdit.LinearGradient_Background = false;
            btnEdit.LinearGradientPen = false;
            btnEdit.Location = new Point(586, 110);
            btnEdit.Name = "btnEdit";
            btnEdit.PenWidth = 15;
            btnEdit.Rounding = true;
            btnEdit.RoundingInt = 20;
            btnEdit.Size = new Size(107, 42);
            btnEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEdit.TabIndex = 11;
            btnEdit.Tag = "Cyber";
            btnEdit.TextButton = "Edit";
            btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEdit.Timer_Effect_1 = 1;
            btnEdit.Timer_RGB = 300;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblStatusT
            // 
            lblStatusT.AutoSize = true;
            lblStatusT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusT.Location = new Point(428, 54);
            lblStatusT.Name = "lblStatusT";
            lblStatusT.Size = new Size(66, 25);
            lblStatusT.TabIndex = 9;
            lblStatusT.Text = "Status:";
            // 
            // lblEndT
            // 
            lblEndT.AutoSize = true;
            lblEndT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndT.Location = new Point(428, 11);
            lblEndT.Name = "lblEndT";
            lblEndT.Size = new Size(92, 25);
            lblEndT.TabIndex = 9;
            lblEndT.Text = "Date End:";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(80, 54);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(55, 25);
            lblDateT.TabIndex = 9;
            lblDateT.Text = "Date:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(312, 54);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 25);
            lblStatus.TabIndex = 7;
            lblStatus.Text = "Status:";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblEnd.Location = new Point(312, 11);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(92, 25);
            lblEnd.TabIndex = 7;
            lblEnd.Text = "Date End:";
            // 
            // lblJobNameT
            // 
            lblJobNameT.AutoSize = true;
            lblJobNameT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobNameT.Location = new Point(131, 11);
            lblJobNameT.Name = "lblJobNameT";
            lblJobNameT.Size = new Size(100, 25);
            lblJobNameT.TabIndex = 8;
            lblJobNameT.Text = "Job Name:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(15, 54);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(55, 25);
            lblDate.TabIndex = 7;
            lblDate.Text = "Date:";
            // 
            // lblJobName
            // 
            lblJobName.AutoSize = true;
            lblJobName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobName.Location = new Point(15, 11);
            lblJobName.Name = "lblJobName";
            lblJobName.Size = new Size(100, 25);
            lblJobName.TabIndex = 6;
            lblJobName.Text = "Job Name:";
            // 
            // UCJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCJob";
            Size = new Size(710, 159);
            Load += UCJob_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lblJobName;
        public Label lblDateT;
        public Label lblJobNameT;
        private Label lblDate;
        private ReaLTaiizor.Controls.CyberButton btnDelete;
        private ReaLTaiizor.Controls.CyberButton btnEdit;
        private ReaLTaiizor.Controls.CyberButton btnApplicants;
        public Label lblEndT;
        private Label lblEnd;
        public Label lblStatusT;
        private Label lblStatus;
    }
}

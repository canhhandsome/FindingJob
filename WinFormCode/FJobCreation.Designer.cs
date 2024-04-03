namespace WinFormProject
{
    partial class FJobCreation
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
            lblJobName = new Label();
            lblExperience = new Label();
            lblSalary = new Label();
            txtJobName = new ReaLTaiizor.Controls.HopeTextBox();
            txtSalary = new ReaLTaiizor.Controls.HopeTextBox();
            lblTitle = new Label();
            pnBody = new Panel();
            lblDateEnd = new Label();
            dtpDateEnd = new DateTimePicker();
            cbbExperience = new ComboBox();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnPostJob = new ReaLTaiizor.Controls.CyberButton();
            tabpage = new TabControl();
            tbprequirement = new TabPage();
            rtxtjobrequirement = new RichTextBox();
            tbpdescription = new TabPage();
            rtxtdescription = new RichTextBox();
            tbpbenefit = new TabPage();
            rtxtBenefit = new RichTextBox();
            pnBody.SuspendLayout();
            tabpage.SuspendLayout();
            tbprequirement.SuspendLayout();
            tbpdescription.SuspendLayout();
            tbpbenefit.SuspendLayout();
            SuspendLayout();
            // 
            // lblJobName
            // 
            lblJobName.AutoSize = true;
            lblJobName.BackColor = Color.White;
            lblJobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobName.ForeColor = SystemColors.ControlText;
            lblJobName.Location = new Point(10, 69);
            lblJobName.Name = "lblJobName";
            lblJobName.Size = new Size(91, 21);
            lblJobName.TabIndex = 0;
            lblJobName.Text = "Job's Name";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.BackColor = Color.White;
            lblExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExperience.ForeColor = SystemColors.ControlText;
            lblExperience.Location = new Point(10, 104);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(143, 21);
            lblExperience.TabIndex = 0;
            lblExperience.Text = "Experience to Work";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = Color.White;
            lblSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = SystemColors.ControlText;
            lblSalary.Location = new Point(13, 144);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(53, 21);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "Salary";
            // 
            // txtJobName
            // 
            txtJobName.BackColor = Color.FromArgb(248, 212, 187);
            txtJobName.BaseColor = Color.FromArgb(44, 55, 66);
            txtJobName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtJobName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtJobName.Cursor = Cursors.IBeam;
            txtJobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJobName.ForeColor = Color.FromArgb(48, 49, 51);
            txtJobName.Hint = "Enter job's name";
            txtJobName.Location = new Point(273, 58);
            txtJobName.Margin = new Padding(3, 2, 3, 2);
            txtJobName.MaxLength = 32767;
            txtJobName.Multiline = false;
            txtJobName.Name = "txtJobName";
            txtJobName.PasswordChar = '\0';
            txtJobName.ScrollBars = ScrollBars.None;
            txtJobName.SelectedText = "";
            txtJobName.SelectionLength = 0;
            txtJobName.SelectionStart = 0;
            txtJobName.Size = new Size(389, 38);
            txtJobName.TabIndex = 11;
            txtJobName.TabStop = false;
            txtJobName.UseSystemPasswordChar = false;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.FromArgb(248, 212, 187);
            txtSalary.BaseColor = Color.FromArgb(44, 55, 66);
            txtSalary.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSalary.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSalary.Cursor = Cursors.IBeam;
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.ForeColor = Color.FromArgb(48, 49, 51);
            txtSalary.Hint = "Enter Salary";
            txtSalary.Location = new Point(273, 139);
            txtSalary.Margin = new Padding(3, 2, 3, 2);
            txtSalary.MaxLength = 32767;
            txtSalary.Multiline = false;
            txtSalary.Name = "txtSalary";
            txtSalary.PasswordChar = '\0';
            txtSalary.ScrollBars = ScrollBars.None;
            txtSalary.SelectedText = "";
            txtSalary.SelectionLength = 0;
            txtSalary.SelectionStart = 0;
            txtSalary.Size = new Size(389, 38);
            txtSalary.TabIndex = 13;
            txtSalary.TabStop = false;
            txtSalary.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.White;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(376, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 28);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Adding a new Job";
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(lblDateEnd);
            pnBody.Controls.Add(dtpDateEnd);
            pnBody.Controls.Add(cbbExperience);
            pnBody.Controls.Add(btnCancel);
            pnBody.Controls.Add(btnPostJob);
            pnBody.Controls.Add(tabpage);
            pnBody.Controls.Add(lblJobName);
            pnBody.Controls.Add(txtJobName);
            pnBody.Controls.Add(lblExperience);
            pnBody.Controls.Add(lblSalary);
            pnBody.Controls.Add(txtSalary);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(917, 450);
            pnBody.TabIndex = 17;
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.BackColor = Color.White;
            lblDateEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateEnd.ForeColor = SystemColors.ControlText;
            lblDateEnd.Location = new Point(10, 189);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(72, 21);
            lblDateEnd.TabIndex = 32;
            lblDateEnd.Text = "Date End";
            // 
            // dtpDateEnd
            // 
            dtpDateEnd.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateEnd.CalendarMonthBackground = Color.White;
            dtpDateEnd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpDateEnd.Location = new Point(273, 185);
            dtpDateEnd.Margin = new Padding(3, 2, 3, 2);
            dtpDateEnd.Name = "dtpDateEnd";
            dtpDateEnd.Size = new Size(392, 29);
            dtpDateEnd.TabIndex = 33;
            // 
            // cbbExperience
            // 
            cbbExperience.BackColor = Color.FromArgb(248, 212, 187);
            cbbExperience.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            cbbExperience.FormattingEnabled = true;
            cbbExperience.Items.AddRange(new object[] { "Intern", "Fresher", "Junior", "Middle", "Senior", "Expert" });
            cbbExperience.Location = new Point(273, 101);
            cbbExperience.Margin = new Padding(3, 2, 3, 2);
            cbbExperience.Name = "cbbExperience";
            cbbExperience.Size = new Size(390, 29);
            cbbExperience.TabIndex = 31;
            // 
            // btnCancel
            // 
            btnCancel.Alpha = 20;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Background = true;
            btnCancel.Background_WidthPen = 4F;
            btnCancel.BackgroundPen = true;
            btnCancel.ColorBackground = Color.FromArgb(176, 226, 243);
            btnCancel.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnCancel.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnCancel.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnCancel.ColorLighting = Color.FromArgb(128, 128, 255);
            btnCancel.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnCancel.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCancel.Effect_1 = true;
            btnCancel.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCancel.Effect_1_Transparency = 25;
            btnCancel.Effect_2 = true;
            btnCancel.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCancel.Effect_2_Transparency = 20;
            btnCancel.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = Color.FromArgb(46, 54, 71);
            btnCancel.Lighting = true;
            btnCancel.LinearGradient_Background = false;
            btnCancel.LinearGradientPen = false;
            btnCancel.Location = new Point(767, 395);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(131, 42);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 28;
            btnCancel.Tag = "Decline";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnPostJob
            // 
            btnPostJob.Alpha = 20;
            btnPostJob.BackColor = Color.Transparent;
            btnPostJob.Background = true;
            btnPostJob.Background_WidthPen = 4F;
            btnPostJob.BackgroundPen = true;
            btnPostJob.ColorBackground = Color.FromArgb(176, 226, 243);
            btnPostJob.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnPostJob.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnPostJob.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnPostJob.ColorLighting = Color.FromArgb(128, 128, 255);
            btnPostJob.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnPostJob.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnPostJob.Cursor = Cursors.Hand;
            btnPostJob.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnPostJob.Effect_1 = true;
            btnPostJob.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnPostJob.Effect_1_Transparency = 25;
            btnPostJob.Effect_2 = true;
            btnPostJob.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnPostJob.Effect_2_Transparency = 20;
            btnPostJob.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostJob.ForeColor = Color.FromArgb(46, 54, 71);
            btnPostJob.Lighting = true;
            btnPostJob.LinearGradient_Background = false;
            btnPostJob.LinearGradientPen = false;
            btnPostJob.Location = new Point(631, 395);
            btnPostJob.Name = "btnPostJob";
            btnPostJob.PenWidth = 15;
            btnPostJob.Rounding = true;
            btnPostJob.RoundingInt = 20;
            btnPostJob.Size = new Size(131, 42);
            btnPostJob.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnPostJob.TabIndex = 27;
            btnPostJob.Tag = "Decline";
            btnPostJob.TextButton = "Post Job";
            btnPostJob.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnPostJob.Timer_Effect_1 = 5;
            btnPostJob.Timer_RGB = 300;
            btnPostJob.Click += btnPostJob_Click;
            // 
            // tabpage
            // 
            tabpage.Controls.Add(tbprequirement);
            tabpage.Controls.Add(tbpdescription);
            tabpage.Controls.Add(tbpbenefit);
            tabpage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabpage.Location = new Point(12, 242);
            tabpage.Margin = new Padding(3, 2, 3, 2);
            tabpage.Name = "tabpage";
            tabpage.SelectedIndex = 0;
            tabpage.Size = new Size(894, 148);
            tabpage.TabIndex = 17;
            // 
            // tbprequirement
            // 
            tbprequirement.AutoScroll = true;
            tbprequirement.BackColor = Color.Transparent;
            tbprequirement.BorderStyle = BorderStyle.Fixed3D;
            tbprequirement.Controls.Add(rtxtjobrequirement);
            tbprequirement.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbprequirement.Location = new Point(4, 30);
            tbprequirement.Margin = new Padding(3, 2, 3, 2);
            tbprequirement.Name = "tbprequirement";
            tbprequirement.Padding = new Padding(3, 2, 3, 2);
            tbprequirement.Size = new Size(886, 114);
            tbprequirement.TabIndex = 0;
            tbprequirement.Text = "Job's Requirement";
            // 
            // rtxtjobrequirement
            // 
            rtxtjobrequirement.BackColor = Color.FromArgb(248, 212, 187);
            rtxtjobrequirement.BorderStyle = BorderStyle.None;
            rtxtjobrequirement.Dock = DockStyle.Fill;
            rtxtjobrequirement.Location = new Point(3, 2);
            rtxtjobrequirement.Margin = new Padding(3, 2, 3, 2);
            rtxtjobrequirement.Name = "rtxtjobrequirement";
            rtxtjobrequirement.Size = new Size(876, 106);
            rtxtjobrequirement.TabIndex = 1;
            rtxtjobrequirement.Text = "";
            // 
            // tbpdescription
            // 
            tbpdescription.AutoScroll = true;
            tbpdescription.BorderStyle = BorderStyle.Fixed3D;
            tbpdescription.Controls.Add(rtxtdescription);
            tbpdescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbpdescription.Location = new Point(4, 30);
            tbpdescription.Margin = new Padding(3, 2, 3, 2);
            tbpdescription.Name = "tbpdescription";
            tbpdescription.Padding = new Padding(3, 2, 3, 2);
            tbpdescription.Size = new Size(886, 114);
            tbpdescription.TabIndex = 1;
            tbpdescription.Text = "Job's Description";
            tbpdescription.UseVisualStyleBackColor = true;
            // 
            // rtxtdescription
            // 
            rtxtdescription.BackColor = Color.FromArgb(248, 212, 187);
            rtxtdescription.BorderStyle = BorderStyle.None;
            rtxtdescription.Dock = DockStyle.Fill;
            rtxtdescription.Location = new Point(3, 2);
            rtxtdescription.Margin = new Padding(3, 2, 3, 2);
            rtxtdescription.Name = "rtxtdescription";
            rtxtdescription.Size = new Size(876, 106);
            rtxtdescription.TabIndex = 0;
            rtxtdescription.Text = "";
            // 
            // tbpbenefit
            // 
            tbpbenefit.AutoScroll = true;
            tbpbenefit.BackColor = Color.Transparent;
            tbpbenefit.BorderStyle = BorderStyle.Fixed3D;
            tbpbenefit.Controls.Add(rtxtBenefit);
            tbpbenefit.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbpbenefit.Location = new Point(4, 30);
            tbpbenefit.Margin = new Padding(3, 2, 3, 2);
            tbpbenefit.Name = "tbpbenefit";
            tbpbenefit.Padding = new Padding(3, 2, 3, 2);
            tbpbenefit.Size = new Size(886, 114);
            tbpbenefit.TabIndex = 2;
            tbpbenefit.Text = "Benefit";
            // 
            // rtxtBenefit
            // 
            rtxtBenefit.BackColor = Color.FromArgb(248, 212, 187);
            rtxtBenefit.BorderStyle = BorderStyle.None;
            rtxtBenefit.Dock = DockStyle.Fill;
            rtxtBenefit.Location = new Point(3, 2);
            rtxtBenefit.Margin = new Padding(3, 2, 3, 2);
            rtxtBenefit.Name = "rtxtBenefit";
            rtxtBenefit.Size = new Size(876, 106);
            rtxtBenefit.TabIndex = 0;
            rtxtBenefit.Text = "";
            // 
            // FJobCreation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(917, 450);
            Controls.Add(lblTitle);
            Controls.Add(pnBody);
            Name = "FJobCreation";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobCreation";
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            tabpage.ResumeLayout(false);
            tbprequirement.ResumeLayout(false);
            tbpdescription.ResumeLayout(false);
            tbpbenefit.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJobName;
        private Label lblExperience;
        private Label lblSalary;
        private ReaLTaiizor.Controls.HopeTextBox txtJobName;
        private ReaLTaiizor.Controls.HopeTextBox txtSalary;
        private Label lblTitle;
        private Panel pnBody;
        private TabControl tabpage;
        private TabPage tbprequirement;
        private TabPage tbpdescription;
        private RichTextBox rtxtjobrequirement;
        private RichTextBox rtxtdescription;
        private TabPage tbpbenefit;
        private RichTextBox rtxtBenefit;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnPostJob;
        private ComboBox cbbExperience;
        private Label lblDateEnd;
        private DateTimePicker dtpDateEnd;
    }
}
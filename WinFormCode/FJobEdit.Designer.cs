namespace WinFormProject
{
    partial class FJobEdit
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
            this.lblJobName = new System.Windows.Forms.Label();
            this.txtJobName = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtSalary = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.cbbExperience = new System.Windows.Forms.ComboBox();
            this.btnCancel = new ReaLTaiizor.Controls.CyberButton();
            this.btnSave = new ReaLTaiizor.Controls.CyberButton();
            this.tabpage = new System.Windows.Forms.TabControl();
            this.tbprequirement = new System.Windows.Forms.TabPage();
            this.rtxtjobrequirement = new System.Windows.Forms.RichTextBox();
            this.tbpdescription = new System.Windows.Forms.TabPage();
            this.rtxtdescription = new System.Windows.Forms.RichTextBox();
            this.tbpbenefit = new System.Windows.Forms.TabPage();
            this.rtxtbenefit = new System.Windows.Forms.RichTextBox();
            this.lblDateEnd = new System.Windows.Forms.Label();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.pnBody.SuspendLayout();
            this.tabpage.SuspendLayout();
            this.tbprequirement.SuspendLayout();
            this.tbpdescription.SuspendLayout();
            this.tbpbenefit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.BackColor = System.Drawing.Color.White;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJobName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJobName.Location = new System.Drawing.Point(12, 92);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(113, 28);
            this.lblJobName.TabIndex = 0;
            this.lblJobName.Text = "Job\'s Name";
            // 
            // txtJobName
            // 
            this.txtJobName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.txtJobName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtJobName.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtJobName.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtJobName.Hint = "Enter job\'s name";
            this.txtJobName.Location = new System.Drawing.Point(220, 77);
            this.txtJobName.MaxLength = 32767;
            this.txtJobName.Multiline = false;
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJobName.SelectedText = "";
            this.txtJobName.SelectionLength = 0;
            this.txtJobName.SelectionStart = 0;
            this.txtJobName.Size = new System.Drawing.Size(445, 43);
            this.txtJobName.TabIndex = 11;
            this.txtJobName.TabStop = false;
            this.txtJobName.UseSystemPasswordChar = false;
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.Color.White;
            this.lblExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExperience.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExperience.Location = new System.Drawing.Point(12, 146);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(181, 28);
            this.lblExperience.TabIndex = 0;
            this.lblExperience.Text = "Experience to Work";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.White;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalary.Location = new System.Drawing.Point(12, 201);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(65, 28);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Salary";
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.txtSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtSalary.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtSalary.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSalary.Hint = "Enter Salary";
            this.txtSalary.Location = new System.Drawing.Point(220, 186);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Multiline = false;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.Size = new System.Drawing.Size(445, 43);
            this.txtSalary.TabIndex = 13;
            this.txtSalary.TabStop = false;
            this.txtSalary.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(475, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(103, 35);
            this.lblTitle.TabIndex = 18;
            this.lblTitle.Text = "Edit Job";
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.dtpDateEnd);
            this.pnBody.Controls.Add(this.cbbExperience);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.btnSave);
            this.pnBody.Controls.Add(this.lblTitle);
            this.pnBody.Controls.Add(this.tabpage);
            this.pnBody.Controls.Add(this.lblDateEnd);
            this.pnBody.Controls.Add(this.lblJobName);
            this.pnBody.Controls.Add(this.txtJobName);
            this.pnBody.Controls.Add(this.lblExperience);
            this.pnBody.Controls.Add(this.lblSalary);
            this.pnBody.Controls.Add(this.txtSalary);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 600);
            this.pnBody.TabIndex = 19;
            // 
            // cbbExperience
            // 
            this.cbbExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.cbbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbExperience.FormattingEnabled = true;
            this.cbbExperience.Items.AddRange(new object[] {
            "Intern",
            "Fresher",
            "Junior",
            "Middle",
            "Senior",
            "Expert"});
            this.cbbExperience.Location = new System.Drawing.Point(220, 138);
            this.cbbExperience.Name = "cbbExperience";
            this.cbbExperience.Size = new System.Drawing.Size(445, 36);
            this.cbbExperience.TabIndex = 30;
            // 
            // btnCancel
            // 
            this.btnCancel.Alpha = 20;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Background = true;
            this.btnCancel.Background_WidthPen = 4F;
            this.btnCancel.BackgroundPen = true;
            this.btnCancel.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnCancel.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnCancel.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnCancel.Effect_1 = true;
            this.btnCancel.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Effect_1_Transparency = 25;
            this.btnCancel.Effect_2 = true;
            this.btnCancel.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCancel.Effect_2_Transparency = 20;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnCancel.Lighting = true;
            this.btnCancel.LinearGradient_Background = false;
            this.btnCancel.LinearGradientPen = false;
            this.btnCancel.Location = new System.Drawing.Point(867, 527);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PenWidth = 15;
            this.btnCancel.Rounding = true;
            this.btnCancel.RoundingInt = 20;
            this.btnCancel.Size = new System.Drawing.Size(150, 56);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 29;
            this.btnCancel.Tag = "Decline";
            this.btnCancel.TextButton = "Cancel";
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Timer_Effect_1 = 5;
            this.btnCancel.Timer_RGB = 300;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Alpha = 20;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.Background = true;
            this.btnSave.Background_WidthPen = 4F;
            this.btnSave.BackgroundPen = true;
            this.btnSave.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnSave.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnSave.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnSave.Effect_1 = true;
            this.btnSave.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Effect_1_Transparency = 25;
            this.btnSave.Effect_2 = true;
            this.btnSave.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSave.Effect_2_Transparency = 20;
            this.btnSave.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnSave.Lighting = true;
            this.btnSave.LinearGradient_Background = false;
            this.btnSave.LinearGradientPen = false;
            this.btnSave.Location = new System.Drawing.Point(711, 527);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.PenWidth = 15;
            this.btnSave.Rounding = true;
            this.btnSave.RoundingInt = 20;
            this.btnSave.Size = new System.Drawing.Size(150, 56);
            this.btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 28;
            this.btnSave.Tag = "Decline";
            this.btnSave.TextButton = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Timer_Effect_1 = 5;
            this.btnSave.Timer_RGB = 300;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabpage
            // 
            this.tabpage.Controls.Add(this.tbprequirement);
            this.tabpage.Controls.Add(this.tbpdescription);
            this.tabpage.Controls.Add(this.tbpbenefit);
            this.tabpage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabpage.Location = new System.Drawing.Point(14, 312);
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Size = new System.Drawing.Size(1022, 208);
            this.tabpage.TabIndex = 17;
            // 
            // tbprequirement
            // 
            this.tbprequirement.AutoScroll = true;
            this.tbprequirement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbprequirement.Controls.Add(this.rtxtjobrequirement);
            this.tbprequirement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbprequirement.Location = new System.Drawing.Point(4, 37);
            this.tbprequirement.Name = "tbprequirement";
            this.tbprequirement.Padding = new System.Windows.Forms.Padding(3);
            this.tbprequirement.Size = new System.Drawing.Size(1014, 167);
            this.tbprequirement.TabIndex = 0;
            this.tbprequirement.Text = "Job\'s Requirement";
            this.tbprequirement.UseVisualStyleBackColor = true;
            // 
            // rtxtjobrequirement
            // 
            this.rtxtjobrequirement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.rtxtjobrequirement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtjobrequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtjobrequirement.Location = new System.Drawing.Point(3, 3);
            this.rtxtjobrequirement.Name = "rtxtjobrequirement";
            this.rtxtjobrequirement.Size = new System.Drawing.Size(1004, 157);
            this.rtxtjobrequirement.TabIndex = 0;
            this.rtxtjobrequirement.Text = "";
            // 
            // tbpdescription
            // 
            this.tbpdescription.AutoScroll = true;
            this.tbpdescription.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpdescription.Controls.Add(this.rtxtdescription);
            this.tbpdescription.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpdescription.Location = new System.Drawing.Point(4, 37);
            this.tbpdescription.Name = "tbpdescription";
            this.tbpdescription.Padding = new System.Windows.Forms.Padding(3);
            this.tbpdescription.Size = new System.Drawing.Size(1014, 209);
            this.tbpdescription.TabIndex = 1;
            this.tbpdescription.Text = "Job\'s Description";
            this.tbpdescription.UseVisualStyleBackColor = true;
            // 
            // rtxtdescription
            // 
            this.rtxtdescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.rtxtdescription.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtdescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtdescription.Location = new System.Drawing.Point(3, 3);
            this.rtxtdescription.Name = "rtxtdescription";
            this.rtxtdescription.Size = new System.Drawing.Size(1004, 199);
            this.rtxtdescription.TabIndex = 0;
            this.rtxtdescription.Text = "";
            // 
            // tbpbenefit
            // 
            this.tbpbenefit.AutoScroll = true;
            this.tbpbenefit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpbenefit.Controls.Add(this.rtxtbenefit);
            this.tbpbenefit.Location = new System.Drawing.Point(4, 37);
            this.tbpbenefit.Name = "tbpbenefit";
            this.tbpbenefit.Padding = new System.Windows.Forms.Padding(3);
            this.tbpbenefit.Size = new System.Drawing.Size(1014, 209);
            this.tbpbenefit.TabIndex = 2;
            this.tbpbenefit.Text = "Benefit";
            this.tbpbenefit.UseVisualStyleBackColor = true;
            // 
            // rtxtbenefit
            // 
            this.rtxtbenefit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.rtxtbenefit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtbenefit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtbenefit.Location = new System.Drawing.Point(3, 3);
            this.rtxtbenefit.Name = "rtxtbenefit";
            this.rtxtbenefit.Size = new System.Drawing.Size(1004, 199);
            this.rtxtbenefit.TabIndex = 0;
            this.rtxtbenefit.Text = "";
            // 
            // lblDateEnd
            // 
            this.lblDateEnd.AutoSize = true;
            this.lblDateEnd.BackColor = System.Drawing.Color.White;
            this.lblDateEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateEnd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDateEnd.Location = new System.Drawing.Point(12, 256);
            this.lblDateEnd.Name = "lblDateEnd";
            this.lblDateEnd.Size = new System.Drawing.Size(91, 28);
            this.lblDateEnd.TabIndex = 0;
            this.lblDateEnd.Text = "Date End";
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDateEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateEnd.Location = new System.Drawing.Point(218, 251);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(447, 34);
            this.dtpDateEnd.TabIndex = 31;
            // 
            // FJobEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.pnBody);
            this.Name = "FJobEdit";
            this.Text = "FJobEdit";
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.tabpage.ResumeLayout(false);
            this.tbprequirement.ResumeLayout(false);
            this.tbpdescription.ResumeLayout(false);
            this.tbpbenefit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label lblJobName;
        private ReaLTaiizor.Controls.HopeTextBox txtJobName;
        private Label lblExperience;
        private Label lblSalary;
        private ReaLTaiizor.Controls.HopeTextBox txtSalary;
        private Label lblTitle;
        private Panel pnBody;
        private TabControl tabpage;
        private TabPage tbprequirement;
        private TabPage tbpdescription;
        private RichTextBox rtxtjobrequirement;
        private RichTextBox rtxtdescription;
        private TabPage tbpbenefit;
        private RichTextBox rtxtbenefit;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnSave;
        private ComboBox cbbExperience;
        private Label lblDateEnd;
        private DateTimePicker dtpDateEnd;
    }
}
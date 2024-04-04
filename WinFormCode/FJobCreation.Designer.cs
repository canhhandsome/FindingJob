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
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.dtpDateEnd = new System.Windows.Forms.DateTimePicker();
            this.btnCancel = new ReaLTaiizor.Controls.CyberButton();
            this.btnPostJob = new ReaLTaiizor.Controls.CyberButton();
            this.tabpage = new System.Windows.Forms.TabControl();
            this.tbprequirement = new System.Windows.Forms.TabPage();
            this.rtxtjobrequirement = new System.Windows.Forms.RichTextBox();
            this.tbpdescription = new System.Windows.Forms.TabPage();
            this.rtxtdescription = new System.Windows.Forms.RichTextBox();
            this.tbpbenefit = new System.Windows.Forms.TabPage();
            this.rtxtBenefit = new System.Windows.Forms.RichTextBox();
            this.txtJobName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtSalary = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cbbExperience = new ReaLTaiizor.Controls.MaterialComboBox();
            this.pnBody.SuspendLayout();
            this.tabpage.SuspendLayout();
            this.tbprequirement.SuspendLayout();
            this.tbpdescription.SuspendLayout();
            this.tbpbenefit.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(419, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 38);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Adding a new Job";
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.cbbExperience);
            this.pnBody.Controls.Add(this.txtSalary);
            this.pnBody.Controls.Add(this.txtJobName);
            this.pnBody.Controls.Add(this.lblTitle);
            this.pnBody.Controls.Add(this.dtpDateEnd);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.btnPostJob);
            this.pnBody.Controls.Add(this.tabpage);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 859);
            this.pnBody.TabIndex = 17;
            // 
            // dtpDateEnd
            // 
            this.dtpDateEnd.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateEnd.CalendarMonthBackground = System.Drawing.Color.White;
            this.dtpDateEnd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDateEnd.Location = new System.Drawing.Point(47, 296);
            this.dtpDateEnd.Name = "dtpDateEnd";
            this.dtpDateEnd.Size = new System.Drawing.Size(342, 34);
            this.dtpDateEnd.TabIndex = 33;
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
            this.btnCancel.Location = new System.Drawing.Point(886, 790);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PenWidth = 15;
            this.btnCancel.Rounding = true;
            this.btnCancel.RoundingInt = 20;
            this.btnCancel.Size = new System.Drawing.Size(150, 56);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 28;
            this.btnCancel.Tag = "Decline";
            this.btnCancel.TextButton = "Cancel";
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Timer_Effect_1 = 5;
            this.btnCancel.Timer_RGB = 300;
            // 
            // btnPostJob
            // 
            this.btnPostJob.Alpha = 20;
            this.btnPostJob.BackColor = System.Drawing.Color.Transparent;
            this.btnPostJob.Background = true;
            this.btnPostJob.Background_WidthPen = 4F;
            this.btnPostJob.BackgroundPen = true;
            this.btnPostJob.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnPostJob.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnPostJob.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostJob.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnPostJob.Effect_1 = true;
            this.btnPostJob.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.Effect_1_Transparency = 25;
            this.btnPostJob.Effect_2 = true;
            this.btnPostJob.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPostJob.Effect_2_Transparency = 20;
            this.btnPostJob.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnPostJob.Lighting = true;
            this.btnPostJob.LinearGradient_Background = false;
            this.btnPostJob.LinearGradientPen = false;
            this.btnPostJob.Location = new System.Drawing.Point(730, 790);
            this.btnPostJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.PenWidth = 15;
            this.btnPostJob.Rounding = true;
            this.btnPostJob.RoundingInt = 20;
            this.btnPostJob.Size = new System.Drawing.Size(150, 56);
            this.btnPostJob.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPostJob.TabIndex = 27;
            this.btnPostJob.Tag = "Decline";
            this.btnPostJob.TextButton = "Post Job";
            this.btnPostJob.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnPostJob.Timer_Effect_1 = 5;
            this.btnPostJob.Timer_RGB = 300;
            // 
            // tabpage
            // 
            this.tabpage.Controls.Add(this.tbprequirement);
            this.tabpage.Controls.Add(this.tbpdescription);
            this.tabpage.Controls.Add(this.tbpbenefit);
            this.tabpage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabpage.Location = new System.Drawing.Point(14, 476);
            this.tabpage.Name = "tabpage";
            this.tabpage.SelectedIndex = 0;
            this.tabpage.Size = new System.Drawing.Size(1022, 290);
            this.tabpage.TabIndex = 17;
            // 
            // tbprequirement
            // 
            this.tbprequirement.AutoScroll = true;
            this.tbprequirement.BackColor = System.Drawing.Color.Transparent;
            this.tbprequirement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbprequirement.Controls.Add(this.rtxtjobrequirement);
            this.tbprequirement.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbprequirement.Location = new System.Drawing.Point(4, 37);
            this.tbprequirement.Name = "tbprequirement";
            this.tbprequirement.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbprequirement.Size = new System.Drawing.Size(1014, 249);
            this.tbprequirement.TabIndex = 0;
            this.tbprequirement.Text = "Job\'s Requirement";
            // 
            // rtxtjobrequirement
            // 
            this.rtxtjobrequirement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.rtxtjobrequirement.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtjobrequirement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtjobrequirement.Location = new System.Drawing.Point(3, 3);
            this.rtxtjobrequirement.Name = "rtxtjobrequirement";
            this.rtxtjobrequirement.Size = new System.Drawing.Size(1004, 239);
            this.rtxtjobrequirement.TabIndex = 1;
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
            this.tbpdescription.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpdescription.Size = new System.Drawing.Size(1014, 249);
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
            this.rtxtdescription.Size = new System.Drawing.Size(1004, 239);
            this.rtxtdescription.TabIndex = 0;
            this.rtxtdescription.Text = "";
            // 
            // tbpbenefit
            // 
            this.tbpbenefit.AutoScroll = true;
            this.tbpbenefit.BackColor = System.Drawing.Color.Transparent;
            this.tbpbenefit.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tbpbenefit.Controls.Add(this.rtxtBenefit);
            this.tbpbenefit.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbpbenefit.Location = new System.Drawing.Point(4, 37);
            this.tbpbenefit.Name = "tbpbenefit";
            this.tbpbenefit.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tbpbenefit.Size = new System.Drawing.Size(1014, 249);
            this.tbpbenefit.TabIndex = 2;
            this.tbpbenefit.Text = "Benefit";
            // 
            // rtxtBenefit
            // 
            this.rtxtBenefit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.rtxtBenefit.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxtBenefit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxtBenefit.Location = new System.Drawing.Point(3, 3);
            this.rtxtBenefit.Name = "rtxtBenefit";
            this.rtxtBenefit.Size = new System.Drawing.Size(1004, 239);
            this.rtxtBenefit.TabIndex = 0;
            this.rtxtBenefit.Text = "";
            // 
            // txtJobName
            // 
            this.txtJobName.AllowPromptAsInput = true;
            this.txtJobName.AnimateReadOnly = false;
            this.txtJobName.AsciiOnly = false;
            this.txtJobName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtJobName.BeepOnError = false;
            this.txtJobName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtJobName.Depth = 0;
            this.txtJobName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtJobName.HidePromptOnLeave = false;
            this.txtJobName.HideSelection = true;
            this.txtJobName.Hint = "Job Name";
            this.txtJobName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtJobName.LeadingIcon = null;
            this.txtJobName.Location = new System.Drawing.Point(47, 97);
            this.txtJobName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJobName.Mask = "";
            this.txtJobName.MaxLength = 32767;
            this.txtJobName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.PrefixSuffixText = null;
            this.txtJobName.PromptChar = '_';
            this.txtJobName.ReadOnly = false;
            this.txtJobName.RejectInputOnFirstFailure = false;
            this.txtJobName.ResetOnPrompt = true;
            this.txtJobName.ResetOnSpace = true;
            this.txtJobName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtJobName.SelectedText = "";
            this.txtJobName.SelectionLength = 0;
            this.txtJobName.SelectionStart = 0;
            this.txtJobName.ShortcutsEnabled = true;
            this.txtJobName.Size = new System.Drawing.Size(342, 48);
            this.txtJobName.SkipLiterals = true;
            this.txtJobName.TabIndex = 39;
            this.txtJobName.TabStop = false;
            this.txtJobName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtJobName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtJobName.TrailingIcon = null;
            this.txtJobName.UseSystemPasswordChar = false;
            this.txtJobName.ValidatingType = null;
            // 
            // txtSalary
            // 
            this.txtSalary.AllowPromptAsInput = true;
            this.txtSalary.AnimateReadOnly = false;
            this.txtSalary.AsciiOnly = false;
            this.txtSalary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSalary.BeepOnError = false;
            this.txtSalary.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSalary.Depth = 0;
            this.txtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSalary.HidePromptOnLeave = false;
            this.txtSalary.HideSelection = true;
            this.txtSalary.Hint = "Salary";
            this.txtSalary.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtSalary.LeadingIcon = null;
            this.txtSalary.Location = new System.Drawing.Point(47, 230);
            this.txtSalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSalary.Mask = "";
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.PrefixSuffixText = null;
            this.txtSalary.PromptChar = '_';
            this.txtSalary.ReadOnly = false;
            this.txtSalary.RejectInputOnFirstFailure = false;
            this.txtSalary.ResetOnPrompt = true;
            this.txtSalary.ResetOnSpace = true;
            this.txtSalary.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.ShortcutsEnabled = true;
            this.txtSalary.Size = new System.Drawing.Size(342, 48);
            this.txtSalary.SkipLiterals = true;
            this.txtSalary.TabIndex = 40;
            this.txtSalary.TabStop = false;
            this.txtSalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSalary.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtSalary.TrailingIcon = null;
            this.txtSalary.UseSystemPasswordChar = false;
            this.txtSalary.ValidatingType = null;
            // 
            // cbbExperience
            // 
            this.cbbExperience.AutoResize = false;
            this.cbbExperience.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbExperience.Depth = 0;
            this.cbbExperience.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbExperience.DropDownHeight = 174;
            this.cbbExperience.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbExperience.DropDownWidth = 121;
            this.cbbExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbExperience.FormattingEnabled = true;
            this.cbbExperience.Hint = "Experience";
            this.cbbExperience.IntegralHeight = false;
            this.cbbExperience.ItemHeight = 43;
            this.cbbExperience.Items.AddRange(new object[] {
            "Intern",
            "Fresher",
            "Junior",
            "Senior"});
            this.cbbExperience.Location = new System.Drawing.Point(47, 163);
            this.cbbExperience.MaxDropDownItems = 4;
            this.cbbExperience.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbExperience.Name = "cbbExperience";
            this.cbbExperience.Size = new System.Drawing.Size(342, 49);
            this.cbbExperience.StartIndex = 0;
            this.cbbExperience.TabIndex = 59;
            // 
            // FJobCreation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1048, 859);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FJobCreation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJobCreation";
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.tabpage.ResumeLayout(false);
            this.tbprequirement.ResumeLayout(false);
            this.tbpdescription.ResumeLayout(false);
            this.tbpbenefit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
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
        private DateTimePicker dtpDateEnd;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtSalary;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtJobName;
        private ReaLTaiizor.Controls.MaterialComboBox cbbExperience;
    }
}
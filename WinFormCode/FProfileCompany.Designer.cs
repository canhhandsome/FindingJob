namespace WinFormProject
{
    partial class FProfileCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProfileCompany));
            this.txtDetail = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.txtCompanyName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtPhoneNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtCompanyType = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtCompanySize = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.btnChoosePicture = new ReaLTaiizor.Controls.CyberButton();
            this.btnSave = new ReaLTaiizor.Controls.CyberButton();
            this.btnCancel = new ReaLTaiizor.Controls.CyberButton();
            this.btnEdit = new ReaLTaiizor.Controls.CyberButton();
            this.lblWorkingTime = new System.Windows.Forms.Label();
            this.txtTaxIdentification = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.cbbWTB = new ReaLTaiizor.Controls.MaterialComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbWTEnd = new ReaLTaiizor.Controls.MaterialComboBox();
            this.txtWebsiteLink = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.btnChooseLicense = new ReaLTaiizor.Controls.CyberButton();
            this.ptbLicense = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLicense)).BeginInit();
            this.SuspendLayout();
            // 
            // txtDetail
            // 
            this.txtDetail.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtDetail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDetail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtDetail.Hint = "Details";
            this.txtDetail.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtDetail.Location = new System.Drawing.Point(26, 384);
            this.txtDetail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDetail.MaxLength = 32767;
            this.txtDetail.Multiline = true;
            this.txtDetail.Name = "txtDetail";
            this.txtDetail.PasswordChar = '\0';
            this.txtDetail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDetail.SelectedText = "";
            this.txtDetail.SelectionLength = 0;
            this.txtDetail.SelectionStart = 0;
            this.txtDetail.Size = new System.Drawing.Size(680, 174);
            this.txtDetail.TabIndex = 22;
            this.txtDetail.TabStop = false;
            this.txtDetail.Text = "Details";
            this.txtDetail.UseSystemPasswordChar = false;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmployees.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmployees.Location = new System.Drawing.Point(565, 253);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(106, 28);
            this.lblEmployees.TabIndex = 37;
            this.lblEmployees.Text = "employees";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.AllowPromptAsInput = true;
            this.txtCompanyName.AnimateReadOnly = false;
            this.txtCompanyName.AsciiOnly = false;
            this.txtCompanyName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompanyName.BeepOnError = false;
            this.txtCompanyName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyName.Depth = 0;
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyName.HidePromptOnLeave = false;
            this.txtCompanyName.HideSelection = true;
            this.txtCompanyName.Hint = "Company Name";
            this.txtCompanyName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCompanyName.LeadingIcon = null;
            this.txtCompanyName.Location = new System.Drawing.Point(26, 32);
            this.txtCompanyName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyName.Mask = "";
            this.txtCompanyName.MaxLength = 32767;
            this.txtCompanyName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.PasswordChar = '\0';
            this.txtCompanyName.PrefixSuffixText = null;
            this.txtCompanyName.PromptChar = '_';
            this.txtCompanyName.ReadOnly = false;
            this.txtCompanyName.RejectInputOnFirstFailure = false;
            this.txtCompanyName.ResetOnPrompt = true;
            this.txtCompanyName.ResetOnSpace = true;
            this.txtCompanyName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyName.SelectedText = "";
            this.txtCompanyName.SelectionLength = 0;
            this.txtCompanyName.SelectionStart = 0;
            this.txtCompanyName.ShortcutsEnabled = true;
            this.txtCompanyName.Size = new System.Drawing.Size(298, 48);
            this.txtCompanyName.SkipLiterals = true;
            this.txtCompanyName.TabIndex = 38;
            this.txtCompanyName.TabStop = false;
            this.txtCompanyName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyName.TrailingIcon = null;
            this.txtCompanyName.UseSystemPasswordChar = false;
            this.txtCompanyName.ValidatingType = null;
            // 
            // txtAddress
            // 
            this.txtAddress.AllowPromptAsInput = true;
            this.txtAddress.AnimateReadOnly = false;
            this.txtAddress.AsciiOnly = false;
            this.txtAddress.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtAddress.BeepOnError = false;
            this.txtAddress.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.Depth = 0;
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtAddress.HidePromptOnLeave = false;
            this.txtAddress.HideSelection = true;
            this.txtAddress.Hint = "Address";
            this.txtAddress.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtAddress.LeadingIcon = null;
            this.txtAddress.Location = new System.Drawing.Point(373, 32);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtAddress.Mask = "";
            this.txtAddress.MaxLength = 32767;
            this.txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.PasswordChar = '\0';
            this.txtAddress.PrefixSuffixText = null;
            this.txtAddress.PromptChar = '_';
            this.txtAddress.ReadOnly = false;
            this.txtAddress.RejectInputOnFirstFailure = false;
            this.txtAddress.ResetOnPrompt = true;
            this.txtAddress.ResetOnSpace = true;
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtAddress.SelectedText = "";
            this.txtAddress.SelectionLength = 0;
            this.txtAddress.SelectionStart = 0;
            this.txtAddress.ShortcutsEnabled = true;
            this.txtAddress.Size = new System.Drawing.Size(298, 48);
            this.txtAddress.SkipLiterals = true;
            this.txtAddress.TabIndex = 39;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.ValidatingType = null;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.AllowPromptAsInput = true;
            this.txtPhoneNumber.AnimateReadOnly = false;
            this.txtPhoneNumber.AsciiOnly = false;
            this.txtPhoneNumber.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPhoneNumber.BeepOnError = false;
            this.txtPhoneNumber.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber.Depth = 0;
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.HidePromptOnLeave = false;
            this.txtPhoneNumber.HideSelection = true;
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPhoneNumber.LeadingIcon = null;
            this.txtPhoneNumber.Location = new System.Drawing.Point(26, 100);
            this.txtPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhoneNumber.Mask = "";
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.PrefixSuffixText = null;
            this.txtPhoneNumber.PromptChar = '_';
            this.txtPhoneNumber.ReadOnly = false;
            this.txtPhoneNumber.RejectInputOnFirstFailure = false;
            this.txtPhoneNumber.ResetOnPrompt = true;
            this.txtPhoneNumber.ResetOnSpace = true;
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(298, 48);
            this.txtPhoneNumber.SkipLiterals = true;
            this.txtPhoneNumber.TabIndex = 40;
            this.txtPhoneNumber.TabStop = false;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber.TrailingIcon = null;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            this.txtPhoneNumber.ValidatingType = null;
            // 
            // txtCompanyType
            // 
            this.txtCompanyType.AllowPromptAsInput = true;
            this.txtCompanyType.AnimateReadOnly = false;
            this.txtCompanyType.AsciiOnly = false;
            this.txtCompanyType.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompanyType.BeepOnError = false;
            this.txtCompanyType.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyType.Depth = 0;
            this.txtCompanyType.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanyType.HidePromptOnLeave = false;
            this.txtCompanyType.HideSelection = true;
            this.txtCompanyType.Hint = "Company Type";
            this.txtCompanyType.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCompanyType.LeadingIcon = null;
            this.txtCompanyType.Location = new System.Drawing.Point(373, 100);
            this.txtCompanyType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanyType.Mask = "";
            this.txtCompanyType.MaxLength = 32767;
            this.txtCompanyType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCompanyType.Name = "txtCompanyType";
            this.txtCompanyType.PasswordChar = '\0';
            this.txtCompanyType.PrefixSuffixText = null;
            this.txtCompanyType.PromptChar = '_';
            this.txtCompanyType.ReadOnly = false;
            this.txtCompanyType.RejectInputOnFirstFailure = false;
            this.txtCompanyType.ResetOnPrompt = true;
            this.txtCompanyType.ResetOnSpace = true;
            this.txtCompanyType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanyType.SelectedText = "";
            this.txtCompanyType.SelectionLength = 0;
            this.txtCompanyType.SelectionStart = 0;
            this.txtCompanyType.ShortcutsEnabled = true;
            this.txtCompanyType.Size = new System.Drawing.Size(298, 48);
            this.txtCompanyType.SkipLiterals = true;
            this.txtCompanyType.TabIndex = 41;
            this.txtCompanyType.TabStop = false;
            this.txtCompanyType.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanyType.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanyType.TrailingIcon = null;
            this.txtCompanyType.UseSystemPasswordChar = false;
            this.txtCompanyType.ValidatingType = null;
            // 
            // txtEmail
            // 
            this.txtEmail.AllowPromptAsInput = true;
            this.txtEmail.AnimateReadOnly = false;
            this.txtEmail.AsciiOnly = false;
            this.txtEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtEmail.BeepOnError = false;
            this.txtEmail.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.Depth = 0;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.HidePromptOnLeave = false;
            this.txtEmail.HideSelection = true;
            this.txtEmail.Hint = "Email";
            this.txtEmail.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtEmail.LeadingIcon = null;
            this.txtEmail.Location = new System.Drawing.Point(26, 170);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Mask = "";
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.PrefixSuffixText = null;
            this.txtEmail.PromptChar = '_';
            this.txtEmail.ReadOnly = false;
            this.txtEmail.RejectInputOnFirstFailure = false;
            this.txtEmail.ResetOnPrompt = true;
            this.txtEmail.ResetOnSpace = true;
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(298, 48);
            this.txtEmail.SkipLiterals = true;
            this.txtEmail.TabIndex = 42;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.ValidatingType = null;
            // 
            // txtCompanySize
            // 
            this.txtCompanySize.AllowPromptAsInput = true;
            this.txtCompanySize.AnimateReadOnly = false;
            this.txtCompanySize.AsciiOnly = false;
            this.txtCompanySize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCompanySize.BeepOnError = false;
            this.txtCompanySize.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanySize.Depth = 0;
            this.txtCompanySize.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCompanySize.HidePromptOnLeave = false;
            this.txtCompanySize.HideSelection = true;
            this.txtCompanySize.Hint = "Company Size";
            this.txtCompanySize.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCompanySize.LeadingIcon = null;
            this.txtCompanySize.Location = new System.Drawing.Point(373, 243);
            this.txtCompanySize.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCompanySize.Mask = "";
            this.txtCompanySize.MaxLength = 32767;
            this.txtCompanySize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCompanySize.Name = "txtCompanySize";
            this.txtCompanySize.PasswordChar = '\0';
            this.txtCompanySize.PrefixSuffixText = null;
            this.txtCompanySize.PromptChar = '_';
            this.txtCompanySize.ReadOnly = false;
            this.txtCompanySize.RejectInputOnFirstFailure = false;
            this.txtCompanySize.ResetOnPrompt = true;
            this.txtCompanySize.ResetOnSpace = true;
            this.txtCompanySize.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCompanySize.SelectedText = "";
            this.txtCompanySize.SelectionLength = 0;
            this.txtCompanySize.SelectionStart = 0;
            this.txtCompanySize.ShortcutsEnabled = true;
            this.txtCompanySize.Size = new System.Drawing.Size(186, 48);
            this.txtCompanySize.SkipLiterals = true;
            this.txtCompanySize.TabIndex = 43;
            this.txtCompanySize.TabStop = false;
            this.txtCompanySize.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCompanySize.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCompanySize.TrailingIcon = null;
            this.txtCompanySize.UseSystemPasswordChar = false;
            this.txtCompanySize.ValidatingType = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Location = new System.Drawing.Point(795, 32);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 195);
            this.panel1.TabIndex = 44;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.ptbAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.ErrorImage")));
            this.ptbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.Image")));
            this.ptbAvatar.Location = new System.Drawing.Point(6, 7);
            this.ptbAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(171, 179);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 8;
            this.ptbAvatar.TabStop = false;
            // 
            // btnChoosePicture
            // 
            this.btnChoosePicture.Alpha = 20;
            this.btnChoosePicture.BackColor = System.Drawing.Color.Transparent;
            this.btnChoosePicture.Background = true;
            this.btnChoosePicture.Background_WidthPen = 4F;
            this.btnChoosePicture.BackgroundPen = true;
            this.btnChoosePicture.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnChoosePicture.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnChoosePicture.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChoosePicture.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnChoosePicture.Effect_1 = true;
            this.btnChoosePicture.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.Effect_1_Transparency = 25;
            this.btnChoosePicture.Effect_2 = true;
            this.btnChoosePicture.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChoosePicture.Effect_2_Transparency = 20;
            this.btnChoosePicture.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChoosePicture.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnChoosePicture.Lighting = true;
            this.btnChoosePicture.LinearGradient_Background = false;
            this.btnChoosePicture.LinearGradientPen = false;
            this.btnChoosePicture.Location = new System.Drawing.Point(801, 235);
            this.btnChoosePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.PenWidth = 15;
            this.btnChoosePicture.Rounding = true;
            this.btnChoosePicture.RoundingInt = 20;
            this.btnChoosePicture.Size = new System.Drawing.Size(171, 56);
            this.btnChoosePicture.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnChoosePicture.TabIndex = 45;
            this.btnChoosePicture.Tag = "Decline";
            this.btnChoosePicture.TextButton = "Choose Picture";
            this.btnChoosePicture.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnChoosePicture.Timer_Effect_1 = 5;
            this.btnChoosePicture.Timer_RGB = 300;
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
            this.btnSave.Location = new System.Drawing.Point(734, 502);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.PenWidth = 15;
            this.btnSave.Rounding = true;
            this.btnSave.RoundingInt = 20;
            this.btnSave.Size = new System.Drawing.Size(148, 56);
            this.btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 46;
            this.btnSave.Tag = "Decline";
            this.btnSave.TextButton = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Timer_Effect_1 = 5;
            this.btnSave.Timer_RGB = 300;
            // 
            // btnCancel
            // 
            this.btnCancel.Alpha = 20;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Background = true;
            this.btnCancel.Background_WidthPen = 4F;
            this.btnCancel.BackgroundPen = true;
            this.btnCancel.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
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
            this.btnCancel.Location = new System.Drawing.Point(888, 502);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PenWidth = 15;
            this.btnCancel.Rounding = true;
            this.btnCancel.RoundingInt = 20;
            this.btnCancel.Size = new System.Drawing.Size(148, 56);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 47;
            this.btnCancel.Tag = "Decline";
            this.btnCancel.TextButton = "Cancel";
            this.btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCancel.Timer_Effect_1 = 5;
            this.btnCancel.Timer_RGB = 300;
            // 
            // btnEdit
            // 
            this.btnEdit.Alpha = 20;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.Background = true;
            this.btnEdit.Background_WidthPen = 4F;
            this.btnEdit.BackgroundPen = true;
            this.btnEdit.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnEdit.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnEdit.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnEdit.Effect_1 = true;
            this.btnEdit.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.Effect_1_Transparency = 25;
            this.btnEdit.Effect_2 = true;
            this.btnEdit.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEdit.Effect_2_Transparency = 20;
            this.btnEdit.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnEdit.Lighting = true;
            this.btnEdit.LinearGradient_Background = false;
            this.btnEdit.LinearGradientPen = false;
            this.btnEdit.Location = new System.Drawing.Point(812, 502);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PenWidth = 15;
            this.btnEdit.Rounding = true;
            this.btnEdit.RoundingInt = 20;
            this.btnEdit.Size = new System.Drawing.Size(148, 56);
            this.btnEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit.TabIndex = 48;
            this.btnEdit.Tag = "Decline";
            this.btnEdit.TextButton = "Edit";
            this.btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit.Timer_Effect_1 = 5;
            this.btnEdit.Timer_RGB = 300;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // lblWorkingTime
            // 
            this.lblWorkingTime.AutoSize = true;
            this.lblWorkingTime.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWorkingTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblWorkingTime.Location = new System.Drawing.Point(26, 326);
            this.lblWorkingTime.Name = "lblWorkingTime";
            this.lblWorkingTime.Size = new System.Drawing.Size(138, 28);
            this.lblWorkingTime.TabIndex = 49;
            this.lblWorkingTime.Text = "Working Time:";
            // 
            // txtTaxIdentification
            // 
            this.txtTaxIdentification.AllowPromptAsInput = true;
            this.txtTaxIdentification.AnimateReadOnly = false;
            this.txtTaxIdentification.AsciiOnly = false;
            this.txtTaxIdentification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtTaxIdentification.BeepOnError = false;
            this.txtTaxIdentification.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTaxIdentification.Depth = 0;
            this.txtTaxIdentification.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTaxIdentification.HidePromptOnLeave = false;
            this.txtTaxIdentification.HideSelection = true;
            this.txtTaxIdentification.Hint = "Tax Identification";
            this.txtTaxIdentification.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtTaxIdentification.LeadingIcon = null;
            this.txtTaxIdentification.Location = new System.Drawing.Point(26, 243);
            this.txtTaxIdentification.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTaxIdentification.Mask = "";
            this.txtTaxIdentification.MaxLength = 32767;
            this.txtTaxIdentification.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtTaxIdentification.Name = "txtTaxIdentification";
            this.txtTaxIdentification.PasswordChar = '\0';
            this.txtTaxIdentification.PrefixSuffixText = null;
            this.txtTaxIdentification.PromptChar = '_';
            this.txtTaxIdentification.ReadOnly = false;
            this.txtTaxIdentification.RejectInputOnFirstFailure = false;
            this.txtTaxIdentification.ResetOnPrompt = true;
            this.txtTaxIdentification.ResetOnSpace = true;
            this.txtTaxIdentification.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTaxIdentification.SelectedText = "";
            this.txtTaxIdentification.SelectionLength = 0;
            this.txtTaxIdentification.SelectionStart = 0;
            this.txtTaxIdentification.ShortcutsEnabled = true;
            this.txtTaxIdentification.Size = new System.Drawing.Size(298, 48);
            this.txtTaxIdentification.SkipLiterals = true;
            this.txtTaxIdentification.TabIndex = 50;
            this.txtTaxIdentification.TabStop = false;
            this.txtTaxIdentification.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtTaxIdentification.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtTaxIdentification.TrailingIcon = null;
            this.txtTaxIdentification.UseSystemPasswordChar = false;
            this.txtTaxIdentification.ValidatingType = null;
            // 
            // cbbWTB
            // 
            this.cbbWTB.AutoResize = false;
            this.cbbWTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbWTB.Depth = 0;
            this.cbbWTB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbWTB.DropDownHeight = 174;
            this.cbbWTB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWTB.DropDownWidth = 121;
            this.cbbWTB.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbWTB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbWTB.FormattingEnabled = true;
            this.cbbWTB.IntegralHeight = false;
            this.cbbWTB.ItemHeight = 43;
            this.cbbWTB.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbWTB.Location = new System.Drawing.Point(170, 315);
            this.cbbWTB.MaxDropDownItems = 4;
            this.cbbWTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbWTB.Name = "cbbWTB";
            this.cbbWTB.Size = new System.Drawing.Size(154, 49);
            this.cbbWTB.StartIndex = 0;
            this.cbbWTB.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(333, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 28);
            this.label1.TabIndex = 52;
            this.label1.Text = "to";
            // 
            // cbbWTEnd
            // 
            this.cbbWTEnd.AutoResize = false;
            this.cbbWTEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbbWTEnd.Depth = 0;
            this.cbbWTEnd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbbWTEnd.DropDownHeight = 174;
            this.cbbWTEnd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbWTEnd.DropDownWidth = 121;
            this.cbbWTEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cbbWTEnd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cbbWTEnd.FormattingEnabled = true;
            this.cbbWTEnd.IntegralHeight = false;
            this.cbbWTEnd.ItemHeight = 43;
            this.cbbWTEnd.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wednesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.cbbWTEnd.Location = new System.Drawing.Point(373, 314);
            this.cbbWTEnd.MaxDropDownItems = 4;
            this.cbbWTEnd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.cbbWTEnd.Name = "cbbWTEnd";
            this.cbbWTEnd.Size = new System.Drawing.Size(154, 49);
            this.cbbWTEnd.StartIndex = 0;
            this.cbbWTEnd.TabIndex = 53;
            // 
            // txtWebsiteLink
            // 
            this.txtWebsiteLink.AllowPromptAsInput = true;
            this.txtWebsiteLink.AnimateReadOnly = false;
            this.txtWebsiteLink.AsciiOnly = false;
            this.txtWebsiteLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtWebsiteLink.BeepOnError = false;
            this.txtWebsiteLink.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtWebsiteLink.Depth = 0;
            this.txtWebsiteLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtWebsiteLink.HidePromptOnLeave = false;
            this.txtWebsiteLink.HideSelection = true;
            this.txtWebsiteLink.Hint = "Website Link";
            this.txtWebsiteLink.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtWebsiteLink.LeadingIcon = null;
            this.txtWebsiteLink.Location = new System.Drawing.Point(373, 170);
            this.txtWebsiteLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWebsiteLink.Mask = "";
            this.txtWebsiteLink.MaxLength = 32767;
            this.txtWebsiteLink.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtWebsiteLink.Name = "txtWebsiteLink";
            this.txtWebsiteLink.PasswordChar = '\0';
            this.txtWebsiteLink.PrefixSuffixText = null;
            this.txtWebsiteLink.PromptChar = '_';
            this.txtWebsiteLink.ReadOnly = false;
            this.txtWebsiteLink.RejectInputOnFirstFailure = false;
            this.txtWebsiteLink.ResetOnPrompt = true;
            this.txtWebsiteLink.ResetOnSpace = true;
            this.txtWebsiteLink.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtWebsiteLink.SelectedText = "";
            this.txtWebsiteLink.SelectionLength = 0;
            this.txtWebsiteLink.SelectionStart = 0;
            this.txtWebsiteLink.ShortcutsEnabled = true;
            this.txtWebsiteLink.Size = new System.Drawing.Size(298, 48);
            this.txtWebsiteLink.SkipLiterals = true;
            this.txtWebsiteLink.TabIndex = 54;
            this.txtWebsiteLink.TabStop = false;
            this.txtWebsiteLink.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtWebsiteLink.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtWebsiteLink.TrailingIcon = null;
            this.txtWebsiteLink.UseSystemPasswordChar = false;
            this.txtWebsiteLink.ValidatingType = null;
            // 
            // btnChooseLicense
            // 
            this.btnChooseLicense.Alpha = 20;
            this.btnChooseLicense.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseLicense.Background = true;
            this.btnChooseLicense.Background_WidthPen = 4F;
            this.btnChooseLicense.BackgroundPen = true;
            this.btnChooseLicense.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnChooseLicense.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnChooseLicense.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseLicense.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnChooseLicense.Effect_1 = true;
            this.btnChooseLicense.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.Effect_1_Transparency = 25;
            this.btnChooseLicense.Effect_2 = true;
            this.btnChooseLicense.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseLicense.Effect_2_Transparency = 20;
            this.btnChooseLicense.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseLicense.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnChooseLicense.Lighting = true;
            this.btnChooseLicense.LinearGradient_Background = false;
            this.btnChooseLicense.LinearGradientPen = false;
            this.btnChooseLicense.Location = new System.Drawing.Point(801, 440);
            this.btnChooseLicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseLicense.Name = "btnChooseLicense";
            this.btnChooseLicense.PenWidth = 15;
            this.btnChooseLicense.Rounding = true;
            this.btnChooseLicense.RoundingInt = 20;
            this.btnChooseLicense.Size = new System.Drawing.Size(171, 56);
            this.btnChooseLicense.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnChooseLicense.TabIndex = 55;
            this.btnChooseLicense.Tag = "Decline";
            this.btnChooseLicense.TextButton = "Choose License";
            this.btnChooseLicense.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnChooseLicense.Timer_Effect_1 = 5;
            this.btnChooseLicense.Timer_RGB = 300;
            // 
            // ptbLicense
            // 
            this.ptbLicense.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.ptbLicense.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbLicense.ErrorImage")));
            this.ptbLicense.Image = ((System.Drawing.Image)(resources.GetObject("ptbLicense.Image")));
            this.ptbLicense.Location = new System.Drawing.Point(812, 307);
            this.ptbLicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbLicense.Name = "ptbLicense";
            this.ptbLicense.Size = new System.Drawing.Size(148, 125);
            this.ptbLicense.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbLicense.TabIndex = 56;
            this.ptbLicense.TabStop = false;
            // 
            // FProfileCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 585);
            this.Controls.Add(this.ptbLicense);
            this.Controls.Add(this.btnChooseLicense);
            this.Controls.Add(this.txtWebsiteLink);
            this.Controls.Add(this.cbbWTEnd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbWTB);
            this.Controls.Add(this.txtTaxIdentification);
            this.Controls.Add(this.lblWorkingTime);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtCompanySize);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtCompanyType);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtCompanyName);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.txtDetail);
            this.Name = "FProfileCompany";
            this.Text = "FProfileCompany";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbLicense)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ReaLTaiizor.Controls.HopeRichTextBox txtDetail;
        private Label lblEmployees;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCompanyName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPhoneNumber;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCompanyType;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCompanySize;
        private Panel panel1;
        private PictureBox ptbAvatar;
        private ReaLTaiizor.Controls.CyberButton btnChoosePicture;
        private ReaLTaiizor.Controls.CyberButton btnSave;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnEdit;
        private Label lblWorkingTime;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtTaxIdentification;
        private ReaLTaiizor.Controls.MaterialComboBox cbbWTB;
        private Label label1;
        private ReaLTaiizor.Controls.MaterialComboBox cbbWTEnd;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtWebsiteLink;
        private ReaLTaiizor.Controls.CyberButton btnChooseLicense;
        private PictureBox ptbLicense;
    }
}
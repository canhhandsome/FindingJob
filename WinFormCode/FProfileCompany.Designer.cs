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
            txtDetail = new ReaLTaiizor.Controls.HopeRichTextBox();
            lblEmployees = new Label();
            txtCompanyName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPhoneNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCompanyType = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCompanySize = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            panel1 = new Panel();
            ptbAvatar = new PictureBox();
            btnChoosePicture = new ReaLTaiizor.Controls.CyberButton();
            btnSave = new ReaLTaiizor.Controls.CyberButton();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnEdit = new ReaLTaiizor.Controls.CyberButton();
            lblWorkingTime = new Label();
            txtTaxIdentification = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            cbbWTB = new ReaLTaiizor.Controls.MaterialComboBox();
            label1 = new Label();
            cbbWTEnd = new ReaLTaiizor.Controls.MaterialComboBox();
            txtWebsiteLink = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            btnChooseLicense = new ReaLTaiizor.Controls.CyberButton();
            ptbLicense = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLicense).BeginInit();
            SuspendLayout();
            // 
            // txtDetail
            // 
            txtDetail.BorderColor = Color.FromArgb(220, 223, 230);
            txtDetail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtDetail.ForeColor = Color.FromArgb(48, 49, 51);
            txtDetail.Hint = "Details";
            txtDetail.HoverBorderColor = Color.FromArgb(64, 158, 255);
            txtDetail.Location = new Point(26, 384);
            txtDetail.Margin = new Padding(3, 4, 3, 4);
            txtDetail.MaxLength = 32767;
            txtDetail.Multiline = true;
            txtDetail.Name = "txtDetail";
            txtDetail.PasswordChar = '\0';
            txtDetail.ScrollBars = ScrollBars.None;
            txtDetail.SelectedText = "";
            txtDetail.SelectionLength = 0;
            txtDetail.SelectionStart = 0;
            txtDetail.Size = new Size(680, 174);
            txtDetail.TabIndex = 22;
            txtDetail.TabStop = false;
            txtDetail.Text = "Details";
            txtDetail.UseSystemPasswordChar = false;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmployees.ForeColor = SystemColors.ControlText;
            lblEmployees.Location = new Point(565, 253);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(106, 28);
            lblEmployees.TabIndex = 37;
            lblEmployees.Text = "employees";
            // 
            // txtCompanyName
            // 
            txtCompanyName.AllowPromptAsInput = true;
            txtCompanyName.AnimateReadOnly = false;
            txtCompanyName.AsciiOnly = false;
            txtCompanyName.BackgroundImageLayout = ImageLayout.None;
            txtCompanyName.BeepOnError = false;
            txtCompanyName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCompanyName.Depth = 0;
            txtCompanyName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCompanyName.HidePromptOnLeave = false;
            txtCompanyName.HideSelection = true;
            txtCompanyName.Hint = "Company Name";
            txtCompanyName.InsertKeyMode = InsertKeyMode.Default;
            txtCompanyName.LeadingIcon = null;
            txtCompanyName.Location = new Point(26, 32);
            txtCompanyName.Margin = new Padding(3, 4, 3, 4);
            txtCompanyName.Mask = "";
            txtCompanyName.MaxLength = 32767;
            txtCompanyName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCompanyName.Name = "txtCompanyName";
            txtCompanyName.PasswordChar = '\0';
            txtCompanyName.PrefixSuffixText = null;
            txtCompanyName.PromptChar = '_';
            txtCompanyName.ReadOnly = false;
            txtCompanyName.RejectInputOnFirstFailure = false;
            txtCompanyName.ResetOnPrompt = true;
            txtCompanyName.ResetOnSpace = true;
            txtCompanyName.RightToLeft = RightToLeft.No;
            txtCompanyName.SelectedText = "";
            txtCompanyName.SelectionLength = 0;
            txtCompanyName.SelectionStart = 0;
            txtCompanyName.ShortcutsEnabled = true;
            txtCompanyName.Size = new Size(298, 48);
            txtCompanyName.SkipLiterals = true;
            txtCompanyName.TabIndex = 38;
            txtCompanyName.TabStop = false;
            txtCompanyName.TextAlign = HorizontalAlignment.Left;
            txtCompanyName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCompanyName.TrailingIcon = null;
            txtCompanyName.UseSystemPasswordChar = false;
            txtCompanyName.ValidatingType = null;
            // 
            // txtAddress
            // 
            txtAddress.AllowPromptAsInput = true;
            txtAddress.AnimateReadOnly = false;
            txtAddress.AsciiOnly = false;
            txtAddress.BackgroundImageLayout = ImageLayout.None;
            txtAddress.BeepOnError = false;
            txtAddress.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtAddress.Depth = 0;
            txtAddress.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtAddress.HidePromptOnLeave = false;
            txtAddress.HideSelection = true;
            txtAddress.Hint = "Address";
            txtAddress.InsertKeyMode = InsertKeyMode.Default;
            txtAddress.LeadingIcon = null;
            txtAddress.Location = new Point(373, 32);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Mask = "";
            txtAddress.MaxLength = 32767;
            txtAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtAddress.Name = "txtAddress";
            txtAddress.PasswordChar = '\0';
            txtAddress.PrefixSuffixText = null;
            txtAddress.PromptChar = '_';
            txtAddress.ReadOnly = false;
            txtAddress.RejectInputOnFirstFailure = false;
            txtAddress.ResetOnPrompt = true;
            txtAddress.ResetOnSpace = true;
            txtAddress.RightToLeft = RightToLeft.No;
            txtAddress.SelectedText = "";
            txtAddress.SelectionLength = 0;
            txtAddress.SelectionStart = 0;
            txtAddress.ShortcutsEnabled = true;
            txtAddress.Size = new Size(298, 48);
            txtAddress.SkipLiterals = true;
            txtAddress.TabIndex = 39;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            txtAddress.ValidatingType = null;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.AllowPromptAsInput = true;
            txtPhoneNumber.AnimateReadOnly = false;
            txtPhoneNumber.AsciiOnly = false;
            txtPhoneNumber.BackgroundImageLayout = ImageLayout.None;
            txtPhoneNumber.BeepOnError = false;
            txtPhoneNumber.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPhoneNumber.Depth = 0;
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPhoneNumber.HidePromptOnLeave = false;
            txtPhoneNumber.HideSelection = true;
            txtPhoneNumber.Hint = "Phone Number";
            txtPhoneNumber.InsertKeyMode = InsertKeyMode.Default;
            txtPhoneNumber.LeadingIcon = null;
            txtPhoneNumber.Location = new Point(26, 100);
            txtPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtPhoneNumber.Mask = "";
            txtPhoneNumber.MaxLength = 32767;
            txtPhoneNumber.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PasswordChar = '\0';
            txtPhoneNumber.PrefixSuffixText = null;
            txtPhoneNumber.PromptChar = '_';
            txtPhoneNumber.ReadOnly = false;
            txtPhoneNumber.RejectInputOnFirstFailure = false;
            txtPhoneNumber.ResetOnPrompt = true;
            txtPhoneNumber.ResetOnSpace = true;
            txtPhoneNumber.RightToLeft = RightToLeft.No;
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.SelectionLength = 0;
            txtPhoneNumber.SelectionStart = 0;
            txtPhoneNumber.ShortcutsEnabled = true;
            txtPhoneNumber.Size = new Size(298, 48);
            txtPhoneNumber.SkipLiterals = true;
            txtPhoneNumber.TabIndex = 40;
            txtPhoneNumber.TabStop = false;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Left;
            txtPhoneNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPhoneNumber.TrailingIcon = null;
            txtPhoneNumber.UseSystemPasswordChar = false;
            txtPhoneNumber.ValidatingType = null;
            // 
            // txtCompanyType
            // 
            txtCompanyType.AllowPromptAsInput = true;
            txtCompanyType.AnimateReadOnly = false;
            txtCompanyType.AsciiOnly = false;
            txtCompanyType.BackgroundImageLayout = ImageLayout.None;
            txtCompanyType.BeepOnError = false;
            txtCompanyType.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCompanyType.Depth = 0;
            txtCompanyType.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCompanyType.HidePromptOnLeave = false;
            txtCompanyType.HideSelection = true;
            txtCompanyType.Hint = "Company Type";
            txtCompanyType.InsertKeyMode = InsertKeyMode.Default;
            txtCompanyType.LeadingIcon = null;
            txtCompanyType.Location = new Point(373, 100);
            txtCompanyType.Margin = new Padding(3, 4, 3, 4);
            txtCompanyType.Mask = "";
            txtCompanyType.MaxLength = 32767;
            txtCompanyType.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCompanyType.Name = "txtCompanyType";
            txtCompanyType.PasswordChar = '\0';
            txtCompanyType.PrefixSuffixText = null;
            txtCompanyType.PromptChar = '_';
            txtCompanyType.ReadOnly = false;
            txtCompanyType.RejectInputOnFirstFailure = false;
            txtCompanyType.ResetOnPrompt = true;
            txtCompanyType.ResetOnSpace = true;
            txtCompanyType.RightToLeft = RightToLeft.No;
            txtCompanyType.SelectedText = "";
            txtCompanyType.SelectionLength = 0;
            txtCompanyType.SelectionStart = 0;
            txtCompanyType.ShortcutsEnabled = true;
            txtCompanyType.Size = new Size(298, 48);
            txtCompanyType.SkipLiterals = true;
            txtCompanyType.TabIndex = 41;
            txtCompanyType.TabStop = false;
            txtCompanyType.TextAlign = HorizontalAlignment.Left;
            txtCompanyType.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCompanyType.TrailingIcon = null;
            txtCompanyType.UseSystemPasswordChar = false;
            txtCompanyType.ValidatingType = null;
            // 
            // txtEmail
            // 
            txtEmail.AllowPromptAsInput = true;
            txtEmail.AnimateReadOnly = false;
            txtEmail.AsciiOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.BeepOnError = false;
            txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HidePromptOnLeave = false;
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.InsertKeyMode = InsertKeyMode.Default;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(26, 170);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Mask = "";
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.PromptChar = '_';
            txtEmail.ReadOnly = false;
            txtEmail.RejectInputOnFirstFailure = false;
            txtEmail.ResetOnPrompt = true;
            txtEmail.ResetOnSpace = true;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(298, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 42;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
            // 
            // txtCompanySize
            // 
            txtCompanySize.AllowPromptAsInput = true;
            txtCompanySize.AnimateReadOnly = false;
            txtCompanySize.AsciiOnly = false;
            txtCompanySize.BackgroundImageLayout = ImageLayout.None;
            txtCompanySize.BeepOnError = false;
            txtCompanySize.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCompanySize.Depth = 0;
            txtCompanySize.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtCompanySize.HidePromptOnLeave = false;
            txtCompanySize.HideSelection = true;
            txtCompanySize.Hint = "Company Size";
            txtCompanySize.InsertKeyMode = InsertKeyMode.Default;
            txtCompanySize.LeadingIcon = null;
            txtCompanySize.Location = new Point(373, 243);
            txtCompanySize.Margin = new Padding(3, 4, 3, 4);
            txtCompanySize.Mask = "";
            txtCompanySize.MaxLength = 32767;
            txtCompanySize.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCompanySize.Name = "txtCompanySize";
            txtCompanySize.PasswordChar = '\0';
            txtCompanySize.PrefixSuffixText = null;
            txtCompanySize.PromptChar = '_';
            txtCompanySize.ReadOnly = false;
            txtCompanySize.RejectInputOnFirstFailure = false;
            txtCompanySize.ResetOnPrompt = true;
            txtCompanySize.ResetOnSpace = true;
            txtCompanySize.RightToLeft = RightToLeft.No;
            txtCompanySize.SelectedText = "";
            txtCompanySize.SelectionLength = 0;
            txtCompanySize.SelectionStart = 0;
            txtCompanySize.ShortcutsEnabled = true;
            txtCompanySize.Size = new Size(186, 48);
            txtCompanySize.SkipLiterals = true;
            txtCompanySize.TabIndex = 43;
            txtCompanySize.TabStop = false;
            txtCompanySize.TextAlign = HorizontalAlignment.Left;
            txtCompanySize.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCompanySize.TrailingIcon = null;
            txtCompanySize.UseSystemPasswordChar = false;
            txtCompanySize.ValidatingType = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 212, 187);
            panel1.Controls.Add(ptbAvatar);
            panel1.Location = new Point(795, 32);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 195);
            panel1.TabIndex = 44;
            // 
            // ptbAvatar
            // 
            ptbAvatar.BackColor = Color.FromArgb(248, 212, 187);
            ptbAvatar.ErrorImage = (Image)resources.GetObject("ptbAvatar.ErrorImage");
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.Location = new Point(6, 7);
            ptbAvatar.Margin = new Padding(3, 4, 3, 4);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(171, 179);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 8;
            ptbAvatar.TabStop = false;
            // 
            // btnChoosePicture
            // 
            btnChoosePicture.Alpha = 20;
            btnChoosePicture.BackColor = Color.Transparent;
            btnChoosePicture.Background = true;
            btnChoosePicture.Background_WidthPen = 4F;
            btnChoosePicture.BackgroundPen = true;
            btnChoosePicture.ColorBackground = Color.FromArgb(176, 226, 243);
            btnChoosePicture.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnChoosePicture.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnChoosePicture.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnChoosePicture.ColorLighting = Color.FromArgb(128, 128, 255);
            btnChoosePicture.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnChoosePicture.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnChoosePicture.Cursor = Cursors.Hand;
            btnChoosePicture.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnChoosePicture.Effect_1 = true;
            btnChoosePicture.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnChoosePicture.Effect_1_Transparency = 25;
            btnChoosePicture.Effect_2 = true;
            btnChoosePicture.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnChoosePicture.Effect_2_Transparency = 20;
            btnChoosePicture.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosePicture.ForeColor = Color.FromArgb(46, 54, 71);
            btnChoosePicture.Lighting = true;
            btnChoosePicture.LinearGradient_Background = false;
            btnChoosePicture.LinearGradientPen = false;
            btnChoosePicture.Location = new Point(801, 235);
            btnChoosePicture.Margin = new Padding(3, 4, 3, 4);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.PenWidth = 15;
            btnChoosePicture.Rounding = true;
            btnChoosePicture.RoundingInt = 20;
            btnChoosePicture.Size = new Size(171, 56);
            btnChoosePicture.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnChoosePicture.TabIndex = 45;
            btnChoosePicture.Tag = "Decline";
            btnChoosePicture.TextButton = "Choose Picture";
            btnChoosePicture.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnChoosePicture.Timer_Effect_1 = 5;
            btnChoosePicture.Timer_RGB = 300;
            btnChoosePicture.Click += btnChoosePicture_Click;
            // 
            // btnSave
            // 
            btnSave.Alpha = 20;
            btnSave.BackColor = Color.Transparent;
            btnSave.Background = true;
            btnSave.Background_WidthPen = 4F;
            btnSave.BackgroundPen = true;
            btnSave.ColorBackground = Color.FromArgb(176, 226, 243);
            btnSave.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnSave.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnSave.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnSave.ColorLighting = Color.FromArgb(128, 128, 255);
            btnSave.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnSave.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnSave.Cursor = Cursors.Hand;
            btnSave.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSave.Effect_1 = true;
            btnSave.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnSave.Effect_1_Transparency = 25;
            btnSave.Effect_2 = true;
            btnSave.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnSave.Effect_2_Transparency = 20;
            btnSave.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = Color.FromArgb(46, 54, 71);
            btnSave.Lighting = true;
            btnSave.LinearGradient_Background = false;
            btnSave.LinearGradientPen = false;
            btnSave.Location = new Point(734, 502);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.PenWidth = 15;
            btnSave.Rounding = true;
            btnSave.RoundingInt = 20;
            btnSave.Size = new Size(148, 56);
            btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSave.TabIndex = 46;
            btnSave.Tag = "Decline";
            btnSave.TextButton = "Save";
            btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Timer_Effect_1 = 5;
            btnSave.Timer_RGB = 300;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Alpha = 20;
            btnCancel.BackColor = Color.Transparent;
            btnCancel.Background = true;
            btnCancel.Background_WidthPen = 4F;
            btnCancel.BackgroundPen = true;
            btnCancel.ColorBackground = Color.FromArgb(255, 150, 150);
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
            btnCancel.Location = new Point(888, 502);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(148, 56);
            btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnCancel.TabIndex = 47;
            btnCancel.Tag = "Decline";
            btnCancel.TextButton = "Cancel";
            btnCancel.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCancel.Timer_Effect_1 = 5;
            btnCancel.Timer_RGB = 300;
            btnCancel.Click += btnCancel_Click;
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
            btnEdit.Location = new Point(812, 502);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.PenWidth = 15;
            btnEdit.Rounding = true;
            btnEdit.RoundingInt = 20;
            btnEdit.Size = new Size(148, 56);
            btnEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnEdit.TabIndex = 48;
            btnEdit.Tag = "Decline";
            btnEdit.TextButton = "Edit";
            btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEdit.Timer_Effect_1 = 5;
            btnEdit.Timer_RGB = 300;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblWorkingTime
            // 
            lblWorkingTime.AutoSize = true;
            lblWorkingTime.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblWorkingTime.ForeColor = SystemColors.ControlText;
            lblWorkingTime.Location = new Point(26, 326);
            lblWorkingTime.Name = "lblWorkingTime";
            lblWorkingTime.Size = new Size(138, 28);
            lblWorkingTime.TabIndex = 49;
            lblWorkingTime.Text = "Working Time:";
            // 
            // txtTaxIdentification
            // 
            txtTaxIdentification.AllowPromptAsInput = true;
            txtTaxIdentification.AnimateReadOnly = false;
            txtTaxIdentification.AsciiOnly = false;
            txtTaxIdentification.BackgroundImageLayout = ImageLayout.None;
            txtTaxIdentification.BeepOnError = false;
            txtTaxIdentification.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtTaxIdentification.Depth = 0;
            txtTaxIdentification.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtTaxIdentification.HidePromptOnLeave = false;
            txtTaxIdentification.HideSelection = true;
            txtTaxIdentification.Hint = "Tax Identification";
            txtTaxIdentification.InsertKeyMode = InsertKeyMode.Default;
            txtTaxIdentification.LeadingIcon = null;
            txtTaxIdentification.Location = new Point(26, 243);
            txtTaxIdentification.Margin = new Padding(3, 4, 3, 4);
            txtTaxIdentification.Mask = "";
            txtTaxIdentification.MaxLength = 32767;
            txtTaxIdentification.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtTaxIdentification.Name = "txtTaxIdentification";
            txtTaxIdentification.PasswordChar = '\0';
            txtTaxIdentification.PrefixSuffixText = null;
            txtTaxIdentification.PromptChar = '_';
            txtTaxIdentification.ReadOnly = false;
            txtTaxIdentification.RejectInputOnFirstFailure = false;
            txtTaxIdentification.ResetOnPrompt = true;
            txtTaxIdentification.ResetOnSpace = true;
            txtTaxIdentification.RightToLeft = RightToLeft.No;
            txtTaxIdentification.SelectedText = "";
            txtTaxIdentification.SelectionLength = 0;
            txtTaxIdentification.SelectionStart = 0;
            txtTaxIdentification.ShortcutsEnabled = true;
            txtTaxIdentification.Size = new Size(298, 48);
            txtTaxIdentification.SkipLiterals = true;
            txtTaxIdentification.TabIndex = 50;
            txtTaxIdentification.TabStop = false;
            txtTaxIdentification.TextAlign = HorizontalAlignment.Left;
            txtTaxIdentification.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtTaxIdentification.TrailingIcon = null;
            txtTaxIdentification.UseSystemPasswordChar = false;
            txtTaxIdentification.ValidatingType = null;
            // 
            // cbbWTB
            // 
            cbbWTB.AutoResize = false;
            cbbWTB.BackColor = Color.FromArgb(255, 255, 255);
            cbbWTB.Depth = 0;
            cbbWTB.DrawMode = DrawMode.OwnerDrawVariable;
            cbbWTB.DropDownHeight = 174;
            cbbWTB.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbWTB.DropDownWidth = 121;
            cbbWTB.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbbWTB.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbbWTB.FormattingEnabled = true;
            cbbWTB.IntegralHeight = false;
            cbbWTB.ItemHeight = 43;
            cbbWTB.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cbbWTB.Location = new Point(170, 315);
            cbbWTB.MaxDropDownItems = 4;
            cbbWTB.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbbWTB.Name = "cbbWTB";
            cbbWTB.Size = new Size(154, 49);
            cbbWTB.StartIndex = 0;
            cbbWTB.TabIndex = 51;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(333, 326);
            label1.Name = "label1";
            label1.Size = new Size(31, 28);
            label1.TabIndex = 52;
            label1.Text = "to";
            // 
            // cbbWTEnd
            // 
            cbbWTEnd.AutoResize = false;
            cbbWTEnd.BackColor = Color.FromArgb(255, 255, 255);
            cbbWTEnd.Depth = 0;
            cbbWTEnd.DrawMode = DrawMode.OwnerDrawVariable;
            cbbWTEnd.DropDownHeight = 174;
            cbbWTEnd.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbWTEnd.DropDownWidth = 121;
            cbbWTEnd.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cbbWTEnd.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cbbWTEnd.FormattingEnabled = true;
            cbbWTEnd.IntegralHeight = false;
            cbbWTEnd.ItemHeight = 43;
            cbbWTEnd.Items.AddRange(new object[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" });
            cbbWTEnd.Location = new Point(373, 314);
            cbbWTEnd.MaxDropDownItems = 4;
            cbbWTEnd.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cbbWTEnd.Name = "cbbWTEnd";
            cbbWTEnd.Size = new Size(154, 49);
            cbbWTEnd.StartIndex = 0;
            cbbWTEnd.TabIndex = 53;
            // 
            // txtWebsiteLink
            // 
            txtWebsiteLink.AllowPromptAsInput = true;
            txtWebsiteLink.AnimateReadOnly = false;
            txtWebsiteLink.AsciiOnly = false;
            txtWebsiteLink.BackgroundImageLayout = ImageLayout.None;
            txtWebsiteLink.BeepOnError = false;
            txtWebsiteLink.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtWebsiteLink.Depth = 0;
            txtWebsiteLink.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtWebsiteLink.HidePromptOnLeave = false;
            txtWebsiteLink.HideSelection = true;
            txtWebsiteLink.Hint = "Website Link";
            txtWebsiteLink.InsertKeyMode = InsertKeyMode.Default;
            txtWebsiteLink.LeadingIcon = null;
            txtWebsiteLink.Location = new Point(373, 170);
            txtWebsiteLink.Margin = new Padding(3, 4, 3, 4);
            txtWebsiteLink.Mask = "";
            txtWebsiteLink.MaxLength = 32767;
            txtWebsiteLink.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtWebsiteLink.Name = "txtWebsiteLink";
            txtWebsiteLink.PasswordChar = '\0';
            txtWebsiteLink.PrefixSuffixText = null;
            txtWebsiteLink.PromptChar = '_';
            txtWebsiteLink.ReadOnly = false;
            txtWebsiteLink.RejectInputOnFirstFailure = false;
            txtWebsiteLink.ResetOnPrompt = true;
            txtWebsiteLink.ResetOnSpace = true;
            txtWebsiteLink.RightToLeft = RightToLeft.No;
            txtWebsiteLink.SelectedText = "";
            txtWebsiteLink.SelectionLength = 0;
            txtWebsiteLink.SelectionStart = 0;
            txtWebsiteLink.ShortcutsEnabled = true;
            txtWebsiteLink.Size = new Size(298, 48);
            txtWebsiteLink.SkipLiterals = true;
            txtWebsiteLink.TabIndex = 54;
            txtWebsiteLink.TabStop = false;
            txtWebsiteLink.TextAlign = HorizontalAlignment.Left;
            txtWebsiteLink.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtWebsiteLink.TrailingIcon = null;
            txtWebsiteLink.UseSystemPasswordChar = false;
            txtWebsiteLink.ValidatingType = null;
            // 
            // btnChooseLicense
            // 
            btnChooseLicense.Alpha = 20;
            btnChooseLicense.BackColor = Color.Transparent;
            btnChooseLicense.Background = true;
            btnChooseLicense.Background_WidthPen = 4F;
            btnChooseLicense.BackgroundPen = true;
            btnChooseLicense.ColorBackground = Color.FromArgb(176, 226, 243);
            btnChooseLicense.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnChooseLicense.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnChooseLicense.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnChooseLicense.ColorLighting = Color.FromArgb(128, 128, 255);
            btnChooseLicense.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnChooseLicense.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnChooseLicense.Cursor = Cursors.Hand;
            btnChooseLicense.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnChooseLicense.Effect_1 = true;
            btnChooseLicense.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnChooseLicense.Effect_1_Transparency = 25;
            btnChooseLicense.Effect_2 = true;
            btnChooseLicense.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnChooseLicense.Effect_2_Transparency = 20;
            btnChooseLicense.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseLicense.ForeColor = Color.FromArgb(46, 54, 71);
            btnChooseLicense.Lighting = true;
            btnChooseLicense.LinearGradient_Background = false;
            btnChooseLicense.LinearGradientPen = false;
            btnChooseLicense.Location = new Point(801, 440);
            btnChooseLicense.Margin = new Padding(3, 4, 3, 4);
            btnChooseLicense.Name = "btnChooseLicense";
            btnChooseLicense.PenWidth = 15;
            btnChooseLicense.Rounding = true;
            btnChooseLicense.RoundingInt = 20;
            btnChooseLicense.Size = new Size(171, 56);
            btnChooseLicense.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnChooseLicense.TabIndex = 55;
            btnChooseLicense.Tag = "Decline";
            btnChooseLicense.TextButton = "Choose License";
            btnChooseLicense.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnChooseLicense.Timer_Effect_1 = 5;
            btnChooseLicense.Timer_RGB = 300;
            btnChooseLicense.Click += btnChooseLicense_Click;
            // 
            // ptbLicense
            // 
            ptbLicense.BackColor = Color.FromArgb(248, 212, 187);
            ptbLicense.ErrorImage = (Image)resources.GetObject("ptbLicense.ErrorImage");
            ptbLicense.Image = (Image)resources.GetObject("ptbLicense.Image");
            ptbLicense.Location = new Point(812, 299);
            ptbLicense.Margin = new Padding(3, 4, 3, 4);
            ptbLicense.Name = "ptbLicense";
            ptbLicense.Size = new Size(148, 131);
            ptbLicense.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbLicense.TabIndex = 56;
            ptbLicense.TabStop = false;
            // 
            // FProfileCompany
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1049, 585);
            Controls.Add(ptbLicense);
            Controls.Add(btnChooseLicense);
            Controls.Add(txtWebsiteLink);
            Controls.Add(cbbWTEnd);
            Controls.Add(label1);
            Controls.Add(cbbWTB);
            Controls.Add(txtTaxIdentification);
            Controls.Add(lblWorkingTime);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnChoosePicture);
            Controls.Add(panel1);
            Controls.Add(txtCompanySize);
            Controls.Add(txtEmail);
            Controls.Add(txtCompanyType);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtCompanyName);
            Controls.Add(lblEmployees);
            Controls.Add(txtDetail);
            Name = "FProfileCompany";
            Text = "FProfileCompany";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLicense).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
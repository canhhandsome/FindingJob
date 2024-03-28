using System.Drawing.Drawing2D;

namespace WinFormProject
{
    partial class FProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProfile));
            this.dtpkBirthDate = new System.Windows.Forms.DateTimePicker();
            this.ptbAvatar = new System.Windows.Forms.PictureBox();
            this.lblDoB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ptbCV = new System.Windows.Forms.PictureBox();
            this.txtFullName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtPhoneNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.txtCitizenID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCV = new ReaLTaiizor.Controls.CyberButton();
            this.btnChooseNewCV = new ReaLTaiizor.Controls.CyberButton();
            this.btnCancel = new ReaLTaiizor.Controls.CyberButton();
            this.btnEdit = new ReaLTaiizor.Controls.CyberButton();
            this.btnSave = new ReaLTaiizor.Controls.CyberButton();
            this.rdoMale = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.rdoFemale = new ReaLTaiizor.Controls.MaterialRadioButton();
            this.btnChoosePicture = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtpkBirthDate
            // 
            this.dtpkBirthDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpkBirthDate.Location = new System.Drawing.Point(415, 276);
            this.dtpkBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkBirthDate.Name = "dtpkBirthDate";
            this.dtpkBirthDate.Size = new System.Drawing.Size(298, 34);
            this.dtpkBirthDate.TabIndex = 6;
            // 
            // ptbAvatar
            // 
            this.ptbAvatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.ptbAvatar.ErrorImage = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.ErrorImage")));
            this.ptbAvatar.Image = ((System.Drawing.Image)(resources.GetObject("ptbAvatar.Image")));
            this.ptbAvatar.Location = new System.Drawing.Point(7, 7);
            this.ptbAvatar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ptbAvatar.Name = "ptbAvatar";
            this.ptbAvatar.Size = new System.Drawing.Size(171, 200);
            this.ptbAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbAvatar.TabIndex = 8;
            this.ptbAvatar.TabStop = false;
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoB.Location = new System.Drawing.Point(415, 239);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(122, 28);
            this.lblDoB.TabIndex = 11;
            this.lblDoB.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(53, 361);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gender";
            // 
            // ptbCV
            // 
            this.ptbCV.BackColor = System.Drawing.Color.White;
            this.ptbCV.Location = new System.Drawing.Point(835, 343);
            this.ptbCV.Name = "ptbCV";
            this.ptbCV.Size = new System.Drawing.Size(123, 141);
            this.ptbCV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCV.TabIndex = 19;
            this.ptbCV.TabStop = false;
            // 
            // txtFullName
            // 
            this.txtFullName.AllowPromptAsInput = true;
            this.txtFullName.AnimateReadOnly = false;
            this.txtFullName.AsciiOnly = false;
            this.txtFullName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFullName.BeepOnError = false;
            this.txtFullName.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFullName.Depth = 0;
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFullName.HidePromptOnLeave = false;
            this.txtFullName.HideSelection = true;
            this.txtFullName.Hint = "Fullname";
            this.txtFullName.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtFullName.LeadingIcon = null;
            this.txtFullName.Location = new System.Drawing.Point(33, 37);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFullName.Mask = "";
            this.txtFullName.MaxLength = 32767;
            this.txtFullName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.PasswordChar = '\0';
            this.txtFullName.PrefixSuffixText = null;
            this.txtFullName.PromptChar = '_';
            this.txtFullName.ReadOnly = false;
            this.txtFullName.RejectInputOnFirstFailure = false;
            this.txtFullName.ResetOnPrompt = true;
            this.txtFullName.ResetOnSpace = true;
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFullName.SelectedText = "";
            this.txtFullName.SelectionLength = 0;
            this.txtFullName.SelectionStart = 0;
            this.txtFullName.ShortcutsEnabled = true;
            this.txtFullName.Size = new System.Drawing.Size(298, 48);
            this.txtFullName.SkipLiterals = true;
            this.txtFullName.TabIndex = 22;
            this.txtFullName.TabStop = false;
            this.txtFullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFullName.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtFullName.TrailingIcon = null;
            this.txtFullName.UseSystemPasswordChar = false;
            this.txtFullName.ValidatingType = null;
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
            this.txtPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPhoneNumber.HidePromptOnLeave = false;
            this.txtPhoneNumber.HideSelection = true;
            this.txtPhoneNumber.Hint = "Phone Number";
            this.txtPhoneNumber.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtPhoneNumber.LeadingIcon = null;
            this.txtPhoneNumber.Location = new System.Drawing.Point(33, 141);
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
            this.txtPhoneNumber.TabIndex = 22;
            this.txtPhoneNumber.TabStop = false;
            this.txtPhoneNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPhoneNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtPhoneNumber.TrailingIcon = null;
            this.txtPhoneNumber.UseSystemPasswordChar = false;
            this.txtPhoneNumber.ValidatingType = null;
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
            this.txtEmail.Location = new System.Drawing.Point(33, 251);
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
            this.txtEmail.TabIndex = 22;
            this.txtEmail.TabStop = false;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtEmail.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtEmail.TrailingIcon = null;
            this.txtEmail.UseSystemPasswordChar = false;
            this.txtEmail.ValidatingType = null;
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
            this.txtAddress.Location = new System.Drawing.Point(415, 37);
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
            this.txtAddress.TabIndex = 22;
            this.txtAddress.TabStop = false;
            this.txtAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtAddress.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtAddress.TrailingIcon = null;
            this.txtAddress.UseSystemPasswordChar = false;
            this.txtAddress.ValidatingType = null;
            // 
            // txtCitizenID
            // 
            this.txtCitizenID.AllowPromptAsInput = true;
            this.txtCitizenID.AnimateReadOnly = false;
            this.txtCitizenID.AsciiOnly = false;
            this.txtCitizenID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCitizenID.BeepOnError = false;
            this.txtCitizenID.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCitizenID.Depth = 0;
            this.txtCitizenID.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCitizenID.HidePromptOnLeave = false;
            this.txtCitizenID.HideSelection = true;
            this.txtCitizenID.Hint = "Citizen ID";
            this.txtCitizenID.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Default;
            this.txtCitizenID.LeadingIcon = null;
            this.txtCitizenID.Location = new System.Drawing.Point(415, 141);
            this.txtCitizenID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCitizenID.Mask = "";
            this.txtCitizenID.MaxLength = 32767;
            this.txtCitizenID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtCitizenID.Name = "txtCitizenID";
            this.txtCitizenID.PasswordChar = '\0';
            this.txtCitizenID.PrefixSuffixText = null;
            this.txtCitizenID.PromptChar = '_';
            this.txtCitizenID.ReadOnly = false;
            this.txtCitizenID.RejectInputOnFirstFailure = false;
            this.txtCitizenID.ResetOnPrompt = true;
            this.txtCitizenID.ResetOnSpace = true;
            this.txtCitizenID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCitizenID.SelectedText = "";
            this.txtCitizenID.SelectionLength = 0;
            this.txtCitizenID.SelectionStart = 0;
            this.txtCitizenID.ShortcutsEnabled = true;
            this.txtCitizenID.Size = new System.Drawing.Size(298, 48);
            this.txtCitizenID.SkipLiterals = true;
            this.txtCitizenID.TabIndex = 22;
            this.txtCitizenID.TabStop = false;
            this.txtCitizenID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCitizenID.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludeLiterals;
            this.txtCitizenID.TrailingIcon = null;
            this.txtCitizenID.UseSystemPasswordChar = false;
            this.txtCitizenID.ValidatingType = null;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.panel1.Controls.Add(this.ptbAvatar);
            this.panel1.Location = new System.Drawing.Point(803, 37);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(183, 213);
            this.panel1.TabIndex = 23;
            // 
            // btnCV
            // 
            this.btnCV.Alpha = 20;
            this.btnCV.BackColor = System.Drawing.Color.Transparent;
            this.btnCV.Background = true;
            this.btnCV.Background_WidthPen = 4F;
            this.btnCV.BackgroundPen = true;
            this.btnCV.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnCV.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnCV.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCV.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnCV.Effect_1 = true;
            this.btnCV.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.Effect_1_Transparency = 25;
            this.btnCV.Effect_2 = true;
            this.btnCV.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCV.Effect_2_Transparency = 20;
            this.btnCV.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnCV.Lighting = true;
            this.btnCV.LinearGradient_Background = false;
            this.btnCV.LinearGradientPen = false;
            this.btnCV.Location = new System.Drawing.Point(837, 508);
            this.btnCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCV.Name = "btnCV";
            this.btnCV.PenWidth = 15;
            this.btnCV.Rounding = true;
            this.btnCV.RoundingInt = 20;
            this.btnCV.Size = new System.Drawing.Size(122, 56);
            this.btnCV.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCV.TabIndex = 25;
            this.btnCV.Tag = "Decline";
            this.btnCV.TextButton = "CV";
            this.btnCV.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnCV.Timer_Effect_1 = 5;
            this.btnCV.Timer_RGB = 300;
            // 
            // btnChooseNewCV
            // 
            this.btnChooseNewCV.Alpha = 20;
            this.btnChooseNewCV.BackColor = System.Drawing.Color.Transparent;
            this.btnChooseNewCV.Background = true;
            this.btnChooseNewCV.Background_WidthPen = 4F;
            this.btnChooseNewCV.BackgroundPen = true;
            this.btnChooseNewCV.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnChooseNewCV.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnChooseNewCV.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChooseNewCV.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnChooseNewCV.Effect_1 = true;
            this.btnChooseNewCV.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.Effect_1_Transparency = 25;
            this.btnChooseNewCV.Effect_2 = true;
            this.btnChooseNewCV.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnChooseNewCV.Effect_2_Transparency = 20;
            this.btnChooseNewCV.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnChooseNewCV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnChooseNewCV.Lighting = true;
            this.btnChooseNewCV.LinearGradient_Background = false;
            this.btnChooseNewCV.LinearGradientPen = false;
            this.btnChooseNewCV.Location = new System.Drawing.Point(837, 508);
            this.btnChooseNewCV.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChooseNewCV.Name = "btnChooseNewCV";
            this.btnChooseNewCV.PenWidth = 15;
            this.btnChooseNewCV.Rounding = true;
            this.btnChooseNewCV.RoundingInt = 20;
            this.btnChooseNewCV.Size = new System.Drawing.Size(122, 56);
            this.btnChooseNewCV.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnChooseNewCV.TabIndex = 26;
            this.btnChooseNewCV.Tag = "Decline";
            this.btnChooseNewCV.TextButton = "Choose CV";
            this.btnChooseNewCV.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnChooseNewCV.Timer_Effect_1 = 5;
            this.btnChooseNewCV.Timer_RGB = 300;
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
            this.btnCancel.Location = new System.Drawing.Point(174, 488);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.PenWidth = 15;
            this.btnCancel.Rounding = true;
            this.btnCancel.RoundingInt = 20;
            this.btnCancel.Size = new System.Drawing.Size(122, 56);
            this.btnCancel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnCancel.TabIndex = 26;
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
            this.btnEdit.Location = new System.Drawing.Point(103, 488);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.PenWidth = 15;
            this.btnEdit.Rounding = true;
            this.btnEdit.RoundingInt = 20;
            this.btnEdit.Size = new System.Drawing.Size(122, 56);
            this.btnEdit.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnEdit.TabIndex = 26;
            this.btnEdit.Tag = "Decline";
            this.btnEdit.TextButton = "Edit";
            this.btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnEdit.Timer_Effect_1 = 5;
            this.btnEdit.Timer_RGB = 300;
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
            this.btnSave.Location = new System.Drawing.Point(33, 488);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.PenWidth = 15;
            this.btnSave.Rounding = true;
            this.btnSave.RoundingInt = 20;
            this.btnSave.Size = new System.Drawing.Size(122, 56);
            this.btnSave.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSave.TabIndex = 26;
            this.btnSave.Tag = "Decline";
            this.btnSave.TextButton = "Save";
            this.btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnSave.Timer_Effect_1 = 5;
            this.btnSave.Timer_RGB = 300;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Depth = 0;
            this.rdoMale.Location = new System.Drawing.Point(33, 400);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoMale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoMale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Ripple = true;
            this.rdoMale.Size = new System.Drawing.Size(70, 37);
            this.rdoMale.TabIndex = 28;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseAccentColor = false;
            this.rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Depth = 0;
            this.rdoFemale.Location = new System.Drawing.Point(145, 400);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(0);
            this.rdoFemale.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rdoFemale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Ripple = true;
            this.rdoFemale.Size = new System.Drawing.Size(87, 37);
            this.rdoFemale.TabIndex = 28;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseAccentColor = false;
            this.rdoFemale.UseVisualStyleBackColor = true;
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
            this.btnChoosePicture.Location = new System.Drawing.Point(810, 259);
            this.btnChoosePicture.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnChoosePicture.Name = "btnChoosePicture";
            this.btnChoosePicture.PenWidth = 15;
            this.btnChoosePicture.Rounding = true;
            this.btnChoosePicture.RoundingInt = 20;
            this.btnChoosePicture.Size = new System.Drawing.Size(171, 56);
            this.btnChoosePicture.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnChoosePicture.TabIndex = 26;
            this.btnChoosePicture.Tag = "Decline";
            this.btnChoosePicture.TextButton = "Choose Picture";
            this.btnChoosePicture.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnChoosePicture.Timer_Effect_1 = 5;
            this.btnChoosePicture.Timer_RGB = 300;
            // 
            // FProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1057, 580);
            this.Controls.Add(this.rdoFemale);
            this.Controls.Add(this.rdoMale);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnChoosePicture);
            this.Controls.Add(this.btnChooseNewCV);
            this.Controls.Add(this.btnCV);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtCitizenID);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.ptbCV);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.dtpkBirthDate);
            this.Controls.Add(this.btnEdit);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ptbAvatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DateTimePicker dtpkBirthDate;
        private PictureBox ptbAvatar;
        private Label lblDoB;
        private Label label8;
        private PictureBox ptbCV;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtFullName;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPhoneNumber;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtAddress;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtCitizenID;
        private Panel panel1;
        private ReaLTaiizor.Controls.CyberButton btnCV;
        private ReaLTaiizor.Controls.CyberButton btnChooseNewCV;
        private ReaLTaiizor.Controls.CyberButton btnCancel;
        private ReaLTaiizor.Controls.CyberButton btnEdit;
        private ReaLTaiizor.Controls.CyberButton btnSave;
        private ReaLTaiizor.Controls.MaterialRadioButton rdoMale;
        private ReaLTaiizor.Controls.MaterialRadioButton rdoFemale;
        private ReaLTaiizor.Controls.CyberButton btnChoosePicture;
    }
}
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
            dtpkBirthDate = new DateTimePicker();
            ptbAvatar = new PictureBox();
            lblDoB = new Label();
            label8 = new Label();
            ptbCV = new PictureBox();
            txtFullName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPhoneNumber = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtAddress = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtCitizenID = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            panel1 = new Panel();
            btnCV = new ReaLTaiizor.Controls.CyberButton();
            btnChooseNewCV = new ReaLTaiizor.Controls.CyberButton();
            btnCancel = new ReaLTaiizor.Controls.CyberButton();
            btnEdit = new ReaLTaiizor.Controls.CyberButton();
            btnSave = new ReaLTaiizor.Controls.CyberButton();
            rdoMale = new ReaLTaiizor.Controls.MaterialRadioButton();
            rdoFemale = new ReaLTaiizor.Controls.MaterialRadioButton();
            btnChoosePicture = new ReaLTaiizor.Controls.CyberButton();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCV).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dtpkBirthDate
            // 
            dtpkBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkBirthDate.Location = new Point(415, 276);
            dtpkBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpkBirthDate.Name = "dtpkBirthDate";
            dtpkBirthDate.Size = new Size(298, 34);
            dtpkBirthDate.TabIndex = 6;
            // 
            // ptbAvatar
            // 
            ptbAvatar.BackColor = Color.FromArgb(248, 212, 187);
            ptbAvatar.ErrorImage = (Image)resources.GetObject("ptbAvatar.ErrorImage");
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.Location = new Point(7, 7);
            ptbAvatar.Margin = new Padding(3, 4, 3, 4);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(171, 200);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 8;
            ptbAvatar.TabStop = false;
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoB.ForeColor = SystemColors.ControlText;
            lblDoB.Location = new Point(415, 239);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(122, 28);
            lblDoB.TabIndex = 11;
            lblDoB.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(53, 361);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 11;
            label8.Text = "Gender";
            // 
            // ptbCV
            // 
            ptbCV.BackColor = Color.White;
            ptbCV.Location = new Point(835, 343);
            ptbCV.Name = "ptbCV";
            ptbCV.Size = new Size(123, 141);
            ptbCV.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCV.TabIndex = 19;
            ptbCV.TabStop = false;
            // 
            // txtFullName
            // 
            txtFullName.AllowPromptAsInput = true;
            txtFullName.AnimateReadOnly = false;
            txtFullName.AsciiOnly = false;
            txtFullName.BackgroundImageLayout = ImageLayout.None;
            txtFullName.BeepOnError = false;
            txtFullName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtFullName.Depth = 0;
            txtFullName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtFullName.HidePromptOnLeave = false;
            txtFullName.HideSelection = true;
            txtFullName.Hint = "Fullname";
            txtFullName.InsertKeyMode = InsertKeyMode.Default;
            txtFullName.LeadingIcon = null;
            txtFullName.Location = new Point(33, 37);
            txtFullName.Margin = new Padding(3, 4, 3, 4);
            txtFullName.Mask = "";
            txtFullName.MaxLength = 32767;
            txtFullName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtFullName.Name = "txtFullName";
            txtFullName.PasswordChar = '\0';
            txtFullName.PrefixSuffixText = null;
            txtFullName.PromptChar = '_';
            txtFullName.ReadOnly = false;
            txtFullName.RejectInputOnFirstFailure = false;
            txtFullName.ResetOnPrompt = true;
            txtFullName.ResetOnSpace = true;
            txtFullName.RightToLeft = RightToLeft.No;
            txtFullName.SelectedText = "";
            txtFullName.SelectionLength = 0;
            txtFullName.SelectionStart = 0;
            txtFullName.ShortcutsEnabled = true;
            txtFullName.Size = new Size(298, 48);
            txtFullName.SkipLiterals = true;
            txtFullName.TabIndex = 22;
            txtFullName.TabStop = false;
            txtFullName.TextAlign = HorizontalAlignment.Left;
            txtFullName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtFullName.TrailingIcon = null;
            txtFullName.UseSystemPasswordChar = false;
            txtFullName.ValidatingType = null;
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
            txtPhoneNumber.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.HidePromptOnLeave = false;
            txtPhoneNumber.HideSelection = true;
            txtPhoneNumber.Hint = "Phone Number";
            txtPhoneNumber.InsertKeyMode = InsertKeyMode.Default;
            txtPhoneNumber.LeadingIcon = null;
            txtPhoneNumber.Location = new Point(33, 141);
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
            txtPhoneNumber.TabIndex = 22;
            txtPhoneNumber.TabStop = false;
            txtPhoneNumber.TextAlign = HorizontalAlignment.Left;
            txtPhoneNumber.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPhoneNumber.TrailingIcon = null;
            txtPhoneNumber.UseSystemPasswordChar = false;
            txtPhoneNumber.ValidatingType = null;
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
            txtEmail.Location = new Point(33, 251);
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
            txtEmail.TabIndex = 22;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
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
            txtAddress.Location = new Point(415, 37);
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
            txtAddress.TabIndex = 22;
            txtAddress.TabStop = false;
            txtAddress.TextAlign = HorizontalAlignment.Left;
            txtAddress.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtAddress.TrailingIcon = null;
            txtAddress.UseSystemPasswordChar = false;
            txtAddress.ValidatingType = null;
            // 
            // txtCitizenID
            // 
            txtCitizenID.AllowPromptAsInput = true;
            txtCitizenID.AnimateReadOnly = false;
            txtCitizenID.AsciiOnly = false;
            txtCitizenID.BackgroundImageLayout = ImageLayout.None;
            txtCitizenID.BeepOnError = false;
            txtCitizenID.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtCitizenID.Depth = 0;
            txtCitizenID.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            txtCitizenID.HidePromptOnLeave = false;
            txtCitizenID.HideSelection = true;
            txtCitizenID.Hint = "Citizen ID";
            txtCitizenID.InsertKeyMode = InsertKeyMode.Default;
            txtCitizenID.LeadingIcon = null;
            txtCitizenID.Location = new Point(415, 141);
            txtCitizenID.Margin = new Padding(3, 4, 3, 4);
            txtCitizenID.Mask = "";
            txtCitizenID.MaxLength = 32767;
            txtCitizenID.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtCitizenID.Name = "txtCitizenID";
            txtCitizenID.PasswordChar = '\0';
            txtCitizenID.PrefixSuffixText = null;
            txtCitizenID.PromptChar = '_';
            txtCitizenID.ReadOnly = false;
            txtCitizenID.RejectInputOnFirstFailure = false;
            txtCitizenID.ResetOnPrompt = true;
            txtCitizenID.ResetOnSpace = true;
            txtCitizenID.RightToLeft = RightToLeft.No;
            txtCitizenID.SelectedText = "";
            txtCitizenID.SelectionLength = 0;
            txtCitizenID.SelectionStart = 0;
            txtCitizenID.ShortcutsEnabled = true;
            txtCitizenID.Size = new Size(298, 48);
            txtCitizenID.SkipLiterals = true;
            txtCitizenID.TabIndex = 22;
            txtCitizenID.TabStop = false;
            txtCitizenID.TextAlign = HorizontalAlignment.Left;
            txtCitizenID.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtCitizenID.TrailingIcon = null;
            txtCitizenID.UseSystemPasswordChar = false;
            txtCitizenID.ValidatingType = null;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(248, 212, 187);
            panel1.Controls.Add(ptbAvatar);
            panel1.Location = new Point(803, 37);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(183, 213);
            panel1.TabIndex = 23;
            // 
            // btnCV
            // 
            btnCV.Alpha = 20;
            btnCV.BackColor = Color.Transparent;
            btnCV.Background = true;
            btnCV.Background_WidthPen = 4F;
            btnCV.BackgroundPen = true;
            btnCV.ColorBackground = Color.FromArgb(176, 226, 243);
            btnCV.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnCV.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnCV.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnCV.ColorLighting = Color.FromArgb(128, 128, 255);
            btnCV.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnCV.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnCV.Cursor = Cursors.Hand;
            btnCV.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnCV.Effect_1 = true;
            btnCV.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCV.Effect_1_Transparency = 25;
            btnCV.Effect_2 = true;
            btnCV.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnCV.Effect_2_Transparency = 20;
            btnCV.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnCV.ForeColor = Color.FromArgb(46, 54, 71);
            btnCV.Lighting = true;
            btnCV.LinearGradient_Background = false;
            btnCV.LinearGradientPen = false;
            btnCV.Location = new Point(837, 508);
            btnCV.Margin = new Padding(3, 4, 3, 4);
            btnCV.Name = "btnCV";
            btnCV.PenWidth = 15;
            btnCV.Rounding = true;
            btnCV.RoundingInt = 20;
            btnCV.Size = new Size(122, 56);
            btnCV.SmoothingMode = SmoothingMode.HighQuality;
            btnCV.TabIndex = 25;
            btnCV.Tag = "Decline";
            btnCV.TextButton = "CV";
            btnCV.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnCV.Timer_Effect_1 = 5;
            btnCV.Timer_RGB = 300;
            btnCV.Click += btnCV_Click;
            // 
            // btnChooseNewCV
            // 
            btnChooseNewCV.Alpha = 20;
            btnChooseNewCV.BackColor = Color.Transparent;
            btnChooseNewCV.Background = true;
            btnChooseNewCV.Background_WidthPen = 4F;
            btnChooseNewCV.BackgroundPen = true;
            btnChooseNewCV.ColorBackground = Color.FromArgb(176, 226, 243);
            btnChooseNewCV.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnChooseNewCV.ColorLighting = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.Cursor = Cursors.Hand;
            btnChooseNewCV.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnChooseNewCV.Effect_1 = true;
            btnChooseNewCV.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.Effect_1_Transparency = 25;
            btnChooseNewCV.Effect_2 = true;
            btnChooseNewCV.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnChooseNewCV.Effect_2_Transparency = 20;
            btnChooseNewCV.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseNewCV.ForeColor = Color.FromArgb(46, 54, 71);
            btnChooseNewCV.Lighting = true;
            btnChooseNewCV.LinearGradient_Background = false;
            btnChooseNewCV.LinearGradientPen = false;
            btnChooseNewCV.Location = new Point(837, 508);
            btnChooseNewCV.Margin = new Padding(3, 4, 3, 4);
            btnChooseNewCV.Name = "btnChooseNewCV";
            btnChooseNewCV.PenWidth = 15;
            btnChooseNewCV.Rounding = true;
            btnChooseNewCV.RoundingInt = 20;
            btnChooseNewCV.Size = new Size(122, 56);
            btnChooseNewCV.SmoothingMode = SmoothingMode.HighQuality;
            btnChooseNewCV.TabIndex = 26;
            btnChooseNewCV.Tag = "Decline";
            btnChooseNewCV.TextButton = "Choose CV";
            btnChooseNewCV.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnChooseNewCV.Timer_Effect_1 = 5;
            btnChooseNewCV.Timer_RGB = 300;
            btnChooseNewCV.Click += btnChooseNewCV_Click;
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
            btnCancel.Location = new Point(174, 488);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.PenWidth = 15;
            btnCancel.Rounding = true;
            btnCancel.RoundingInt = 20;
            btnCancel.Size = new Size(122, 56);
            btnCancel.SmoothingMode = SmoothingMode.HighQuality;
            btnCancel.TabIndex = 26;
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
            btnEdit.Location = new Point(103, 488);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.PenWidth = 15;
            btnEdit.Rounding = true;
            btnEdit.RoundingInt = 20;
            btnEdit.Size = new Size(122, 56);
            btnEdit.SmoothingMode = SmoothingMode.HighQuality;
            btnEdit.TabIndex = 26;
            btnEdit.Tag = "Decline";
            btnEdit.TextButton = "Edit";
            btnEdit.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnEdit.Timer_Effect_1 = 5;
            btnEdit.Timer_RGB = 300;
            btnEdit.Click += btnEdit_Click;
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
            btnSave.Location = new Point(33, 488);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.PenWidth = 15;
            btnSave.Rounding = true;
            btnSave.RoundingInt = 20;
            btnSave.Size = new Size(122, 56);
            btnSave.SmoothingMode = SmoothingMode.HighQuality;
            btnSave.TabIndex = 26;
            btnSave.Tag = "Decline";
            btnSave.TextButton = "Save";
            btnSave.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSave.Timer_Effect_1 = 5;
            btnSave.Timer_RGB = 300;
            btnSave.Click += btnSave_Click;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.Depth = 0;
            rdoMale.Location = new Point(33, 400);
            rdoMale.Margin = new Padding(0);
            rdoMale.MouseLocation = new Point(-1, -1);
            rdoMale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdoMale.Name = "rdoMale";
            rdoMale.Ripple = true;
            rdoMale.Size = new Size(70, 37);
            rdoMale.TabIndex = 28;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseAccentColor = false;
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdoFemale
            // 
            rdoFemale.AutoSize = true;
            rdoFemale.Depth = 0;
            rdoFemale.Location = new Point(145, 400);
            rdoFemale.Margin = new Padding(0);
            rdoFemale.MouseLocation = new Point(-1, -1);
            rdoFemale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rdoFemale.Name = "rdoFemale";
            rdoFemale.Ripple = true;
            rdoFemale.Size = new Size(87, 37);
            rdoFemale.TabIndex = 28;
            rdoFemale.TabStop = true;
            rdoFemale.Text = "Female";
            rdoFemale.UseAccentColor = false;
            rdoFemale.UseVisualStyleBackColor = true;
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
            btnChoosePicture.Location = new Point(810, 259);
            btnChoosePicture.Margin = new Padding(3, 4, 3, 4);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.PenWidth = 15;
            btnChoosePicture.Rounding = true;
            btnChoosePicture.RoundingInt = 20;
            btnChoosePicture.Size = new Size(171, 56);
            btnChoosePicture.SmoothingMode = SmoothingMode.HighQuality;
            btnChoosePicture.TabIndex = 26;
            btnChoosePicture.Tag = "Decline";
            btnChoosePicture.TextButton = "Choose Picture";
            btnChoosePicture.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnChoosePicture.Timer_Effect_1 = 5;
            btnChoosePicture.Timer_RGB = 300;
            btnChoosePicture.Click += btnChoosePicture_Click;
            // 
            // FProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1057, 580);
            Controls.Add(rdoFemale);
            Controls.Add(rdoMale);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnChoosePicture);
            Controls.Add(btnChooseNewCV);
            Controls.Add(btnCV);
            Controls.Add(panel1);
            Controls.Add(txtEmail);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtCitizenID);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(ptbCV);
            Controls.Add(label8);
            Controls.Add(lblDoB);
            Controls.Add(dtpkBirthDate);
            Controls.Add(btnEdit);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FProfile";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCV).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
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
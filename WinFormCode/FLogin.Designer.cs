namespace WinFormProject
{
    partial class FLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnforgotpw = new ReaLTaiizor.Controls.HopeRoundButton();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            rdojobseeker = new ReaLTaiizor.Controls.ParrotRadioButton();
            rdocompany = new ReaLTaiizor.Controls.ParrotRadioButton();
            txtemail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtpassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            sRemember = new ReaLTaiizor.Controls.MaterialSwitch();
            btnsignup = new ReaLTaiizor.Controls.ParrotButton();
            btnsignin = new ReaLTaiizor.Controls.ParrotButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(95, 34);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(201, 46);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(65, 59, 96);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(297, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.White;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.DimGray;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(180, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(180, 160, 160);
            nightControlBox1.Location = new Point(1063, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(25, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.FromArgb(64, 64, 64);
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(25, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.FromArgb(64, 64, 64);
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 26);
            panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(519, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(683, 437);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // btnforgotpw
            // 
            btnforgotpw.BorderColor = Color.FromArgb(220, 223, 230);
            btnforgotpw.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnforgotpw.DangerColor = Color.FromArgb(245, 108, 108);
            btnforgotpw.DefaultColor = Color.FromArgb(255, 255, 255);
            btnforgotpw.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnforgotpw.ForeColor = Color.Black;
            btnforgotpw.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnforgotpw.InfoColor = Color.FromArgb(144, 147, 153);
            btnforgotpw.Location = new Point(285, 336);
            btnforgotpw.Name = "btnforgotpw";
            btnforgotpw.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnforgotpw.Size = new Size(152, 36);
            btnforgotpw.SuccessColor = Color.FromArgb(103, 194, 58);
            btnforgotpw.TabIndex = 28;
            btnforgotpw.Text = "Forgot Password?";
            btnforgotpw.TextColor = Color.White;
            btnforgotpw.WarningColor = Color.FromArgb(230, 162, 60);
            btnforgotpw.Click += btnforgotpw_Click;
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(125, 96);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(271, 34);
            foxLabel2.TabIndex = 29;
            foxLabel2.Text = "Sign in With Email Address";
            // 
            // rdojobseeker
            // 
            rdojobseeker.Checked = false;
            rdojobseeker.ForeColor = Color.Black;
            rdojobseeker.Location = new Point(125, 152);
            rdojobseeker.Name = "rdojobseeker";
            rdojobseeker.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdojobseeker.RadioColor = Color.FromArgb(0, 162, 250);
            rdojobseeker.RadioHoverColor = Color.Fuchsia;
            rdojobseeker.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdojobseeker.Size = new Size(100, 16);
            rdojobseeker.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdojobseeker.TabIndex = 30;
            rdojobseeker.Text = "Job Seeker";
            rdojobseeker.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // rdocompany
            // 
            rdocompany.Checked = false;
            rdocompany.ForeColor = Color.Black;
            rdocompany.Location = new Point(297, 152);
            rdocompany.Name = "rdocompany";
            rdocompany.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdocompany.RadioColor = Color.FromArgb(0, 162, 250);
            rdocompany.RadioHoverColor = Color.Fuchsia;
            rdocompany.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdocompany.Size = new Size(100, 16);
            rdocompany.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdocompany.TabIndex = 30;
            rdocompany.Text = "Company";
            rdocompany.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // txtemail
            // 
            txtemail.AnimateReadOnly = false;
            txtemail.AutoCompleteMode = AutoCompleteMode.None;
            txtemail.AutoCompleteSource = AutoCompleteSource.None;
            txtemail.BackgroundImageLayout = ImageLayout.None;
            txtemail.CharacterCasing = CharacterCasing.Normal;
            txtemail.Depth = 0;
            txtemail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtemail.HideSelection = true;
            txtemail.Hint = "Enter Email Address";
            txtemail.LeadingIcon = null;
            txtemail.Location = new Point(73, 191);
            txtemail.MaxLength = 32767;
            txtemail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtemail.Name = "txtemail";
            txtemail.PasswordChar = '\0';
            txtemail.PrefixSuffixText = null;
            txtemail.ReadOnly = false;
            txtemail.RightToLeft = RightToLeft.No;
            txtemail.SelectedText = "";
            txtemail.SelectionLength = 0;
            txtemail.SelectionStart = 0;
            txtemail.ShortcutsEnabled = true;
            txtemail.Size = new Size(336, 48);
            txtemail.TabIndex = 31;
            txtemail.TabStop = false;
            txtemail.TextAlign = HorizontalAlignment.Left;
            txtemail.TrailingIcon = null;
            txtemail.UseSystemPasswordChar = false;
            // 
            // txtpassword
            // 
            txtpassword.AnimateReadOnly = false;
            txtpassword.AutoCompleteMode = AutoCompleteMode.None;
            txtpassword.AutoCompleteSource = AutoCompleteSource.None;
            txtpassword.BackgroundImageLayout = ImageLayout.None;
            txtpassword.CharacterCasing = CharacterCasing.Normal;
            txtpassword.Depth = 0;
            txtpassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtpassword.HideSelection = true;
            txtpassword.Hint = "Enter Password";
            txtpassword.LeadingIcon = null;
            txtpassword.Location = new Point(73, 260);
            txtpassword.MaxLength = 32767;
            txtpassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.PrefixSuffixText = null;
            txtpassword.ReadOnly = false;
            txtpassword.RightToLeft = RightToLeft.No;
            txtpassword.SelectedText = "";
            txtpassword.SelectionLength = 0;
            txtpassword.SelectionStart = 0;
            txtpassword.ShortcutsEnabled = true;
            txtpassword.Size = new Size(336, 48);
            txtpassword.TabIndex = 32;
            txtpassword.TabStop = false;
            txtpassword.TextAlign = HorizontalAlignment.Left;
            txtpassword.TrailingIcon = null;
            txtpassword.UseSystemPasswordChar = false;
            // 
            // sRemember
            // 
            sRemember.AutoSize = true;
            sRemember.Depth = 0;
            sRemember.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point);
            sRemember.Location = new Point(57, 335);
            sRemember.Margin = new Padding(0);
            sRemember.MouseLocation = new Point(-1, -1);
            sRemember.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            sRemember.Name = "sRemember";
            sRemember.Ripple = true;
            sRemember.Size = new Size(168, 37);
            sRemember.TabIndex = 33;
            sRemember.Text = "Remember me?";
            sRemember.UseAccentColor = false;
            sRemember.UseVisualStyleBackColor = true;
            // 
            // btnsignup
            // 
            btnsignup.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnsignup.ButtonImage = null;
            btnsignup.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnsignup.ButtonText = "Sign Up";
            btnsignup.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnsignup.ClickTextColor = Color.Black;
            btnsignup.CornerRadius = 6;
            btnsignup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsignup.Horizontal_Alignment = StringAlignment.Center;
            btnsignup.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnsignup.HoverTextColor = Color.Black;
            btnsignup.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnsignup.Location = new Point(297, 388);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(131, 38);
            btnsignup.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnsignup.TabIndex = 34;
            btnsignup.TextColor = Color.Black;
            btnsignup.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnsignup.Vertical_Alignment = StringAlignment.Center;
            btnsignup.Click += btnsignup_Click;
            // 
            // btnsignin
            // 
            btnsignin.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnsignin.ButtonImage = null;
            btnsignin.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnsignin.ButtonText = "Sign In";
            btnsignin.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnsignin.ClickTextColor = Color.Black;
            btnsignin.CornerRadius = 6;
            btnsignin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsignin.Horizontal_Alignment = StringAlignment.Center;
            btnsignin.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnsignin.HoverTextColor = Color.Black;
            btnsignin.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnsignin.Location = new Point(73, 388);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(131, 38);
            btnsignin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnsignin.TabIndex = 34;
            btnsignin.TextColor = Color.Black;
            btnsignin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnsignin.Vertical_Alignment = StringAlignment.Center;
            btnsignin.Click += btnsignin_Click;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1202, 463);
            Controls.Add(btnsignin);
            Controls.Add(btnsignup);
            Controls.Add(sRemember);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            Controls.Add(rdocompany);
            Controls.Add(rdojobseeker);
            Controls.Add(foxLabel2);
            Controls.Add(btnforgotpw);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(261, 61);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeRoundButton btnforgotpw;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ParrotRadioButton rdojobseeker;
        private ReaLTaiizor.Controls.ParrotRadioButton rdocompany;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtemail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtpassword;
        private ReaLTaiizor.Controls.MaterialSwitch sRemember;
        private ReaLTaiizor.Controls.ParrotButton btnsignup;
        private ReaLTaiizor.Controls.ParrotButton btnsignin;
    }
}
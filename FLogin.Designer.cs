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
            txtemail = new ReaLTaiizor.Controls.HopeTextBox();
            btnsignup = new ReaLTaiizor.Controls.Button();
            btnsignin = new ReaLTaiizor.Controls.Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            txtpassword = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            label3 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            swremember = new ReaLTaiizor.Controls.HopeSwitch();
            btnforgotpw = new ReaLTaiizor.Controls.HopeRoundButton();
            lblremember = new Label();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            rdojobseeker = new ReaLTaiizor.Controls.ParrotRadioButton();
            rdocompany = new ReaLTaiizor.Controls.ParrotRadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtemail
            // 
            txtemail.BackColor = Color.White;
            txtemail.BaseColor = Color.FromArgb(44, 55, 66);
            txtemail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtemail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtemail.Cursor = Cursors.IBeam;
            txtemail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = Color.FromArgb(48, 49, 51);
            txtemail.Hint = "Enter your email";
            txtemail.Location = new Point(69, 272);
            txtemail.MaxLength = 32767;
            txtemail.Multiline = false;
            txtemail.Name = "txtemail";
            txtemail.PasswordChar = '\0';
            txtemail.ScrollBars = ScrollBars.None;
            txtemail.SelectedText = "";
            txtemail.SelectionLength = 0;
            txtemail.SelectionStart = 0;
            txtemail.Size = new Size(445, 43);
            txtemail.TabIndex = 10;
            txtemail.TabStop = false;
            txtemail.UseSystemPasswordChar = false;
            // 
            // btnsignup
            // 
            btnsignup.BackColor = Color.Transparent;
            btnsignup.BorderColor = Color.FromArgb(32, 34, 37);
            btnsignup.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnsignup.EnteredColor = Color.FromArgb(32, 34, 37);
            btnsignup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsignup.Image = null;
            btnsignup.ImageAlign = ContentAlignment.MiddleLeft;
            btnsignup.InactiveColor = Color.FromArgb(32, 34, 37);
            btnsignup.Location = new Point(353, 539);
            btnsignup.Name = "btnsignup";
            btnsignup.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnsignup.PressedColor = Color.FromArgb(165, 37, 37);
            btnsignup.Size = new Size(150, 51);
            btnsignup.TabIndex = 7;
            btnsignup.Text = "Sign Up";
            btnsignup.TextAlignment = StringAlignment.Center;
            btnsignup.Click += btnsignup_Click;
            // 
            // btnsignin
            // 
            btnsignin.BackColor = Color.Transparent;
            btnsignin.BorderColor = Color.FromArgb(32, 34, 37);
            btnsignin.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnsignin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnsignin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnsignin.Image = null;
            btnsignin.ImageAlign = ContentAlignment.MiddleLeft;
            btnsignin.InactiveColor = Color.FromArgb(32, 34, 37);
            btnsignin.Location = new Point(69, 539);
            btnsignin.Name = "btnsignin";
            btnsignin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnsignin.PressedColor = Color.FromArgb(165, 37, 37);
            btnsignin.Size = new Size(150, 51);
            btnsignin.TabIndex = 1;
            btnsignin.Text = "Sign In";
            btnsignin.TextAlignment = StringAlignment.Center;
            btnsignin.Click += btnsignin_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(224, 224, 224);
            bigLabel1.Location = new Point(109, 45);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(247, 57);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(339, 45);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtpassword
            // 
            txtpassword.BackColor = Color.White;
            txtpassword.BaseColor = Color.FromArgb(44, 55, 66);
            txtpassword.BorderColorA = Color.FromArgb(64, 158, 255);
            txtpassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtpassword.Cursor = Cursors.IBeam;
            txtpassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtpassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtpassword.Hint = "Enter your password";
            txtpassword.Location = new Point(69, 379);
            txtpassword.MaxLength = 32767;
            txtpassword.Multiline = false;
            txtpassword.Name = "txtpassword";
            txtpassword.PasswordChar = '*';
            txtpassword.ScrollBars = ScrollBars.None;
            txtpassword.SelectedText = "";
            txtpassword.SelectionLength = 0;
            txtpassword.SelectionStart = 0;
            txtpassword.Size = new Size(445, 43);
            txtpassword.TabIndex = 3;
            txtpassword.TabStop = false;
            txtpassword.UseSystemPasswordChar = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(69, 249);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 15;
            label1.Text = "Email Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(69, 356);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 15;
            label3.Text = "Password";
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
            nightControlBox1.Location = new Point(1235, 0);
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1374, 35);
            panel1.TabIndex = 17;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(593, 35);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(781, 582);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // swremember
            // 
            swremember.AutoSize = true;
            swremember.BaseColor = Color.White;
            swremember.BaseOffColor = Color.FromArgb(220, 223, 230);
            swremember.BaseOnColor = Color.FromArgb(64, 158, 255);
            swremember.Location = new Point(69, 467);
            swremember.Margin = new Padding(3, 4, 3, 4);
            swremember.Name = "swremember";
            swremember.Size = new Size(40, 20);
            swremember.TabIndex = 20;
            swremember.UseVisualStyleBackColor = true;
            // 
            // btnforgotpw
            // 
            btnforgotpw.BorderColor = Color.FromArgb(220, 223, 230);
            btnforgotpw.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            btnforgotpw.DangerColor = Color.FromArgb(245, 108, 108);
            btnforgotpw.DefaultColor = Color.FromArgb(255, 255, 255);
            btnforgotpw.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnforgotpw.HoverTextColor = Color.FromArgb(48, 49, 51);
            btnforgotpw.InfoColor = Color.FromArgb(144, 147, 153);
            btnforgotpw.Location = new Point(339, 467);
            btnforgotpw.Margin = new Padding(3, 4, 3, 4);
            btnforgotpw.Name = "btnforgotpw";
            btnforgotpw.PrimaryColor = Color.FromArgb(64, 158, 255);
            btnforgotpw.Size = new Size(174, 48);
            btnforgotpw.SuccessColor = Color.FromArgb(103, 194, 58);
            btnforgotpw.TabIndex = 28;
            btnforgotpw.Text = "Forgot Password?";
            btnforgotpw.TextColor = Color.White;
            btnforgotpw.WarningColor = Color.FromArgb(230, 162, 60);
            btnforgotpw.Click += btnforgotpw_Click;
            // 
            // lblremember
            // 
            lblremember.AutoSize = true;
            lblremember.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            lblremember.ForeColor = Color.White;
            lblremember.Location = new Point(131, 467);
            lblremember.Name = "lblremember";
            lblremember.Size = new Size(130, 23);
            lblremember.TabIndex = 15;
            lblremember.Text = "Remember me?";
            lblremember.Click += lblremember_Click;
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(143, 128);
            foxLabel2.Margin = new Padding(3, 4, 3, 4);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(310, 45);
            foxLabel2.TabIndex = 29;
            foxLabel2.Text = "Sign in With Email Address";
            // 
            // rdojobseeker
            // 
            rdojobseeker.Checked = false;
            rdojobseeker.ForeColor = Color.White;
            rdojobseeker.Location = new Point(143, 203);
            rdojobseeker.Margin = new Padding(3, 4, 3, 4);
            rdojobseeker.Name = "rdojobseeker";
            rdojobseeker.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdojobseeker.RadioColor = Color.FromArgb(0, 162, 250);
            rdojobseeker.RadioHoverColor = Color.Fuchsia;
            rdojobseeker.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdojobseeker.Size = new Size(114, 21);
            rdojobseeker.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdojobseeker.TabIndex = 30;
            rdojobseeker.Text = "Job Seeker";
            rdojobseeker.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // rdocompany
            // 
            rdocompany.Checked = false;
            rdocompany.ForeColor = Color.White;
            rdocompany.Location = new Point(339, 203);
            rdocompany.Margin = new Padding(3, 4, 3, 4);
            rdocompany.Name = "rdocompany";
            rdocompany.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdocompany.RadioColor = Color.FromArgb(0, 162, 250);
            rdocompany.RadioHoverColor = Color.Fuchsia;
            rdocompany.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdocompany.Size = new Size(114, 21);
            rdocompany.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdocompany.TabIndex = 30;
            rdocompany.Text = "Company";
            rdocompany.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(1374, 617);
            Controls.Add(rdocompany);
            Controls.Add(rdojobseeker);
            Controls.Add(foxLabel2);
            Controls.Add(btnforgotpw);
            Controls.Add(swremember);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(lblremember);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(btnsignin);
            Controls.Add(btnsignup);
            Controls.Add(txtpassword);
            Controls.Add(txtemail);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(298, 81);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox txtemail;
        private ReaLTaiizor.Controls.Button btnsignup;
        private ReaLTaiizor.Controls.Button btnsignin;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtpassword;
        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeSwitch swremember;
        private ReaLTaiizor.Controls.HopeRoundButton btnforgotpw;
        private Label lblremember;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ParrotRadioButton rdojobseeker;
        private ReaLTaiizor.Controls.ParrotRadioButton rdocompany;
    }
}
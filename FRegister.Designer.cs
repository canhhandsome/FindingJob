namespace WinFormProject
{
    partial class FRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRegister));
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            btnSignup = new ReaLTaiizor.Controls.Button();
            btnSignin = new ReaLTaiizor.Controls.Button();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            materialCheckBox1 = new ReaLTaiizor.Controls.MaterialCheckBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            rdoCompany = new ReaLTaiizor.Controls.ParrotRadioButton();
            rdoJobSeeker = new ReaLTaiizor.Controls.ParrotRadioButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BaseColor = Color.FromArgb(44, 55, 66);
            txtEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtEmail.Cursor = Cursors.IBeam;
            txtEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmail.Hint = "Enter your email";
            txtEmail.Location = new Point(60, 204);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(389, 38);
            txtEmail.TabIndex = 10;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.FromArgb(44, 55, 66);
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Cursor = Cursors.IBeam;
            txtName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtName.ForeColor = Color.FromArgb(48, 49, 51);
            txtName.Hint = "Enter your full name";
            txtName.Location = new Point(60, 288);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(389, 38);
            txtName.TabIndex = 3;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.White;
            btnSignup.BorderColor = Color.FromArgb(32, 34, 37);
            btnSignup.Enabled = false;
            btnSignup.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSignup.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSignup.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignup.Image = null;
            btnSignup.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignup.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSignup.Location = new Point(309, 487);
            btnSignup.Margin = new Padding(3, 2, 3, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSignup.PressedColor = Color.FromArgb(165, 37, 37);
            btnSignup.Size = new Size(131, 38);
            btnSignup.TabIndex = 7;
            btnSignup.Text = "Sign Up";
            btnSignup.TextAlignment = StringAlignment.Center;
            btnSignup.Click += btnSignup_Click;
            // 
            // btnSignin
            // 
            btnSignin.BackColor = Color.Transparent;
            btnSignin.BorderColor = Color.FromArgb(32, 34, 37);
            btnSignin.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnSignin.EnteredColor = Color.FromArgb(32, 34, 37);
            btnSignin.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSignin.Image = null;
            btnSignin.ImageAlign = ContentAlignment.MiddleLeft;
            btnSignin.InactiveColor = Color.FromArgb(32, 34, 37);
            btnSignin.Location = new Point(60, 487);
            btnSignin.Margin = new Padding(3, 2, 3, 2);
            btnSignin.Name = "btnSignin";
            btnSignin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSignin.PressedColor = Color.FromArgb(165, 37, 37);
            btnSignin.Size = new Size(131, 38);
            btnSignin.TabIndex = 1;
            btnSignin.Text = "Sign In";
            btnSignin.TextAlignment = StringAlignment.Center;
            btnSignin.Click += button2_Click;
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Cursor = Cursors.Hand;
            labelEdit1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            labelEdit1.ForeColor = Color.FromArgb(224, 224, 224);
            labelEdit1.Location = new Point(95, 425);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(354, 40);
            labelEdit1.TabIndex = 11;
            labelEdit1.Text = "I have read and agree to CTV's Terms of Service \r\nand Privacy Policy regarding my private information.";
            labelEdit1.Click += labelEdit1_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(224, 224, 224);
            bigLabel1.Location = new Point(95, 46);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(201, 46);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Welcome to";
            bigLabel1.Click += bigLabel1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(297, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BaseColor = Color.FromArgb(44, 55, 66);
            txtPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPassword.Cursor = Cursors.IBeam;
            txtPassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtPassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtPassword.Hint = "Enter your password";
            txtPassword.Location = new Point(60, 372);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(389, 38);
            txtPassword.TabIndex = 3;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.White;
            label1.Location = new Point(60, 187);
            label1.Name = "label1";
            label1.Size = new Size(81, 15);
            label1.TabIndex = 15;
            label1.Text = "Email Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(60, 271);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 15;
            label2.Text = "Full name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 355);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 15;
            label3.Text = "Password";
            // 
            // materialCheckBox1
            // 
            materialCheckBox1.AutoSize = true;
            materialCheckBox1.Depth = 0;
            materialCheckBox1.Location = new Point(60, 425);
            materialCheckBox1.Margin = new Padding(0);
            materialCheckBox1.MouseLocation = new Point(-1, -1);
            materialCheckBox1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            materialCheckBox1.Name = "materialCheckBox1";
            materialCheckBox1.ReadOnly = false;
            materialCheckBox1.Ripple = true;
            materialCheckBox1.Size = new Size(35, 37);
            materialCheckBox1.TabIndex = 16;
            materialCheckBox1.UseAccentColor = false;
            materialCheckBox1.UseVisualStyleBackColor = true;
            materialCheckBox1.CheckedChanged += materialCheckBox1_CheckedChanged;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.White;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(1063, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
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
            pictureBox2.Size = new Size(683, 530);
            pictureBox2.TabIndex = 18;
            pictureBox2.TabStop = false;
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(115, 113);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(250, 34);
            foxLabel2.TabIndex = 19;
            foxLabel2.Text = "Sign up With Email Address";
            // 
            // rdoCompany
            // 
            rdoCompany.Checked = false;
            rdoCompany.ForeColor = Color.White;
            rdoCompany.Location = new Point(287, 153);
            rdoCompany.Name = "rdoCompany";
            rdoCompany.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdoCompany.RadioColor = Color.FromArgb(0, 162, 250);
            rdoCompany.RadioHoverColor = Color.Fuchsia;
            rdoCompany.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdoCompany.Size = new Size(100, 16);
            rdoCompany.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdoCompany.TabIndex = 31;
            rdoCompany.Text = "Company";
            rdoCompany.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // rdoJobSeeker
            // 
            rdoJobSeeker.Checked = false;
            rdoJobSeeker.ForeColor = Color.White;
            rdoJobSeeker.Location = new Point(115, 153);
            rdoJobSeeker.Name = "rdoJobSeeker";
            rdoJobSeeker.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdoJobSeeker.RadioColor = Color.FromArgb(0, 162, 250);
            rdoJobSeeker.RadioHoverColor = Color.Fuchsia;
            rdoJobSeeker.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdoJobSeeker.Size = new Size(100, 16);
            rdoJobSeeker.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdoJobSeeker.TabIndex = 32;
            rdoJobSeeker.Text = "Job Seeker";
            rdoJobSeeker.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(1202, 556);
            Controls.Add(rdoCompany);
            Controls.Add(rdoJobSeeker);
            Controls.Add(foxLabel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(materialCheckBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(labelEdit1);
            Controls.Add(btnSignin);
            Controls.Add(btnSignup);
            Controls.Add(txtPassword);
            Controls.Add(txtName);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(261, 61);
            Name = "FRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FRegister_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.Button btnSignup;
        private ReaLTaiizor.Controls.Button btnSignin;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private ReaLTaiizor.Controls.MaterialCheckBox materialCheckBox1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ParrotRadioButton rdoCompany;
        private ReaLTaiizor.Controls.ParrotRadioButton rdoJobSeeker;
    }
}
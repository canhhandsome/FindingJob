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
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            button1 = new ReaLTaiizor.Controls.Button();
            btnSignin = new ReaLTaiizor.Controls.Button();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            label1 = new Label();
            label3 = new Label();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            hopeSwitch1 = new ReaLTaiizor.Controls.HopeSwitch();
            hopeRoundButton1 = new ReaLTaiizor.Controls.HopeRoundButton();
            label2 = new Label();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            rdoJobSeeker = new ReaLTaiizor.Controls.ParrotRadioButton();
            rdoCompany = new ReaLTaiizor.Controls.ParrotRadioButton();
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
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 34, 37);
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(32, 34, 37);
            button1.Location = new Point(309, 404);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(131, 38);
            button1.TabIndex = 7;
            button1.Text = "Sign Up";
            button1.TextAlignment = StringAlignment.Center;
            button1.Click += button1_Click;
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
            btnSignin.Location = new Point(60, 404);
            btnSignin.Margin = new Padding(3, 2, 3, 2);
            btnSignin.Name = "btnSignin";
            btnSignin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnSignin.PressedColor = Color.FromArgb(165, 37, 37);
            btnSignin.Size = new Size(131, 38);
            btnSignin.TabIndex = 1;
            btnSignin.Text = "Sign In";
            btnSignin.TextAlignment = StringAlignment.Center;
            btnSignin.Click += btnSignin_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(224, 224, 224);
            bigLabel1.Location = new Point(95, 34);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(201, 46);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(297, 34);
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
            txtPassword.Location = new Point(60, 284);
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
            txtPassword.UseSystemPasswordChar = false;
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
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(60, 267);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
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
            // hopeSwitch1
            // 
            hopeSwitch1.AutoSize = true;
            hopeSwitch1.BaseColor = Color.White;
            hopeSwitch1.BaseOffColor = Color.FromArgb(220, 223, 230);
            hopeSwitch1.BaseOnColor = Color.FromArgb(64, 158, 255);
            hopeSwitch1.Location = new Point(60, 350);
            hopeSwitch1.Name = "hopeSwitch1";
            hopeSwitch1.Size = new Size(40, 20);
            hopeSwitch1.TabIndex = 20;
            hopeSwitch1.UseVisualStyleBackColor = true;
            // 
            // hopeRoundButton1
            // 
            hopeRoundButton1.BorderColor = Color.FromArgb(220, 223, 230);
            hopeRoundButton1.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            hopeRoundButton1.DangerColor = Color.FromArgb(245, 108, 108);
            hopeRoundButton1.DefaultColor = Color.FromArgb(255, 255, 255);
            hopeRoundButton1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            hopeRoundButton1.HoverTextColor = Color.FromArgb(48, 49, 51);
            hopeRoundButton1.InfoColor = Color.FromArgb(144, 147, 153);
            hopeRoundButton1.Location = new Point(297, 350);
            hopeRoundButton1.Name = "hopeRoundButton1";
            hopeRoundButton1.PrimaryColor = Color.FromArgb(64, 158, 255);
            hopeRoundButton1.Size = new Size(152, 36);
            hopeRoundButton1.SuccessColor = Color.FromArgb(103, 194, 58);
            hopeRoundButton1.TabIndex = 28;
            hopeRoundButton1.Text = "Forgot Password?";
            hopeRoundButton1.TextColor = Color.White;
            hopeRoundButton1.WarningColor = Color.FromArgb(230, 162, 60);
            hopeRoundButton1.Click += hopeRoundButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(115, 350);
            label2.Name = "label2";
            label2.Size = new Size(104, 19);
            label2.TabIndex = 15;
            label2.Text = "Remember me?";
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(125, 96);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(271, 34);
            foxLabel2.TabIndex = 29;
            foxLabel2.Text = "Sign in With Email Address";
            // 
            // rdoJobSeeker
            // 
            rdoJobSeeker.Checked = false;
            rdoJobSeeker.ForeColor = Color.White;
            rdoJobSeeker.Location = new Point(125, 152);
            rdoJobSeeker.Name = "rdoJobSeeker";
            rdoJobSeeker.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdoJobSeeker.RadioColor = Color.FromArgb(0, 162, 250);
            rdoJobSeeker.RadioHoverColor = Color.Fuchsia;
            rdoJobSeeker.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdoJobSeeker.Size = new Size(100, 16);
            rdoJobSeeker.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdoJobSeeker.TabIndex = 30;
            rdoJobSeeker.Text = "Job Seeker";
            rdoJobSeeker.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // rdoCompany
            // 
            rdoCompany.Checked = false;
            rdoCompany.ForeColor = Color.White;
            rdoCompany.Location = new Point(297, 152);
            rdoCompany.Name = "rdoCompany";
            rdoCompany.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdoCompany.RadioColor = Color.FromArgb(0, 162, 250);
            rdoCompany.RadioHoverColor = Color.Fuchsia;
            rdoCompany.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdoCompany.Size = new Size(100, 16);
            rdoCompany.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdoCompany.TabIndex = 30;
            rdoCompany.Text = "Company";
            rdoCompany.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // FLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(1202, 463);
            Controls.Add(rdoCompany);
            Controls.Add(rdoJobSeeker);
            Controls.Add(foxLabel2);
            Controls.Add(hopeRoundButton1);
            Controls.Add(hopeSwitch1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(btnSignin);
            Controls.Add(button1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(261, 61);
            Name = "FLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FLogin_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button btnSignin;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private Label label1;
        private Label label3;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.HopeSwitch hopeSwitch1;
        private ReaLTaiizor.Controls.HopeRoundButton hopeRoundButton1;
        private Label label2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ParrotRadioButton rdoJobSeeker;
        private ReaLTaiizor.Controls.ParrotRadioButton rdoCompany;
    }
}
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
            lblagree = new ReaLTaiizor.Controls.LabelEdit();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            btnagree = new ReaLTaiizor.Controls.MaterialCheckBox();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            rdocompany = new ReaLTaiizor.Controls.ParrotRadioButton();
            rdojobseeker = new ReaLTaiizor.Controls.ParrotRadioButton();
            btnsignin = new ReaLTaiizor.Controls.ParrotButton();
            btnsignup = new ReaLTaiizor.Controls.ParrotButton();
            txtfullname = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtemail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtpassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblagree
            // 
            lblagree.AutoSize = true;
            lblagree.BackColor = Color.Transparent;
            lblagree.Cursor = Cursors.Hand;
            lblagree.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            lblagree.ForeColor = Color.Black;
            lblagree.Location = new Point(95, 425);
            lblagree.Name = "lblagree";
            lblagree.Size = new Size(354, 40);
            lblagree.TabIndex = 11;
            lblagree.Text = "I have read and agree to CTV's Terms of Service \r\nand Privacy Policy regarding my private information.";
            lblagree.Click += lblagree_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(95, 46);
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
            pictureBox1.Location = new Point(297, 46);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // btnagree
            // 
            btnagree.AutoSize = true;
            btnagree.Depth = 0;
            btnagree.ForeColor = Color.Black;
            btnagree.Location = new Point(60, 425);
            btnagree.Margin = new Padding(0);
            btnagree.MouseLocation = new Point(-1, -1);
            btnagree.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnagree.Name = "btnagree";
            btnagree.ReadOnly = false;
            btnagree.Ripple = true;
            btnagree.Size = new Size(35, 37);
            btnagree.TabIndex = 16;
            btnagree.UseAccentColor = false;
            btnagree.UseVisualStyleBackColor = true;
            btnagree.CheckedChanged += btnagree_CheckedChanged;
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
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(115, 102);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(250, 34);
            foxLabel2.TabIndex = 19;
            foxLabel2.Text = "Sign up With Email Address";
            // 
            // rdocompany
            // 
            rdocompany.Checked = false;
            rdocompany.ForeColor = Color.Black;
            rdocompany.Location = new Point(287, 153);
            rdocompany.Name = "rdocompany";
            rdocompany.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdocompany.RadioColor = Color.FromArgb(0, 162, 250);
            rdocompany.RadioHoverColor = Color.Fuchsia;
            rdocompany.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdocompany.Size = new Size(100, 16);
            rdocompany.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdocompany.TabIndex = 31;
            rdocompany.Text = "Company";
            rdocompany.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // rdojobseeker
            // 
            rdojobseeker.Checked = false;
            rdojobseeker.ForeColor = Color.Black;
            rdojobseeker.Location = new Point(115, 153);
            rdojobseeker.Name = "rdojobseeker";
            rdojobseeker.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            rdojobseeker.RadioColor = Color.FromArgb(0, 162, 250);
            rdojobseeker.RadioHoverColor = Color.Fuchsia;
            rdojobseeker.RadioStyle = ReaLTaiizor.Controls.ParrotRadioButton.Style.Material;
            rdojobseeker.Size = new Size(100, 16);
            rdojobseeker.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            rdojobseeker.TabIndex = 32;
            rdojobseeker.Text = "Job Seeker";
            rdojobseeker.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            btnsignin.Location = new Point(75, 489);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(131, 38);
            btnsignin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnsignin.TabIndex = 35;
            btnsignin.TextColor = Color.Black;
            btnsignin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnsignin.Vertical_Alignment = StringAlignment.Center;
            btnsignin.Click += btnsignin_Click;
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
            btnsignup.Location = new Point(299, 489);
            btnsignup.Name = "btnsignup";
            btnsignup.Size = new Size(131, 38);
            btnsignup.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnsignup.TabIndex = 36;
            btnsignup.TextColor = Color.Black;
            btnsignup.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnsignup.Vertical_Alignment = StringAlignment.Center;
            // 
            // txtfullname
            // 
            txtfullname.AnimateReadOnly = false;
            txtfullname.AutoCompleteMode = AutoCompleteMode.None;
            txtfullname.AutoCompleteSource = AutoCompleteSource.None;
            txtfullname.BackgroundImageLayout = ImageLayout.None;
            txtfullname.CharacterCasing = CharacterCasing.Normal;
            txtfullname.Depth = 0;
            txtfullname.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtfullname.HideSelection = true;
            txtfullname.Hint = "Enter Fullname";
            txtfullname.LeadingIcon = null;
            txtfullname.Location = new Point(60, 273);
            txtfullname.MaxLength = 32767;
            txtfullname.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtfullname.Name = "txtfullname";
            txtfullname.PasswordChar = '*';
            txtfullname.PrefixSuffixText = null;
            txtfullname.ReadOnly = false;
            txtfullname.RightToLeft = RightToLeft.No;
            txtfullname.SelectedText = "";
            txtfullname.SelectionLength = 0;
            txtfullname.SelectionStart = 0;
            txtfullname.ShortcutsEnabled = true;
            txtfullname.Size = new Size(370, 48);
            txtfullname.TabIndex = 38;
            txtfullname.TabStop = false;
            txtfullname.TextAlign = HorizontalAlignment.Left;
            txtfullname.TrailingIcon = null;
            txtfullname.UseSystemPasswordChar = false;
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
            txtemail.Location = new Point(60, 197);
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
            txtemail.Size = new Size(370, 48);
            txtemail.TabIndex = 37;
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
            txtpassword.Location = new Point(60, 351);
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
            txtpassword.Size = new Size(370, 48);
            txtpassword.TabIndex = 38;
            txtpassword.TabStop = false;
            txtpassword.TextAlign = HorizontalAlignment.Left;
            txtpassword.TrailingIcon = null;
            txtpassword.UseSystemPasswordChar = false;
            // 
            // FRegister
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1202, 556);
            Controls.Add(txtpassword);
            Controls.Add(txtfullname);
            Controls.Add(txtemail);
            Controls.Add(btnsignin);
            Controls.Add(btnsignup);
            Controls.Add(rdocompany);
            Controls.Add(rdojobseeker);
            Controls.Add(foxLabel2);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            Controls.Add(btnagree);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(lblagree);
            ForeColor = Color.Black;
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
        private ReaLTaiizor.Controls.LabelEdit lblagree;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MaterialCheckBox btnagree;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.ParrotRadioButton rdocompany;
        private ReaLTaiizor.Controls.ParrotRadioButton rdojobseeker;
        private ReaLTaiizor.Controls.ParrotButton btnsignin;
        private ReaLTaiizor.Controls.ParrotButton btnsignup;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtfullname;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtemail;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtpassword;
    }
}
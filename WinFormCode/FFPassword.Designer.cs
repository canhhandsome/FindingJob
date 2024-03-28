namespace WinFormProject
{
    partial class FFPassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FFPassword));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            pictureBox2 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
            pictureBox1 = new PictureBox();
            btnsignin = new ReaLTaiizor.Controls.ParrotButton();
            btnrspassword = new ReaLTaiizor.Controls.ParrotButton();
            txtemail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(nightControlBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(982, 26);
            panel1.TabIndex = 0;
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
            nightControlBox1.Location = new Point(843, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(486, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(496, 380);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(95, 45);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(201, 46);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Welcome to";
            // 
            // foxLabel1
            // 
            foxLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel1.ForeColor = Color.Black;
            foxLabel1.Location = new Point(240, 304);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(29, 19);
            foxLabel1.TabIndex = 14;
            foxLabel1.Text = "OR";
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.Black;
            foxLabel2.Location = new Point(175, 113);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(168, 34);
            foxLabel2.TabIndex = 15;
            foxLabel2.Text = "Forgot Password";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(65, 59, 96);
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(302, 45);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 16;
            pictureBox1.TabStop = false;
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
            btnsignin.Location = new Point(188, 339);
            btnsignin.Name = "btnsignin";
            btnsignin.Size = new Size(131, 38);
            btnsignin.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnsignin.TabIndex = 36;
            btnsignin.TextColor = Color.Black;
            btnsignin.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnsignin.Vertical_Alignment = StringAlignment.Center;
            btnsignin.Click += btnrspassword_Click;
            // 
            // btnrspassword
            // 
            btnrspassword.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnrspassword.ButtonImage = null;
            btnrspassword.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnrspassword.ButtonText = "Forgot Password";
            btnrspassword.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnrspassword.ClickTextColor = Color.Black;
            btnrspassword.CornerRadius = 6;
            btnrspassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnrspassword.Horizontal_Alignment = StringAlignment.Center;
            btnrspassword.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnrspassword.HoverTextColor = Color.Black;
            btnrspassword.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnrspassword.Location = new Point(188, 243);
            btnrspassword.Name = "btnrspassword";
            btnrspassword.Size = new Size(131, 38);
            btnrspassword.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnrspassword.TabIndex = 36;
            btnrspassword.TextColor = Color.Black;
            btnrspassword.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnrspassword.Vertical_Alignment = StringAlignment.Center;
            btnrspassword.Click += btnResetP_Click;
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
            txtemail.Location = new Point(82, 165);
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
            txtemail.TabIndex = 37;
            txtemail.TabStop = false;
            txtemail.TextAlign = HorizontalAlignment.Left;
            txtemail.TrailingIcon = null;
            txtemail.UseSystemPasswordChar = false;
            // 
            // FFPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(982, 406);
            Controls.Add(txtemail);
            Controls.Add(btnrspassword);
            Controls.Add(btnsignin);
            Controls.Add(pictureBox1);
            Controls.Add(foxLabel2);
            Controls.Add(foxLabel1);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(261, 61);
            Name = "FFPassword";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FFPassword_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button2;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.ParrotButton btnsignin;
        private ReaLTaiizor.Controls.ParrotButton btnrspassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtemail;
    }
}
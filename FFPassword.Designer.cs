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
            txtemail = new ReaLTaiizor.Controls.HopeTextBox();
            btnrspassword = new ReaLTaiizor.Controls.Button();
            btnsignin = new ReaLTaiizor.Controls.Button();
            pictureBox2 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox1 = new PictureBox();
            foxLabel1 = new ReaLTaiizor.Controls.FoxLabel();
            foxLabel2 = new ReaLTaiizor.Controls.FoxLabel();
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
            panel1.Name = "panel1";
            panel1.Size = new Size(1122, 35);
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
            nightControlBox1.Location = new Point(983, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 0;
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
            txtemail.Location = new Point(69, 228);
            txtemail.MaxLength = 32767;
            txtemail.Multiline = false;
            txtemail.Name = "txtemail";
            txtemail.PasswordChar = '\0';
            txtemail.ScrollBars = ScrollBars.None;
            txtemail.SelectedText = "";
            txtemail.SelectionLength = 0;
            txtemail.SelectionStart = 0;
            txtemail.Size = new Size(445, 43);
            txtemail.TabIndex = 2;
            txtemail.TabStop = false;
            txtemail.UseSystemPasswordChar = false;
            // 
            // btnrspassword
            // 
            btnrspassword.BackColor = Color.Transparent;
            btnrspassword.BorderColor = Color.FromArgb(32, 34, 37);
            btnrspassword.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnrspassword.EnteredColor = Color.FromArgb(32, 34, 37);
            btnrspassword.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnrspassword.Image = null;
            btnrspassword.ImageAlign = ContentAlignment.MiddleLeft;
            btnrspassword.InactiveColor = Color.FromArgb(32, 34, 37);
            btnrspassword.Location = new Point(215, 321);
            btnrspassword.Name = "btnrspassword";
            btnrspassword.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnrspassword.PressedColor = Color.FromArgb(165, 37, 37);
            btnrspassword.Size = new Size(150, 51);
            btnrspassword.TabIndex = 7;
            btnrspassword.Text = "Reset Password";
            btnrspassword.TextAlignment = StringAlignment.Center;
            btnrspassword.Click += btnrspassword_Click;
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
            btnsignin.Location = new Point(215, 448);
            btnsignin.Name = "btnsignin";
            btnsignin.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnsignin.PressedColor = Color.FromArgb(165, 37, 37);
            btnsignin.Size = new Size(150, 51);
            btnsignin.TabIndex = 8;
            btnsignin.Text = "Sign In";
            btnsignin.TextAlignment = StringAlignment.Center;
            btnsignin.Click += btnsignin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Dock = DockStyle.Right;
            pictureBox2.Location = new Point(555, 35);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(567, 506);
            pictureBox2.TabIndex = 10;
            pictureBox2.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            bigLabel1.ForeColor = Color.FromArgb(224, 224, 224);
            bigLabel1.Location = new Point(109, 60);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(247, 57);
            bigLabel1.TabIndex = 12;
            bigLabel1.Text = "Welcome to";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(339, 60);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(114, 67);
            pictureBox1.TabIndex = 13;
            pictureBox1.TabStop = false;
            // 
            // foxLabel1
            // 
            foxLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel1.ForeColor = Color.White;
            foxLabel1.Location = new Point(274, 396);
            foxLabel1.Margin = new Padding(3, 4, 3, 4);
            foxLabel1.Name = "foxLabel1";
            foxLabel1.Size = new Size(33, 25);
            foxLabel1.TabIndex = 14;
            foxLabel1.Text = "OR";
            // 
            // foxLabel2
            // 
            foxLabel2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            foxLabel2.ForeColor = Color.White;
            foxLabel2.Location = new Point(200, 151);
            foxLabel2.Margin = new Padding(3, 4, 3, 4);
            foxLabel2.Name = "foxLabel2";
            foxLabel2.Size = new Size(192, 45);
            foxLabel2.TabIndex = 15;
            foxLabel2.Text = "Forgot Password";
            // 
            // FFPassword
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(1122, 541);
            Controls.Add(foxLabel2);
            Controls.Add(foxLabel1);
            Controls.Add(pictureBox1);
            Controls.Add(bigLabel1);
            Controls.Add(pictureBox2);
            Controls.Add(btnsignin);
            Controls.Add(btnrspassword);
            Controls.Add(txtemail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(298, 81);
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
        private ReaLTaiizor.Controls.HopeTextBox txtemail;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.Button button2;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel1;
        private ReaLTaiizor.Controls.FoxLabel foxLabel2;
        private ReaLTaiizor.Controls.Button btnrspassword;
        private ReaLTaiizor.Controls.Button btnsignin;
    }
}
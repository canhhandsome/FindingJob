namespace WinFormProject
{
    partial class FOTP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FOTP));
            panel1 = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            txtOTP = new ReaLTaiizor.Controls.HopeTextBox();
            btnResetP = new ReaLTaiizor.Controls.Button();
            btnCancel = new ReaLTaiizor.Controls.Button();
            ptbSologan = new PictureBox();
            lblWelcome = new ReaLTaiizor.Controls.BigLabel();
            ptbLogo = new PictureBox();
            lblOr = new ReaLTaiizor.Controls.FoxLabel();
            lblForget = new ReaLTaiizor.Controls.FoxLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbSologan).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).BeginInit();
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
            // txtOTP
            // 
            txtOTP.BackColor = Color.White;
            txtOTP.BaseColor = Color.FromArgb(44, 55, 66);
            txtOTP.BorderColorA = Color.FromArgb(64, 158, 255);
            txtOTP.BorderColorB = Color.FromArgb(220, 223, 230);
            txtOTP.Cursor = Cursors.IBeam;
            txtOTP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtOTP.ForeColor = Color.FromArgb(48, 49, 51);
            txtOTP.Hint = "Enter your OTP";
            txtOTP.Location = new Point(60, 171);
            txtOTP.Margin = new Padding(3, 2, 3, 2);
            txtOTP.MaxLength = 32767;
            txtOTP.Multiline = false;
            txtOTP.Name = "txtOTP";
            txtOTP.PasswordChar = '\0';
            txtOTP.ScrollBars = ScrollBars.None;
            txtOTP.SelectedText = "";
            txtOTP.SelectionLength = 0;
            txtOTP.SelectionStart = 0;
            txtOTP.Size = new Size(389, 38);
            txtOTP.TabIndex = 2;
            txtOTP.TabStop = false;
            txtOTP.UseSystemPasswordChar = false;
            // 
            // btnResetP
            // 
            btnResetP.BackColor = Color.Transparent;
            btnResetP.BorderColor = Color.FromArgb(32, 34, 37);
            btnResetP.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnResetP.EnteredColor = Color.FromArgb(32, 34, 37);
            btnResetP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnResetP.Image = null;
            btnResetP.ImageAlign = ContentAlignment.MiddleLeft;
            btnResetP.InactiveColor = Color.FromArgb(32, 34, 37);
            btnResetP.Location = new Point(188, 241);
            btnResetP.Margin = new Padding(3, 2, 3, 2);
            btnResetP.Name = "btnResetP";
            btnResetP.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnResetP.PressedColor = Color.FromArgb(165, 37, 37);
            btnResetP.Size = new Size(131, 38);
            btnResetP.TabIndex = 7;
            btnResetP.Text = "Reset Password";
            btnResetP.TextAlignment = StringAlignment.Center;
            btnResetP.Click += btnResetP_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Transparent;
            btnCancel.BorderColor = Color.FromArgb(32, 34, 37);
            btnCancel.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.EnteredColor = Color.FromArgb(32, 34, 37);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Image = null;
            btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancel.InactiveColor = Color.FromArgb(32, 34, 37);
            btnCancel.Location = new Point(188, 336);
            btnCancel.Margin = new Padding(3, 2, 3, 2);
            btnCancel.Name = "btnCancel";
            btnCancel.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnCancel.PressedColor = Color.FromArgb(165, 37, 37);
            btnCancel.Size = new Size(131, 38);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Cancel";
            btnCancel.TextAlignment = StringAlignment.Center;
            btnCancel.Click += button2_Click;
            // 
            // ptbSologan
            // 
            ptbSologan.BackgroundImage = (Image)resources.GetObject("ptbSologan.BackgroundImage");
            ptbSologan.BackgroundImageLayout = ImageLayout.Stretch;
            ptbSologan.Dock = DockStyle.Right;
            ptbSologan.Location = new Point(486, 26);
            ptbSologan.Name = "ptbSologan";
            ptbSologan.Size = new Size(496, 380);
            ptbSologan.TabIndex = 10;
            ptbSologan.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.BackColor = Color.Transparent;
            lblWelcome.Font = new Font("Segoe UI", 25F, FontStyle.Regular, GraphicsUnit.Point);
            lblWelcome.ForeColor = Color.FromArgb(224, 224, 224);
            lblWelcome.Location = new Point(95, 45);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(201, 46);
            lblWelcome.TabIndex = 12;
            lblWelcome.Text = "Welcome to";
            // 
            // ptbLogo
            // 
            ptbLogo.BackgroundImage = (Image)resources.GetObject("ptbLogo.BackgroundImage");
            ptbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            ptbLogo.Location = new Point(297, 45);
            ptbLogo.Name = "ptbLogo";
            ptbLogo.Size = new Size(100, 50);
            ptbLogo.TabIndex = 13;
            ptbLogo.TabStop = false;
            // 
            // lblOr
            // 
            lblOr.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblOr.ForeColor = Color.White;
            lblOr.Location = new Point(240, 297);
            lblOr.Name = "lblOr";
            lblOr.Size = new Size(29, 19);
            lblOr.TabIndex = 14;
            lblOr.Text = "OR";
            // 
            // lblForget
            // 
            lblForget.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblForget.ForeColor = Color.White;
            lblForget.Location = new Point(60, 111);
            lblForget.Name = "lblForget";
            lblForget.Size = new Size(389, 34);
            lblForget.TabIndex = 15;
            lblForget.Text = "Hi, ";
            // 
            // FOTP
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(982, 406);
            Controls.Add(lblForget);
            Controls.Add(lblOr);
            Controls.Add(ptbLogo);
            Controls.Add(lblWelcome);
            Controls.Add(ptbSologan);
            Controls.Add(btnCancel);
            Controls.Add(btnResetP);
            Controls.Add(txtOTP);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(261, 61);
            Name = "FOTP";
            StartPosition = FormStartPosition.CenterScreen;
            Load += FOTP_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbSologan).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtOTP;
        private ReaLTaiizor.Controls.Button btnResetP;
        private ReaLTaiizor.Controls.Button btnCancel;
        private PictureBox ptbSologan;
        private ReaLTaiizor.Controls.BigLabel lblWelcome;
        private PictureBox ptbLogo;
        private ReaLTaiizor.Controls.FoxLabel lblOr;
        private ReaLTaiizor.Controls.FoxLabel lblForget;
    }
}
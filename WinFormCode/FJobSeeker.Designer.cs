namespace WinFormProject
{
    partial class FJobSeeker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FJobSeeker));
            panel1 = new Panel();
            metroControlBox4 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            panel2 = new Panel();
            btnLogOut = new ReaLTaiizor.Controls.ParrotButton();
            btnSetting = new ReaLTaiizor.Controls.ParrotButton();
            btnJobAlert = new ReaLTaiizor.Controls.ParrotButton();
            btnSearchJob = new ReaLTaiizor.Controls.ParrotButton();
            pictureBox2 = new PictureBox();
            pnBody = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(metroControlBox4);
            panel1.Controls.Add(metroControlBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1297, 24);
            panel1.TabIndex = 5;
            // 
            // metroControlBox4
            // 
            metroControlBox4.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox4.CloseHoverForeColor = Color.White;
            metroControlBox4.CloseNormalForeColor = Color.Gray;
            metroControlBox4.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox4.DisabledForeColor = Color.DimGray;
            metroControlBox4.Dock = DockStyle.Right;
            metroControlBox4.IsDerivedStyle = true;
            metroControlBox4.Location = new Point(1197, 0);
            metroControlBox4.Margin = new Padding(3, 2, 3, 2);
            metroControlBox4.MaximizeBox = true;
            metroControlBox4.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox4.MaximizeHoverForeColor = Color.Gray;
            metroControlBox4.MaximizeNormalForeColor = Color.Gray;
            metroControlBox4.MinimizeBox = true;
            metroControlBox4.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox4.MinimizeHoverForeColor = Color.Gray;
            metroControlBox4.MinimizeNormalForeColor = Color.Gray;
            metroControlBox4.Name = "metroControlBox4";
            metroControlBox4.Size = new Size(100, 25);
            metroControlBox4.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox4.StyleManager = null;
            metroControlBox4.TabIndex = 6;
            metroControlBox4.Text = "metroControlBox4";
            metroControlBox4.ThemeAuthor = "Taiizor";
            metroControlBox4.ThemeName = "MetroLight";
            // 
            // metroControlBox3
            // 
            metroControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox3.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox3.CloseHoverForeColor = Color.White;
            metroControlBox3.CloseNormalForeColor = Color.Gray;
            metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox3.DisabledForeColor = Color.DimGray;
            metroControlBox3.IsDerivedStyle = true;
            metroControlBox3.Location = new Point(2503, -3);
            metroControlBox3.Margin = new Padding(3, 2, 3, 2);
            metroControlBox3.MaximizeBox = true;
            metroControlBox3.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MaximizeHoverForeColor = Color.Gray;
            metroControlBox3.MaximizeNormalForeColor = Color.Gray;
            metroControlBox3.MinimizeBox = true;
            metroControlBox3.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MinimizeHoverForeColor = Color.Gray;
            metroControlBox3.MinimizeNormalForeColor = Color.Gray;
            metroControlBox3.Name = "metroControlBox3";
            metroControlBox3.Size = new Size(100, 25);
            metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox3.StyleManager = null;
            metroControlBox3.TabIndex = 5;
            metroControlBox3.Text = "metroControlBox3";
            metroControlBox3.ThemeAuthor = "Taiizor";
            metroControlBox3.ThemeName = "MetroLight";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(65, 59, 96);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnJobAlert);
            panel2.Controls.Add(btnSearchJob);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 674);
            panel2.TabIndex = 6;
            // 
            // btnLogOut
            // 
            btnLogOut.BackgroundColor = Color.FromArgb(236, 247, 251);
            btnLogOut.ButtonImage = (Image)resources.GetObject("btnLogOut.ButtonImage");
            btnLogOut.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnLogOut.ButtonText = "Log Out";
            btnLogOut.ClickBackColor = Color.FromArgb(220, 251, 251);
            btnLogOut.ClickTextColor = Color.Black;
            btnLogOut.CornerRadius = 5;
            btnLogOut.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Horizontal_Alignment = StringAlignment.Center;
            btnLogOut.HoverBackgroundColor = Color.FromArgb(250, 247, 251);
            btnLogOut.HoverTextColor = Color.Black;
            btnLogOut.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnLogOut.Location = new Point(12, 372);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(178, 71);
            btnLogOut.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogOut.TabIndex = 13;
            btnLogOut.TextColor = Color.Black;
            btnLogOut.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnLogOut.Vertical_Alignment = StringAlignment.Center;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSetting
            // 
            btnSetting.BackgroundColor = Color.FromArgb(236, 247, 251);
            btnSetting.ButtonImage = (Image)resources.GetObject("btnSetting.ButtonImage");
            btnSetting.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSetting.ButtonText = "Profile";
            btnSetting.ClickBackColor = Color.FromArgb(220, 251, 251);
            btnSetting.ClickTextColor = Color.Black;
            btnSetting.CornerRadius = 5;
            btnSetting.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.Horizontal_Alignment = StringAlignment.Center;
            btnSetting.HoverBackgroundColor = Color.FromArgb(250, 247, 251);
            btnSetting.HoverTextColor = Color.Black;
            btnSetting.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSetting.Location = new Point(12, 293);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(178, 71);
            btnSetting.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSetting.TabIndex = 13;
            btnSetting.TextColor = Color.Black;
            btnSetting.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnSetting.Vertical_Alignment = StringAlignment.Center;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnJobAlert
            // 
            btnJobAlert.BackgroundColor = Color.FromArgb(236, 247, 251);
            btnJobAlert.ButtonImage = (Image)resources.GetObject("btnJobAlert.ButtonImage");
            btnJobAlert.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnJobAlert.ButtonText = "Job Alert";
            btnJobAlert.ClickBackColor = Color.FromArgb(220, 251, 251);
            btnJobAlert.ClickTextColor = Color.Black;
            btnJobAlert.CornerRadius = 5;
            btnJobAlert.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnJobAlert.Horizontal_Alignment = StringAlignment.Center;
            btnJobAlert.HoverBackgroundColor = Color.FromArgb(250, 247, 251);
            btnJobAlert.HoverTextColor = Color.Black;
            btnJobAlert.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnJobAlert.Location = new Point(12, 215);
            btnJobAlert.Name = "btnJobAlert";
            btnJobAlert.Size = new Size(178, 71);
            btnJobAlert.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnJobAlert.TabIndex = 13;
            btnJobAlert.TextColor = Color.Black;
            btnJobAlert.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnJobAlert.Vertical_Alignment = StringAlignment.Center;
            btnJobAlert.Click += btnJobAlert_Click;
            // 
            // btnSearchJob
            // 
            btnSearchJob.BackgroundColor = Color.FromArgb(236, 247, 251);
            btnSearchJob.ButtonImage = (Image)resources.GetObject("btnSearchJob.ButtonImage");
            btnSearchJob.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnSearchJob.ButtonText = "Search Job";
            btnSearchJob.ClickBackColor = Color.FromArgb(220, 251, 251);
            btnSearchJob.ClickTextColor = Color.Black;
            btnSearchJob.CornerRadius = 5;
            btnSearchJob.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearchJob.Horizontal_Alignment = StringAlignment.Center;
            btnSearchJob.HoverBackgroundColor = Color.FromArgb(250, 247, 251);
            btnSearchJob.HoverTextColor = Color.Black;
            btnSearchJob.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnSearchJob.Location = new Point(12, 136);
            btnSearchJob.Name = "btnSearchJob";
            btnSearchJob.Size = new Size(178, 71);
            btnSearchJob.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearchJob.TabIndex = 13;
            btnSearchJob.TextColor = Color.Black;
            btnSearchJob.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnSearchJob.Vertical_Alignment = StringAlignment.Center;
            btnSearchJob.Click += btnSearchJob_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 121);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            pnBody.BorderStyle = BorderStyle.FixedSingle;
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(202, 24);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1095, 674);
            pnBody.TabIndex = 7;
            // 
            // FJobSeeker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1297, 698);
            Controls.Add(pnBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FJobSeeker";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "d";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox4;
        private Panel pnBody;
        private ReaLTaiizor.Controls.ParrotButton btnSearchJob;
        private ReaLTaiizor.Controls.ParrotButton btnLogOut;
        private ReaLTaiizor.Controls.ParrotButton btnSetting;
        private ReaLTaiizor.Controls.ParrotButton btnJobAlert;
    }
}
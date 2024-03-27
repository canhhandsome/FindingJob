namespace WinFormProject
{
    partial class FCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompany));
            panel1 = new Panel();
            metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            panel2 = new Panel();
            btnLogOut = new ReaLTaiizor.Controls.ParrotButton();
            btnSetting = new ReaLTaiizor.Controls.ParrotButton();
            btnApplicant = new ReaLTaiizor.Controls.ParrotButton();
            btnPostJob = new ReaLTaiizor.Controls.ParrotButton();
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
            panel1.Controls.Add(metroControlBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 24);
            panel1.TabIndex = 2;
            // 
            // metroControlBox3
            // 
            metroControlBox3.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox3.CloseHoverForeColor = Color.White;
            metroControlBox3.CloseNormalForeColor = Color.Gray;
            metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox3.DisabledForeColor = Color.DimGray;
            metroControlBox3.Dock = DockStyle.Right;
            metroControlBox3.IsDerivedStyle = true;
            metroControlBox3.Location = new Point(1024, 0);
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
            panel2.Controls.Add(btnApplicant);
            panel2.Controls.Add(btnPostJob);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(202, 474);
            panel2.TabIndex = 3;
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
            btnLogOut.Location = new Point(12, 377);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(178, 71);
            btnLogOut.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnLogOut.TabIndex = 14;
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
            btnSetting.Location = new Point(12, 296);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(178, 71);
            btnSetting.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSetting.TabIndex = 14;
            btnSetting.TextColor = Color.Black;
            btnSetting.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnSetting.Vertical_Alignment = StringAlignment.Center;
            btnSetting.Click += btnSetting_Click;
            // 
            // btnApplicant
            // 
            btnApplicant.BackgroundColor = Color.FromArgb(236, 247, 251);
            btnApplicant.ButtonImage = (Image)resources.GetObject("btnApplicant.ButtonImage");
            btnApplicant.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnApplicant.ButtonText = "History";
            btnApplicant.ClickBackColor = Color.FromArgb(220, 251, 251);
            btnApplicant.ClickTextColor = Color.Black;
            btnApplicant.CornerRadius = 5;
            btnApplicant.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplicant.Horizontal_Alignment = StringAlignment.Center;
            btnApplicant.HoverBackgroundColor = Color.FromArgb(250, 247, 251);
            btnApplicant.HoverTextColor = Color.Black;
            btnApplicant.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnApplicant.Location = new Point(12, 216);
            btnApplicant.Name = "btnApplicant";
            btnApplicant.Size = new Size(178, 71);
            btnApplicant.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnApplicant.TabIndex = 14;
            btnApplicant.TextColor = Color.Black;
            btnApplicant.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnApplicant.Vertical_Alignment = StringAlignment.Center;
            // 
            // btnPostJob
            // 
            btnPostJob.BackgroundColor = Color.FromArgb(236, 247, 251);
            btnPostJob.ButtonImage = (Image)resources.GetObject("btnPostJob.ButtonImage");
            btnPostJob.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnPostJob.ButtonText = "Post Job";
            btnPostJob.ClickBackColor = Color.FromArgb(220, 251, 251);
            btnPostJob.ClickTextColor = Color.Black;
            btnPostJob.CornerRadius = 5;
            btnPostJob.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostJob.Horizontal_Alignment = StringAlignment.Center;
            btnPostJob.HoverBackgroundColor = Color.FromArgb(250, 247, 251);
            btnPostJob.HoverTextColor = Color.Black;
            btnPostJob.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnPostJob.Location = new Point(12, 136);
            btnPostJob.Name = "btnPostJob";
            btnPostJob.Size = new Size(178, 71);
            btnPostJob.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnPostJob.TabIndex = 14;
            btnPostJob.TextColor = Color.Black;
            btnPostJob.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            btnPostJob.Vertical_Alignment = StringAlignment.Center;
            btnPostJob.Click += btnPostJob_Click;
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
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(202, 24);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(922, 474);
            pnBody.TabIndex = 4;
            // 
            // FCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1124, 498);
            Controls.Add(pnBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCompany";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Panel pnBody;
        private ReaLTaiizor.Controls.ParrotButton btnPostJob;
        private ReaLTaiizor.Controls.ParrotButton btnLogOut;
        private ReaLTaiizor.Controls.ParrotButton btnSetting;
        private ReaLTaiizor.Controls.ParrotButton btnApplicant;
    }
}
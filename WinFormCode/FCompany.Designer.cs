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
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogOut = new ReaLTaiizor.Controls.ParrotButton();
            this.btnSetting = new ReaLTaiizor.Controls.ParrotButton();
            this.btnHistory = new ReaLTaiizor.Controls.ParrotButton();
            this.btnPostJob = new ReaLTaiizor.Controls.ParrotButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.metroControlBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1482, 32);
            this.panel1.TabIndex = 2;
            // 
            // metroControlBox3
            // 
            this.metroControlBox3.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroControlBox3.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroControlBox3.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            this.metroControlBox3.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroControlBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroControlBox3.IsDerivedStyle = true;
            this.metroControlBox3.Location = new System.Drawing.Point(1382, 0);
            this.metroControlBox3.MaximizeBox = true;
            this.metroControlBox3.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox3.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MinimizeBox = true;
            this.metroControlBox3.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroControlBox3.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroControlBox3.Name = "metroControlBox3";
            this.metroControlBox3.Size = new System.Drawing.Size(100, 25);
            this.metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.metroControlBox3.StyleManager = null;
            this.metroControlBox3.TabIndex = 5;
            this.metroControlBox3.Text = "metroControlBox3";
            this.metroControlBox3.ThemeAuthor = "Taiizor";
            this.metroControlBox3.ThemeName = "MetroLight";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(59)))), ((int)(((byte)(96)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnHistory);
            this.panel2.Controls.Add(this.btnPostJob);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(231, 899);
            this.panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnLogOut.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnLogOut.ButtonImage")));
            this.btnLogOut.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnLogOut.ButtonText = "Log Out";
            this.btnLogOut.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnLogOut.ClickTextColor = System.Drawing.Color.Black;
            this.btnLogOut.CornerRadius = 5;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogOut.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnLogOut.HoverTextColor = System.Drawing.Color.Black;
            this.btnLogOut.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnLogOut.Location = new System.Drawing.Point(14, 503);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(203, 95);
            this.btnLogOut.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnLogOut.TabIndex = 14;
            this.btnLogOut.TextColor = System.Drawing.Color.Black;
            this.btnLogOut.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnLogOut.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSetting.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnSetting.ButtonImage")));
            this.btnSetting.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnSetting.ButtonText = "Profile";
            this.btnSetting.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnSetting.ClickTextColor = System.Drawing.Color.Black;
            this.btnSetting.CornerRadius = 5;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnSetting.HoverTextColor = System.Drawing.Color.Black;
            this.btnSetting.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnSetting.Location = new System.Drawing.Point(14, 395);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(203, 95);
            this.btnSetting.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnSetting.TabIndex = 14;
            this.btnSetting.TextColor = System.Drawing.Color.Black;
            this.btnSetting.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnSetting.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnSetting.Click += new System.EventHandler(this.btnSetting_Click);
            // 
            // btnHistory
            // 
            this.btnHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnHistory.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnHistory.ButtonImage")));
            this.btnHistory.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnHistory.ButtonText = "History";
            this.btnHistory.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnHistory.ClickTextColor = System.Drawing.Color.Black;
            this.btnHistory.CornerRadius = 5;
            this.btnHistory.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHistory.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnHistory.HoverTextColor = System.Drawing.Color.Black;
            this.btnHistory.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnHistory.Location = new System.Drawing.Point(14, 288);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(203, 95);
            this.btnHistory.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnHistory.TabIndex = 14;
            this.btnHistory.TextColor = System.Drawing.Color.Black;
            this.btnHistory.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnHistory.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // btnPostJob
            // 
            this.btnPostJob.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnPostJob.ButtonImage = ((System.Drawing.Image)(resources.GetObject("btnPostJob.ButtonImage")));
            this.btnPostJob.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnPostJob.ButtonText = "Post Job";
            this.btnPostJob.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(251)))), ((int)(((byte)(251)))));
            this.btnPostJob.ClickTextColor = System.Drawing.Color.Black;
            this.btnPostJob.CornerRadius = 5;
            this.btnPostJob.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostJob.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPostJob.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(247)))), ((int)(((byte)(251)))));
            this.btnPostJob.HoverTextColor = System.Drawing.Color.Black;
            this.btnPostJob.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnPostJob.Location = new System.Drawing.Point(14, 181);
            this.btnPostJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.Size = new System.Drawing.Size(203, 95);
            this.btnPostJob.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnPostJob.TabIndex = 14;
            this.btnPostJob.TextColor = System.Drawing.Color.Black;
            this.btnPostJob.TextRenderingType = System.Drawing.Text.TextRenderingHint.SingleBitPerPixel;
            this.btnPostJob.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            this.btnPostJob.Click += new System.EventHandler(this.btnPostJob_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(231, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(231, 32);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1251, 899);
            this.pnBody.TabIndex = 4;
            // 
            // FCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1482, 931);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCompany";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private ReaLTaiizor.Controls.ParrotButton btnHistory;
    }
}
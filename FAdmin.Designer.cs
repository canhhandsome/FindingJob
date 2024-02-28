namespace WinFormProject
{
    partial class FAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FAdmin));
            pnBody = new Panel();
            panel1 = new Panel();
            metroControlBox4 = new ReaLTaiizor.Controls.MetroControlBox();
            metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            panel2 = new Panel();
            btnLogOut = new Button();
            btnSetting = new Button();
            btnReport = new Button();
            btnManageUser = new Button();
            btnJobListing = new Button();
            pictureBox2 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnBody
            // 
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(183, 24);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(941, 474);
            pnBody.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(metroControlBox4);
            panel1.Controls.Add(metroControlBox3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 24);
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
            metroControlBox4.Location = new Point(1024, 0);
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
            metroControlBox4.TabIndex = 7;
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
            metroControlBox3.Location = new Point(1940, -3);
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
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnReport);
            panel2.Controls.Add(btnManageUser);
            panel2.Controls.Add(btnJobListing);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(183, 474);
            panel2.TabIndex = 6;
            // 
            // btnLogOut
            // 
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 396);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(183, 78);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            // 
            // btnSetting
            // 
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 318);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(183, 78);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnReport
            // 
            btnReport.Cursor = Cursors.Hand;
            btnReport.Dock = DockStyle.Top;
            btnReport.FlatAppearance.BorderSize = 0;
            btnReport.FlatStyle = FlatStyle.Flat;
            btnReport.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnReport.Image = (Image)resources.GetObject("btnReport.Image");
            btnReport.ImageAlign = ContentAlignment.MiddleLeft;
            btnReport.Location = new Point(0, 240);
            btnReport.Name = "btnReport";
            btnReport.Size = new Size(183, 78);
            btnReport.TabIndex = 3;
            btnReport.Text = "Report";
            btnReport.UseVisualStyleBackColor = true;
            // 
            // btnManageUser
            // 
            btnManageUser.Cursor = Cursors.Hand;
            btnManageUser.Dock = DockStyle.Top;
            btnManageUser.FlatAppearance.BorderSize = 0;
            btnManageUser.FlatStyle = FlatStyle.Flat;
            btnManageUser.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnManageUser.Image = (Image)resources.GetObject("btnManageUser.Image");
            btnManageUser.ImageAlign = ContentAlignment.MiddleLeft;
            btnManageUser.Location = new Point(0, 162);
            btnManageUser.Name = "btnManageUser";
            btnManageUser.Size = new Size(183, 78);
            btnManageUser.TabIndex = 2;
            btnManageUser.Text = "Manage User";
            btnManageUser.UseVisualStyleBackColor = true;
            // 
            // btnJobListing
            // 
            btnJobListing.Cursor = Cursors.Hand;
            btnJobListing.Dock = DockStyle.Top;
            btnJobListing.FlatAppearance.BorderSize = 0;
            btnJobListing.FlatStyle = FlatStyle.Flat;
            btnJobListing.Font = new Font("Segoe UI", 12.5F, FontStyle.Regular, GraphicsUnit.Point);
            btnJobListing.Image = (Image)resources.GetObject("btnJobListing.Image");
            btnJobListing.ImageAlign = ContentAlignment.MiddleLeft;
            btnJobListing.Location = new Point(0, 84);
            btnJobListing.Name = "btnJobListing";
            btnJobListing.Size = new Size(183, 78);
            btnJobListing.TabIndex = 1;
            btnJobListing.Text = "Job Listing";
            btnJobListing.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // FAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(1124, 498);
            Controls.Add(pnBody);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAdmin";
            Load += FAdmin_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private Panel pnBody;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private Panel panel2;
        private Button btnLogOut;
        private Button btnSetting;
        private Button btnReport;
        private Button btnManageUser;
        private Button btnJobListing;
        private PictureBox pictureBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox4;
    }
}
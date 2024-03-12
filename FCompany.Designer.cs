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
            btnLogOut = new Button();
            btnSetting = new Button();
            btnApplicant = new Button();
            btnEditJob = new Button();
            btnPostJob = new Button();
            pictureBox2 = new PictureBox();
            pnBody = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
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
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btnLogOut);
            panel2.Controls.Add(btnSetting);
            panel2.Controls.Add(btnApplicant);
            panel2.Controls.Add(btnEditJob);
            panel2.Controls.Add(btnPostJob);
            panel2.Controls.Add(pictureBox2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 24);
            panel2.Name = "panel2";
            panel2.Size = new Size(191, 474);
            panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            btnLogOut.Cursor = Cursors.Hand;
            btnLogOut.Dock = DockStyle.Top;
            btnLogOut.FlatAppearance.BorderSize = 0;
            btnLogOut.FlatStyle = FlatStyle.Flat;
            btnLogOut.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.Location = new Point(0, 396);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.Size = new Size(191, 78);
            btnLogOut.TabIndex = 5;
            btnLogOut.Text = "Log Out";
            btnLogOut.UseVisualStyleBackColor = true;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // btnSetting
            // 
            btnSetting.Cursor = Cursors.Hand;
            btnSetting.Dock = DockStyle.Top;
            btnSetting.FlatAppearance.BorderSize = 0;
            btnSetting.FlatStyle = FlatStyle.Flat;
            btnSetting.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnSetting.Image = (Image)resources.GetObject("btnSetting.Image");
            btnSetting.ImageAlign = ContentAlignment.MiddleLeft;
            btnSetting.Location = new Point(0, 318);
            btnSetting.Name = "btnSetting";
            btnSetting.Size = new Size(191, 78);
            btnSetting.TabIndex = 4;
            btnSetting.Text = "Setting";
            btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnApplicant
            // 
            btnApplicant.Cursor = Cursors.Hand;
            btnApplicant.Dock = DockStyle.Top;
            btnApplicant.FlatAppearance.BorderSize = 0;
            btnApplicant.FlatStyle = FlatStyle.Flat;
            btnApplicant.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplicant.Image = (Image)resources.GetObject("btnApplicant.Image");
            btnApplicant.ImageAlign = ContentAlignment.MiddleLeft;
            btnApplicant.Location = new Point(0, 240);
            btnApplicant.Name = "btnApplicant";
            btnApplicant.Size = new Size(191, 78);
            btnApplicant.TabIndex = 3;
            btnApplicant.Text = "Applicants";
            btnApplicant.UseVisualStyleBackColor = true;
            btnApplicant.Click += btnApplicant_Click;
            // 
            // btnEditJob
            // 
            btnEditJob.Cursor = Cursors.Hand;
            btnEditJob.Dock = DockStyle.Top;
            btnEditJob.FlatAppearance.BorderSize = 0;
            btnEditJob.FlatStyle = FlatStyle.Flat;
            btnEditJob.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditJob.Image = (Image)resources.GetObject("btnEditJob.Image");
            btnEditJob.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditJob.Location = new Point(0, 162);
            btnEditJob.Name = "btnEditJob";
            btnEditJob.Size = new Size(191, 78);
            btnEditJob.TabIndex = 2;
            btnEditJob.Text = "Edit Jobs";
            btnEditJob.UseVisualStyleBackColor = true;
            btnEditJob.Click += btnEditJob_Click;
            // 
            // btnPostJob
            // 
            btnPostJob.Cursor = Cursors.Hand;
            btnPostJob.Dock = DockStyle.Top;
            btnPostJob.FlatAppearance.BorderSize = 0;
            btnPostJob.FlatStyle = FlatStyle.Flat;
            btnPostJob.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostJob.Image = (Image)resources.GetObject("btnPostJob.Image");
            btnPostJob.ImageAlign = ContentAlignment.MiddleLeft;
            btnPostJob.Location = new Point(0, 84);
            btnPostJob.Name = "btnPostJob";
            btnPostJob.Size = new Size(191, 78);
            btnPostJob.TabIndex = 1;
            btnPostJob.Text = "Post Job";
            btnPostJob.UseVisualStyleBackColor = true;
            btnPostJob.Click += btnPostJob_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(191, 84);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(191, 24);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(933, 474);
            pnBody.TabIndex = 4;
            // 
            // FCompany
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
            Name = "FCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCompany";
            Load += FCompany_Load;
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
        private Button btnPostJob;
        private Button btnLogOut;
        private Button btnSetting;
        private Button btnApplicant;
        private Button btnEditJob;
        private Panel pnBody;
    }
}
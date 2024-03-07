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
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnSetting = new System.Windows.Forms.Button();
            this.btnApplicant = new System.Windows.Forms.Button();
            this.btnEditJob = new System.Windows.Forms.Button();
            this.btnPostJob = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pnBody = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.metroControlBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1285, 32);
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
            this.metroControlBox3.Location = new System.Drawing.Point(1185, 0);
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
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.btnLogOut);
            this.panel2.Controls.Add(this.btnSetting);
            this.panel2.Controls.Add(this.btnApplicant);
            this.panel2.Controls.Add(this.btnEditJob);
            this.panel2.Controls.Add(this.btnPostJob);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(218, 632);
            this.panel2.TabIndex = 3;
            // 
            // btnLogOut
            // 
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLogOut.FlatAppearance.BorderSize = 0;
            this.btnLogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 528);
            this.btnLogOut.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(218, 104);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnSetting
            // 
            this.btnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSetting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSetting.FlatAppearance.BorderSize = 0;
            this.btnSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetting.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSetting.Image = ((System.Drawing.Image)(resources.GetObject("btnSetting.Image")));
            this.btnSetting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetting.Location = new System.Drawing.Point(0, 424);
            this.btnSetting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSetting.Name = "btnSetting";
            this.btnSetting.Size = new System.Drawing.Size(218, 104);
            this.btnSetting.TabIndex = 4;
            this.btnSetting.Text = "Setting";
            this.btnSetting.UseVisualStyleBackColor = true;
            // 
            // btnApplicant
            // 
            this.btnApplicant.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApplicant.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnApplicant.FlatAppearance.BorderSize = 0;
            this.btnApplicant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplicant.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnApplicant.Image = ((System.Drawing.Image)(resources.GetObject("btnApplicant.Image")));
            this.btnApplicant.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnApplicant.Location = new System.Drawing.Point(0, 320);
            this.btnApplicant.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApplicant.Name = "btnApplicant";
            this.btnApplicant.Size = new System.Drawing.Size(218, 104);
            this.btnApplicant.TabIndex = 3;
            this.btnApplicant.Text = "Applicants";
            this.btnApplicant.UseVisualStyleBackColor = true;
            this.btnApplicant.Click += new System.EventHandler(this.btnApplicant_Click);
            // 
            // btnEditJob
            // 
            this.btnEditJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditJob.FlatAppearance.BorderSize = 0;
            this.btnEditJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditJob.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditJob.Image = ((System.Drawing.Image)(resources.GetObject("btnEditJob.Image")));
            this.btnEditJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditJob.Location = new System.Drawing.Point(0, 216);
            this.btnEditJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditJob.Name = "btnEditJob";
            this.btnEditJob.Size = new System.Drawing.Size(218, 104);
            this.btnEditJob.TabIndex = 2;
            this.btnEditJob.Text = "Edit Jobs";
            this.btnEditJob.UseVisualStyleBackColor = true;
            this.btnEditJob.Click += new System.EventHandler(this.btnEditJob_Click);
            // 
            // btnPostJob
            // 
            this.btnPostJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostJob.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPostJob.FlatAppearance.BorderSize = 0;
            this.btnPostJob.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPostJob.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostJob.Image = ((System.Drawing.Image)(resources.GetObject("btnPostJob.Image")));
            this.btnPostJob.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPostJob.Location = new System.Drawing.Point(0, 112);
            this.btnPostJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.Size = new System.Drawing.Size(218, 104);
            this.btnPostJob.TabIndex = 1;
            this.btnPostJob.Text = "Post Job";
            this.btnPostJob.UseVisualStyleBackColor = true;
            this.btnPostJob.Click += new System.EventHandler(this.btnPostJob_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(218, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pnBody
            // 
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(218, 32);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1067, 632);
            this.pnBody.TabIndex = 4;
            // 
            // FCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1285, 664);
            this.Controls.Add(this.pnBody);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FCompany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FCompany";
            this.Load += new System.EventHandler(this.FCompany_Load);
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
        private Button btnPostJob;
        private Button btnLogOut;
        private Button btnSetting;
        private Button btnApplicant;
        private Button btnEditJob;
        private Panel pnBody;
    }
}
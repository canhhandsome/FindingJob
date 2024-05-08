namespace WinFormProject.WinFormCode
{
    partial class UCInterview
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            panel7 = new Panel();
            lblStatus = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel5 = new Panel();
            lblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel6 = new Panel();
            lblTimeAdd = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel4 = new Panel();
            lblJob = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel1 = new Panel();
            ptbAvatar = new Guna.UI2.WinForms.Guna2PictureBox();
            panel3 = new Panel();
            lblJSeeker = new Guna.UI2.WinForms.Guna2HtmlLabel();
            panel2 = new Panel();
            guna2Panel1.SuspendLayout();
            panel7.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.BackColor = Color.Transparent;
            guna2Panel1.BorderRadius = 20;
            guna2Panel1.Controls.Add(panel7);
            guna2Panel1.Controls.Add(panel5);
            guna2Panel1.Controls.Add(panel6);
            guna2Panel1.Controls.Add(panel4);
            guna2Panel1.Controls.Add(panel1);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Fill;
            guna2Panel1.FillColor = Color.FromArgb(248, 212, 187);
            guna2Panel1.Location = new Point(0, 0);
            guna2Panel1.Margin = new Padding(3, 13, 3, 4);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.BorderRadius = 20;
            guna2Panel1.ShadowDecoration.Color = Color.Gray;
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.ShadowDecoration.Depth = 10;
            guna2Panel1.ShadowDecoration.Enabled = true;
            guna2Panel1.Size = new Size(1184, 109);
            guna2Panel1.TabIndex = 0;
            guna2Panel1.Click += lblJob_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(lblStatus);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(959, 0);
            panel7.Margin = new Padding(3, 4, 3, 4);
            panel7.Name = "panel7";
            panel7.Size = new Size(225, 109);
            panel7.TabIndex = 7;
            panel7.Click += lblJob_Click;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = false;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Dock = DockStyle.Fill;
            lblStatus.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(0, 0);
            lblStatus.Margin = new Padding(3, 4, 3, 4);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(225, 109);
            lblStatus.TabIndex = 0;
            lblStatus.Text = "15:00 - 17:00";
            lblStatus.TextAlignment = ContentAlignment.MiddleCenter;
            lblStatus.Click += lblJob_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(lblTime);
            panel5.Dock = DockStyle.Left;
            panel5.Location = new Point(822, 0);
            panel5.Margin = new Padding(3, 4, 3, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(137, 109);
            panel5.TabIndex = 5;
            panel5.Click += lblJob_Click;
            // 
            // lblTime
            // 
            lblTime.AutoSize = false;
            lblTime.BackColor = Color.Transparent;
            lblTime.Dock = DockStyle.Fill;
            lblTime.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTime.Location = new Point(0, 0);
            lblTime.Margin = new Padding(3, 4, 3, 4);
            lblTime.Name = "lblTime";
            lblTime.Size = new Size(137, 109);
            lblTime.TabIndex = 0;
            lblTime.Text = "15:00 - 17:00";
            lblTime.TextAlignment = ContentAlignment.MiddleCenter;
            lblTime.Click += lblJob_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(lblTimeAdd);
            panel6.Dock = DockStyle.Left;
            panel6.Location = new Point(644, 0);
            panel6.Margin = new Padding(3, 4, 3, 4);
            panel6.Name = "panel6";
            panel6.Size = new Size(178, 109);
            panel6.TabIndex = 6;
            panel6.Click += lblJob_Click;
            // 
            // lblTimeAdd
            // 
            lblTimeAdd.AutoSize = false;
            lblTimeAdd.BackColor = Color.Transparent;
            lblTimeAdd.Dock = DockStyle.Fill;
            lblTimeAdd.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblTimeAdd.Location = new Point(0, 0);
            lblTimeAdd.Margin = new Padding(3, 4, 3, 4);
            lblTimeAdd.Name = "lblTimeAdd";
            lblTimeAdd.Size = new Size(178, 109);
            lblTimeAdd.TabIndex = 0;
            lblTimeAdd.Text = "28/11/2004";
            lblTimeAdd.TextAlignment = ContentAlignment.MiddleCenter;
            lblTimeAdd.Click += lblJob_Click;
            // 
            // panel4
            // 
            panel4.AutoScroll = true;
            panel4.Controls.Add(lblJob);
            panel4.Dock = DockStyle.Left;
            panel4.Location = new Point(341, 0);
            panel4.Margin = new Padding(3, 4, 3, 4);
            panel4.Name = "panel4";
            panel4.Size = new Size(303, 109);
            panel4.TabIndex = 4;
            panel4.Click += lblJob_Click;
            // 
            // lblJob
            // 
            lblJob.AutoSize = false;
            lblJob.BackColor = Color.Transparent;
            lblJob.Dock = DockStyle.Fill;
            lblJob.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJob.Location = new Point(0, 0);
            lblJob.Margin = new Padding(3, 4, 3, 4);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(303, 109);
            lblJob.TabIndex = 0;
            lblJob.Text = "Name Job";
            lblJob.TextAlignment = ContentAlignment.MiddleCenter;
            lblJob.Click += lblJob_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(ptbAvatar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(341, 109);
            panel1.TabIndex = 2;
            panel1.Click += lblJob_Click;
            // 
            // ptbAvatar
            // 
            ptbAvatar.CustomizableEdges = customizableEdges1;
            ptbAvatar.ImageRotate = 0F;
            ptbAvatar.Location = new Point(40, 8);
            ptbAvatar.Margin = new Padding(3, 4, 3, 4);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ptbAvatar.Size = new Size(79, 92);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 2;
            ptbAvatar.TabStop = false;
            ptbAvatar.Click += lblJob_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblJSeeker);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(127, 0);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(214, 109);
            panel3.TabIndex = 2;
            panel3.Click += lblJob_Click;
            // 
            // lblJSeeker
            // 
            lblJSeeker.AutoSize = false;
            lblJSeeker.BackColor = Color.Transparent;
            lblJSeeker.Dock = DockStyle.Fill;
            lblJSeeker.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblJSeeker.Location = new Point(0, 0);
            lblJSeeker.Margin = new Padding(3, 4, 3, 4);
            lblJSeeker.Name = "lblJSeeker";
            lblJSeeker.Size = new Size(214, 109);
            lblJSeeker.TabIndex = 0;
            lblJSeeker.Text = "Name Jobseeker";
            lblJSeeker.TextAlignment = ContentAlignment.MiddleCenter;
            lblJSeeker.Click += lblJob_Click;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(33, 109);
            panel2.TabIndex = 1;
            panel2.Click += lblJob_Click;
            // 
            // UCInterview
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Transparent;
            Controls.Add(guna2Panel1);
            Margin = new Padding(3, 20, 3, 4);
            Name = "UCInterview";
            Size = new Size(1184, 109);
            guna2Panel1.ResumeLayout(false);
            panel7.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        public Panel panel6;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTimeAdd;
        public Panel panel5;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblTime;
        public Panel panel4;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJob;
        public Panel panel1;
        public Guna.UI2.WinForms.Guna2PictureBox ptbAvatar;
        public Panel panel3;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblJSeeker;
        public Panel panel2;
        public Panel panel7;
        public Guna.UI2.WinForms.Guna2HtmlLabel lblStatus;
    }
}

namespace WinFormProject
{
    partial class FPostJob
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPostJob));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnBody = new Panel();
            btnPostingJob = new Guna.UI2.WinForms.Guna2Button();
            btnFilter = new Guna.UI2.WinForms.Guna2Button();
            pnSubBody = new FlowLayoutPanel();
            guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            lblListJobs = new Label();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            pnBody.SuspendLayout();
            SuspendLayout();
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(btnPostingJob);
            pnBody.Controls.Add(btnFilter);
            pnBody.Controls.Add(pnSubBody);
            pnBody.Controls.Add(guna2CircleButton1);
            pnBody.Controls.Add(lblListJobs);
            pnBody.Controls.Add(txtSearch);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1079, 635);
            pnBody.TabIndex = 2;
            // 
            // btnPostingJob
            // 
            btnPostingJob.BackColor = Color.Transparent;
            btnPostingJob.BorderRadius = 23;
            btnPostingJob.CustomizableEdges = customizableEdges1;
            btnPostingJob.DisabledState.BorderColor = Color.DarkGray;
            btnPostingJob.DisabledState.CustomBorderColor = Color.DarkGray;
            btnPostingJob.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnPostingJob.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnPostingJob.FillColor = Color.FromArgb(248, 212, 187);
            btnPostingJob.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnPostingJob.ForeColor = Color.Black;
            btnPostingJob.HoverState.Font = new Font("Sitka Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPostingJob.Location = new Point(878, 29);
            btnPostingJob.Margin = new Padding(3, 2, 3, 2);
            btnPostingJob.Name = "btnPostingJob";
            btnPostingJob.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPostingJob.Size = new Size(172, 38);
            btnPostingJob.TabIndex = 46;
            btnPostingJob.Text = "Posting a Job";
            btnPostingJob.Click += btnPostingJob_Click;
            // 
            // btnFilter
            // 
            btnFilter.BackColor = Color.Transparent;
            btnFilter.BorderRadius = 23;
            btnFilter.CustomizableEdges = customizableEdges3;
            btnFilter.DisabledState.BorderColor = Color.DarkGray;
            btnFilter.DisabledState.CustomBorderColor = Color.DarkGray;
            btnFilter.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnFilter.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnFilter.FillColor = Color.FromArgb(248, 212, 187);
            btnFilter.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.Black;
            btnFilter.HoverState.Font = new Font("Sitka Text", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.Location = new Point(891, 83);
            btnFilter.Margin = new Padding(3, 2, 3, 2);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFilter.Size = new Size(86, 36);
            btnFilter.TabIndex = 45;
            btnFilter.Text = "Filter";
            btnFilter.Click += btnFilter_Click;
            // 
            // pnSubBody
            // 
            pnSubBody.Location = new Point(60, 136);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(1000, 207);
            pnSubBody.TabIndex = 4;
            // 
            // guna2CircleButton1
            // 
            guna2CircleButton1.Cursor = Cursors.Hand;
            guna2CircleButton1.DisabledState.BorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.CustomBorderColor = Color.DarkGray;
            guna2CircleButton1.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            guna2CircleButton1.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            guna2CircleButton1.FillColor = Color.Transparent;
            guna2CircleButton1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            guna2CircleButton1.ForeColor = Color.White;
            guna2CircleButton1.Image = (Image)resources.GetObject("guna2CircleButton1.Image");
            guna2CircleButton1.ImageSize = new Size(45, 45);
            guna2CircleButton1.Location = new Point(993, 83);
            guna2CircleButton1.Margin = new Padding(3, 2, 3, 2);
            guna2CircleButton1.Name = "guna2CircleButton1";
            guna2CircleButton1.ShadowDecoration.CustomizableEdges = customizableEdges5;
            guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            guna2CircleButton1.Size = new Size(57, 36);
            guna2CircleButton1.TabIndex = 44;
            guna2CircleButton1.Click += guna2CircleButton1_Click;
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.White;
            lblListJobs.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(46, 29);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(281, 35);
            lblListJobs.TabIndex = 3;
            lblListJobs.Text = "List Of Current Jobs";
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 17;
            txtSearch.CustomizableEdges = customizableEdges6;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(60, 83);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges7;
            txtSearch.Size = new Size(824, 36);
            txtSearch.TabIndex = 43;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // FPostJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(1079, 635);
            Controls.Add(pnBody);
            Name = "FPostJob";
            Text = "PostJob";
            Load += PostJob_Load;
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Panel pnBody;
        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
        private Guna.UI2.WinForms.Guna2Button btnFilter;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnPostingJob;
    }
}
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPostJob));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            pnBody = new Panel();
            btnPostingJob = new Guna.UI2.WinForms.Guna2Button();
            btnFilter = new Guna.UI2.WinForms.Guna2Button();
            pnSubBody = new FlowLayoutPanel();
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
            pnBody.Controls.Add(lblListJobs);
            pnBody.Controls.Add(txtSearch);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1233, 847);
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
            btnPostingJob.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold);
            btnPostingJob.ForeColor = Color.Black;
            btnPostingJob.HoverState.Font = new Font("Sitka Text", 13.8F, FontStyle.Bold);
            btnPostingJob.Location = new Point(1003, 39);
            btnPostingJob.Name = "btnPostingJob";
            btnPostingJob.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnPostingJob.Size = new Size(197, 51);
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
            btnFilter.Font = new Font("Sitka Text Semibold", 12F, FontStyle.Bold);
            btnFilter.ForeColor = Color.Black;
            btnFilter.HoverState.Font = new Font("Sitka Text", 13.8F, FontStyle.Bold);
            btnFilter.Location = new Point(1018, 111);
            btnFilter.Name = "btnFilter";
            btnFilter.ShadowDecoration.CustomizableEdges = customizableEdges4;
            btnFilter.Size = new Size(168, 48);
            btnFilter.TabIndex = 45;
            btnFilter.Text = "Filter";
            btnFilter.Click += btnFilter_Click;
            // 
            // pnSubBody
            // 
            pnSubBody.Location = new Point(69, 181);
            pnSubBody.Margin = new Padding(3, 4, 3, 4);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(1143, 276);
            pnSubBody.TabIndex = 4;
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.White;
            lblListJobs.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(53, 39);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(348, 42);
            lblListJobs.TabIndex = 3;
            lblListJobs.Text = "List Of Current Jobs";
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 23;
            txtSearch.CustomizableEdges = customizableEdges5;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(69, 111);
            txtSearch.Margin = new Padding(5, 4, 5, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges6;
            txtSearch.Size = new Size(942, 48);
            txtSearch.TabIndex = 43;
            txtSearch.KeyDown += txtSearch_KeyDown;
            // 
            // FPostJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(1233, 847);
            Controls.Add(pnBody);
            Margin = new Padding(3, 4, 3, 4);
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
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Button btnPostingJob;
    }
}
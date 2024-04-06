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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPostJob));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            btnPostingJob = new Button();
            pnBody = new Panel();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            pnSubBody = new FlowLayoutPanel();
            lblListJobs = new Label();
            pnBody.SuspendLayout();
            SuspendLayout();
            // 
            // btnPostingJob
            // 
            btnPostingJob.BackColor = Color.DimGray;
            btnPostingJob.Cursor = Cursors.Hand;
            btnPostingJob.FlatStyle = FlatStyle.System;
            btnPostingJob.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnPostingJob.ForeColor = SystemColors.ControlLightLight;
            btnPostingJob.Location = new Point(726, 28);
            btnPostingJob.Name = "btnPostingJob";
            btnPostingJob.Size = new Size(166, 39);
            btnPostingJob.TabIndex = 1;
            btnPostingJob.Text = "Posting a job";
            btnPostingJob.UseVisualStyleBackColor = false;
            btnPostingJob.Click += btnPostingJob_Click;
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(txtSearch);
            pnBody.Controls.Add(btnFilter);
            pnBody.Controls.Add(pnSubBody);
            pnBody.Controls.Add(lblListJobs);
            pnBody.Controls.Add(btnPostingJob);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1079, 635);
            pnBody.TabIndex = 2;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 17;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(68, 83);
            txtSearch.Margin = new Padding(4, 3, 4, 3);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(711, 36);
            txtSearch.TabIndex = 39;
            // 
            // btnFilter
            // 
            btnFilter.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnFilter.ButtonImage = null;
            btnFilter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnFilter.ButtonText = "Filter";
            btnFilter.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnFilter.ClickTextColor = Color.Black;
            btnFilter.CornerRadius = 6;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.Horizontal_Alignment = StringAlignment.Center;
            btnFilter.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnFilter.HoverTextColor = Color.Black;
            btnFilter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnFilter.Location = new Point(786, 83);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(73, 36);
            btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFilter.TabIndex = 38;
            btnFilter.TextColor = Color.Black;
            btnFilter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFilter.Vertical_Alignment = StringAlignment.Center;
            // 
            // pnSubBody
            // 
            pnSubBody.Location = new Point(27, 125);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(1052, 207);
            pnSubBody.TabIndex = 4;
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.White;
            lblListJobs.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(35, 29);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(281, 35);
            lblListJobs.TabIndex = 3;
            lblListJobs.Text = "List Of Current Jobs";
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
        private Button btnPostingJob;
        private Panel pnBody;
        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
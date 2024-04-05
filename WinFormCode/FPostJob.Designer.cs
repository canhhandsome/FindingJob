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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FPostJob));
            this.btnPostingJob = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            this.txtSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            this.pnSubBody = new System.Windows.Forms.FlowLayoutPanel();
            this.lblListJobs = new System.Windows.Forms.Label();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPostingJob
            // 
            this.btnPostingJob.BackColor = System.Drawing.Color.DimGray;
            this.btnPostingJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostingJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPostingJob.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPostingJob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPostingJob.Location = new System.Drawing.Point(830, 37);
            this.btnPostingJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostingJob.Name = "btnPostingJob";
            this.btnPostingJob.Size = new System.Drawing.Size(190, 52);
            this.btnPostingJob.TabIndex = 1;
            this.btnPostingJob.Text = "Posting a job";
            this.btnPostingJob.UseVisualStyleBackColor = false;
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.AutoSize = true;
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.btnFilter);
            this.pnBody.Controls.Add(this.txtSearch);
            this.pnBody.Controls.Add(this.pnSubBody);
            this.pnBody.Controls.Add(this.lblListJobs);
            this.pnBody.Controls.Add(this.btnPostingJob);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 600);
            this.pnBody.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(212)))), ((int)(((byte)(187)))));
            this.btnFilter.ButtonImage = null;
            this.btnFilter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            this.btnFilter.ButtonText = "Filter";
            this.btnFilter.ClickBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(212)))), ((int)(((byte)(180)))));
            this.btnFilter.ClickTextColor = System.Drawing.Color.Black;
            this.btnFilter.CornerRadius = 6;
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.Horizontal_Alignment = System.Drawing.StringAlignment.Center;
            this.btnFilter.HoverBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(242)))), ((int)(((byte)(197)))));
            this.btnFilter.HoverTextColor = System.Drawing.Color.Black;
            this.btnFilter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            this.btnFilter.Location = new System.Drawing.Point(898, 111);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(83, 48);
            this.btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 38;
            this.btnFilter.TextColor = System.Drawing.Color.Black;
            this.btnFilter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnFilter.Vertical_Alignment = System.Drawing.StringAlignment.Center;
            // 
            // txtSearch
            // 
            this.txtSearch.AnimateReadOnly = false;
            this.txtSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSearch.Depth = 0;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.HideSelection = true;
            this.txtSearch.Hint = "Search Job";
            this.txtSearch.LeadingIcon = ((System.Drawing.Image)(resources.GetObject("txtSearch.LeadingIcon")));
            this.txtSearch.Location = new System.Drawing.Point(62, 111);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PrefixSuffixText = null;
            this.txtSearch.ReadOnly = false;
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(820, 48);
            this.txtSearch.TabIndex = 37;
            this.txtSearch.TabStop = false;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSearch.TrailingIcon = null;
            this.txtSearch.UseSystemPasswordChar = false;
            // 
            // pnSubBody
            // 
            this.pnSubBody.Location = new System.Drawing.Point(62, 167);
            this.pnSubBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnSubBody.Name = "pnSubBody";
            this.pnSubBody.Size = new System.Drawing.Size(919, 276);
            this.pnSubBody.TabIndex = 4;
            // 
            // lblListJobs
            // 
            this.lblListJobs.AutoSize = true;
            this.lblListJobs.BackColor = System.Drawing.Color.White;
            this.lblListJobs.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListJobs.Location = new System.Drawing.Point(40, 39);
            this.lblListJobs.Name = "lblListJobs";
            this.lblListJobs.Size = new System.Drawing.Size(348, 42);
            this.lblListJobs.TabIndex = 3;
            this.lblListJobs.Text = "List Of Current Jobs";
            // 
            // FPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FPostJob";
            this.Text = "PostJob";
            this.Load += new System.EventHandler(this.PostJob_Load);
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPostingJob;
        private Panel pnBody;
        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSearch;
    }
}
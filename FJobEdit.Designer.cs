namespace WinFormProject
{
    partial class FJobEdit
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
            rtxtDescription = new ReaLTaiizor.Controls.HopeRichTextBox();
            lblJobName = new Label();
            lblExperience = new Label();
            lblSalary = new Label();
            lblDescription = new Label();
            txtJobName = new ReaLTaiizor.Controls.HopeTextBox();
            txtExperience = new ReaLTaiizor.Controls.HopeTextBox();
            txtSalary = new ReaLTaiizor.Controls.HopeTextBox();
            lblTitle = new Label();
            btnJobRequire = new Button();
            btnPostJob = new Button();
            btnCancle = new Button();
            pnBody = new Panel();
            SuspendLayout();
            // 
            // rtxtDescription
            // 
            rtxtDescription.BorderColor = Color.FromArgb(220, 223, 230);
            rtxtDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtDescription.ForeColor = Color.FromArgb(48, 49, 51);
            rtxtDescription.Hint = "Enter Description";
            rtxtDescription.HoverBorderColor = Color.FromArgb(64, 158, 255);
            rtxtDescription.Location = new Point(548, 103);
            rtxtDescription.MaxLength = 32767;
            rtxtDescription.Multiline = true;
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.PasswordChar = '\0';
            rtxtDescription.ScrollBars = ScrollBars.Horizontal;
            rtxtDescription.SelectedText = "";
            rtxtDescription.SelectionLength = 0;
            rtxtDescription.SelectionStart = 0;
            rtxtDescription.Size = new Size(301, 242);
            rtxtDescription.TabIndex = 15;
            rtxtDescription.TabStop = false;
            rtxtDescription.UseSystemPasswordChar = false;
            // 
            // lblJobName
            // 
            lblJobName.AutoSize = true;
            lblJobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobName.ForeColor = SystemColors.ButtonHighlight;
            lblJobName.Location = new Point(62, 69);
            lblJobName.Name = "lblJobName";
            lblJobName.Size = new Size(91, 21);
            lblJobName.TabIndex = 0;
            lblJobName.Text = "Job's Name";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExperience.ForeColor = SystemColors.ButtonHighlight;
            lblExperience.Location = new Point(62, 174);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(143, 21);
            lblExperience.TabIndex = 0;
            lblExperience.Text = "Experience to Work";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = SystemColors.ButtonHighlight;
            lblSalary.Location = new Point(62, 273);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(53, 21);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "Salary";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDescription.ForeColor = SystemColors.ButtonHighlight;
            lblDescription.Location = new Point(548, 69);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(128, 21);
            lblDescription.TabIndex = 0;
            lblDescription.Text = "Job's Description";
            // 
            // txtJobName
            // 
            txtJobName.BackColor = Color.White;
            txtJobName.BaseColor = Color.FromArgb(44, 55, 66);
            txtJobName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtJobName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtJobName.Cursor = Cursors.IBeam;
            txtJobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtJobName.ForeColor = Color.FromArgb(48, 49, 51);
            txtJobName.Hint = "Enter job's name";
            txtJobName.Location = new Point(62, 103);
            txtJobName.Margin = new Padding(3, 2, 3, 2);
            txtJobName.MaxLength = 32767;
            txtJobName.Multiline = false;
            txtJobName.Name = "txtJobName";
            txtJobName.PasswordChar = '\0';
            txtJobName.ScrollBars = ScrollBars.None;
            txtJobName.SelectedText = "";
            txtJobName.SelectionLength = 0;
            txtJobName.SelectionStart = 0;
            txtJobName.Size = new Size(389, 38);
            txtJobName.TabIndex = 11;
            txtJobName.TabStop = false;
            txtJobName.UseSystemPasswordChar = false;
            // 
            // txtExperience
            // 
            txtExperience.BackColor = Color.White;
            txtExperience.BaseColor = Color.FromArgb(44, 55, 66);
            txtExperience.BorderColorA = Color.FromArgb(64, 158, 255);
            txtExperience.BorderColorB = Color.FromArgb(220, 223, 230);
            txtExperience.Cursor = Cursors.IBeam;
            txtExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtExperience.ForeColor = Color.FromArgb(48, 49, 51);
            txtExperience.Hint = "Enter Experience";
            txtExperience.Location = new Point(62, 207);
            txtExperience.Margin = new Padding(3, 2, 3, 2);
            txtExperience.MaxLength = 32767;
            txtExperience.Multiline = false;
            txtExperience.Name = "txtExperience";
            txtExperience.PasswordChar = '\0';
            txtExperience.ScrollBars = ScrollBars.None;
            txtExperience.SelectedText = "";
            txtExperience.SelectionLength = 0;
            txtExperience.SelectionStart = 0;
            txtExperience.Size = new Size(389, 38);
            txtExperience.TabIndex = 12;
            txtExperience.TabStop = false;
            txtExperience.UseSystemPasswordChar = false;
            // 
            // txtSalary
            // 
            txtSalary.BackColor = Color.White;
            txtSalary.BaseColor = Color.FromArgb(44, 55, 66);
            txtSalary.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSalary.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSalary.Cursor = Cursors.IBeam;
            txtSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSalary.ForeColor = Color.FromArgb(48, 49, 51);
            txtSalary.Hint = "Enter Salary";
            txtSalary.Location = new Point(62, 307);
            txtSalary.Margin = new Padding(3, 2, 3, 2);
            txtSalary.MaxLength = 32767;
            txtSalary.Multiline = false;
            txtSalary.Name = "txtSalary";
            txtSalary.PasswordChar = '\0';
            txtSalary.ScrollBars = ScrollBars.None;
            txtSalary.SelectedText = "";
            txtSalary.SelectionLength = 0;
            txtSalary.SelectionStart = 0;
            txtSalary.Size = new Size(389, 38);
            txtSalary.TabIndex = 13;
            txtSalary.TabStop = false;
            txtSalary.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.FromArgb(64, 64, 64);
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(376, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(168, 28);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Adding a new Job";
            // 
            // btnJobRequire
            // 
            btnJobRequire.BackColor = Color.Silver;
            btnJobRequire.FlatStyle = FlatStyle.Flat;
            btnJobRequire.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnJobRequire.Location = new Point(62, 379);
            btnJobRequire.Name = "btnJobRequire";
            btnJobRequire.Size = new Size(154, 38);
            btnJobRequire.TabIndex = 16;
            btnJobRequire.Text = "Job's Requirement";
            btnJobRequire.UseVisualStyleBackColor = false;
            btnJobRequire.Click += btnJobRequire_Click;
            // 
            // btnPostJob
            // 
            btnPostJob.BackColor = Color.Silver;
            btnPostJob.FlatStyle = FlatStyle.Flat;
            btnPostJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostJob.Location = new Point(548, 379);
            btnPostJob.Name = "btnPostJob";
            btnPostJob.Size = new Size(148, 38);
            btnPostJob.TabIndex = 16;
            btnPostJob.Text = "Post Job";
            btnPostJob.UseVisualStyleBackColor = false;
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Silver;
            btnCancle.FlatStyle = FlatStyle.Flat;
            btnCancle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancle.Location = new Point(701, 379);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(148, 38);
            btnCancle.TabIndex = 16;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // pnBody
            // 
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(917, 450);
            pnBody.TabIndex = 17;
            // 
            // FJobEdit
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(917, 450);
            Controls.Add(btnCancle);
            Controls.Add(btnPostJob);
            Controls.Add(btnJobRequire);
            Controls.Add(rtxtDescription);
            Controls.Add(lblTitle);
            Controls.Add(txtSalary);
            Controls.Add(txtExperience);
            Controls.Add(txtJobName);
            Controls.Add(lblSalary);
            Controls.Add(lblExperience);
            Controls.Add(lblDescription);
            Controls.Add(lblJobName);
            Controls.Add(pnBody);
            Name = "FJobEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobEdit";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJobName;
        private Label lblExperience;
        private Label lblSalary;
        private Label lblDescription;
        private ReaLTaiizor.Controls.HopeTextBox txtJobName;
        private ReaLTaiizor.Controls.HopeTextBox txtExperience;
        private ReaLTaiizor.Controls.HopeTextBox txtSalary;
        private Label lblTitle;
        private ReaLTaiizor.Controls.HopeRichTextBox rtxtDescription;
        private Button btnJobRequire;
        private Button btnPostJob;
        private Button btnCancle;
        private Panel pnBody;
    }
}
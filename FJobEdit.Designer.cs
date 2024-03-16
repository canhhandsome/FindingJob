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
            lblJobName = new Label();
            lblExperience = new Label();
            lblSalary = new Label();
            txtJobName = new ReaLTaiizor.Controls.HopeTextBox();
            txtExperience = new ReaLTaiizor.Controls.HopeTextBox();
            txtSalary = new ReaLTaiizor.Controls.HopeTextBox();
            lblTitle = new Label();
            btnPostJob = new Button();
            btnCancel = new Button();
            pnBody = new Panel();
            tabpage = new TabControl();
            tbprequirement = new TabPage();
            rtxtjobrequirement = new ReaLTaiizor.Controls.MaterialRichTextBox();
            tbpdescription = new TabPage();
            rtxtdescription = new ReaLTaiizor.Controls.MaterialRichTextBox();
            pnBody.SuspendLayout();
            tabpage.SuspendLayout();
            tbprequirement.SuspendLayout();
            tbpdescription.SuspendLayout();
            SuspendLayout();
            // 
            // lblJobName
            // 
            lblJobName.AutoSize = true;
            lblJobName.BackColor = Color.LightGray;
            lblJobName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobName.ForeColor = SystemColors.ControlText;
            lblJobName.Location = new Point(12, 92);
            lblJobName.Name = "lblJobName";
            lblJobName.Size = new Size(113, 28);
            lblJobName.TabIndex = 0;
            lblJobName.Text = "Job's Name";
            // 
            // lblExperience
            // 
            lblExperience.AutoSize = true;
            lblExperience.BackColor = Color.LightGray;
            lblExperience.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblExperience.ForeColor = SystemColors.ControlText;
            lblExperience.Location = new Point(12, 154);
            lblExperience.Name = "lblExperience";
            lblExperience.Size = new Size(181, 28);
            lblExperience.TabIndex = 0;
            lblExperience.Text = "Experience to Work";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.BackColor = Color.LightGray;
            lblSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = SystemColors.ControlText;
            lblSalary.Location = new Point(12, 216);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(65, 28);
            lblSalary.TabIndex = 0;
            lblSalary.Text = "Salary";
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
            txtJobName.Location = new Point(312, 77);
            txtJobName.MaxLength = 32767;
            txtJobName.Multiline = false;
            txtJobName.Name = "txtJobName";
            txtJobName.PasswordChar = '\0';
            txtJobName.ScrollBars = ScrollBars.None;
            txtJobName.SelectedText = "";
            txtJobName.SelectionLength = 0;
            txtJobName.SelectionStart = 0;
            txtJobName.Size = new Size(445, 43);
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
            txtExperience.Location = new Point(312, 139);
            txtExperience.MaxLength = 32767;
            txtExperience.Multiline = false;
            txtExperience.Name = "txtExperience";
            txtExperience.PasswordChar = '\0';
            txtExperience.ScrollBars = ScrollBars.None;
            txtExperience.SelectedText = "";
            txtExperience.SelectionLength = 0;
            txtExperience.SelectionStart = 0;
            txtExperience.Size = new Size(445, 43);
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
            txtSalary.Location = new Point(312, 201);
            txtSalary.MaxLength = 32767;
            txtSalary.Multiline = false;
            txtSalary.Name = "txtSalary";
            txtSalary.PasswordChar = '\0';
            txtSalary.ScrollBars = ScrollBars.None;
            txtSalary.SelectedText = "";
            txtSalary.SelectionLength = 0;
            txtSalary.SelectionStart = 0;
            txtSalary.Size = new Size(445, 43);
            txtSalary.TabIndex = 13;
            txtSalary.TabStop = false;
            txtSalary.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.LightGray;
            lblTitle.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            lblTitle.ForeColor = SystemColors.ControlText;
            lblTitle.Location = new Point(430, 25);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(214, 35);
            lblTitle.TabIndex = 14;
            lblTitle.Text = "Adding a new Job";
            // 
            // btnPostJob
            // 
            btnPostJob.BackColor = Color.Silver;
            btnPostJob.FlatStyle = FlatStyle.System;
            btnPostJob.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostJob.Location = new Point(692, 527);
            btnPostJob.Margin = new Padding(3, 4, 3, 4);
            btnPostJob.Name = "btnPostJob";
            btnPostJob.Size = new Size(169, 51);
            btnPostJob.TabIndex = 16;
            btnPostJob.Text = "Post Job";
            btnPostJob.UseVisualStyleBackColor = false;
            btnPostJob.Click += btnPostJob_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.Silver;
            btnCancel.FlatStyle = FlatStyle.System;
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.Location = new Point(867, 527);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(169, 51);
            btnCancel.TabIndex = 16;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // pnBody
            // 
            pnBody.BackColor = Color.LightGray;
            pnBody.Controls.Add(tabpage);
            pnBody.Controls.Add(btnCancel);
            pnBody.Controls.Add(btnPostJob);
            pnBody.Controls.Add(lblJobName);
            pnBody.Controls.Add(txtJobName);
            pnBody.Controls.Add(lblExperience);
            pnBody.Controls.Add(lblSalary);
            pnBody.Controls.Add(txtSalary);
            pnBody.Controls.Add(txtExperience);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1048, 600);
            pnBody.TabIndex = 17;
            // 
            // tabpage
            // 
            tabpage.Controls.Add(tbprequirement);
            tabpage.Controls.Add(tbpdescription);
            tabpage.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tabpage.Location = new Point(14, 270);
            tabpage.Name = "tabpage";
            tabpage.SelectedIndex = 0;
            tabpage.Size = new Size(1022, 250);
            tabpage.TabIndex = 17;
            // 
            // tbprequirement
            // 
            tbprequirement.AutoScroll = true;
            tbprequirement.BorderStyle = BorderStyle.Fixed3D;
            tbprequirement.Controls.Add(rtxtjobrequirement);
            tbprequirement.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbprequirement.Location = new Point(4, 37);
            tbprequirement.Name = "tbprequirement";
            tbprequirement.Padding = new Padding(3);
            tbprequirement.Size = new Size(1014, 209);
            tbprequirement.TabIndex = 0;
            tbprequirement.Text = "Job's Requirement";
            tbprequirement.UseVisualStyleBackColor = true;
            // 
            // rtxtjobrequirement
            // 
            rtxtjobrequirement.BackColor = Color.FromArgb(255, 255, 255);
            rtxtjobrequirement.BorderStyle = BorderStyle.None;
            rtxtjobrequirement.Depth = 0;
            rtxtjobrequirement.Dock = DockStyle.Fill;
            rtxtjobrequirement.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtjobrequirement.ForeColor = Color.FromArgb(222, 0, 0, 0);
            rtxtjobrequirement.Hint = "";
            rtxtjobrequirement.Location = new Point(3, 3);
            rtxtjobrequirement.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rtxtjobrequirement.Name = "rtxtjobrequirement";
            rtxtjobrequirement.Size = new Size(1004, 199);
            rtxtjobrequirement.TabIndex = 0;
            rtxtjobrequirement.Text = "";
            // 
            // tbpdescription
            // 
            tbpdescription.AutoScroll = true;
            tbpdescription.BorderStyle = BorderStyle.Fixed3D;
            tbpdescription.Controls.Add(rtxtdescription);
            tbpdescription.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbpdescription.Location = new Point(4, 37);
            tbpdescription.Name = "tbpdescription";
            tbpdescription.Padding = new Padding(3);
            tbpdescription.Size = new Size(1014, 209);
            tbpdescription.TabIndex = 1;
            tbpdescription.Text = "Job's Description";
            tbpdescription.UseVisualStyleBackColor = true;
            // 
            // rtxtdescription
            // 
            rtxtdescription.BackColor = Color.FromArgb(255, 255, 255);
            rtxtdescription.BorderStyle = BorderStyle.None;
            rtxtdescription.Depth = 0;
            rtxtdescription.Dock = DockStyle.Fill;
            rtxtdescription.Font = new Font("Microsoft Sans Serif", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            rtxtdescription.ForeColor = Color.FromArgb(222, 0, 0, 0);
            rtxtdescription.Hint = "";
            rtxtdescription.Location = new Point(3, 3);
            rtxtdescription.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rtxtdescription.Name = "rtxtdescription";
            rtxtdescription.Size = new Size(1004, 199);
            rtxtdescription.TabIndex = 0;
            rtxtdescription.Text = "";
            // 
            // FJobEdit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(1048, 600);
            Controls.Add(lblTitle);
            Controls.Add(pnBody);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FJobEdit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobEdit";
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            tabpage.ResumeLayout(false);
            tbprequirement.ResumeLayout(false);
            tbpdescription.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblJobName;
        private Label lblExperience;
        private Label lblSalary;
        private ReaLTaiizor.Controls.HopeTextBox txtJobName;
        private ReaLTaiizor.Controls.HopeTextBox txtExperience;
        private ReaLTaiizor.Controls.HopeTextBox txtSalary;
        private Label lblTitle;
        private Button btnPostJob;
        private Button btnCancel;
        private Panel pnBody;
        private TabControl tabpage;
        private TabPage tbprequirement;
        private TabPage tbpdescription;
        private ReaLTaiizor.Controls.MaterialRichTextBox rtxtdescription;
        private ReaLTaiizor.Controls.MaterialRichTextBox rtxtjobrequirement;
    }
}
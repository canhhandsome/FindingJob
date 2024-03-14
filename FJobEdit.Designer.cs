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
            this.lblJobName = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.lblSalary = new System.Windows.Forms.Label();
            this.txtJobName = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtExperience = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtSalary = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnJobRequire = new System.Windows.Forms.Button();
            this.btnPostJob = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pnBody.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblJobName
            // 
            this.lblJobName.AutoSize = true;
            this.lblJobName.BackColor = System.Drawing.Color.LightGray;
            this.lblJobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblJobName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblJobName.Location = new System.Drawing.Point(12, 92);
            this.lblJobName.Name = "lblJobName";
            this.lblJobName.Size = new System.Drawing.Size(113, 28);
            this.lblJobName.TabIndex = 0;
            this.lblJobName.Text = "Job\'s Name";
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.Color.LightGray;
            this.lblExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblExperience.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblExperience.Location = new System.Drawing.Point(12, 154);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(181, 28);
            this.lblExperience.TabIndex = 0;
            this.lblExperience.Text = "Experience to Work";
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.BackColor = System.Drawing.Color.LightGray;
            this.lblSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalary.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSalary.Location = new System.Drawing.Point(12, 216);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(65, 28);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Salary";
            // 
            // txtJobName
            // 
            this.txtJobName.BackColor = System.Drawing.Color.White;
            this.txtJobName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtJobName.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtJobName.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtJobName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtJobName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJobName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtJobName.Hint = "Enter job\'s name";
            this.txtJobName.Location = new System.Drawing.Point(312, 77);
            this.txtJobName.MaxLength = 32767;
            this.txtJobName.Multiline = false;
            this.txtJobName.Name = "txtJobName";
            this.txtJobName.PasswordChar = '\0';
            this.txtJobName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJobName.SelectedText = "";
            this.txtJobName.SelectionLength = 0;
            this.txtJobName.SelectionStart = 0;
            this.txtJobName.Size = new System.Drawing.Size(445, 43);
            this.txtJobName.TabIndex = 11;
            this.txtJobName.TabStop = false;
            this.txtJobName.UseSystemPasswordChar = false;
            // 
            // txtExperience
            // 
            this.txtExperience.BackColor = System.Drawing.Color.White;
            this.txtExperience.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtExperience.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtExperience.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtExperience.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtExperience.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtExperience.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtExperience.Hint = "Enter Experience";
            this.txtExperience.Location = new System.Drawing.Point(312, 139);
            this.txtExperience.MaxLength = 32767;
            this.txtExperience.Multiline = false;
            this.txtExperience.Name = "txtExperience";
            this.txtExperience.PasswordChar = '\0';
            this.txtExperience.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtExperience.SelectedText = "";
            this.txtExperience.SelectionLength = 0;
            this.txtExperience.SelectionStart = 0;
            this.txtExperience.Size = new System.Drawing.Size(445, 43);
            this.txtExperience.TabIndex = 12;
            this.txtExperience.TabStop = false;
            this.txtExperience.UseSystemPasswordChar = false;
            // 
            // txtSalary
            // 
            this.txtSalary.BackColor = System.Drawing.Color.White;
            this.txtSalary.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtSalary.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtSalary.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtSalary.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSalary.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSalary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtSalary.Hint = "Enter Salary";
            this.txtSalary.Location = new System.Drawing.Point(312, 201);
            this.txtSalary.MaxLength = 32767;
            this.txtSalary.Multiline = false;
            this.txtSalary.Name = "txtSalary";
            this.txtSalary.PasswordChar = '\0';
            this.txtSalary.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSalary.SelectedText = "";
            this.txtSalary.SelectionLength = 0;
            this.txtSalary.SelectionStart = 0;
            this.txtSalary.Size = new System.Drawing.Size(445, 43);
            this.txtSalary.TabIndex = 13;
            this.txtSalary.TabStop = false;
            this.txtSalary.UseSystemPasswordChar = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.LightGray;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblTitle.Location = new System.Drawing.Point(430, 25);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(214, 35);
            this.lblTitle.TabIndex = 14;
            this.lblTitle.Text = "Adding a new Job";
            // 
            // btnJobRequire
            // 
            this.btnJobRequire.BackColor = System.Drawing.Color.Silver;
            this.btnJobRequire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnJobRequire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnJobRequire.Location = new System.Drawing.Point(806, 153);
            this.btnJobRequire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnJobRequire.Name = "btnJobRequire";
            this.btnJobRequire.Size = new System.Drawing.Size(203, 51);
            this.btnJobRequire.TabIndex = 16;
            this.btnJobRequire.Text = "Add Requirement";
            this.btnJobRequire.UseVisualStyleBackColor = false;
            this.btnJobRequire.Click += new System.EventHandler(this.btnJobRequire_Click);
            // 
            // btnPostJob
            // 
            this.btnPostJob.BackColor = System.Drawing.Color.Silver;
            this.btnPostJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPostJob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostJob.Location = new System.Drawing.Point(692, 527);
            this.btnPostJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostJob.Name = "btnPostJob";
            this.btnPostJob.Size = new System.Drawing.Size(169, 51);
            this.btnPostJob.TabIndex = 16;
            this.btnPostJob.Text = "Post Job";
            this.btnPostJob.UseVisualStyleBackColor = false;
            this.btnPostJob.Click += new System.EventHandler(this.btnPostJob_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Silver;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(867, 527);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 51);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.LightGray;
            this.pnBody.Controls.Add(this.tabControl1);
            this.pnBody.Controls.Add(this.btnCancel);
            this.pnBody.Controls.Add(this.btnPostJob);
            this.pnBody.Controls.Add(this.lblJobName);
            this.pnBody.Controls.Add(this.txtJobName);
            this.pnBody.Controls.Add(this.lblExperience);
            this.pnBody.Controls.Add(this.lblSalary);
            this.pnBody.Controls.Add(this.txtSalary);
            this.pnBody.Controls.Add(this.txtExperience);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 600);
            this.pnBody.TabIndex = 17;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(14, 270);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1022, 250);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.btnJobRequire);
            this.tabPage1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage1.Location = new System.Drawing.Point(4, 37);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1014, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Job\'s Requirement";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabPage2.Location = new System.Drawing.Point(4, 37);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1014, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Job\'s Description";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Silver;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(806, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 51);
            this.button1.TabIndex = 18;
            this.button1.Text = "Add Description";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // FJobEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FJobEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJobEdit";
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblJobName;
        private Label lblExperience;
        private Label lblSalary;
        private ReaLTaiizor.Controls.HopeTextBox txtJobName;
        private ReaLTaiizor.Controls.HopeTextBox txtExperience;
        private ReaLTaiizor.Controls.HopeTextBox txtSalary;
        private Label lblTitle;
        private Button btnJobRequire;
        private Button btnPostJob;
        private Button btnCancel;
        private Panel pnBody;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button1;
    }
}
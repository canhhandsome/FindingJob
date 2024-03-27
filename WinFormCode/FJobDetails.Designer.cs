namespace WinFormProject
{
    partial class FJobDetails
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
            lblCompany = new Label();
            lblCompanyT = new Label();
            lblName = new Label();
            lblNameT = new Label();
            lblPosition = new Label();
            lblPositionT = new Label();
            lblSalary = new Label();
            lblSalaryT = new Label();
            lblDate = new Label();
            lblDateT = new Label();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            rtxtRequirement = new RichTextBox();
            tabPage2 = new TabPage();
            rtxtDescription = new RichTextBox();
            btnApply = new ReaLTaiizor.Controls.DreamButton();
            btnBack = new ReaLTaiizor.Controls.DreamButton();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // lblCompany
            // 
            lblCompany.AutoSize = true;
            lblCompany.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompany.ForeColor = SystemColors.ControlText;
            lblCompany.Location = new Point(10, 15);
            lblCompany.Name = "lblCompany";
            lblCompany.Size = new Size(80, 21);
            lblCompany.TabIndex = 13;
            lblCompany.Text = "Company:";
            // 
            // lblCompanyT
            // 
            lblCompanyT.AutoSize = true;
            lblCompanyT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCompanyT.ForeColor = SystemColors.ControlText;
            lblCompanyT.Location = new Point(103, 15);
            lblCompanyT.Name = "lblCompanyT";
            lblCompanyT.Size = new Size(80, 21);
            lblCompanyT.TabIndex = 14;
            lblCompanyT.Text = "Company:";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblName.ForeColor = SystemColors.ControlText;
            lblName.Location = new Point(10, 45);
            lblName.Name = "lblName";
            lblName.Size = new Size(83, 21);
            lblName.TabIndex = 15;
            lblName.Text = "Job Name:";
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameT.ForeColor = SystemColors.ControlText;
            lblNameT.Location = new Point(107, 45);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(83, 21);
            lblNameT.TabIndex = 16;
            lblNameT.Text = "Job Name:";
            // 
            // lblPosition
            // 
            lblPosition.AutoSize = true;
            lblPosition.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPosition.ForeColor = SystemColors.ControlText;
            lblPosition.Location = new Point(10, 75);
            lblPosition.Name = "lblPosition";
            lblPosition.Size = new Size(68, 21);
            lblPosition.TabIndex = 17;
            lblPosition.Text = "Position:";
            // 
            // lblPositionT
            // 
            lblPositionT.AutoSize = true;
            lblPositionT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPositionT.ForeColor = SystemColors.ControlText;
            lblPositionT.Location = new Point(91, 75);
            lblPositionT.Name = "lblPositionT";
            lblPositionT.Size = new Size(68, 21);
            lblPositionT.TabIndex = 18;
            lblPositionT.Text = "Position:";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalary.ForeColor = SystemColors.ControlText;
            lblSalary.Location = new Point(10, 105);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(56, 21);
            lblSalary.TabIndex = 19;
            lblSalary.Text = "Salary:";
            // 
            // lblSalaryT
            // 
            lblSalaryT.AutoSize = true;
            lblSalaryT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryT.ForeColor = SystemColors.ControlText;
            lblSalaryT.Location = new Point(76, 105);
            lblSalaryT.Name = "lblSalaryT";
            lblSalaryT.Size = new Size(56, 21);
            lblSalaryT.TabIndex = 20;
            lblSalaryT.Text = "Salary:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(10, 135);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(100, 21);
            lblDate.TabIndex = 21;
            lblDate.Text = "Date Publish:";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = SystemColors.ControlText;
            lblDateT.Location = new Point(125, 135);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(100, 21);
            lblDateT.TabIndex = 22;
            lblDateT.Text = "Date Publish:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            tabControl1.Location = new Point(10, 174);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(488, 231);
            tabControl1.TabIndex = 28;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(rtxtRequirement);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(480, 198);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Requirement";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // rtxtRequirement
            // 
            rtxtRequirement.Dock = DockStyle.Fill;
            rtxtRequirement.Enabled = false;
            rtxtRequirement.Location = new Point(3, 3);
            rtxtRequirement.Name = "rtxtRequirement";
            rtxtRequirement.Size = new Size(474, 192);
            rtxtRequirement.TabIndex = 0;
            rtxtRequirement.Text = "";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(rtxtDescription);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(480, 198);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Description";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Dock = DockStyle.Fill;
            rtxtDescription.Enabled = false;
            rtxtDescription.Location = new Point(3, 3);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(474, 192);
            rtxtDescription.TabIndex = 0;
            rtxtDescription.Text = "";
            // 
            // btnApply
            // 
            btnApply.ColorA = Color.FromArgb(31, 31, 31);
            btnApply.ColorB = Color.FromArgb(41, 41, 41);
            btnApply.ColorC = Color.FromArgb(51, 51, 51);
            btnApply.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnApply.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnApply.ForeColor = Color.FromArgb(40, 218, 255);
            btnApply.Location = new Point(252, 420);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(120, 40);
            btnApply.TabIndex = 30;
            btnApply.Text = "Apply";
            btnApply.UseVisualStyleBackColor = true;
            btnApply.Click += btnApply_Click;
            // 
            // btnBack
            // 
            btnBack.ColorA = Color.FromArgb(31, 31, 31);
            btnBack.ColorB = Color.FromArgb(41, 41, 41);
            btnBack.ColorC = Color.FromArgb(51, 51, 51);
            btnBack.ColorD = Color.FromArgb(0, 0, 0, 0);
            btnBack.ColorE = Color.FromArgb(25, 255, 255, 255);
            btnBack.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnBack.ForeColor = Color.FromArgb(40, 218, 255);
            btnBack.Location = new Point(378, 420);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(120, 40);
            btnBack.TabIndex = 30;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FJobDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MistyRose;
            ClientSize = new Size(510, 472);
            Controls.Add(btnBack);
            Controls.Add(btnApply);
            Controls.Add(tabControl1);
            Controls.Add(lblDateT);
            Controls.Add(lblDate);
            Controls.Add(lblSalaryT);
            Controls.Add(lblSalary);
            Controls.Add(lblPositionT);
            Controls.Add(lblPosition);
            Controls.Add(lblNameT);
            Controls.Add(lblName);
            Controls.Add(lblCompanyT);
            Controls.Add(lblCompany);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Name = "FJobDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobDetails";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCompany;
        private Label lblCompanyT;
        private Label lblName;
        private Label lblNameT;
        private Label lblPosition;
        private Label lblPositionT;
        private Label lblSalary;
        private Label lblSalaryT;
        private Label lblDate;
        private Label lblDateT;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private RichTextBox rtxtRequirement;
        private TabPage tabPage2;
        private RichTextBox rtxtDescription;
        private ReaLTaiizor.Controls.DreamButton btnApply;
        private ReaLTaiizor.Controls.DreamButton btnBack;
    }
}
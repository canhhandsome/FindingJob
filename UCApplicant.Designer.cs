namespace WinFormProject
{
    partial class UCApplicant
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
            panel1 = new Panel();
            btnDecline = new Button();
            lblDateT = new Label();
            lblJobT = new Label();
            lblApplicantNameT = new Label();
            btnApprove = new Button();
            btnProfile = new Button();
            lblDate = new Label();
            lblJob = new Label();
            lblApplicantName = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(btnDecline);
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblJobT);
            panel1.Controls.Add(lblApplicantNameT);
            panel1.Controls.Add(btnApprove);
            panel1.Controls.Add(btnProfile);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblJob);
            panel1.Controls.Add(lblApplicantName);
            panel1.Dock = DockStyle.Fill;
            panel1.ForeColor = SystemColors.ControlText;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(831, 176);
            panel1.TabIndex = 3;
            // 
            // btnDecline
            // 
            btnDecline.FlatStyle = FlatStyle.Flat;
            btnDecline.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDecline.ForeColor = SystemColors.ControlText;
            btnDecline.Location = new Point(508, 124);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(98, 33);
            btnDecline.TabIndex = 8;
            btnDecline.Text = "Decline";
            btnDecline.UseVisualStyleBackColor = true;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = SystemColors.ControlText;
            lblDateT.Location = new Point(84, 67);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(58, 25);
            lblDateT.TabIndex = 7;
            lblDateT.Text = "Date: ";
            // 
            // lblJobT
            // 
            lblJobT.AutoSize = true;
            lblJobT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobT.ForeColor = SystemColors.ControlText;
            lblJobT.Location = new Point(74, 38);
            lblJobT.Name = "lblJobT";
            lblJobT.Size = new Size(49, 25);
            lblJobT.TabIndex = 6;
            lblJobT.Text = "Job: ";
            // 
            // lblApplicantNameT
            // 
            lblApplicantNameT.AutoSize = true;
            lblApplicantNameT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApplicantNameT.ForeColor = SystemColors.ControlText;
            lblApplicantNameT.Location = new Point(192, 11);
            lblApplicantNameT.Name = "lblApplicantNameT";
            lblApplicantNameT.Size = new Size(160, 25);
            lblApplicantNameT.TabIndex = 5;
            lblApplicantNameT.Text = "Applicant's Name: ";
            // 
            // btnApprove
            // 
            btnApprove.FlatStyle = FlatStyle.Flat;
            btnApprove.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnApprove.ForeColor = SystemColors.ControlText;
            btnApprove.Location = new Point(611, 124);
            btnApprove.Name = "btnApprove";
            btnApprove.Size = new Size(98, 33);
            btnApprove.TabIndex = 3;
            btnApprove.Text = "Approve";
            btnApprove.UseVisualStyleBackColor = true;
            // 
            // btnProfile
            // 
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnProfile.ForeColor = SystemColors.ControlText;
            btnProfile.Location = new Point(714, 124);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(98, 33);
            btnProfile.TabIndex = 3;
            btnProfile.Text = "Profile";
            btnProfile.UseVisualStyleBackColor = true;
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.ForeColor = SystemColors.ControlText;
            lblDate.Location = new Point(18, 67);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 25);
            lblDate.TabIndex = 2;
            lblDate.Text = "Date: ";
            // 
            // lblJob
            // 
            lblJob.AutoSize = true;
            lblJob.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblJob.ForeColor = SystemColors.ControlText;
            lblJob.Location = new Point(18, 38);
            lblJob.Name = "lblJob";
            lblJob.Size = new Size(49, 25);
            lblJob.TabIndex = 1;
            lblJob.Text = "Job: ";
            // 
            // lblApplicantName
            // 
            lblApplicantName.AutoSize = true;
            lblApplicantName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblApplicantName.ForeColor = SystemColors.ControlText;
            lblApplicantName.Location = new Point(18, 11);
            lblApplicantName.Name = "lblApplicantName";
            lblApplicantName.Size = new Size(160, 25);
            lblApplicantName.TabIndex = 0;
            lblApplicantName.Text = "Applicant's Name: ";
            // 
            // UCApplicant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCApplicant";
            Size = new Size(831, 176);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnApprove;
        private Button btnProfile;
        private Label lblDate;
        private Label lblJob;
        private Label lblApplicantName;
        private Button btnDecline;
        private Label lblDateT;
        private Label lblJobT;
        private Label lblApplicantNameT;
    }
}

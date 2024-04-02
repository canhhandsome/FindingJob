namespace WinFormProject
{
    partial class UCInformation
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
            ptbCompanyPicture = new PictureBox();
            lblDateEndT = new Label();
            lblDateEnd = new Label();
            lblDateT = new Label();
            lblDate = new Label();
            lblNameT = new Label();
            lblContent = new Label();
            lblFromT = new Label();
            lblForm = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(254, 232, 223);
            panel1.Controls.Add(ptbCompanyPicture);
            panel1.Controls.Add(lblDateEndT);
            panel1.Controls.Add(lblDateEnd);
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblNameT);
            panel1.Controls.Add(lblContent);
            panel1.Controls.Add(lblFromT);
            panel1.Controls.Add(lblForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 135);
            panel1.TabIndex = 7;
            panel1.Click += panel1_Click;
            // 
            // ptbCompanyPicture
            // 
            ptbCompanyPicture.Location = new Point(15, 7);
            ptbCompanyPicture.Margin = new Padding(3, 2, 3, 2);
            ptbCompanyPicture.Name = "ptbCompanyPicture";
            ptbCompanyPicture.Size = new Size(131, 119);
            ptbCompanyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCompanyPicture.TabIndex = 1;
            ptbCompanyPicture.TabStop = false;
            // 
            // lblDateEndT
            // 
            lblDateEndT.AutoSize = true;
            lblDateEndT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateEndT.Location = new Point(693, 13);
            lblDateEndT.Name = "lblDateEndT";
            lblDateEndT.Size = new Size(58, 25);
            lblDateEndT.TabIndex = 0;
            lblDateEndT.Text = "Date: ";
            // 
            // lblDateEnd
            // 
            lblDateEnd.AutoSize = true;
            lblDateEnd.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateEnd.Location = new Point(568, 13);
            lblDateEnd.Name = "lblDateEnd";
            lblDateEnd.Size = new Size(93, 25);
            lblDateEnd.TabIndex = 0;
            lblDateEnd.Text = "Date End: ";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(277, 50);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(58, 25);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(151, 50);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(120, 25);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date Publish: ";
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameT.Location = new Point(277, 88);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(68, 25);
            lblNameT.TabIndex = 0;
            lblNameT.Text = "Name: ";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(151, 88);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(68, 25);
            lblContent.TabIndex = 0;
            lblContent.Text = "Name: ";
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFromT.Location = new Point(277, 13);
            lblFromT.Name = "lblFromT";
            lblFromT.Size = new Size(58, 25);
            lblFromT.TabIndex = 0;
            lblFromT.Text = "From:";
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblForm.Location = new Point(151, 13);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(58, 25);
            lblForm.TabIndex = 0;
            lblForm.Text = "From:";
            // 
            // UCInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCInformation";
            Size = new Size(847, 135);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lblDate;
        public Label lblContent;
        public Label lblForm;
        public Label lblDateT;
        public Label lblFromT;
        public Label lblNameT;
        private PictureBox ptbCompanyPicture;
        public Label lblDateEndT;
        public Label lblDateEnd;
    }
}

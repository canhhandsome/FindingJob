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
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblNameT);
            panel1.Controls.Add(lblContent);
            panel1.Controls.Add(lblFromT);
            panel1.Controls.Add(lblForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 180);
            panel1.TabIndex = 7;
            panel1.Click += panel1_Click;
            // 
            // ptbCompanyPicture
            // 
            ptbCompanyPicture.Location = new Point(17, 17);
            ptbCompanyPicture.Name = "ptbCompanyPicture";
            ptbCompanyPicture.Size = new Size(150, 145);
            ptbCompanyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCompanyPicture.TabIndex = 1;
            ptbCompanyPicture.TabStop = false;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(264, 67);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(69, 30);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(173, 67);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(69, 30);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date: ";
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameT.Location = new Point(264, 117);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(82, 30);
            lblNameT.TabIndex = 0;
            lblNameT.Text = "Name: ";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(173, 117);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(82, 30);
            lblContent.TabIndex = 0;
            lblContent.Text = "Name: ";
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFromT.Location = new Point(264, 17);
            lblFromT.Name = "lblFromT";
            lblFromT.Size = new Size(69, 30);
            lblFromT.TabIndex = 0;
            lblFromT.Text = "From:";
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblForm.Location = new Point(173, 17);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(69, 30);
            lblForm.TabIndex = 0;
            lblForm.Text = "From:";
            // 
            // UCInformation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCInformation";
            Size = new Size(968, 180);
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
    }
}

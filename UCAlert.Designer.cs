namespace WinFormProject
{
    partial class UCAlert
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
            lblDateT = new Label();
            lblDate = new Label();
            lblSubjectT = new Label();
            lblSubject = new Label();
            lblFromT = new Label();
            lblForm = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblDateT);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblSubjectT);
            panel1.Controls.Add(lblSubject);
            panel1.Controls.Add(lblFromT);
            panel1.Controls.Add(lblForm);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.MaximumSize = new Size(848, 170);
            panel1.Name = "panel1";
            panel1.Size = new Size(847, 169);
            panel1.TabIndex = 8;
            panel1.Click += panel1_Click;
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(102, 91);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(58, 25);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(14, 91);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 25);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date: ";
            // 
            // lblSubjectT
            // 
            lblSubjectT.AutoSize = true;
            lblSubjectT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubjectT.Location = new Point(102, 53);
            lblSubjectT.Name = "lblSubjectT";
            lblSubjectT.Size = new Size(79, 25);
            lblSubjectT.TabIndex = 0;
            lblSubjectT.Text = "Subject: ";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(14, 53);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(79, 25);
            lblSubject.TabIndex = 0;
            lblSubject.Text = "Subject: ";
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFromT.Location = new Point(102, 16);
            lblFromT.Name = "lblFromT";
            lblFromT.Size = new Size(58, 25);
            lblFromT.TabIndex = 0;
            lblFromT.Text = "From:";
            // 
            // lblForm
            // 
            lblForm.AutoSize = true;
            lblForm.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblForm.Location = new Point(14, 16);
            lblForm.Name = "lblForm";
            lblForm.Size = new Size(58, 25);
            lblForm.TabIndex = 0;
            lblForm.Text = "From:";
            // 
            // UCAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCAlert";
            Size = new Size(847, 169);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel panel1;
        public Label lblDateT;
        public Label lblDate;
        public Label lblSubjectT;
        public Label lblSubject;
        public Label lblFromT;
        public Label lblForm;
    }
}

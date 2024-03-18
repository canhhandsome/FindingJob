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
            lblDateT = new Label();
            lblDate = new Label();
            lblNameT = new Label();
            lblContent = new Label();
            lblFromT = new Label();
            lblForm = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.Fixed3D;
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
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(94, 53);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(58, 25);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(14, 53);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(58, 25);
            lblDate.TabIndex = 0;
            lblDate.Text = "Date: ";
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblNameT.Location = new Point(94, 91);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(68, 25);
            lblNameT.TabIndex = 0;
            lblNameT.Text = "Name: ";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(14, 91);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(68, 25);
            lblContent.TabIndex = 0;
            lblContent.Text = "Name: ";
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblFromT.Location = new Point(94, 16);
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
    }
}

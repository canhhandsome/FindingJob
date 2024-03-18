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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDateT = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblContentT = new System.Windows.Forms.Label();
            this.lblContent = new System.Windows.Forms.Label();
            this.lblFromT = new System.Windows.Forms.Label();
            this.lblForm = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblDateT);
            this.panel1.Controls.Add(this.lblDate);
            this.panel1.Controls.Add(this.lblContentT);
            this.panel1.Controls.Add(this.lblContent);
            this.panel1.Controls.Add(this.lblFromT);
            this.panel1.Controls.Add(this.lblForm);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.MaximumSize = new System.Drawing.Size(968, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 225);
            this.panel1.TabIndex = 8;
            // 
            // lblDateT
            // 
            this.lblDateT.AutoSize = true;
            this.lblDateT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDateT.Location = new System.Drawing.Point(91, 121);
            this.lblDateT.Name = "lblDateT";
            this.lblDateT.Size = new System.Drawing.Size(69, 30);
            this.lblDateT.TabIndex = 0;
            this.lblDateT.Text = "Date: ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(16, 121);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(69, 30);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Date: ";
            // 
            // lblContentT
            // 
            this.lblContentT.AutoSize = true;
            this.lblContentT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContentT.Location = new System.Drawing.Point(123, 71);
            this.lblContentT.Name = "lblContentT";
            this.lblContentT.Size = new System.Drawing.Size(101, 30);
            this.lblContentT.TabIndex = 0;
            this.lblContentT.Text = "Content: ";
            // 
            // lblContent
            // 
            this.lblContent.AutoSize = true;
            this.lblContent.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblContent.Location = new System.Drawing.Point(16, 71);
            this.lblContent.Name = "lblContent";
            this.lblContent.Size = new System.Drawing.Size(101, 30);
            this.lblContent.TabIndex = 0;
            this.lblContent.Text = "Content: ";
            // 
            // lblFromT
            // 
            this.lblFromT.AutoSize = true;
            this.lblFromT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFromT.Location = new System.Drawing.Point(91, 21);
            this.lblFromT.Name = "lblFromT";
            this.lblFromT.Size = new System.Drawing.Size(69, 30);
            this.lblFromT.TabIndex = 0;
            this.lblFromT.Text = "From:";
            // 
            // lblForm
            // 
            this.lblForm.AutoSize = true;
            this.lblForm.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblForm.Location = new System.Drawing.Point(16, 21);
            this.lblForm.Name = "lblForm";
            this.lblForm.Size = new System.Drawing.Size(69, 30);
            this.lblForm.TabIndex = 0;
            this.lblForm.Text = "From:";
            // 
            // UCAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UCAlert";
            this.Size = new System.Drawing.Size(968, 225);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public Panel panel1;
        public Label lblDateT;
        public Label lblDate;
        public Label lblContentT;
        public Label lblContent;
        public Label lblFromT;
        public Label lblForm;
    }
}

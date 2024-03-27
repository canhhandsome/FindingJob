namespace WinFormProject
{
    partial class FAlertView
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
            btnDone = new Button();
            lblContent = new Label();
            lblSubject = new Label();
            lblDateT = new Label();
            lblDate = new Label();
            llFromT = new Label();
            lblFrom = new Label();
            lblSubjectT = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            lblContentT = new Label();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnDone
            // 
            btnDone.BackColor = Color.White;
            btnDone.Cursor = Cursors.Hand;
            btnDone.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnDone.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnDone.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnDone.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDone.ForeColor = SystemColors.ActiveCaptionText;
            btnDone.Location = new Point(750, 383);
            btnDone.Name = "btnDone";
            btnDone.Size = new Size(134, 37);
            btnDone.TabIndex = 38;
            btnDone.Text = "Done";
            btnDone.UseVisualStyleBackColor = false;
            btnDone.Click += btnDone_Click;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(9, 130);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(83, 25);
            lblContent.TabIndex = 35;
            lblContent.Text = "Content:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(9, 88);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(78, 25);
            lblSubject.TabIndex = 34;
            lblSubject.Text = "Subject:";
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.Location = new Point(106, 50);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(55, 25);
            lblDateT.TabIndex = 33;
            lblDateT.Text = "Date:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(9, 50);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(55, 25);
            lblDate.TabIndex = 32;
            lblDate.Text = "Date:";
            // 
            // llFromT
            // 
            llFromT.AutoSize = true;
            llFromT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            llFromT.Location = new Point(106, 12);
            llFromT.Name = "llFromT";
            llFromT.Size = new Size(59, 25);
            llFromT.TabIndex = 31;
            llFromT.Text = "From:";
            // 
            // lblFrom
            // 
            lblFrom.AutoSize = true;
            lblFrom.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblFrom.Location = new Point(9, 12);
            lblFrom.Name = "lblFrom";
            lblFrom.Size = new Size(59, 25);
            lblFrom.TabIndex = 30;
            lblFrom.Text = "From:";
            // 
            // lblSubjectT
            // 
            lblSubjectT.AutoSize = true;
            lblSubjectT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubjectT.Location = new Point(106, 88);
            lblSubjectT.Name = "lblSubjectT";
            lblSubjectT.Size = new Size(78, 25);
            lblSubjectT.TabIndex = 40;
            lblSubjectT.Text = "Subject:";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.White;
            flowLayoutPanel1.BorderStyle = BorderStyle.Fixed3D;
            flowLayoutPanel1.Controls.Add(lblContentT);
            flowLayoutPanel1.Enabled = false;
            flowLayoutPanel1.Location = new Point(106, 130);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(750, 237);
            flowLayoutPanel1.TabIndex = 41;
            // 
            // lblContentT
            // 
            lblContentT.AutoSize = true;
            lblContentT.BackColor = Color.White;
            lblContentT.Dock = DockStyle.Fill;
            lblContentT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblContentT.Location = new Point(3, 0);
            lblContentT.Name = "lblContentT";
            lblContentT.Size = new Size(65, 21);
            lblContentT.TabIndex = 0;
            lblContentT.Text = "Content";
            // 
            // FAlertView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(918, 439);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(lblSubjectT);
            Controls.Add(btnDone);
            Controls.Add(lblContent);
            Controls.Add(lblSubject);
            Controls.Add(lblDateT);
            Controls.Add(lblDate);
            Controls.Add(llFromT);
            Controls.Add(lblFrom);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAlertView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAlertView";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnDone;
        private Label lblContent;
        private Label lblSubject;
        private Label lblDateT;
        private Label lblDate;
        private Label llFromT;
        private Label lblFrom;
        private Label lblSubjectT;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label lblContentT;
    }
}
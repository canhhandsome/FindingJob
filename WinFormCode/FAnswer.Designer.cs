namespace WinFormProject
{
    partial class FAnswer
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblTo = new Label();
            lblToT = new Label();
            lblSubject = new Label();
            lblContent = new Label();
            txtContent = new ReaLTaiizor.Controls.HopeRichTextBox();
            btnCancel = new Button();
            btnSend = new Button();
            txtSubject = new ReaLTaiizor.Controls.HopeTextBox();
            cbbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            SuspendLayout();
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTo.Location = new Point(15, 23);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(35, 25);
            lblTo.TabIndex = 9;
            lblTo.Text = "To:";
            // 
            // lblToT
            // 
            lblToT.AutoSize = true;
            lblToT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblToT.Location = new Point(112, 23);
            lblToT.Name = "lblToT";
            lblToT.Size = new Size(35, 25);
            lblToT.TabIndex = 10;
            lblToT.Text = "To:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(15, 62);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(78, 25);
            lblSubject.TabIndex = 11;
            lblSubject.Text = "Subject:";
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(15, 103);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(83, 25);
            lblContent.TabIndex = 12;
            lblContent.Text = "Content:";
            // 
            // txtContent
            // 
            txtContent.BorderColor = Color.FromArgb(220, 223, 230);
            txtContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.ForeColor = Color.FromArgb(48, 49, 51);
            txtContent.Hint = "";
            txtContent.HoverBorderColor = Color.FromArgb(64, 158, 255);
            txtContent.Location = new Point(112, 103);
            txtContent.Margin = new Padding(3, 2, 3, 2);
            txtContent.MaxLength = 32767;
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.PasswordChar = '\0';
            txtContent.ScrollBars = ScrollBars.None;
            txtContent.SelectedText = "";
            txtContent.SelectionLength = 0;
            txtContent.SelectionStart = 0;
            txtContent.Size = new Size(769, 177);
            txtContent.TabIndex = 14;
            txtContent.TabStop = false;
            txtContent.Text = "Enter content";
            txtContent.UseSystemPasswordChar = false;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.LightCoral;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCancel.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnCancel.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnCancel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancel.ForeColor = SystemColors.Control;
            btnCancel.Location = new Point(747, 321);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 37);
            btnCancel.TabIndex = 28;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSend
            // 
            btnSend.BackColor = Color.White;
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = SystemColors.ControlText;
            btnSend.Location = new Point(589, 321);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(134, 37);
            btnSend.TabIndex = 29;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
            btnSend.Click += btnSend_Click;
            // 
            // txtSubject
            // 
            txtSubject.BackColor = Color.White;
            txtSubject.BaseColor = Color.FromArgb(44, 55, 66);
            txtSubject.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSubject.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSubject.Cursor = Cursors.IBeam;
            txtSubject.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtSubject.ForeColor = Color.FromArgb(48, 49, 51);
            txtSubject.Hint = "Enter subject";
            txtSubject.Location = new Point(112, 56);
            txtSubject.Margin = new Padding(3, 2, 3, 2);
            txtSubject.MaxLength = 32767;
            txtSubject.Multiline = false;
            txtSubject.Name = "txtSubject";
            txtSubject.PasswordChar = '\0';
            txtSubject.ScrollBars = ScrollBars.None;
            txtSubject.SelectedText = "";
            txtSubject.SelectionLength = 0;
            txtSubject.SelectionStart = 0;
            txtSubject.Size = new Size(599, 38);
            txtSubject.TabIndex = 13;
            txtSubject.TabStop = false;
            txtSubject.UseSystemPasswordChar = false;
            // 
            // cbbStatus
            // 
            cbbStatus.BackColor = Color.Transparent;
            cbbStatus.CustomizableEdges = customizableEdges3;
            cbbStatus.DrawMode = DrawMode.OwnerDrawFixed;
            cbbStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbStatus.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbStatus.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbStatus.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbbStatus.ForeColor = Color.FromArgb(68, 88, 112);
            cbbStatus.ItemHeight = 30;
            cbbStatus.Items.AddRange(new object[] { "Approve", "Decline" });
            cbbStatus.Location = new Point(729, 56);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbbStatus.Size = new Size(152, 36);
            cbbStatus.TabIndex = 30;
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.BorderRadius = 30;
            guna2Elipse1.TargetControl = this;
            // 
            // guna2ShadowForm1
            // 
            guna2ShadowForm1.BorderRadius = 30;
            guna2ShadowForm1.TargetForm = this;
            // 
            // FAnswer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 386);
            Controls.Add(cbbStatus);
            Controls.Add(btnSend);
            Controls.Add(btnCancel);
            Controls.Add(txtContent);
            Controls.Add(txtSubject);
            Controls.Add(lblContent);
            Controls.Add(lblSubject);
            Controls.Add(lblToT);
            Controls.Add(lblTo);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FAnswer";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FAnswer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblTo;
        private Label lblToT;
        private Label lblSubject;
        private Label lblContent;
        private ReaLTaiizor.Controls.HopeRichTextBox txtContent;
        private Button btnCancel;
        private Button btnSend;
        private ReaLTaiizor.Controls.HopeTextBox txtSubject;
        private Guna.UI2.WinForms.Guna2ComboBox cbbStatus;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
    }
}
namespace WinFormProject.WinFormCode
{
    partial class FOffer
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            btnSend = new Button();
            btnCancel = new Button();
            txtContent = new ReaLTaiizor.Controls.HopeRichTextBox();
            lblContent = new Label();
            lblSubject = new Label();
            lblToT = new Label();
            lblTo = new Label();
            guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowForm2 = new Guna.UI2.WinForms.Guna2ShadowForm(components);
            btnInterview = new Guna.UI2.WinForms.Guna2Button();
            cbbSubject = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
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
            // btnSend
            // 
            btnSend.BackColor = Color.White;
            btnSend.Cursor = Cursors.Hand;
            btnSend.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSend.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnSend.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnSend.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSend.ForeColor = SystemColors.ControlText;
            btnSend.Location = new Point(600, 324);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(134, 37);
            btnSend.TabIndex = 38;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = false;
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
            btnCancel.Location = new Point(758, 324);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(134, 37);
            btnCancel.TabIndex = 37;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // txtContent
            // 
            txtContent.BorderColor = Color.FromArgb(220, 223, 230);
            txtContent.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtContent.ForeColor = Color.FromArgb(48, 49, 51);
            txtContent.Hint = "";
            txtContent.HoverBorderColor = Color.FromArgb(64, 158, 255);
            txtContent.Location = new Point(123, 106);
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
            txtContent.TabIndex = 36;
            txtContent.TabStop = false;
            txtContent.Text = "Enter content";
            txtContent.UseSystemPasswordChar = false;
            // 
            // lblContent
            // 
            lblContent.AutoSize = true;
            lblContent.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblContent.Location = new Point(26, 106);
            lblContent.Name = "lblContent";
            lblContent.Size = new Size(83, 25);
            lblContent.TabIndex = 35;
            lblContent.Text = "Content:";
            // 
            // lblSubject
            // 
            lblSubject.AutoSize = true;
            lblSubject.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblSubject.Location = new Point(26, 65);
            lblSubject.Name = "lblSubject";
            lblSubject.Size = new Size(78, 25);
            lblSubject.TabIndex = 34;
            lblSubject.Text = "Subject:";
            // 
            // lblToT
            // 
            lblToT.AutoSize = true;
            lblToT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblToT.Location = new Point(123, 26);
            lblToT.Name = "lblToT";
            lblToT.Size = new Size(35, 25);
            lblToT.TabIndex = 33;
            lblToT.Text = "To:";
            // 
            // lblTo
            // 
            lblTo.AutoSize = true;
            lblTo.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblTo.Location = new Point(26, 26);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(35, 25);
            lblTo.TabIndex = 32;
            lblTo.Text = "To:";
            // 
            // guna2Elipse2
            // 
            guna2Elipse2.BorderRadius = 30;
            // 
            // guna2ShadowForm2
            // 
            guna2ShadowForm2.BorderRadius = 30;
            // 
            // btnInterview
            // 
            btnInterview.BorderRadius = 10;
            btnInterview.Cursor = Cursors.Hand;
            btnInterview.CustomizableEdges = customizableEdges1;
            btnInterview.DisabledState.BorderColor = Color.DarkGray;
            btnInterview.DisabledState.CustomBorderColor = Color.DarkGray;
            btnInterview.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnInterview.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnInterview.FillColor = Color.FromArgb(176, 226, 243);
            btnInterview.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnInterview.ForeColor = Color.Black;
            btnInterview.Location = new Point(361, 65);
            btnInterview.Name = "btnInterview";
            btnInterview.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnInterview.Size = new Size(107, 36);
            btnInterview.TabIndex = 40;
            btnInterview.Text = "Interview";
            btnInterview.Visible = false;
            // 
            // cbbSubject
            // 
            cbbSubject.BackColor = Color.Transparent;
            cbbSubject.CustomizableEdges = customizableEdges3;
            cbbSubject.DrawMode = DrawMode.OwnerDrawFixed;
            cbbSubject.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSubject.FocusedColor = Color.FromArgb(94, 148, 255);
            cbbSubject.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            cbbSubject.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cbbSubject.ForeColor = Color.FromArgb(68, 88, 112);
            cbbSubject.ItemHeight = 30;
            cbbSubject.Items.AddRange(new object[] { "Approve", "Decline" });
            cbbSubject.Location = new Point(123, 65);
            cbbSubject.Name = "cbbSubject";
            cbbSubject.ShadowDecoration.CustomizableEdges = customizableEdges4;
            cbbSubject.Size = new Size(221, 36);
            cbbSubject.TabIndex = 39;
            // 
            // FOffer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(918, 386);
            Controls.Add(btnSend);
            Controls.Add(btnCancel);
            Controls.Add(txtContent);
            Controls.Add(lblContent);
            Controls.Add(lblSubject);
            Controls.Add(lblToT);
            Controls.Add(lblTo);
            Controls.Add(btnInterview);
            Controls.Add(cbbSubject);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FOffer";
            Text = "FOffer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Button btnSend;
        private Button btnCancel;
        private ReaLTaiizor.Controls.HopeRichTextBox txtContent;
        private Label lblContent;
        private Label lblSubject;
        private Label lblToT;
        private Label lblTo;
        private Guna.UI2.WinForms.Guna2Button btnInterview;
        private Guna.UI2.WinForms.Guna2ComboBox cbbSubject;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm2;
    }
}
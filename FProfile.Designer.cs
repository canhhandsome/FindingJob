using System.Drawing.Drawing2D;

namespace WinFormProject
{
    partial class FProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProfile));
            txtboxFullName = new ReaLTaiizor.Controls.HopeTextBox();
            txtboxPhoneNumber = new ReaLTaiizor.Controls.HopeTextBox();
            txtboxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            txtboxAddress = new ReaLTaiizor.Controls.HopeTextBox();
            dtpkBirthDate = new DateTimePicker();
            hopeRadioButton1 = new ReaLTaiizor.Controls.HopeRadioButton();
            hopeRadioButton2 = new ReaLTaiizor.Controls.HopeRadioButton();
            txtboxCitizenId = new ReaLTaiizor.Controls.HopeTextBox();
            ptbAvatar = new PictureBox();
            btnCV = new Button();
            txtboxPersonalLink = new ReaLTaiizor.Controls.HopeTextBox();
            btnEdit = new Button();
            lblFullName = new Label();
            lblAddress = new Label();
            lblCitizenId = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblPersonalLink = new Label();
            lblDoB = new Label();
            label8 = new Label();
            btnCancel = new Button();
            btnChoosePicture = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            SuspendLayout();
            // 
            // txtboxFullName
            // 
            txtboxFullName.BackColor = Color.White;
            txtboxFullName.BaseColor = Color.FromArgb(44, 55, 66);
            txtboxFullName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtboxFullName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtboxFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxFullName.ForeColor = Color.FromArgb(48, 49, 51);
            txtboxFullName.Hint = "Enter Fullname";
            txtboxFullName.Location = new Point(33, 60);
            txtboxFullName.Margin = new Padding(3, 4, 3, 4);
            txtboxFullName.MaxLength = 32767;
            txtboxFullName.Multiline = false;
            txtboxFullName.Name = "txtboxFullName";
            txtboxFullName.PasswordChar = '\0';
            txtboxFullName.ScrollBars = ScrollBars.None;
            txtboxFullName.SelectedText = "";
            txtboxFullName.SelectionLength = 0;
            txtboxFullName.SelectionStart = 0;
            txtboxFullName.Size = new Size(298, 43);
            txtboxFullName.TabIndex = 3;
            txtboxFullName.TabStop = false;
            txtboxFullName.UseSystemPasswordChar = false;
            // 
            // txtboxPhoneNumber
            // 
            txtboxPhoneNumber.BackColor = Color.White;
            txtboxPhoneNumber.BaseColor = Color.FromArgb(44, 55, 66);
            txtboxPhoneNumber.BorderColorA = Color.FromArgb(64, 158, 255);
            txtboxPhoneNumber.BorderColorB = Color.FromArgb(220, 223, 230);
            txtboxPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxPhoneNumber.ForeColor = Color.FromArgb(48, 49, 51);
            txtboxPhoneNumber.Hint = "Enter Phone Number";
            txtboxPhoneNumber.Location = new Point(33, 164);
            txtboxPhoneNumber.Margin = new Padding(3, 4, 3, 4);
            txtboxPhoneNumber.MaxLength = 32767;
            txtboxPhoneNumber.Multiline = false;
            txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            txtboxPhoneNumber.PasswordChar = '\0';
            txtboxPhoneNumber.ScrollBars = ScrollBars.None;
            txtboxPhoneNumber.SelectedText = "";
            txtboxPhoneNumber.SelectionLength = 0;
            txtboxPhoneNumber.SelectionStart = 0;
            txtboxPhoneNumber.Size = new Size(298, 43);
            txtboxPhoneNumber.TabIndex = 4;
            txtboxPhoneNumber.TabStop = false;
            txtboxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // txtboxEmail
            // 
            txtboxEmail.BackColor = Color.White;
            txtboxEmail.BaseColor = Color.FromArgb(44, 55, 66);
            txtboxEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtboxEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtboxEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtboxEmail.Hint = "Enter Email";
            txtboxEmail.Location = new Point(33, 271);
            txtboxEmail.Margin = new Padding(3, 4, 3, 4);
            txtboxEmail.MaxLength = 32767;
            txtboxEmail.Multiline = false;
            txtboxEmail.Name = "txtboxEmail";
            txtboxEmail.PasswordChar = '\0';
            txtboxEmail.ScrollBars = ScrollBars.None;
            txtboxEmail.SelectedText = "";
            txtboxEmail.SelectionLength = 0;
            txtboxEmail.SelectionStart = 0;
            txtboxEmail.Size = new Size(298, 43);
            txtboxEmail.TabIndex = 5;
            txtboxEmail.TabStop = false;
            txtboxEmail.UseSystemPasswordChar = false;
            // 
            // txtboxAddress
            // 
            txtboxAddress.BackColor = Color.White;
            txtboxAddress.BaseColor = Color.FromArgb(44, 55, 66);
            txtboxAddress.BorderColorA = Color.FromArgb(64, 158, 255);
            txtboxAddress.BorderColorB = Color.FromArgb(220, 223, 230);
            txtboxAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxAddress.ForeColor = Color.FromArgb(48, 49, 51);
            txtboxAddress.Hint = "Enter Address";
            txtboxAddress.Location = new Point(415, 60);
            txtboxAddress.Margin = new Padding(3, 4, 3, 4);
            txtboxAddress.MaxLength = 32767;
            txtboxAddress.Multiline = false;
            txtboxAddress.Name = "txtboxAddress";
            txtboxAddress.PasswordChar = '\0';
            txtboxAddress.ScrollBars = ScrollBars.None;
            txtboxAddress.SelectedText = "";
            txtboxAddress.SelectionLength = 0;
            txtboxAddress.SelectionStart = 0;
            txtboxAddress.Size = new Size(298, 43);
            txtboxAddress.TabIndex = 5;
            txtboxAddress.TabStop = false;
            txtboxAddress.UseSystemPasswordChar = false;
            // 
            // dtpkBirthDate
            // 
            dtpkBirthDate.Location = new Point(415, 371);
            dtpkBirthDate.Margin = new Padding(3, 4, 3, 4);
            dtpkBirthDate.Name = "dtpkBirthDate";
            dtpkBirthDate.Size = new Size(226, 27);
            dtpkBirthDate.TabIndex = 6;
            // 
            // hopeRadioButton1
            // 
            hopeRadioButton1.AutoSize = true;
            hopeRadioButton1.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeRadioButton1.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeRadioButton1.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeRadioButton1.Enable = true;
            hopeRadioButton1.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeRadioButton1.EnabledStringColor = Color.FromArgb(146, 146, 146);
            hopeRadioButton1.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeRadioButton1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeRadioButton1.ForeColor = SystemColors.Desktop;
            hopeRadioButton1.Location = new Point(33, 375);
            hopeRadioButton1.Margin = new Padding(3, 4, 3, 4);
            hopeRadioButton1.Name = "hopeRadioButton1";
            hopeRadioButton1.Size = new Size(80, 20);
            hopeRadioButton1.TabIndex = 7;
            hopeRadioButton1.TabStop = true;
            hopeRadioButton1.Text = "Male";
            hopeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // hopeRadioButton2
            // 
            hopeRadioButton2.AutoSize = true;
            hopeRadioButton2.CheckedColor = Color.FromArgb(64, 158, 255);
            hopeRadioButton2.DisabledColor = Color.FromArgb(196, 198, 202);
            hopeRadioButton2.DisabledStringColor = Color.FromArgb(186, 187, 189);
            hopeRadioButton2.Enable = true;
            hopeRadioButton2.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            hopeRadioButton2.EnabledStringColor = Color.FromArgb(146, 146, 146);
            hopeRadioButton2.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            hopeRadioButton2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeRadioButton2.ForeColor = SystemColors.ControlText;
            hopeRadioButton2.Location = new Point(176, 375);
            hopeRadioButton2.Margin = new Padding(3, 4, 3, 4);
            hopeRadioButton2.Name = "hopeRadioButton2";
            hopeRadioButton2.Size = new Size(99, 20);
            hopeRadioButton2.TabIndex = 7;
            hopeRadioButton2.TabStop = true;
            hopeRadioButton2.Text = "Female";
            hopeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // txtboxCitizenId
            // 
            txtboxCitizenId.BackColor = Color.White;
            txtboxCitizenId.BaseColor = Color.FromArgb(44, 55, 66);
            txtboxCitizenId.BorderColorA = Color.FromArgb(64, 158, 255);
            txtboxCitizenId.BorderColorB = Color.FromArgb(220, 223, 230);
            txtboxCitizenId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxCitizenId.ForeColor = Color.FromArgb(48, 49, 51);
            txtboxCitizenId.Hint = "Enter Citizen identification";
            txtboxCitizenId.Location = new Point(415, 164);
            txtboxCitizenId.Margin = new Padding(3, 4, 3, 4);
            txtboxCitizenId.MaxLength = 32767;
            txtboxCitizenId.Multiline = false;
            txtboxCitizenId.Name = "txtboxCitizenId";
            txtboxCitizenId.PasswordChar = '\0';
            txtboxCitizenId.ScrollBars = ScrollBars.None;
            txtboxCitizenId.SelectedText = "";
            txtboxCitizenId.SelectionLength = 0;
            txtboxCitizenId.SelectionStart = 0;
            txtboxCitizenId.Size = new Size(298, 43);
            txtboxCitizenId.TabIndex = 5;
            txtboxCitizenId.TabStop = false;
            txtboxCitizenId.UseSystemPasswordChar = false;
            // 
            // ptbAvatar
            // 
            ptbAvatar.ErrorImage = (Image)resources.GetObject("ptbAvatar.ErrorImage");
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.Location = new Point(799, 28);
            ptbAvatar.Margin = new Padding(3, 4, 3, 4);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(171, 200);
            ptbAvatar.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbAvatar.TabIndex = 8;
            ptbAvatar.TabStop = false;
            // 
            // btnCV
            // 
            btnCV.BackColor = Color.DimGray;
            btnCV.Cursor = Cursors.Hand;
            btnCV.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnCV.FlatStyle = FlatStyle.System;
            btnCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCV.ForeColor = SystemColors.ControlLightLight;
            btnCV.Location = new Point(33, 491);
            btnCV.Margin = new Padding(3, 4, 3, 4);
            btnCV.Name = "btnCV";
            btnCV.Size = new Size(126, 49);
            btnCV.TabIndex = 10;
            btnCV.Text = "CV";
            btnCV.UseVisualStyleBackColor = false;
            // 
            // txtboxPersonalLink
            // 
            txtboxPersonalLink.BackColor = Color.White;
            txtboxPersonalLink.BaseColor = Color.FromArgb(44, 55, 66);
            txtboxPersonalLink.BorderColorA = Color.FromArgb(64, 158, 255);
            txtboxPersonalLink.BorderColorB = Color.FromArgb(220, 223, 230);
            txtboxPersonalLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            txtboxPersonalLink.ForeColor = Color.FromArgb(48, 49, 51);
            txtboxPersonalLink.Hint = "Enter Personal link";
            txtboxPersonalLink.Location = new Point(415, 271);
            txtboxPersonalLink.Margin = new Padding(3, 4, 3, 4);
            txtboxPersonalLink.MaxLength = 32767;
            txtboxPersonalLink.Multiline = false;
            txtboxPersonalLink.Name = "txtboxPersonalLink";
            txtboxPersonalLink.PasswordChar = '\0';
            txtboxPersonalLink.ScrollBars = ScrollBars.None;
            txtboxPersonalLink.SelectedText = "";
            txtboxPersonalLink.SelectionLength = 0;
            txtboxPersonalLink.SelectionStart = 0;
            txtboxPersonalLink.Size = new Size(298, 43);
            txtboxPersonalLink.TabIndex = 5;
            txtboxPersonalLink.TabStop = false;
            txtboxPersonalLink.UseSystemPasswordChar = false;
            // 
            // btnEdit
            // 
            btnEdit.BackColor = Color.DimGray;
            btnEdit.Cursor = Cursors.Hand;
            btnEdit.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnEdit.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnEdit.FlatStyle = FlatStyle.System;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ControlLightLight;
            btnEdit.Location = new Point(689, 491);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(126, 49);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += button5_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.ForeColor = SystemColors.ControlText;
            lblFullName.Location = new Point(33, 28);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(91, 28);
            lblFullName.TabIndex = 11;
            lblFullName.Text = "Fullname";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.ForeColor = SystemColors.ControlText;
            lblAddress.Location = new Point(415, 28);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(82, 28);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address";
            // 
            // lblCitizenId
            // 
            lblCitizenId.AutoSize = true;
            lblCitizenId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCitizenId.ForeColor = SystemColors.ControlText;
            lblCitizenId.Location = new Point(415, 132);
            lblCitizenId.Name = "lblCitizenId";
            lblCitizenId.Size = new Size(95, 28);
            lblCitizenId.TabIndex = 11;
            lblCitizenId.Text = "Citizen ID";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = SystemColors.ControlText;
            lblPhoneNumber.Location = new Point(33, 132);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(144, 28);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(33, 239);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 28);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblPersonalLink
            // 
            lblPersonalLink.AutoSize = true;
            lblPersonalLink.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPersonalLink.ForeColor = SystemColors.ControlText;
            lblPersonalLink.Location = new Point(415, 239);
            lblPersonalLink.Name = "lblPersonalLink";
            lblPersonalLink.Size = new Size(125, 28);
            lblPersonalLink.TabIndex = 11;
            lblPersonalLink.Text = "Personal Link";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoB.ForeColor = SystemColors.ControlText;
            lblDoB.Location = new Point(415, 337);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(122, 28);
            lblDoB.TabIndex = 11;
            lblDoB.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(33, 337);
            label8.Name = "label8";
            label8.Size = new Size(76, 28);
            label8.TabIndex = 11;
            label8.Text = "Gender";
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
            btnCancel.Location = new Point(821, 491);
            btnCancel.Margin = new Padding(3, 4, 3, 4);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(126, 49);
            btnCancel.TabIndex = 10;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            // 
            // btnChoosePicture
            // 
            btnChoosePicture.BackColor = Color.DimGray;
            btnChoosePicture.Cursor = Cursors.Hand;
            btnChoosePicture.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnChoosePicture.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnChoosePicture.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnChoosePicture.FlatStyle = FlatStyle.System;
            btnChoosePicture.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChoosePicture.ForeColor = SystemColors.ControlLightLight;
            btnChoosePicture.Location = new Point(810, 271);
            btnChoosePicture.Margin = new Padding(3, 4, 3, 4);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.Size = new Size(149, 49);
            btnChoosePicture.TabIndex = 12;
            btnChoosePicture.Text = "Choose Picture";
            btnChoosePicture.UseVisualStyleBackColor = false;
            btnChoosePicture.Click += btnChoosePicture_Click;
            // 
            // FProfile
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(1057, 580);
            Controls.Add(btnChoosePicture);
            Controls.Add(label8);
            Controls.Add(lblDoB);
            Controls.Add(lblPersonalLink);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCitizenId);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnCV);
            Controls.Add(ptbAvatar);
            Controls.Add(hopeRadioButton2);
            Controls.Add(hopeRadioButton1);
            Controls.Add(dtpkBirthDate);
            Controls.Add(txtboxPersonalLink);
            Controls.Add(txtboxCitizenId);
            Controls.Add(txtboxAddress);
            Controls.Add(txtboxEmail);
            Controls.Add(txtboxPhoneNumber);
            Controls.Add(txtboxFullName);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FProfile";
            Text = "FProfile";
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtboxFullName;
        private ReaLTaiizor.Controls.HopeTextBox txtboxPhoneNumber;
        private ReaLTaiizor.Controls.HopeTextBox txtboxEmail;
        private ReaLTaiizor.Controls.HopeTextBox txtboxAddress;
        private DateTimePicker dtpkBirthDate;
        private ReaLTaiizor.Controls.HopeRadioButton hopeRadioButton1;
        private ReaLTaiizor.Controls.HopeRadioButton hopeRadioButton2;
        private ReaLTaiizor.Controls.HopeTextBox txtboxCitizenId;
        private PictureBox ptbAvatar;
        private Button btnCV;
        private ReaLTaiizor.Controls.HopeTextBox txtboxPersonalLink;
        private Button btnEdit;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblCitizenId;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblPersonalLink;
        private Label lblDoB;
        private Label label8;
        private Button btnCancel;
        private Button btnChoosePicture;
    }
}
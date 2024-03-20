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
            dtpkBirthDate = new DateTimePicker();
            rdoMale = new ReaLTaiizor.Controls.HopeRadioButton();
            rdofemale = new ReaLTaiizor.Controls.HopeRadioButton();
            ptbAvatar = new PictureBox();
            btnCV = new Button();
            btnEdit = new Button();
            lblFullName = new Label();
            lblAddress = new Label();
            lblCitizenId = new Label();
            lblPhoneNumber = new Label();
            lblEmail = new Label();
            lblDoB = new Label();
            label8 = new Label();
            btnCancel = new Button();
            btnChoosePicture = new Button();
            btnSave = new Button();
            txtFullName = new TextBox();
            txtAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCitizenID = new TextBox();
            txtEmail = new TextBox();
            ptbCV = new PictureBox();
            btnChooseNewCV = new Button();
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ptbCV).BeginInit();
            SuspendLayout();
            // 
            // dtpkBirthDate
            // 
            dtpkBirthDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtpkBirthDate.Location = new Point(355, 207);
            dtpkBirthDate.Name = "dtpkBirthDate";
            dtpkBirthDate.Size = new Size(287, 29);
            dtpkBirthDate.TabIndex = 6;
            // 
            // rdoMale
            // 
            rdoMale.AutoSize = true;
            rdoMale.CheckedColor = Color.FromArgb(64, 158, 255);
            rdoMale.DisabledColor = Color.FromArgb(196, 198, 202);
            rdoMale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rdoMale.Enable = true;
            rdoMale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rdoMale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rdoMale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rdoMale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdoMale.ForeColor = SystemColors.Desktop;
            rdoMale.Location = new Point(29, 281);
            rdoMale.Name = "rdoMale";
            rdoMale.Size = new Size(69, 20);
            rdoMale.TabIndex = 7;
            rdoMale.TabStop = true;
            rdoMale.Text = "Male";
            rdoMale.UseVisualStyleBackColor = true;
            // 
            // rdofemale
            // 
            rdofemale.AutoSize = true;
            rdofemale.CheckedColor = Color.FromArgb(64, 158, 255);
            rdofemale.DisabledColor = Color.FromArgb(196, 198, 202);
            rdofemale.DisabledStringColor = Color.FromArgb(186, 187, 189);
            rdofemale.Enable = true;
            rdofemale.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            rdofemale.EnabledStringColor = Color.FromArgb(146, 146, 146);
            rdofemale.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            rdofemale.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rdofemale.ForeColor = SystemColors.ControlText;
            rdofemale.Location = new Point(154, 281);
            rdofemale.Name = "rdofemale";
            rdofemale.Size = new Size(85, 20);
            rdofemale.TabIndex = 7;
            rdofemale.TabStop = true;
            rdofemale.Text = "Female";
            rdofemale.UseVisualStyleBackColor = true;
            // 
            // ptbAvatar
            // 
            ptbAvatar.ErrorImage = (Image)resources.GetObject("ptbAvatar.ErrorImage");
            ptbAvatar.Image = (Image)resources.GetObject("ptbAvatar.Image");
            ptbAvatar.Location = new Point(709, 21);
            ptbAvatar.Name = "ptbAvatar";
            ptbAvatar.Size = new Size(150, 150);
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
            btnCV.Location = new Point(29, 368);
            btnCV.Name = "btnCV";
            btnCV.Size = new Size(110, 37);
            btnCV.TabIndex = 10;
            btnCV.Text = "CV";
            btnCV.UseVisualStyleBackColor = false;
            btnCV.Click += btnCV_Click;
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
            btnEdit.Location = new Point(729, 368);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(110, 37);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = false;
            btnEdit.Click += btnEdit_Click;
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblFullName.ForeColor = SystemColors.ControlText;
            lblFullName.Location = new Point(29, 21);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(74, 21);
            lblFullName.TabIndex = 11;
            lblFullName.Text = "Fullname";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddress.ForeColor = SystemColors.ControlText;
            lblAddress.Location = new Point(363, 21);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(66, 21);
            lblAddress.TabIndex = 11;
            lblAddress.Text = "Address";
            // 
            // lblCitizenId
            // 
            lblCitizenId.AutoSize = true;
            lblCitizenId.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblCitizenId.ForeColor = SystemColors.ControlText;
            lblCitizenId.Location = new Point(363, 99);
            lblCitizenId.Name = "lblCitizenId";
            lblCitizenId.Size = new Size(76, 21);
            lblCitizenId.TabIndex = 11;
            lblCitizenId.Text = "Citizen ID";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblPhoneNumber.ForeColor = SystemColors.ControlText;
            lblPhoneNumber.Location = new Point(29, 99);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(116, 21);
            lblPhoneNumber.TabIndex = 11;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEmail.ForeColor = SystemColors.ControlText;
            lblEmail.Location = new Point(29, 179);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(48, 21);
            lblEmail.TabIndex = 11;
            lblEmail.Text = "Email";
            // 
            // lblDoB
            // 
            lblDoB.AutoSize = true;
            lblDoB.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDoB.ForeColor = SystemColors.ControlText;
            lblDoB.Location = new Point(363, 179);
            lblDoB.Name = "lblDoB";
            lblDoB.Size = new Size(97, 21);
            lblDoB.TabIndex = 11;
            lblDoB.Text = "Date of Birth";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ControlText;
            label8.Location = new Point(29, 253);
            label8.Name = "label8";
            label8.Size = new Size(61, 21);
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
            btnCancel.Location = new Point(764, 368);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(110, 37);
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
            btnChoosePicture.Location = new Point(718, 203);
            btnChoosePicture.Name = "btnChoosePicture";
            btnChoosePicture.Size = new Size(130, 37);
            btnChoosePicture.TabIndex = 12;
            btnChoosePicture.Text = "Choose Picture";
            btnChoosePicture.UseVisualStyleBackColor = false;
            btnChoosePicture.Click += btnChoosePicture_Click;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.DimGray;
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnSave.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnSave.FlatStyle = FlatStyle.System;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ControlLightLight;
            btnSave.Location = new Point(648, 368);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 37);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtFullName
            // 
            txtFullName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtFullName.Location = new Point(29, 45);
            txtFullName.Margin = new Padding(3, 2, 3, 2);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(261, 31);
            txtFullName.TabIndex = 14;
            // 
            // txtAddress
            // 
            txtAddress.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtAddress.Location = new Point(363, 45);
            txtAddress.Margin = new Padding(3, 2, 3, 2);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(261, 31);
            txtAddress.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPhoneNumber.Location = new Point(29, 123);
            txtPhoneNumber.Margin = new Padding(3, 2, 3, 2);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(261, 31);
            txtPhoneNumber.TabIndex = 16;
            // 
            // txtCitizenID
            // 
            txtCitizenID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCitizenID.Location = new Point(363, 123);
            txtCitizenID.Margin = new Padding(3, 2, 3, 2);
            txtCitizenID.Name = "txtCitizenID";
            txtCitizenID.Size = new Size(261, 31);
            txtCitizenID.TabIndex = 17;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtEmail.Location = new Point(29, 203);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(261, 31);
            txtEmail.TabIndex = 18;
            // 
            // ptbCV
            // 
            ptbCV.Location = new Point(29, 320);
            ptbCV.Margin = new Padding(3, 2, 3, 2);
            ptbCV.Name = "ptbCV";
            ptbCV.Size = new Size(108, 106);
            ptbCV.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCV.TabIndex = 19;
            ptbCV.TabStop = false;
            // 
            // btnChooseNewCV
            // 
            btnChooseNewCV.BackColor = Color.DimGray;
            btnChooseNewCV.Cursor = Cursors.Hand;
            btnChooseNewCV.FlatAppearance.BorderColor = Color.FromArgb(224, 224, 224);
            btnChooseNewCV.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 64, 64);
            btnChooseNewCV.FlatAppearance.MouseOverBackColor = Color.FromArgb(0, 0, 64);
            btnChooseNewCV.FlatStyle = FlatStyle.System;
            btnChooseNewCV.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnChooseNewCV.ForeColor = SystemColors.ControlLightLight;
            btnChooseNewCV.Location = new Point(154, 368);
            btnChooseNewCV.Name = "btnChooseNewCV";
            btnChooseNewCV.Size = new Size(110, 37);
            btnChooseNewCV.TabIndex = 20;
            btnChooseNewCV.Text = "Choose CV";
            btnChooseNewCV.UseVisualStyleBackColor = false;
            btnChooseNewCV.Click += btnChooseNewCV_Click;
            // 
            // FProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightGray;
            ClientSize = new Size(925, 435);
            Controls.Add(btnChooseNewCV);
            Controls.Add(ptbCV);
            Controls.Add(txtEmail);
            Controls.Add(txtCitizenID);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtFullName);
            Controls.Add(btnSave);
            Controls.Add(btnChoosePicture);
            Controls.Add(label8);
            Controls.Add(lblDoB);
            Controls.Add(lblEmail);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblCitizenId);
            Controls.Add(lblAddress);
            Controls.Add(lblFullName);
            Controls.Add(btnCancel);
            Controls.Add(btnEdit);
            Controls.Add(btnCV);
            Controls.Add(ptbAvatar);
            Controls.Add(rdofemale);
            Controls.Add(rdoMale);
            Controls.Add(dtpkBirthDate);
            Name = "FProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FProfile";
            ((System.ComponentModel.ISupportInitialize)ptbAvatar).EndInit();
            ((System.ComponentModel.ISupportInitialize)ptbCV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DateTimePicker dtpkBirthDate;
        private ReaLTaiizor.Controls.HopeRadioButton rdoMale;
        private ReaLTaiizor.Controls.HopeRadioButton rdofemale;
        private PictureBox ptbAvatar;
        public Button btnCV;
        public Button btnEdit;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblCitizenId;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblDoB;
        private Label label8;
        private Button btnCancel;
        private Button btnChoosePicture;
        private Button btnSave;
        private TextBox txtFullName;
        private TextBox txtAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtCitizenID;
        private TextBox txtEmail;
        private PictureBox ptbCV;
        private Button btnChooseNewCV;
    }
}
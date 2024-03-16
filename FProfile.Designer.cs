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
            this.txtboxFullName = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtboxPhoneNumber = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtboxEmail = new ReaLTaiizor.Controls.HopeTextBox();
            this.txtboxAddress = new ReaLTaiizor.Controls.HopeTextBox();
            this.dtpkBirthDate = new System.Windows.Forms.DateTimePicker();
            this.hopeRadioButton1 = new ReaLTaiizor.Controls.HopeRadioButton();
            this.hopeRadioButton2 = new ReaLTaiizor.Controls.HopeRadioButton();
            this.txtboxCitizenId = new ReaLTaiizor.Controls.HopeTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtboxDetails = new ReaLTaiizor.Controls.HopeRichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxPersonalLink = new ReaLTaiizor.Controls.HopeTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblCitizenId = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPersonalLink = new System.Windows.Forms.Label();
            this.lblDoB = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxFullName
            // 
            this.txtboxFullName.BackColor = System.Drawing.Color.White;
            this.txtboxFullName.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtboxFullName.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxFullName.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxFullName.Hint = "Enter Fullname";
            this.txtboxFullName.Location = new System.Drawing.Point(33, 60);
            this.txtboxFullName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxFullName.MaxLength = 32767;
            this.txtboxFullName.Multiline = false;
            this.txtboxFullName.Name = "txtboxFullName";
            this.txtboxFullName.PasswordChar = '\0';
            this.txtboxFullName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxFullName.SelectedText = "";
            this.txtboxFullName.SelectionLength = 0;
            this.txtboxFullName.SelectionStart = 0;
            this.txtboxFullName.Size = new System.Drawing.Size(298, 43);
            this.txtboxFullName.TabIndex = 3;
            this.txtboxFullName.TabStop = false;
            this.txtboxFullName.UseSystemPasswordChar = false;
            // 
            // txtboxPhoneNumber
            // 
            this.txtboxPhoneNumber.BackColor = System.Drawing.Color.White;
            this.txtboxPhoneNumber.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtboxPhoneNumber.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxPhoneNumber.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxPhoneNumber.Hint = "Enter Phone Number";
            this.txtboxPhoneNumber.Location = new System.Drawing.Point(33, 164);
            this.txtboxPhoneNumber.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxPhoneNumber.MaxLength = 32767;
            this.txtboxPhoneNumber.Multiline = false;
            this.txtboxPhoneNumber.Name = "txtboxPhoneNumber";
            this.txtboxPhoneNumber.PasswordChar = '\0';
            this.txtboxPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPhoneNumber.SelectedText = "";
            this.txtboxPhoneNumber.SelectionLength = 0;
            this.txtboxPhoneNumber.SelectionStart = 0;
            this.txtboxPhoneNumber.Size = new System.Drawing.Size(298, 43);
            this.txtboxPhoneNumber.TabIndex = 4;
            this.txtboxPhoneNumber.TabStop = false;
            this.txtboxPhoneNumber.UseSystemPasswordChar = false;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.BackColor = System.Drawing.Color.White;
            this.txtboxEmail.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtboxEmail.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxEmail.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxEmail.Hint = "Enter Email";
            this.txtboxEmail.Location = new System.Drawing.Point(33, 271);
            this.txtboxEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxEmail.MaxLength = 32767;
            this.txtboxEmail.Multiline = false;
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.PasswordChar = '\0';
            this.txtboxEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxEmail.SelectedText = "";
            this.txtboxEmail.SelectionLength = 0;
            this.txtboxEmail.SelectionStart = 0;
            this.txtboxEmail.Size = new System.Drawing.Size(298, 43);
            this.txtboxEmail.TabIndex = 5;
            this.txtboxEmail.TabStop = false;
            this.txtboxEmail.UseSystemPasswordChar = false;
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.BackColor = System.Drawing.Color.White;
            this.txtboxAddress.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtboxAddress.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxAddress.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxAddress.Hint = "Enter Address";
            this.txtboxAddress.Location = new System.Drawing.Point(415, 60);
            this.txtboxAddress.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxAddress.MaxLength = 32767;
            this.txtboxAddress.Multiline = false;
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.PasswordChar = '\0';
            this.txtboxAddress.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxAddress.SelectedText = "";
            this.txtboxAddress.SelectionLength = 0;
            this.txtboxAddress.SelectionStart = 0;
            this.txtboxAddress.Size = new System.Drawing.Size(298, 43);
            this.txtboxAddress.TabIndex = 5;
            this.txtboxAddress.TabStop = false;
            this.txtboxAddress.UseSystemPasswordChar = false;
            // 
            // dtpkBirthDate
            // 
            this.dtpkBirthDate.Location = new System.Drawing.Point(415, 371);
            this.dtpkBirthDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpkBirthDate.Name = "dtpkBirthDate";
            this.dtpkBirthDate.Size = new System.Drawing.Size(226, 27);
            this.dtpkBirthDate.TabIndex = 6;
            // 
            // hopeRadioButton1
            // 
            this.hopeRadioButton1.AutoSize = true;
            this.hopeRadioButton1.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRadioButton1.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeRadioButton1.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeRadioButton1.Enable = true;
            this.hopeRadioButton1.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRadioButton1.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.hopeRadioButton1.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeRadioButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeRadioButton1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.hopeRadioButton1.Location = new System.Drawing.Point(33, 375);
            this.hopeRadioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopeRadioButton1.Name = "hopeRadioButton1";
            this.hopeRadioButton1.Size = new System.Drawing.Size(80, 20);
            this.hopeRadioButton1.TabIndex = 7;
            this.hopeRadioButton1.TabStop = true;
            this.hopeRadioButton1.Text = "Male";
            this.hopeRadioButton1.UseVisualStyleBackColor = true;
            // 
            // hopeRadioButton2
            // 
            this.hopeRadioButton2.AutoSize = true;
            this.hopeRadioButton2.CheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRadioButton2.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(196)))), ((int)(((byte)(198)))), ((int)(((byte)(202)))));
            this.hopeRadioButton2.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.hopeRadioButton2.Enable = true;
            this.hopeRadioButton2.EnabledCheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeRadioButton2.EnabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(146)))), ((int)(((byte)(146)))));
            this.hopeRadioButton2.EnabledUncheckedColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(158)))), ((int)(((byte)(161)))));
            this.hopeRadioButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeRadioButton2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.hopeRadioButton2.Location = new System.Drawing.Point(176, 375);
            this.hopeRadioButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopeRadioButton2.Name = "hopeRadioButton2";
            this.hopeRadioButton2.Size = new System.Drawing.Size(99, 20);
            this.hopeRadioButton2.TabIndex = 7;
            this.hopeRadioButton2.TabStop = true;
            this.hopeRadioButton2.Text = "Female";
            this.hopeRadioButton2.UseVisualStyleBackColor = true;
            // 
            // txtboxCitizenId
            // 
            this.txtboxCitizenId.BackColor = System.Drawing.Color.White;
            this.txtboxCitizenId.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtboxCitizenId.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxCitizenId.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxCitizenId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxCitizenId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxCitizenId.Hint = "Enter Citizen identification";
            this.txtboxCitizenId.Location = new System.Drawing.Point(415, 164);
            this.txtboxCitizenId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxCitizenId.MaxLength = 32767;
            this.txtboxCitizenId.Multiline = false;
            this.txtboxCitizenId.Name = "txtboxCitizenId";
            this.txtboxCitizenId.PasswordChar = '\0';
            this.txtboxCitizenId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxCitizenId.SelectedText = "";
            this.txtboxCitizenId.SelectionLength = 0;
            this.txtboxCitizenId.SelectionStart = 0;
            this.txtboxCitizenId.Size = new System.Drawing.Size(298, 43);
            this.txtboxCitizenId.TabIndex = 5;
            this.txtboxCitizenId.TabStop = false;
            this.txtboxCitizenId.UseSystemPasswordChar = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(832, 28);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // txtboxDetails
            // 
            this.txtboxDetails.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxDetails.Hint = "Details";
            this.txtboxDetails.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxDetails.Location = new System.Drawing.Point(801, 252);
            this.txtboxDetails.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxDetails.MaxLength = 32767;
            this.txtboxDetails.Multiline = true;
            this.txtboxDetails.Name = "txtboxDetails";
            this.txtboxDetails.PasswordChar = '\0';
            this.txtboxDetails.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxDetails.SelectedText = "";
            this.txtboxDetails.SelectionLength = 0;
            this.txtboxDetails.SelectionStart = 0;
            this.txtboxDetails.Size = new System.Drawing.Size(229, 149);
            this.txtboxDetails.TabIndex = 9;
            this.txtboxDetails.TabStop = false;
            this.txtboxDetails.Text = "Details";
            this.txtboxDetails.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DimGray;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(101, 491);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 49);
            this.button1.TabIndex = 10;
            this.button1.Text = "CV";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // txtboxPersonalLink
            // 
            this.txtboxPersonalLink.BackColor = System.Drawing.Color.White;
            this.txtboxPersonalLink.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtboxPersonalLink.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtboxPersonalLink.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtboxPersonalLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtboxPersonalLink.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtboxPersonalLink.Hint = "Enter Personal link";
            this.txtboxPersonalLink.Location = new System.Drawing.Point(415, 271);
            this.txtboxPersonalLink.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtboxPersonalLink.MaxLength = 32767;
            this.txtboxPersonalLink.Multiline = false;
            this.txtboxPersonalLink.Name = "txtboxPersonalLink";
            this.txtboxPersonalLink.PasswordChar = '\0';
            this.txtboxPersonalLink.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtboxPersonalLink.SelectedText = "";
            this.txtboxPersonalLink.SelectionLength = 0;
            this.txtboxPersonalLink.SelectionStart = 0;
            this.txtboxPersonalLink.Size = new System.Drawing.Size(298, 43);
            this.txtboxPersonalLink.TabIndex = 5;
            this.txtboxPersonalLink.TabStop = false;
            this.txtboxPersonalLink.UseSystemPasswordChar = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(246, 491);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(126, 49);
            this.button2.TabIndex = 10;
            this.button2.Text = "Project";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(389, 491);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(126, 49);
            this.button3.TabIndex = 10;
            this.button3.Text = "Certificate";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(533, 491);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 49);
            this.button4.TabIndex = 10;
            this.button4.Text = "Reward";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(677, 491);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 49);
            this.button5.TabIndex = 10;
            this.button5.Text = "Edit";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblFullName.Location = new System.Drawing.Point(33, 28);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(91, 28);
            this.lblFullName.TabIndex = 11;
            this.lblFullName.Text = "Fullname";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddress.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddress.Location = new System.Drawing.Point(415, 28);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(82, 28);
            this.lblAddress.TabIndex = 11;
            this.lblAddress.Text = "Address";
            // 
            // lblCitizenId
            // 
            this.lblCitizenId.AutoSize = true;
            this.lblCitizenId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCitizenId.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCitizenId.Location = new System.Drawing.Point(415, 132);
            this.lblCitizenId.Name = "lblCitizenId";
            this.lblCitizenId.Size = new System.Drawing.Size(95, 28);
            this.lblCitizenId.TabIndex = 11;
            this.lblCitizenId.Text = "Citizen ID";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhoneNumber.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPhoneNumber.Location = new System.Drawing.Point(33, 132);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(144, 28);
            this.lblPhoneNumber.TabIndex = 11;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblEmail.Location = new System.Drawing.Point(33, 239);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(59, 28);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "Email";
            // 
            // lblPersonalLink
            // 
            this.lblPersonalLink.AutoSize = true;
            this.lblPersonalLink.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPersonalLink.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPersonalLink.Location = new System.Drawing.Point(415, 239);
            this.lblPersonalLink.Name = "lblPersonalLink";
            this.lblPersonalLink.Size = new System.Drawing.Size(125, 28);
            this.lblPersonalLink.TabIndex = 11;
            this.lblPersonalLink.Text = "Personal Link";
            // 
            // lblDoB
            // 
            this.lblDoB.AutoSize = true;
            this.lblDoB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDoB.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDoB.Location = new System.Drawing.Point(415, 337);
            this.lblDoB.Name = "lblDoB";
            this.lblDoB.Size = new System.Drawing.Size(122, 28);
            this.lblDoB.TabIndex = 11;
            this.lblDoB.Text = "Date of Birth";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(33, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Gender";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.LightCoral;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button6.ForeColor = System.Drawing.SystemColors.Control;
            this.button6.Location = new System.Drawing.Point(821, 491);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(126, 49);
            this.button6.TabIndex = 10;
            this.button6.Text = "Cancel";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // FProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1057, 580);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblDoB);
            this.Controls.Add(this.lblPersonalLink);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblCitizenId);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtboxDetails);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.hopeRadioButton2);
            this.Controls.Add(this.hopeRadioButton1);
            this.Controls.Add(this.dtpkBirthDate);
            this.Controls.Add(this.txtboxPersonalLink);
            this.Controls.Add(this.txtboxCitizenId);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxPhoneNumber);
            this.Controls.Add(this.txtboxFullName);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FProfile";
            this.Text = "FProfile";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.HopeRichTextBox txtboxDetails;
        private Button button1;
        private ReaLTaiizor.Controls.HopeTextBox txtboxPersonalLink;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lblFullName;
        private Label lblAddress;
        private Label lblCitizenId;
        private Label lblPhoneNumber;
        private Label lblEmail;
        private Label lblPersonalLink;
        private Label lblDoB;
        private Label label8;
        private Button button6;
    }
}
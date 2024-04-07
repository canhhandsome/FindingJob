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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblDateT = new Label();
            lblNameT = new Label();
            lblFromT = new Label();
            flpBody = new FlowLayoutPanel();
            panel2 = new Panel();
            pnPublish = new FlowLayoutPanel();
            pnName = new Panel();
            pnCompany = new FlowLayoutPanel();
            ptbCompanyPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            pnWorkingForm = new FlowLayoutPanel();
            lblWorkingFormT = new Label();
            flpSkills = new FlowLayoutPanel();
            pnAddress = new FlowLayoutPanel();
            lblAddressT = new Label();
            btnDetails = new ReaLTaiizor.Controls.ParrotButton();
            flpBody.SuspendLayout();
            pnPublish.SuspendLayout();
            pnName.SuspendLayout();
            pnCompany.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).BeginInit();
            pnWorkingForm.SuspendLayout();
            pnAddress.SuspendLayout();
            SuspendLayout();
            // 
            // lblDateT
            // 
            lblDateT.AutoSize = true;
            lblDateT.Dock = DockStyle.Right;
            lblDateT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = Color.FromArgb(65, 64, 66);
            lblDateT.Location = new Point(3, 14);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(58, 25);
            lblDateT.TabIndex = 0;
            lblDateT.Text = "Date: ";
            lblDateT.TextAlign = ContentAlignment.BottomCenter;
            // 
            // lblNameT
            // 
            lblNameT.AutoSize = true;
            lblNameT.Dock = DockStyle.Fill;
            lblNameT.Font = new Font("Segoe UI Semibold", 25F, FontStyle.Bold, GraphicsUnit.Point);
            lblNameT.Location = new Point(0, 0);
            lblNameT.Name = "lblNameT";
            lblNameT.Size = new Size(129, 46);
            lblNameT.TabIndex = 0;
            lblNameT.Text = "Name: ";
            // 
            // lblFromT
            // 
            lblFromT.AutoSize = true;
            lblFromT.Dock = DockStyle.Fill;
            lblFromT.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFromT.ForeColor = Color.FromArgb(65, 64, 66);
            lblFromT.Location = new Point(69, 0);
            lblFromT.Name = "lblFromT";
            lblFromT.Size = new Size(76, 44);
            lblFromT.TabIndex = 0;
            lblFromT.Text = "From:";
            lblFromT.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flpBody
            // 
            flpBody.BackColor = Color.FromArgb(254, 232, 223);
            flpBody.Controls.Add(panel2);
            flpBody.Controls.Add(pnPublish);
            flpBody.Controls.Add(pnName);
            flpBody.Controls.Add(pnCompany);
            flpBody.Controls.Add(pnWorkingForm);
            flpBody.Controls.Add(flpSkills);
            flpBody.FlowDirection = FlowDirection.TopDown;
            flpBody.Location = new Point(6, 6);
            flpBody.Name = "flpBody";
            flpBody.Size = new Size(483, 250);
            flpBody.TabIndex = 47;
            // 
            // panel2
            // 
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(18, 341);
            panel2.TabIndex = 48;
            // 
            // pnPublish
            // 
            pnPublish.AutoScroll = true;
            pnPublish.BackColor = Color.Transparent;
            pnPublish.Controls.Add(lblDateT);
            pnPublish.FlowDirection = FlowDirection.BottomUp;
            pnPublish.Location = new Point(27, 3);
            pnPublish.Name = "pnPublish";
            pnPublish.Size = new Size(875, 39);
            pnPublish.TabIndex = 49;
            // 
            // pnName
            // 
            pnName.AutoScroll = true;
            pnName.BackColor = Color.Transparent;
            pnName.Controls.Add(lblNameT);
            pnName.Location = new Point(27, 48);
            pnName.Name = "pnName";
            pnName.Size = new Size(475, 50);
            pnName.TabIndex = 48;
            // 
            // pnCompany
            // 
            pnCompany.AutoScroll = true;
            pnCompany.BackColor = Color.Transparent;
            pnCompany.Controls.Add(ptbCompanyPicture);
            pnCompany.Controls.Add(lblFromT);
            pnCompany.Location = new Point(27, 104);
            pnCompany.Name = "pnCompany";
            pnCompany.Size = new Size(457, 47);
            pnCompany.TabIndex = 48;
            // 
            // ptbCompanyPicture
            // 
            ptbCompanyPicture.CustomizableEdges = customizableEdges1;
            ptbCompanyPicture.ImageRotate = 0F;
            ptbCompanyPicture.Location = new Point(3, 2);
            ptbCompanyPicture.Margin = new Padding(3, 2, 3, 2);
            ptbCompanyPicture.Name = "ptbCompanyPicture";
            ptbCompanyPicture.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ptbCompanyPicture.Size = new Size(60, 40);
            ptbCompanyPicture.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCompanyPicture.TabIndex = 2;
            ptbCompanyPicture.TabStop = false;
            // 
            // pnWorkingForm
            // 
            pnWorkingForm.BackColor = Color.Transparent;
            pnWorkingForm.Controls.Add(lblWorkingFormT);
            pnWorkingForm.Location = new Point(27, 157);
            pnWorkingForm.Name = "pnWorkingForm";
            pnWorkingForm.Size = new Size(457, 39);
            pnWorkingForm.TabIndex = 48;
            // 
            // lblWorkingFormT
            // 
            lblWorkingFormT.AutoSize = true;
            lblWorkingFormT.Dock = DockStyle.Fill;
            lblWorkingFormT.Font = new Font("Segoe UI Semibold", 13.2000008F, FontStyle.Bold, GraphicsUnit.Point);
            lblWorkingFormT.ForeColor = Color.FromArgb(65, 64, 66);
            lblWorkingFormT.Location = new Point(3, 0);
            lblWorkingFormT.Name = "lblWorkingFormT";
            lblWorkingFormT.Size = new Size(157, 25);
            lblWorkingFormT.TabIndex = 0;
            lblWorkingFormT.Text = "lblWorkingFormT";
            // 
            // flpSkills
            // 
            flpSkills.BackColor = Color.Transparent;
            flpSkills.Location = new Point(27, 202);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(457, 39);
            flpSkills.TabIndex = 50;
            // 
            // pnAddress
            // 
            pnAddress.BackColor = Color.Transparent;
            pnAddress.Controls.Add(lblAddressT);
            pnAddress.Location = new Point(11, 262);
            pnAddress.Name = "pnAddress";
            pnAddress.Size = new Size(381, 36);
            pnAddress.TabIndex = 48;
            // 
            // lblAddressT
            // 
            lblAddressT.AutoSize = true;
            lblAddressT.Dock = DockStyle.Fill;
            lblAddressT.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddressT.ForeColor = SystemColors.ControlDarkDark;
            lblAddressT.Location = new Point(3, 0);
            lblAddressT.Name = "lblAddressT";
            lblAddressT.Size = new Size(96, 25);
            lblAddressT.TabIndex = 0;
            lblAddressT.Text = "lblAddress";
            // 
            // btnDetails
            // 
            btnDetails.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnDetails.ButtonImage = null;
            btnDetails.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnDetails.ButtonText = "Details";
            btnDetails.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnDetails.ClickTextColor = Color.Black;
            btnDetails.CornerRadius = 20;
            btnDetails.Cursor = Cursors.Hand;
            btnDetails.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDetails.Horizontal_Alignment = StringAlignment.Center;
            btnDetails.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnDetails.HoverTextColor = Color.Black;
            btnDetails.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnDetails.Location = new Point(398, 262);
            btnDetails.Name = "btnDetails";
            btnDetails.Size = new Size(88, 38);
            btnDetails.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnDetails.TabIndex = 49;
            btnDetails.TextColor = Color.Black;
            btnDetails.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnDetails.Vertical_Alignment = StringAlignment.Center;
            btnDetails.Click += panel1_Click;
            // 
            // UCInformation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            Controls.Add(btnDetails);
            Controls.Add(flpBody);
            Controls.Add(pnAddress);
            Margin = new Padding(3, 2, 10, 10);
            Name = "UCInformation";
            Size = new Size(1092, 554);
            flpBody.ResumeLayout(false);
            pnPublish.ResumeLayout(false);
            pnPublish.PerformLayout();
            pnName.ResumeLayout(false);
            pnName.PerformLayout();
            pnCompany.ResumeLayout(false);
            pnCompany.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ptbCompanyPicture).EndInit();
            pnWorkingForm.ResumeLayout(false);
            pnWorkingForm.PerformLayout();
            pnAddress.ResumeLayout(false);
            pnAddress.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Label lblDateT;
        public Label lblFromT;
        public Label lblNameT;
        public FlowLayoutPanel flpBody;
        private FlowLayoutPanel pnPublish;
        private Panel pnName;
        private FlowLayoutPanel pnCompany;
        private FlowLayoutPanel pnWorkingForm;
        private Panel panel2;
        public Label lblWorkingFormT;
        private FlowLayoutPanel pnAddress;
        public Label lblAddressT;
        private ReaLTaiizor.Controls.ParrotButton btnDetails;
        private Guna.UI2.WinForms.Guna2PictureBox ptbCompanyPicture;
        private FlowLayoutPanel flpSkills;
    }
}

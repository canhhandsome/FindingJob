namespace WinFormProject.WinFormCode
{
    partial class UCHistory
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            panel2 = new Panel();
            lblDateT = new Label();
            panel1 = new Panel();
            lblEndT = new Label();
            lblCountApplicants = new Label();
            flpSkills = new FlowLayoutPanel();
            btnApplicants = new Guna.UI2.WinForms.Guna2Button();
            lblStatusT = new Label();
            lblStatus = new Label();
            lblJobNameT = new Label();
            guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(components);
            guna2ShadowPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // guna2ShadowPanel1
            // 
            guna2ShadowPanel1.BackColor = Color.Transparent;
            guna2ShadowPanel1.Controls.Add(panel2);
            guna2ShadowPanel1.Controls.Add(panel1);
            guna2ShadowPanel1.Controls.Add(lblCountApplicants);
            guna2ShadowPanel1.Controls.Add(flpSkills);
            guna2ShadowPanel1.Controls.Add(btnApplicants);
            guna2ShadowPanel1.Controls.Add(lblStatusT);
            guna2ShadowPanel1.Controls.Add(lblStatus);
            guna2ShadowPanel1.Controls.Add(lblJobNameT);
            guna2ShadowPanel1.Dock = DockStyle.Fill;
            guna2ShadowPanel1.FillColor = Color.MistyRose;
            guna2ShadowPanel1.Location = new Point(0, 0);
            guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            guna2ShadowPanel1.Radius = 10;
            guna2ShadowPanel1.ShadowColor = Color.Black;
            guna2ShadowPanel1.Size = new Size(508, 184);
            guna2ShadowPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lblDateT);
            panel2.Location = new Point(352, 11);
            panel2.Name = "panel2";
            panel2.Size = new Size(145, 25);
            panel2.TabIndex = 24;
            // 
            // lblDateT
            // 
            lblDateT.Dock = DockStyle.Fill;
            lblDateT.FlatStyle = FlatStyle.Flat;
            lblDateT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblDateT.ForeColor = Color.FromArgb(64, 64, 64);
            lblDateT.Location = new Point(0, 0);
            lblDateT.Name = "lblDateT";
            lblDateT.Size = new Size(145, 25);
            lblDateT.TabIndex = 18;
            lblDateT.Text = "Date:";
            lblDateT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            panel1.Controls.Add(lblEndT);
            panel1.Location = new Point(352, 42);
            panel1.Name = "panel1";
            panel1.Size = new Size(145, 25);
            panel1.TabIndex = 24;
            // 
            // lblEndT
            // 
            lblEndT.Dock = DockStyle.Fill;
            lblEndT.FlatStyle = FlatStyle.Flat;
            lblEndT.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblEndT.ForeColor = Color.FromArgb(64, 64, 64);
            lblEndT.Location = new Point(0, 0);
            lblEndT.Name = "lblEndT";
            lblEndT.Size = new Size(145, 25);
            lblEndT.TabIndex = 17;
            lblEndT.Text = "Date End:";
            lblEndT.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblCountApplicants
            // 
            lblCountApplicants.AutoSize = true;
            lblCountApplicants.BackColor = Color.IndianRed;
            lblCountApplicants.Location = new Point(462, 130);
            lblCountApplicants.Name = "lblCountApplicants";
            lblCountApplicants.Size = new Size(13, 15);
            lblCountApplicants.TabIndex = 22;
            lblCountApplicants.Text = "0";
            // 
            // flpSkills
            // 
            flpSkills.Location = new Point(12, 86);
            flpSkills.Margin = new Padding(3, 2, 3, 2);
            flpSkills.Name = "flpSkills";
            flpSkills.Size = new Size(485, 45);
            flpSkills.TabIndex = 23;
            // 
            // btnApplicants
            // 
            btnApplicants.BorderRadius = 10;
            btnApplicants.CustomizableEdges = customizableEdges1;
            btnApplicants.DisabledState.BorderColor = Color.DarkGray;
            btnApplicants.DisabledState.CustomBorderColor = Color.DarkGray;
            btnApplicants.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnApplicants.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnApplicants.Font = new Font("Verdana", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnApplicants.ForeColor = Color.White;
            btnApplicants.Location = new Point(369, 135);
            btnApplicants.Name = "btnApplicants";
            btnApplicants.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnApplicants.Size = new Size(102, 37);
            btnApplicants.TabIndex = 13;
            btnApplicants.Text = "Applicants";
            btnApplicants.Click += btnApplicants_Click;
            // 
            // lblStatusT
            // 
            lblStatusT.AutoSize = true;
            lblStatusT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatusT.Location = new Point(90, 49);
            lblStatusT.Name = "lblStatusT";
            lblStatusT.Size = new Size(66, 25);
            lblStatusT.TabIndex = 16;
            lblStatusT.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblStatus.Location = new Point(12, 49);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(66, 25);
            lblStatus.TabIndex = 14;
            lblStatus.Text = "Status:";
            // 
            // lblJobNameT
            // 
            lblJobNameT.AutoSize = true;
            lblJobNameT.Font = new Font("Segoe UI Semibold", 19.8F, FontStyle.Bold, GraphicsUnit.Point);
            lblJobNameT.Location = new Point(12, 11);
            lblJobNameT.Name = "lblJobNameT";
            lblJobNameT.Size = new Size(147, 37);
            lblJobNameT.TabIndex = 15;
            lblJobNameT.Text = "Job Name:";
            // 
            // guna2Elipse1
            // 
            guna2Elipse1.TargetControl = lblCountApplicants;
            // 
            // UCHistory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(guna2ShadowPanel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCHistory";
            Size = new Size(508, 184);
            guna2ShadowPanel1.ResumeLayout(false);
            guna2ShadowPanel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private Panel panel2;
        public Label lblDateT;
        private Panel panel1;
        public Label lblEndT;
        private Label lblCountApplicants;
        private FlowLayoutPanel flpSkills;
        private Guna.UI2.WinForms.Guna2Button btnApplicants;
        public Label lblStatusT;
        private Label lblStatus;
        public Label lblJobNameT;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}

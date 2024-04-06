namespace WinFormProject.WinFormCode
{
    partial class FHistory
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FHistory));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            lblListJobs = new Label();
            pnSubBody = new FlowLayoutPanel();
            dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            SuspendLayout();
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.White;
            lblListJobs.Font = new Font("Times New Roman", 22.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(40, 39);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(135, 42);
            lblListJobs.TabIndex = 6;
            lblListJobs.Text = "History";
            // 
            // pnSubBody
            // 
            pnSubBody.Location = new Point(48, 149);
            pnSubBody.Margin = new Padding(3, 4, 3, 4);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(949, 296);
            pnSubBody.TabIndex = 7;
            // 
            // dungeonComboBox1
            // 
            dungeonComboBox1.BackColor = Color.FromArgb(246, 246, 246);
            dungeonComboBox1.ColorA = Color.FromArgb(246, 132, 85);
            dungeonComboBox1.ColorB = Color.FromArgb(231, 108, 57);
            dungeonComboBox1.ColorC = Color.FromArgb(242, 241, 240);
            dungeonComboBox1.ColorD = Color.FromArgb(253, 252, 252);
            dungeonComboBox1.ColorE = Color.FromArgb(239, 237, 236);
            dungeonComboBox1.ColorF = Color.FromArgb(180, 180, 180);
            dungeonComboBox1.ColorG = Color.FromArgb(119, 119, 118);
            dungeonComboBox1.ColorH = Color.FromArgb(224, 222, 220);
            dungeonComboBox1.ColorI = Color.FromArgb(250, 249, 249);
            dungeonComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            dungeonComboBox1.DropDownHeight = 250;
            dungeonComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dungeonComboBox1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            dungeonComboBox1.ForeColor = Color.FromArgb(76, 76, 97);
            dungeonComboBox1.FormattingEnabled = true;
            dungeonComboBox1.HoverSelectionColor = Color.Empty;
            dungeonComboBox1.IntegralHeight = false;
            dungeonComboBox1.ItemHeight = 30;
            dungeonComboBox1.Items.AddRange(new object[] { "All", "Waiting", "Done" });
            dungeonComboBox1.Location = new Point(875, 35);
            dungeonComboBox1.Margin = new Padding(3, 4, 3, 4);
            dungeonComboBox1.Name = "dungeonComboBox1";
            dungeonComboBox1.Size = new Size(147, 36);
            dungeonComboBox1.StartIndex = 0;
            dungeonComboBox1.TabIndex = 2;
            // 
            // btnFilter
            // 
            btnFilter.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnFilter.ButtonImage = null;
            btnFilter.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnFilter.ButtonText = "Filter";
            btnFilter.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnFilter.ClickTextColor = Color.Black;
            btnFilter.CornerRadius = 6;
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnFilter.Horizontal_Alignment = StringAlignment.Center;
            btnFilter.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnFilter.HoverTextColor = Color.Black;
            btnFilter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnFilter.Location = new Point(923, 93);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(74, 48);
            btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFilter.TabIndex = 38;
            btnFilter.TextColor = Color.Black;
            btnFilter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFilter.Vertical_Alignment = StringAlignment.Center;
            // 
            // txtSearch
            // 
            txtSearch.AutoRoundedCorners = true;
            txtSearch.BorderRadius = 23;
            txtSearch.CustomizableEdges = customizableEdges1;
            txtSearch.DefaultText = "";
            txtSearch.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtSearch.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtSearch.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtSearch.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            txtSearch.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtSearch.IconLeft = (Image)resources.GetObject("txtSearch.IconLeft");
            txtSearch.Location = new Point(48, 85);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(837, 48);
            txtSearch.TabIndex = 39;
            // 
            // FHistory
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1048, 600);
            Controls.Add(txtSearch);
            Controls.Add(btnFilter);
            Controls.Add(dungeonComboBox1);
            Controls.Add(pnSubBody);
            Controls.Add(lblListJobs);
            Name = "FHistory";
            Text = "FHistory";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
    }
}
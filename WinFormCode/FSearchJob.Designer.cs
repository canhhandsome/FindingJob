namespace WinFormProject
{
    partial class FSearchJob
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSearchJob));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            flpJob = new FlowLayoutPanel();
            btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            SuspendLayout();
            // 
            // flpJob
            // 
            flpJob.Location = new Point(35, 137);
            flpJob.Margin = new Padding(3, 4, 3, 4);
            flpJob.Name = "flpJob";
            flpJob.Size = new Size(1184, 1);
            flpJob.TabIndex = 4;
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
            btnFilter.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.Horizontal_Alignment = StringAlignment.Center;
            btnFilter.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnFilter.HoverTextColor = Color.Black;
            btnFilter.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnFilter.Location = new Point(1075, 23);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(145, 48);
            btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFilter.TabIndex = 36;
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
            txtSearch.Location = new Point(242, 23);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PlaceholderText = "Search for jobs";
            txtSearch.SelectedText = "";
            txtSearch.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtSearch.Size = new Size(813, 48);
            txtSearch.TabIndex = 37;
            // 
            // guna2ComboBox1
            // 
            guna2ComboBox1.AutoRoundedCorners = true;
            guna2ComboBox1.BackColor = Color.Transparent;
            guna2ComboBox1.BorderRadius = 17;
            guna2ComboBox1.CustomizableEdges = customizableEdges3;
            guna2ComboBox1.DrawMode = DrawMode.OwnerDrawFixed;
            guna2ComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            guna2ComboBox1.FocusedColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            guna2ComboBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            guna2ComboBox1.ForeColor = Color.FromArgb(68, 88, 112);
            guna2ComboBox1.ItemHeight = 30;
            guna2ComboBox1.Location = new Point(35, 35);
            guna2ComboBox1.Name = "guna2ComboBox1";
            guna2ComboBox1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2ComboBox1.Size = new Size(185, 36);
            guna2ComboBox1.TabIndex = 38;
            // 
            // FSearchJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1233, 847);
            Controls.Add(guna2ComboBox1);
            Controls.Add(txtSearch);
            Controls.Add(btnFilter);
            Controls.Add(flpJob);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FSearchJob";
            Text = "FSearchJob";
            ResumeLayout(false);
        }

        #endregion
        private FlowLayoutPanel flpJob;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}
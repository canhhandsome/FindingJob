﻿namespace WinFormProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FSearchJob));
            dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            flpJob = new FlowLayoutPanel();
            txtSearch = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnFilter = new ReaLTaiizor.Controls.ParrotButton();
            SuspendLayout();
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
            dungeonComboBox1.DropDownHeight = 100;
            dungeonComboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            dungeonComboBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dungeonComboBox1.ForeColor = Color.FromArgb(76, 76, 97);
            dungeonComboBox1.FormattingEnabled = true;
            dungeonComboBox1.HoverSelectionColor = Color.Empty;
            dungeonComboBox1.IntegralHeight = false;
            dungeonComboBox1.ItemHeight = 20;
            dungeonComboBox1.Location = new Point(35, 39);
            dungeonComboBox1.Margin = new Padding(3, 4, 3, 4);
            dungeonComboBox1.Name = "dungeonComboBox1";
            dungeonComboBox1.Size = new Size(147, 26);
            dungeonComboBox1.StartIndex = 0;
            dungeonComboBox1.TabIndex = 1;
            // 
            // flpJob
            // 
            flpJob.Location = new Point(35, 137);
            flpJob.Margin = new Padding(3, 4, 3, 4);
            flpJob.Name = "flpJob";
            flpJob.Size = new Size(967, 188);
            flpJob.TabIndex = 4;
            // 
            // txtSearch
            // 
            txtSearch.AnimateReadOnly = false;
            txtSearch.AutoCompleteMode = AutoCompleteMode.None;
            txtSearch.AutoCompleteSource = AutoCompleteSource.None;
            txtSearch.BackgroundImageLayout = ImageLayout.None;
            txtSearch.CharacterCasing = CharacterCasing.Normal;
            txtSearch.Depth = 0;
            txtSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtSearch.HideSelection = true;
            txtSearch.Hint = "Search Job";
            txtSearch.LeadingIcon = (Image)resources.GetObject("txtSearch.LeadingIcon");
            txtSearch.Location = new Point(208, 24);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.MaxLength = 32767;
            txtSearch.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtSearch.Name = "txtSearch";
            txtSearch.PasswordChar = '\0';
            txtSearch.PrefixSuffixText = null;
            txtSearch.ReadOnly = false;
            txtSearch.RightToLeft = RightToLeft.No;
            txtSearch.SelectedText = "";
            txtSearch.SelectionLength = 0;
            txtSearch.SelectionStart = 0;
            txtSearch.ShortcutsEnabled = true;
            txtSearch.Size = new Size(707, 48);
            txtSearch.TabIndex = 4;
            txtSearch.TabStop = false;
            txtSearch.TextAlign = HorizontalAlignment.Left;
            txtSearch.TrailingIcon = null;
            txtSearch.UseSystemPasswordChar = false;
            txtSearch.KeyDown += txtSearch_KeyDown;
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
            btnFilter.Location = new Point(921, 24);
            btnFilter.Margin = new Padding(3, 4, 3, 4);
            btnFilter.Name = "btnFilter";
            btnFilter.Size = new Size(80, 51);
            btnFilter.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFilter.TabIndex = 36;
            btnFilter.TextColor = Color.Black;
            btnFilter.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFilter.Vertical_Alignment = StringAlignment.Center;
            btnFilter.Click += btnFilter_Click;
            // 
            // FSearchJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.White;
            ClientSize = new Size(1048, 580);
            Controls.Add(btnFilter);
            Controls.Add(txtSearch);
            Controls.Add(flpJob);
            Controls.Add(dungeonComboBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FSearchJob";
            Text = "FSearchJob";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private FlowLayoutPanel flpJob;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtSearch;
        private ReaLTaiizor.Controls.ParrotButton btnFilter;
    }
}
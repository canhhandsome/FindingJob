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
            this.dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            this.txtJob = new ReaLTaiizor.Controls.HopeTextBox();
            this.flpJob = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilter = new ReaLTaiizor.Controls.CyberButton();
            this.SuspendLayout();
            // 
            // dungeonComboBox1
            // 
            this.dungeonComboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(246)))), ((int)(((byte)(246)))));
            this.dungeonComboBox1.ColorA = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(132)))), ((int)(((byte)(85)))));
            this.dungeonComboBox1.ColorB = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(108)))), ((int)(((byte)(57)))));
            this.dungeonComboBox1.ColorC = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(241)))), ((int)(((byte)(240)))));
            this.dungeonComboBox1.ColorD = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dungeonComboBox1.ColorE = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(237)))), ((int)(((byte)(236)))));
            this.dungeonComboBox1.ColorF = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.dungeonComboBox1.ColorG = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(119)))), ((int)(((byte)(118)))));
            this.dungeonComboBox1.ColorH = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(222)))), ((int)(((byte)(220)))));
            this.dungeonComboBox1.ColorI = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.dungeonComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dungeonComboBox1.DropDownHeight = 100;
            this.dungeonComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dungeonComboBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(97)))));
            this.dungeonComboBox1.FormattingEnabled = true;
            this.dungeonComboBox1.HoverSelectionColor = System.Drawing.Color.Empty;
            this.dungeonComboBox1.IntegralHeight = false;
            this.dungeonComboBox1.ItemHeight = 20;
            this.dungeonComboBox1.Location = new System.Drawing.Point(85, 45);
            this.dungeonComboBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dungeonComboBox1.Name = "dungeonComboBox1";
            this.dungeonComboBox1.Size = new System.Drawing.Size(186, 26);
            this.dungeonComboBox1.StartIndex = 0;
            this.dungeonComboBox1.TabIndex = 1;
            // 
            // txtJob
            // 
            this.txtJob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.txtJob.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.txtJob.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.txtJob.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.txtJob.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtJob.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.txtJob.Hint = "Enter Jobs";
            this.txtJob.Location = new System.Drawing.Point(296, 36);
            this.txtJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJob.MaxLength = 32767;
            this.txtJob.Multiline = false;
            this.txtJob.Name = "txtJob";
            this.txtJob.PasswordChar = '\0';
            this.txtJob.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtJob.SelectedText = "";
            this.txtJob.SelectionLength = 0;
            this.txtJob.SelectionStart = 0;
            this.txtJob.Size = new System.Drawing.Size(641, 43);
            this.txtJob.TabIndex = 2;
            this.txtJob.TabStop = false;
            this.txtJob.UseSystemPasswordChar = false;
            this.txtJob.Enter += new System.EventHandler(this.hopeTextBox1_Enter);
            // 
            // flpJob
            // 
            this.flpJob.Location = new System.Drawing.Point(55, 136);
            this.flpJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpJob.Name = "flpJob";
            this.flpJob.Size = new System.Drawing.Size(967, 188);
            this.flpJob.TabIndex = 4;
            // 
            // btnFilter
            // 
            this.btnFilter.Alpha = 20;
            this.btnFilter.BackColor = System.Drawing.Color.Transparent;
            this.btnFilter.Background = true;
            this.btnFilter.Background_WidthPen = 4F;
            this.btnFilter.BackgroundPen = true;
            this.btnFilter.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnFilter.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.ColorBackground_Pen = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(226)))), ((int)(((byte)(243)))));
            this.btnFilter.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilter.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.btnFilter.Effect_1 = true;
            this.btnFilter.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.Effect_1_Transparency = 25;
            this.btnFilter.Effect_2 = true;
            this.btnFilter.Effect_2_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFilter.Effect_2_Transparency = 20;
            this.btnFilter.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(54)))), ((int)(((byte)(71)))));
            this.btnFilter.Lighting = true;
            this.btnFilter.LinearGradient_Background = false;
            this.btnFilter.LinearGradientPen = false;
            this.btnFilter.Location = new System.Drawing.Point(943, 36);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.PenWidth = 15;
            this.btnFilter.Rounding = true;
            this.btnFilter.RoundingInt = 20;
            this.btnFilter.Size = new System.Drawing.Size(90, 43);
            this.btnFilter.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 45;
            this.btnFilter.Tag = "Decline";
            this.btnFilter.TextButton = "Filter";
            this.btnFilter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnFilter.Timer_Effect_1 = 5;
            this.btnFilter.Timer_RGB = 300;
            // 
            // FSearchJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1048, 580);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.flpJob);
            this.Controls.Add(this.txtJob);
            this.Controls.Add(this.dungeonComboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FSearchJob";
            this.Text = "FSearchJob";
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.HopeTextBox txtJob;
        private FlowLayoutPanel flpJob;
        private ReaLTaiizor.Controls.CyberButton btnFilter;
    }
}
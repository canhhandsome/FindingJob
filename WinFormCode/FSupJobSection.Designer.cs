namespace WinFormProject
{
    partial class FSupJobSection
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
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            flpAlert = new FlowLayoutPanel();
            btnSearch = new ReaLTaiizor.Controls.CyberButton();
            SuspendLayout();
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.FromArgb(247, 218, 218);
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "Enter Search";
            hopeTextBox1.Location = new Point(27, 24);
            hopeTextBox1.Margin = new Padding(3, 4, 3, 4);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(841, 43);
            hopeTextBox1.TabIndex = 2;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // flpAlert
            // 
            flpAlert.AutoScroll = true;
            flpAlert.Location = new Point(12, 115);
            flpAlert.Margin = new Padding(3, 4, 3, 4);
            flpAlert.Name = "flpAlert";
            flpAlert.Size = new Size(1005, 165);
            flpAlert.TabIndex = 4;
            // 
            // btnSearch
            // 
            btnSearch.Alpha = 20;
            btnSearch.BackColor = Color.Transparent;
            btnSearch.Background = true;
            btnSearch.Background_WidthPen = 4F;
            btnSearch.BackgroundPen = true;
            btnSearch.ColorBackground = Color.FromArgb(176, 226, 243);
            btnSearch.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnSearch.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnSearch.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnSearch.ColorLighting = Color.FromArgb(128, 128, 255);
            btnSearch.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnSearch.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnSearch.Cursor = Cursors.Hand;
            btnSearch.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnSearch.Effect_1 = true;
            btnSearch.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnSearch.Effect_1_Transparency = 25;
            btnSearch.Effect_2 = true;
            btnSearch.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnSearch.Effect_2_Transparency = 20;
            btnSearch.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.ForeColor = Color.FromArgb(46, 54, 71);
            btnSearch.Lighting = true;
            btnSearch.LinearGradient_Background = false;
            btnSearch.LinearGradientPen = false;
            btnSearch.Location = new Point(891, 18);
            btnSearch.Margin = new Padding(3, 4, 3, 4);
            btnSearch.Name = "btnSearch";
            btnSearch.PenWidth = 15;
            btnSearch.Rounding = true;
            btnSearch.RoundingInt = 20;
            btnSearch.Size = new Size(104, 53);
            btnSearch.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearch.TabIndex = 44;
            btnSearch.Tag = "Decline";
            btnSearch.TextButton = "Search";
            btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSearch.Timer_Effect_1 = 5;
            btnSearch.Timer_RGB = 300;
            // 
            // FSupJobSection
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1029, 611);
            Controls.Add(btnSearch);
            Controls.Add(flpAlert);
            Controls.Add(hopeTextBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FSupJobSection";
            Text = "FSupJobSection";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private UCAlert ucAlert1;
        private FlowLayoutPanel flpAlert;
        private ReaLTaiizor.Controls.CyberButton btnSearch;
    }
}
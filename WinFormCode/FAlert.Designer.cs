namespace WinFormProject
{
    partial class FAlert
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
            hopeTextBox1.Location = new Point(24, 18);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(736, 38);
            hopeTextBox1.TabIndex = 2;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // flpAlert
            // 
            flpAlert.AutoScroll = true;
            flpAlert.Location = new Point(31, 86);
            flpAlert.Name = "flpAlert";
            flpAlert.Size = new Size(879, 124);
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
            btnSearch.Location = new Point(780, 14);
            btnSearch.Name = "btnSearch";
            btnSearch.PenWidth = 15;
            btnSearch.Rounding = true;
            btnSearch.RoundingInt = 20;
            btnSearch.Size = new Size(91, 40);
            btnSearch.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnSearch.TabIndex = 44;
            btnSearch.Tag = "Decline";
            btnSearch.TextButton = "Search";
            btnSearch.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnSearch.Timer_Effect_1 = 5;
            btnSearch.Timer_RGB = 300;
            // 
            // FAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(900, 458);
            Controls.Add(btnSearch);
            Controls.Add(flpAlert);
            Controls.Add(hopeTextBox1);
            Name = "FAlert";
            Text = "FAlert";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private UCAlert ucAlert1;
        private FlowLayoutPanel flpAlert;
        private ReaLTaiizor.Controls.CyberButton btnSearch;
    }
}
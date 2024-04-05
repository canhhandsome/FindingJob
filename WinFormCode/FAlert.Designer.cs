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
            btnFilter = new ReaLTaiizor.Controls.CyberButton();
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
            hopeTextBox1.Location = new Point(24, 47);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(946, 38);
            hopeTextBox1.TabIndex = 2;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // flpAlert
            // 
            flpAlert.AutoScroll = true;
            flpAlert.Location = new Point(24, 108);
            flpAlert.Name = "flpAlert";
            flpAlert.Size = new Size(1043, 124);
            flpAlert.TabIndex = 4;
            // 
            // btnFilter
            // 
            btnFilter.Alpha = 20;
            btnFilter.BackColor = Color.Transparent;
            btnFilter.Background = true;
            btnFilter.Background_WidthPen = 4F;
            btnFilter.BackgroundPen = true;
            btnFilter.ColorBackground = Color.FromArgb(176, 226, 243);
            btnFilter.ColorBackground_1 = Color.FromArgb(128, 128, 255);
            btnFilter.ColorBackground_2 = Color.FromArgb(128, 128, 255);
            btnFilter.ColorBackground_Pen = Color.FromArgb(176, 226, 243);
            btnFilter.ColorLighting = Color.FromArgb(128, 128, 255);
            btnFilter.ColorPen_1 = Color.FromArgb(128, 128, 255);
            btnFilter.ColorPen_2 = Color.FromArgb(128, 128, 255);
            btnFilter.Cursor = Cursors.Hand;
            btnFilter.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnFilter.Effect_1 = true;
            btnFilter.Effect_1_ColorBackground = Color.FromArgb(128, 128, 255);
            btnFilter.Effect_1_Transparency = 25;
            btnFilter.Effect_2 = true;
            btnFilter.Effect_2_ColorBackground = Color.FromArgb(128, 128, 255);
            btnFilter.Effect_2_Transparency = 20;
            btnFilter.Font = new Font("Arial", 11F, FontStyle.Regular, GraphicsUnit.Point);
            btnFilter.ForeColor = Color.FromArgb(46, 54, 71);
            btnFilter.Lighting = true;
            btnFilter.LinearGradient_Background = false;
            btnFilter.LinearGradientPen = false;
            btnFilter.Location = new Point(976, 47);
            btnFilter.Name = "btnFilter";
            btnFilter.PenWidth = 15;
            btnFilter.Rounding = true;
            btnFilter.RoundingInt = 20;
            btnFilter.Size = new Size(91, 40);
            btnFilter.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnFilter.TabIndex = 44;
            btnFilter.Tag = "Decline";
            btnFilter.TextButton = "Filter";
            btnFilter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnFilter.Timer_Effect_1 = 5;
            btnFilter.Timer_RGB = 300;
            // 
            // FAlert
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1079, 635);
            Controls.Add(btnFilter);
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
        private ReaLTaiizor.Controls.CyberButton btnFilter;
    }
}
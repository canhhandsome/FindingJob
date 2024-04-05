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
            this.hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            this.flpAlert = new System.Windows.Forms.FlowLayoutPanel();
            this.btnFilter = new ReaLTaiizor.Controls.CyberButton();
            this.SuspendLayout();
            // 
            // hopeTextBox1
            // 
            this.hopeTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.hopeTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox1.Hint = "Enter Search";
            this.hopeTextBox1.Location = new System.Drawing.Point(27, 63);
            this.hopeTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopeTextBox1.MaxLength = 32767;
            this.hopeTextBox1.Multiline = false;
            this.hopeTextBox1.Name = "hopeTextBox1";
            this.hopeTextBox1.PasswordChar = '\0';
            this.hopeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox1.SelectedText = "";
            this.hopeTextBox1.SelectionLength = 0;
            this.hopeTextBox1.SelectionStart = 0;
            this.hopeTextBox1.Size = new System.Drawing.Size(1081, 43);
            this.hopeTextBox1.TabIndex = 2;
            this.hopeTextBox1.TabStop = false;
            this.hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // flpAlert
            // 
            this.flpAlert.AutoScroll = true;
            this.flpAlert.Location = new System.Drawing.Point(27, 144);
            this.flpAlert.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.flpAlert.Name = "flpAlert";
            this.flpAlert.Size = new System.Drawing.Size(1192, 165);
            this.flpAlert.TabIndex = 4;
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
            this.btnFilter.Location = new System.Drawing.Point(1115, 53);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.PenWidth = 15;
            this.btnFilter.Rounding = true;
            this.btnFilter.RoundingInt = 20;
            this.btnFilter.Size = new System.Drawing.Size(104, 53);
            this.btnFilter.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.btnFilter.TabIndex = 44;
            this.btnFilter.Tag = "Decline";
            this.btnFilter.TextButton = "Filter";
            this.btnFilter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.btnFilter.Timer_Effect_1 = 5;
            this.btnFilter.Timer_RGB = 300;
            // 
            // FAlert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1233, 847);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.flpAlert);
            this.Controls.Add(this.hopeTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FAlert";
            this.Text = "FAlert";
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private UCAlert ucAlert1;
        private FlowLayoutPanel flpAlert;
        private ReaLTaiizor.Controls.CyberButton btnFilter;
    }
}
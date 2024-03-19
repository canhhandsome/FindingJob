namespace WinFormProject
{
    partial class FApplicant
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
            lblSearchApplicant = new Label();
            flpApplicant = new FlowLayoutPanel();
            SuspendLayout();
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "Enter Applicant";
            hopeTextBox1.Location = new Point(263, 35);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(583, 38);
            hopeTextBox1.TabIndex = 0;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // lblSearchApplicant
            // 
            lblSearchApplicant.AutoSize = true;
            lblSearchApplicant.BackColor = Color.Transparent;
            lblSearchApplicant.Font = new Font("Segoe UI", 19.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblSearchApplicant.ForeColor = SystemColors.ControlText;
            lblSearchApplicant.Location = new Point(22, 34);
            lblSearchApplicant.Name = "lblSearchApplicant";
            lblSearchApplicant.Size = new Size(207, 36);
            lblSearchApplicant.TabIndex = 1;
            lblSearchApplicant.Text = "Search Applicant";
            // 
            // flpApplicant
            // 
            flpApplicant.Location = new Point(29, 104);
            flpApplicant.Name = "flpApplicant";
            flpApplicant.Size = new Size(817, 204);
            flpApplicant.TabIndex = 2;
            // 
            // FApplicant
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(917, 450);
            Controls.Add(flpApplicant);
            Controls.Add(lblSearchApplicant);
            Controls.Add(hopeTextBox1);
            ForeColor = SystemColors.ControlText;
            Name = "FApplicant";
            Text = "FApplicant";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private Label lblSearchApplicant;
        private UCApplicant ucApplicant1;
        private FlowLayoutPanel flpApplicant;
    }
}
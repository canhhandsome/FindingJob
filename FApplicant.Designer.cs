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
            this.hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            this.lblSearchApplicant = new System.Windows.Forms.Label();
            this.pnSubBody = new System.Windows.Forms.Panel();
            this.ucApplicant1 = new WinFormProject.UCApplicant();
            this.pnSubBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeTextBox1
            // 
            this.hopeTextBox1.BackColor = System.Drawing.Color.White;
            this.hopeTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox1.Hint = "Enter Applicant";
            this.hopeTextBox1.Location = new System.Drawing.Point(301, 47);
            this.hopeTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopeTextBox1.MaxLength = 32767;
            this.hopeTextBox1.Multiline = false;
            this.hopeTextBox1.Name = "hopeTextBox1";
            this.hopeTextBox1.PasswordChar = '\0';
            this.hopeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox1.SelectedText = "";
            this.hopeTextBox1.SelectionLength = 0;
            this.hopeTextBox1.SelectionStart = 0;
            this.hopeTextBox1.Size = new System.Drawing.Size(666, 43);
            this.hopeTextBox1.TabIndex = 0;
            this.hopeTextBox1.TabStop = false;
            this.hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // lblSearchApplicant
            // 
            this.lblSearchApplicant.AutoSize = true;
            this.lblSearchApplicant.BackColor = System.Drawing.Color.Transparent;
            this.lblSearchApplicant.Font = new System.Drawing.Font("Segoe UI", 19.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSearchApplicant.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSearchApplicant.Location = new System.Drawing.Point(25, 45);
            this.lblSearchApplicant.Name = "lblSearchApplicant";
            this.lblSearchApplicant.Size = new System.Drawing.Size(258, 45);
            this.lblSearchApplicant.TabIndex = 1;
            this.lblSearchApplicant.Text = "Search Applicant";
            // 
            // pnSubBody
            // 
            this.pnSubBody.AutoScroll = true;
            this.pnSubBody.Controls.Add(this.ucApplicant1);
            this.pnSubBody.Location = new System.Drawing.Point(35, 124);
            this.pnSubBody.Name = "pnSubBody";
            this.pnSubBody.Size = new System.Drawing.Size(950, 645);
            this.pnSubBody.TabIndex = 3;
            // 
            // ucApplicant1
            // 
            this.ucApplicant1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucApplicant1.Location = new System.Drawing.Point(0, 0);
            this.ucApplicant1.Name = "ucApplicant1";
            this.ucApplicant1.Size = new System.Drawing.Size(950, 286);
            this.ucApplicant1.TabIndex = 0;
            // 
            // FApplicant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.pnSubBody);
            this.Controls.Add(this.lblSearchApplicant);
            this.Controls.Add(this.hopeTextBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FApplicant";
            this.Text = "FApplicant";
            this.pnSubBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private Label lblSearchApplicant;
        private Panel pnSubBody;
        private UCApplicant ucApplicant1;
    }
}
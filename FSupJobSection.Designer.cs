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
            this.hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucInformation3 = new WinFormProject.UCInformation();
            this.ucInformation2 = new WinFormProject.UCInformation();
            this.ucInformation1 = new WinFormProject.UCInformation();
            this.panel1.SuspendLayout();
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
            this.hopeTextBox1.Hint = "Enter Search";
            this.hopeTextBox1.Location = new System.Drawing.Point(21, 24);
            this.hopeTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopeTextBox1.MaxLength = 32767;
            this.hopeTextBox1.Multiline = false;
            this.hopeTextBox1.Name = "hopeTextBox1";
            this.hopeTextBox1.PasswordChar = '\0';
            this.hopeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox1.SelectedText = "";
            this.hopeTextBox1.SelectionLength = 0;
            this.hopeTextBox1.SelectionStart = 0;
            this.hopeTextBox1.Size = new System.Drawing.Size(841, 43);
            this.hopeTextBox1.TabIndex = 2;
            this.hopeTextBox1.TabStop = false;
            this.hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(895, 24);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 43);
            this.button1.TabIndex = 3;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucInformation3);
            this.panel1.Controls.Add(this.ucInformation2);
            this.panel1.Controls.Add(this.ucInformation1);
            this.panel1.Location = new System.Drawing.Point(21, 109);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 762);
            this.panel1.TabIndex = 5;
            // 
            // ucInformation3
            // 
            this.ucInformation3.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInformation3.Location = new System.Drawing.Point(0, 450);
            this.ucInformation3.Name = "ucInformation3";
            this.ucInformation3.Size = new System.Drawing.Size(968, 225);
            this.ucInformation3.TabIndex = 2;
            // 
            // ucInformation2
            // 
            this.ucInformation2.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInformation2.Location = new System.Drawing.Point(0, 225);
            this.ucInformation2.Name = "ucInformation2";
            this.ucInformation2.Size = new System.Drawing.Size(968, 225);
            this.ucInformation2.TabIndex = 1;
            // 
            // ucInformation1
            // 
            this.ucInformation1.Dock = System.Windows.Forms.DockStyle.Top;
            this.ucInformation1.Location = new System.Drawing.Point(0, 0);
            this.ucInformation1.Name = "ucInformation1";
            this.ucInformation1.Size = new System.Drawing.Size(968, 225);
            this.ucInformation1.TabIndex = 0;
            // 
            // FSupJobSection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1029, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.hopeTextBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FSupJobSection";
            this.Text = "FSupJobSection";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private Button button1;
        private Panel panel1;
        private UCInformation ucInformation3;
        private UCInformation ucInformation2;
        private UCInformation ucInformation1;
    }
}
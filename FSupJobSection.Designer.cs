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
            btnSearch = new Button();
            flpAlert = new FlowLayoutPanel();
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
            // btnSearch
            // 
            btnSearch.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSearch.Location = new Point(789, 18);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(82, 32);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // flpAlert
            // 
            flpAlert.AutoScroll = true;
            flpAlert.Location = new Point(24, 86);
            flpAlert.Name = "flpAlert";
            flpAlert.Size = new Size(847, 124);
            flpAlert.TabIndex = 4;
            // 
            // FSupJobSection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(900, 458);
            Controls.Add(flpAlert);
            Controls.Add(btnSearch);
            Controls.Add(hopeTextBox1);
            Name = "FSupJobSection";
            Text = "FSupJobSection";
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private Button btnSearch;
        private UCAlert ucAlert1;
        private FlowLayoutPanel flpAlert;
    }
}
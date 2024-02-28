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
            dungeonComboBox1 = new ReaLTaiizor.Controls.DungeonComboBox();
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
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
            dungeonComboBox1.Location = new Point(74, 34);
            dungeonComboBox1.Name = "dungeonComboBox1";
            dungeonComboBox1.Size = new Size(163, 26);
            dungeonComboBox1.StartIndex = 0;
            dungeonComboBox1.TabIndex = 1;
            // 
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.FromArgb(44, 55, 66);
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "Enter Jobs";
            hopeTextBox1.Location = new Point(259, 27);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(561, 38);
            hopeTextBox1.TabIndex = 2;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // FSearchJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(90, 48, 52);
            ClientSize = new Size(917, 435);
            Controls.Add(hopeTextBox1);
            Controls.Add(dungeonComboBox1);
            Name = "FSearchJob";
            Text = "FSearchJob";
            Load += FSearchJob_Load;
            ResumeLayout(false);
        }

        #endregion
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
    }
}
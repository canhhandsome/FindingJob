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
            this.hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            this.btnFilter = new System.Windows.Forms.Button();
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
            // hopeTextBox1
            // 
            this.hopeTextBox1.BackColor = System.Drawing.Color.White;
            this.hopeTextBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.hopeTextBox1.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.hopeTextBox1.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeTextBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.hopeTextBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeTextBox1.Hint = "Enter Jobs";
            this.hopeTextBox1.Location = new System.Drawing.Point(296, 36);
            this.hopeTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.hopeTextBox1.MaxLength = 32767;
            this.hopeTextBox1.Multiline = false;
            this.hopeTextBox1.Name = "hopeTextBox1";
            this.hopeTextBox1.PasswordChar = '\0';
            this.hopeTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.hopeTextBox1.SelectedText = "";
            this.hopeTextBox1.SelectionLength = 0;
            this.hopeTextBox1.SelectionStart = 0;
            this.hopeTextBox1.Size = new System.Drawing.Size(641, 43);
            this.hopeTextBox1.TabIndex = 2;
            this.hopeTextBox1.TabStop = false;
            this.hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // btnFilter
            // 
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnFilter.Location = new System.Drawing.Point(953, 36);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(57, 43);
            this.btnFilter.TabIndex = 3;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            // 
            // FSearchJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1048, 580);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.hopeTextBox1);
            this.Controls.Add(this.dungeonComboBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FSearchJob";
            this.Text = "FSearchJob";
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.DungeonComboBox dungeonComboBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private Button btnFilter;
    }
}
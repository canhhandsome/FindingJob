namespace WinFormProject
{
    partial class FJobRequire
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddRequire = new System.Windows.Forms.Button();
            this.pnJobRequirement = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DimGray;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(805, 515);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(169, 51);
            this.btnCancel.TabIndex = 26;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(630, 515);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(169, 51);
            this.button2.TabIndex = 27;
            this.button2.Text = "Save";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnAddRequire
            // 
            this.btnAddRequire.BackColor = System.Drawing.Color.DimGray;
            this.btnAddRequire.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnAddRequire.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAddRequire.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddRequire.Location = new System.Drawing.Point(67, 515);
            this.btnAddRequire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRequire.Name = "btnAddRequire";
            this.btnAddRequire.Size = new System.Drawing.Size(222, 51);
            this.btnAddRequire.TabIndex = 28;
            this.btnAddRequire.Text = "Add New Requirement";
            this.btnAddRequire.UseVisualStyleBackColor = false;
            this.btnAddRequire.Click += new System.EventHandler(this.btnAddRequire_Click);
            // 
            // pnJobRequirement
            // 
            this.pnJobRequirement.AutoScroll = true;
            this.pnJobRequirement.BackColor = System.Drawing.Color.LightGray;
            this.pnJobRequirement.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnJobRequirement.Location = new System.Drawing.Point(67, 124);
            this.pnJobRequirement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnJobRequirement.Name = "pnJobRequirement";
            this.pnJobRequirement.Size = new System.Drawing.Size(913, 339);
            this.pnJobRequirement.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(394, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 35);
            this.label1.TabIndex = 24;
            this.label1.Text = "Adding Job\'s Requirement";
            // 
            // pnBody
            // 
            this.pnBody.BackColor = System.Drawing.Color.LightGray;
            this.pnBody.Controls.Add(this.btnAddRequire);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 600);
            this.pnBody.TabIndex = 30;
            // 
            // FJobRequire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.pnJobRequirement);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FJobRequire";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FJobRequire";
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancel;
        private Button button2;
        private Button btnAddRequire;
        private Panel pnJobRequirement;
        private Label label1;
        private Panel pnBody;
    }
}
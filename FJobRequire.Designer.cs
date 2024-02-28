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
            btnCancle = new Button();
            button2 = new Button();
            btnAddRequire = new Button();
            pnJobRequirement = new Panel();
            label1 = new Label();
            pnBody = new Panel();
            SuspendLayout();
            // 
            // btnCancle
            // 
            btnCancle.BackColor = Color.Silver;
            btnCancle.FlatStyle = FlatStyle.Flat;
            btnCancle.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCancle.Location = new Point(704, 386);
            btnCancle.Name = "btnCancle";
            btnCancle.Size = new Size(148, 38);
            btnCancle.TabIndex = 26;
            btnCancle.Text = "Cancle";
            btnCancle.UseVisualStyleBackColor = false;
            btnCancle.Click += btnCancle_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(551, 386);
            button2.Name = "button2";
            button2.Size = new Size(148, 38);
            button2.TabIndex = 27;
            button2.Text = "Save";
            button2.UseVisualStyleBackColor = false;
            // 
            // btnAddRequire
            // 
            btnAddRequire.BackColor = Color.Silver;
            btnAddRequire.FlatStyle = FlatStyle.Flat;
            btnAddRequire.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAddRequire.Location = new Point(664, 59);
            btnAddRequire.Name = "btnAddRequire";
            btnAddRequire.Size = new Size(194, 38);
            btnAddRequire.TabIndex = 28;
            btnAddRequire.Text = "Add New Requirement";
            btnAddRequire.UseVisualStyleBackColor = false;
            btnAddRequire.Click += btnAddRequire_Click;
            // 
            // pnJobRequirement
            // 
            pnJobRequirement.AutoScroll = true;
            pnJobRequirement.Location = new Point(59, 93);
            pnJobRequirement.Name = "pnJobRequirement";
            pnJobRequirement.Size = new Size(799, 254);
            pnJobRequirement.TabIndex = 29;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(64, 64, 64);
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(345, 24);
            label1.Name = "label1";
            label1.Size = new Size(242, 28);
            label1.TabIndex = 24;
            label1.Text = "Adding Job's Requirement";
            // 
            // pnBody
            // 
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(917, 450);
            pnBody.TabIndex = 30;
            // 
            // FJobRequire
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(917, 450);
            Controls.Add(pnJobRequirement);
            Controls.Add(btnCancle);
            Controls.Add(button2);
            Controls.Add(btnAddRequire);
            Controls.Add(label1);
            Controls.Add(pnBody);
            Name = "FJobRequire";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FJobRequire";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancle;
        private Button button2;
        private Button btnAddRequire;
        private Panel pnJobRequirement;
        private Label label1;
        private Panel pnBody;
    }
}
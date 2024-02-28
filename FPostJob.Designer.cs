namespace WinFormProject
{
    partial class FPostJob
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
            label1 = new Label();
            btnPostingJob = new Button();
            pnBody = new Panel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(35, 29);
            label1.Name = "label1";
            label1.Size = new Size(247, 37);
            label1.TabIndex = 0;
            label1.Text = "List Of Current Jobs";
            // 
            // btnPostingJob
            // 
            btnPostingJob.BackColor = Color.Silver;
            btnPostingJob.Cursor = Cursors.Hand;
            btnPostingJob.FlatStyle = FlatStyle.Flat;
            btnPostingJob.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostingJob.Location = new Point(722, 31);
            btnPostingJob.Name = "btnPostingJob";
            btnPostingJob.Size = new Size(166, 39);
            btnPostingJob.TabIndex = 1;
            btnPostingJob.Text = "Posting a job";
            btnPostingJob.UseVisualStyleBackColor = false;
            btnPostingJob.Click += btnPostingJob_Click;
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(917, 450);
            pnBody.TabIndex = 2;
            pnBody.Paint += pnBody_Paint;
            // 
            // FPostJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(917, 450);
            Controls.Add(btnPostingJob);
            Controls.Add(label1);
            Controls.Add(pnBody);
            Name = "FPostJob";
            Text = "PostJob";
            Load += PostJob_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnPostingJob;
        private Panel pnBody;
    }
}
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
            btnPostingJob = new Button();
            pnBody = new Panel();
            pnSubBody = new FlowLayoutPanel();
            lblListJobs = new Label();
            pnBody.SuspendLayout();
            SuspendLayout();
            // 
            // btnPostingJob
            // 
            btnPostingJob.BackColor = Color.DimGray;
            btnPostingJob.Cursor = Cursors.Hand;
            btnPostingJob.FlatStyle = FlatStyle.System;
            btnPostingJob.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnPostingJob.ForeColor = SystemColors.ControlLightLight;
            btnPostingJob.Location = new Point(712, 28);
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
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.White;
            pnBody.Controls.Add(pnSubBody);
            pnBody.Controls.Add(lblListJobs);
            pnBody.Controls.Add(btnPostingJob);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(917, 450);
            pnBody.TabIndex = 2;
            // 
            // pnSubBody
            // 
            pnSubBody.Location = new Point(94, 92);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(749, 207);
            pnSubBody.TabIndex = 4;
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.White;
            lblListJobs.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(35, 29);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(247, 37);
            lblListJobs.TabIndex = 3;
            lblListJobs.Text = "List Of Current Jobs";
            // 
            // FPostJob
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(917, 450);
            Controls.Add(pnBody);
            Name = "FPostJob";
            Text = "PostJob";
            Load += PostJob_Load;
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPostingJob;
        private Panel pnBody;
        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
    }
}
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
            pnSubBody = new Panel();
            pnBody = new Panel();
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
            btnPostingJob.Location = new Point(814, 38);
            btnPostingJob.Margin = new Padding(3, 4, 3, 4);
            btnPostingJob.Name = "btnPostingJob";
            btnPostingJob.Size = new Size(190, 52);
            btnPostingJob.TabIndex = 1;
            btnPostingJob.Text = "Posting a job";
            btnPostingJob.UseVisualStyleBackColor = false;
            btnPostingJob.Click += btnPostingJob_Click;
            // 
            // pnSubBody
            // 
            pnSubBody.AutoScroll = true;
            pnSubBody.AutoSize = true;
            pnSubBody.BorderStyle = BorderStyle.Fixed3D;
            pnSubBody.Location = new Point(107, 131);
            pnSubBody.Name = "pnSubBody";
            pnSubBody.Size = new Size(812, 491);
            pnSubBody.TabIndex = 2;
            // 
            // pnBody
            // 
            pnBody.AutoScroll = true;
            pnBody.AutoSize = true;
            pnBody.BackColor = Color.LightGray;
            pnBody.Controls.Add(lblListJobs);
            pnBody.Controls.Add(pnSubBody);
            pnBody.Controls.Add(btnPostingJob);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 0);
            pnBody.Margin = new Padding(3, 4, 3, 4);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(1048, 600);
            pnBody.TabIndex = 2;
            // 
            // lblListJobs
            // 
            lblListJobs.AutoSize = true;
            lblListJobs.BackColor = Color.LightGray;
            lblListJobs.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lblListJobs.ForeColor = SystemColors.ControlText;
            lblListJobs.Location = new Point(40, 39);
            lblListJobs.Name = "lblListJobs";
            lblListJobs.Size = new Size(313, 46);
            lblListJobs.TabIndex = 3;
            lblListJobs.Text = "List Of Current Jobs";
            // 
            // FPostJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.FromArgb(32, 41, 58);
            ClientSize = new Size(1048, 600);
            Controls.Add(pnBody);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FPostJob";
            Text = "PostJob";
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnPostingJob;
        private Panel pnSubBody;
        private Panel pnBody;
        private Label lblListJobs;
    }
}
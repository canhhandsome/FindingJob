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
            this.btnPostingJob = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnSubBody = new System.Windows.Forms.FlowLayoutPanel();
            this.lblListJobs = new System.Windows.Forms.Label();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPostingJob
            // 
            this.btnPostingJob.BackColor = System.Drawing.Color.DimGray;
            this.btnPostingJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostingJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPostingJob.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostingJob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPostingJob.Location = new System.Drawing.Point(814, 37);
            this.btnPostingJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostingJob.Name = "btnPostingJob";
            this.btnPostingJob.Size = new System.Drawing.Size(190, 52);
            this.btnPostingJob.TabIndex = 1;
            this.btnPostingJob.Text = "Posting a job";
            this.btnPostingJob.UseVisualStyleBackColor = false;
            this.btnPostingJob.Click += new System.EventHandler(this.btnPostingJob_Click);
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.AutoSize = true;
            this.pnBody.BackColor = System.Drawing.Color.White;
            this.pnBody.Controls.Add(this.pnSubBody);
            this.pnBody.Controls.Add(this.lblListJobs);
            this.pnBody.Controls.Add(this.btnPostingJob);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 600);
            this.pnBody.TabIndex = 2;
            // 
            // pnSubBody
            // 
            this.pnSubBody.Location = new System.Drawing.Point(107, 123);
            this.pnSubBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnSubBody.Name = "pnSubBody";
            this.pnSubBody.Size = new System.Drawing.Size(856, 276);
            this.pnSubBody.TabIndex = 4;
            // 
            // lblListJobs
            // 
            this.lblListJobs.AutoSize = true;
            this.lblListJobs.BackColor = System.Drawing.Color.White;
            this.lblListJobs.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblListJobs.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblListJobs.Location = new System.Drawing.Point(40, 39);
            this.lblListJobs.Name = "lblListJobs";
            this.lblListJobs.Size = new System.Drawing.Size(313, 46);
            this.lblListJobs.TabIndex = 3;
            this.lblListJobs.Text = "List Of Current Jobs";
            // 
            // FPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FPostJob";
            this.Text = "PostJob";
            this.pnBody.ResumeLayout(false);
            this.pnBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnPostingJob;
        private Panel pnBody;
        private Label lblListJobs;
        private FlowLayoutPanel pnSubBody;
    }
}
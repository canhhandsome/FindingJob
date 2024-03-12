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
            this.label1 = new System.Windows.Forms.Label();
            this.btnPostingJob = new System.Windows.Forms.Button();
            this.pnBody = new System.Windows.Forms.Panel();
            this.pnBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightGray;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(40, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "List Of Current Jobs";
            // 
            // btnPostingJob
            // 
            this.btnPostingJob.BackColor = System.Drawing.Color.DimGray;
            this.btnPostingJob.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPostingJob.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPostingJob.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPostingJob.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPostingJob.Location = new System.Drawing.Point(814, 38);
            this.btnPostingJob.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPostingJob.Name = "btnPostingJob";
            this.btnPostingJob.Size = new System.Drawing.Size(190, 52);
            this.btnPostingJob.TabIndex = 1;
            this.btnPostingJob.Text = "Posting a job";
            this.btnPostingJob.UseVisualStyleBackColor = false;
            // 
            // pnBody
            // 
            this.pnBody.AutoScroll = true;
            this.pnBody.BackColor = System.Drawing.Color.LightGray;
            this.pnBody.Controls.Add(this.btnPostingJob);
            this.pnBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnBody.Location = new System.Drawing.Point(0, 0);
            this.pnBody.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pnBody.Name = "pnBody";
            this.pnBody.Size = new System.Drawing.Size(1048, 600);
            this.pnBody.TabIndex = 2;
            // 
            // FPostJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1048, 600);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnBody);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FPostJob";
            this.Text = "PostJob";
            this.pnBody.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button btnPostingJob;
        private Panel pnBody;
    }
}
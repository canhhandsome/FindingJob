namespace WinFormProject
{
    partial class FCVcs
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
            this.ptbCV = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCV)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCV
            // 
            this.ptbCV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ptbCV.Location = new System.Drawing.Point(0, 0);
            this.ptbCV.Name = "ptbCV";
            this.ptbCV.Size = new System.Drawing.Size(1057, 580);
            this.ptbCV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbCV.TabIndex = 0;
            this.ptbCV.TabStop = false;
            // 
            // FCVcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1057, 580);
            this.Controls.Add(this.ptbCV);
            this.Name = "FCVcs";
            this.Text = "FCVcs";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptbCV;
    }
}
namespace WinFormProject
{
    partial class FCV
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
            ptbCV = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)ptbCV).BeginInit();
            SuspendLayout();
            // 
            // ptbCV
            // 
            ptbCV.Dock = DockStyle.Fill;
            ptbCV.Location = new Point(0, 0);
            ptbCV.Name = "ptbCV";
            ptbCV.Size = new Size(954, 839);
            ptbCV.SizeMode = PictureBoxSizeMode.StretchImage;
            ptbCV.TabIndex = 0;
            ptbCV.TabStop = false;
            // 
            // FCV
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.LightGray;
            ClientSize = new Size(954, 839);
            Controls.Add(ptbCV);
            Name = "FCV";
            Text = "FCV";
            ((System.ComponentModel.ISupportInitialize)ptbCV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox ptbCV;
    }
}
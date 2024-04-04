namespace WinFormProject.WinFormCode
{
    partial class UCCarousel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCarousel));
            btnLeftArrow = new Button();
            btnRightArrow = new Button();
            SuspendLayout();
            // 
            // btnLeftArrow
            // 
            btnLeftArrow.BackColor = Color.Transparent;
            btnLeftArrow.Dock = DockStyle.Left;
            btnLeftArrow.FlatAppearance.BorderSize = 0;
            btnLeftArrow.FlatStyle = FlatStyle.Flat;
            btnLeftArrow.Image = (Image)resources.GetObject("btnLeftArrow.Image");
            btnLeftArrow.Location = new Point(0, 0);
            btnLeftArrow.Name = "btnLeftArrow";
            btnLeftArrow.Size = new Size(94, 331);
            btnLeftArrow.TabIndex = 0;
            btnLeftArrow.UseVisualStyleBackColor = false;
            // 
            // btnRightArrow
            // 
            btnRightArrow.BackColor = Color.Transparent;
            btnRightArrow.Dock = DockStyle.Right;
            btnRightArrow.FlatAppearance.BorderSize = 0;
            btnRightArrow.FlatStyle = FlatStyle.Flat;
            btnRightArrow.Image = (Image)resources.GetObject("btnRightArrow.Image");
            btnRightArrow.Location = new Point(719, 0);
            btnRightArrow.Name = "btnRightArrow";
            btnRightArrow.Size = new Size(94, 331);
            btnRightArrow.TabIndex = 1;
            btnRightArrow.UseVisualStyleBackColor = false;
            // 
            // UCCarousel
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnRightArrow);
            Controls.Add(btnLeftArrow);
            Name = "UCCarousel";
            Size = new Size(813, 331);
            ResumeLayout(false);
        }

        #endregion

        private Button btnLeftArrow;
        private Button btnRightArrow;
    }
}

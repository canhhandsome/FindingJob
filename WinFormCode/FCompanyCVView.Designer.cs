namespace WinFormProject.WinFormCode
{
    partial class FCompanyCVView
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            btnHeart = new Guna.UI2.WinForms.Guna2PictureBox();
            guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            lblLikes = new Guna.UI2.WinForms.Guna2HtmlLabel();
            guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHeart).BeginInit();
            SuspendLayout();
            // 
            // guna2Panel1
            // 
            guna2Panel1.Controls.Add(lblLikes);
            guna2Panel1.Controls.Add(guna2HtmlLabel1);
            guna2Panel1.Controls.Add(btnHeart);
            guna2Panel1.CustomizableEdges = customizableEdges3;
            guna2Panel1.Dock = DockStyle.Bottom;
            guna2Panel1.Location = new Point(0, 774);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel1.Size = new Size(995, 71);
            guna2Panel1.TabIndex = 0;
            // 
            // btnHeart
            // 
            btnHeart.CustomizableEdges = customizableEdges1;
            btnHeart.Dock = DockStyle.Left;
            btnHeart.Image = Properties.Resources.DarkHeart;
            btnHeart.ImageRotate = 0F;
            btnHeart.Location = new Point(0, 0);
            btnHeart.Name = "btnHeart";
            btnHeart.ShadowDecoration.CustomizableEdges = customizableEdges2;
            btnHeart.Size = new Size(89, 71);
            btnHeart.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHeart.TabIndex = 0;
            btnHeart.TabStop = false;
            btnHeart.Click += btnHeart_Click;
            // 
            // guna2HtmlLabel1
            // 
            guna2HtmlLabel1.BackColor = Color.Transparent;
            guna2HtmlLabel1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            guna2HtmlLabel1.Location = new Point(758, 25);
            guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            guna2HtmlLabel1.Size = new Size(178, 27);
            guna2HtmlLabel1.TabIndex = 1;
            guna2HtmlLabel1.Text = "Total Like Of This CV:";
            // 
            // lblLikes
            // 
            lblLikes.BackColor = Color.Transparent;
            lblLikes.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            lblLikes.Location = new Point(940, 27);
            lblLikes.Name = "lblLikes";
            lblLikes.Size = new Size(39, 25);
            lblLikes.TabIndex = 2;
            lblLikes.Text = "Likes";
            // 
            // FCompanyCVView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 845);
            Controls.Add(guna2Panel1);
            Name = "FCompanyCVView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCompanyCVView";
            guna2Panel1.ResumeLayout(false);
            guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHeart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox btnHeart;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblLikes;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
    }
}
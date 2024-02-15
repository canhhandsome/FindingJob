namespace WinFormProject
{
    partial class FCompany
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCompany));
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            metroControlBox3 = new ReaLTaiizor.Controls.MetroControlBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            button1 = new ReaLTaiizor.Controls.Button();
            panel11 = new Panel();
            button6 = new ReaLTaiizor.Controls.Button();
            panel10 = new Panel();
            button5 = new ReaLTaiizor.Controls.Button();
            panel6 = new Panel();
            button4 = new ReaLTaiizor.Controls.Button();
            panel4 = new Panel();
            button3 = new ReaLTaiizor.Controls.Button();
            panel3 = new Panel();
            btnLogOut = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel11.SuspendLayout();
            panel10.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 2);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 22);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(metroControlBox3);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1124, 24);
            panel1.TabIndex = 2;
            // 
            // metroControlBox3
            // 
            metroControlBox3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            metroControlBox3.CloseHoverBackColor = Color.FromArgb(183, 40, 40);
            metroControlBox3.CloseHoverForeColor = Color.White;
            metroControlBox3.CloseNormalForeColor = Color.Gray;
            metroControlBox3.DefaultLocation = ReaLTaiizor.Enum.Metro.LocationType.Normal;
            metroControlBox3.DisabledForeColor = Color.DimGray;
            metroControlBox3.IsDerivedStyle = true;
            metroControlBox3.Location = new Point(1024, -3);
            metroControlBox3.Margin = new Padding(3, 2, 3, 2);
            metroControlBox3.MaximizeBox = true;
            metroControlBox3.MaximizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MaximizeHoverForeColor = Color.Gray;
            metroControlBox3.MaximizeNormalForeColor = Color.Gray;
            metroControlBox3.MinimizeBox = true;
            metroControlBox3.MinimizeHoverBackColor = Color.FromArgb(238, 238, 238);
            metroControlBox3.MinimizeHoverForeColor = Color.Gray;
            metroControlBox3.MinimizeNormalForeColor = Color.Gray;
            metroControlBox3.Name = "metroControlBox3";
            metroControlBox3.Size = new Size(100, 25);
            metroControlBox3.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            metroControlBox3.StyleManager = null;
            metroControlBox3.TabIndex = 5;
            metroControlBox3.Text = "metroControlBox3";
            metroControlBox3.ThemeAuthor = "Taiizor";
            metroControlBox3.ThemeName = "MetroLight";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(64, 64, 64);
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel11);
            flowLayoutPanel1.Controls.Add(panel10);
            flowLayoutPanel1.Controls.Add(panel6);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 24);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(0, 22, 0, 0);
            flowLayoutPanel1.Size = new Size(42, 474);
            flowLayoutPanel1.TabIndex = 7;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Location = new Point(3, 24);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(242, 60);
            panel2.TabIndex = 5;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.FromArgb(32, 34, 37);
            button1.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button1.EnteredColor = Color.FromArgb(32, 38, 39);
            button1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.FromArgb(64, 64, 64);
            button1.Location = new Point(-1, -12);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button1.PressedColor = Color.FromArgb(165, 37, 37);
            button1.Size = new Size(185, 84);
            button1.TabIndex = 15;
            button1.Text = "Dashboard";
            button1.TextAlignment = StringAlignment.Center;
            // 
            // panel11
            // 
            panel11.Controls.Add(button6);
            panel11.Location = new Point(3, 88);
            panel11.Margin = new Padding(3, 2, 3, 2);
            panel11.Name = "panel11";
            panel11.Size = new Size(242, 60);
            panel11.TabIndex = 5;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BorderColor = Color.FromArgb(32, 34, 37);
            button6.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button6.EnteredColor = Color.FromArgb(32, 38, 39);
            button6.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.InactiveColor = Color.FromArgb(64, 64, 64);
            button6.Location = new Point(-1, -12);
            button6.Name = "button6";
            button6.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button6.PressedColor = Color.FromArgb(165, 37, 37);
            button6.Size = new Size(185, 84);
            button6.TabIndex = 15;
            button6.Text = "Post Job";
            button6.TextAlignment = StringAlignment.Center;
            // 
            // panel10
            // 
            panel10.Controls.Add(button5);
            panel10.Location = new Point(3, 152);
            panel10.Margin = new Padding(3, 2, 3, 2);
            panel10.Name = "panel10";
            panel10.Size = new Size(242, 60);
            panel10.TabIndex = 5;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BorderColor = Color.FromArgb(32, 34, 37);
            button5.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button5.EnteredColor = Color.FromArgb(32, 38, 39);
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.InactiveColor = Color.FromArgb(64, 64, 64);
            button5.Location = new Point(-1, -10);
            button5.Name = "button5";
            button5.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button5.PressedColor = Color.FromArgb(165, 37, 37);
            button5.Size = new Size(185, 84);
            button5.TabIndex = 15;
            button5.Text = "Edit Jobs Info";
            button5.TextAlignment = StringAlignment.Center;
            // 
            // panel6
            // 
            panel6.Controls.Add(button4);
            panel6.Location = new Point(3, 216);
            panel6.Margin = new Padding(3, 2, 3, 2);
            panel6.Name = "panel6";
            panel6.Size = new Size(242, 60);
            panel6.TabIndex = 5;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BorderColor = Color.FromArgb(32, 34, 37);
            button4.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button4.EnteredColor = Color.FromArgb(32, 38, 39);
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.InactiveColor = Color.FromArgb(64, 64, 64);
            button4.Location = new Point(-1, -11);
            button4.Name = "button4";
            button4.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button4.PressedColor = Color.FromArgb(165, 37, 37);
            button4.Size = new Size(187, 84);
            button4.TabIndex = 15;
            button4.Text = "Applicants";
            button4.TextAlignment = StringAlignment.Center;
            // 
            // panel4
            // 
            panel4.Controls.Add(button3);
            panel4.Location = new Point(3, 280);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(242, 60);
            panel4.TabIndex = 5;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BorderColor = Color.FromArgb(32, 34, 37);
            button3.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            button3.EnteredColor = Color.FromArgb(32, 38, 39);
            button3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.InactiveColor = Color.FromArgb(64, 64, 64);
            button3.Location = new Point(-1, -10);
            button3.Name = "button3";
            button3.PressedBorderColor = Color.FromArgb(165, 37, 37);
            button3.PressedColor = Color.FromArgb(165, 37, 37);
            button3.Size = new Size(187, 84);
            button3.TabIndex = 15;
            button3.Text = "Profile Setting";
            button3.TextAlignment = StringAlignment.Center;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnLogOut);
            panel3.Location = new Point(3, 344);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(242, 60);
            panel3.TabIndex = 5;
            // 
            // btnLogOut
            // 
            btnLogOut.BackColor = Color.Transparent;
            btnLogOut.BorderColor = Color.FromArgb(32, 34, 37);
            btnLogOut.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            btnLogOut.EnteredColor = Color.FromArgb(32, 38, 39);
            btnLogOut.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogOut.Image = (Image)resources.GetObject("btnLogOut.Image");
            btnLogOut.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogOut.InactiveColor = Color.FromArgb(64, 64, 64);
            btnLogOut.Location = new Point(-1, -9);
            btnLogOut.Name = "btnLogOut";
            btnLogOut.PressedBorderColor = Color.FromArgb(165, 37, 37);
            btnLogOut.PressedColor = Color.FromArgb(165, 37, 37);
            btnLogOut.Size = new Size(187, 84);
            btnLogOut.TabIndex = 15;
            btnLogOut.Text = "Log Out";
            btnLogOut.TextAlignment = StringAlignment.Center;
            btnLogOut.Click += btnLogOut_Click;
            // 
            // FCompany
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 41, 50);
            ClientSize = new Size(1124, 498);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FCompany";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FCompany";
            Load += FCompany_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel11.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox1;
        private Panel panel1;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox2;
        private ReaLTaiizor.Controls.MetroControlBox metroControlBox3;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel2;
        private ReaLTaiizor.Controls.Button button1;
        private Panel panel11;
        private ReaLTaiizor.Controls.Button button6;
        private Panel panel10;
        private ReaLTaiizor.Controls.Button button5;
        private Panel panel6;
        private ReaLTaiizor.Controls.Button button4;
        private Panel panel4;
        private ReaLTaiizor.Controls.Button button3;
        private Panel panel3;
        private ReaLTaiizor.Controls.Button btnLogOut;
    }
}
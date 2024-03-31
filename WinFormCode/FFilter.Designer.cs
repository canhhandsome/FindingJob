namespace WinFormProject
{
    partial class FFilter
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
            pnHeader = new Panel();
            lblFilter = new Label();
            pnFooter = new Panel();
            btnApply = new ReaLTaiizor.Controls.ParrotButton();
            label1 = new Label();
            pnBody = new Panel();
            panel1 = new Panel();
            btnRemote = new Button();
            btnAtOffice = new Button();
            btnHybrid = new Button();
            pnType = new Panel();
            btnHeadHunter = new Button();
            btnOutsource = new Button();
            btnProduct = new Button();
            btnNonIT = new Button();
            btnServices = new Button();
            pnLevel = new Panel();
            btnJunior = new Button();
            btnFresher = new Button();
            btnSenior = new Button();
            btnIntern = new Button();
            tbFrom = new TrackBar();
            lblSalaryRange = new Label();
            lblWorkForm = new Label();
            lblTypeCompany = new Label();
            lblSalary = new Label();
            lblLevel = new Label();
            tbTo = new TrackBar();
            pnHeader.SuspendLayout();
            pnFooter.SuspendLayout();
            pnBody.SuspendLayout();
            panel1.SuspendLayout();
            pnType.SuspendLayout();
            pnLevel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tbFrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tbTo).BeginInit();
            SuspendLayout();
            // 
            // pnHeader
            // 
            pnHeader.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnHeader.BorderStyle = BorderStyle.FixedSingle;
            pnHeader.Controls.Add(lblFilter);
            pnHeader.Dock = DockStyle.Top;
            pnHeader.Location = new Point(0, 0);
            pnHeader.Name = "pnHeader";
            pnHeader.Size = new Size(786, 77);
            pnHeader.TabIndex = 0;
            // 
            // lblFilter
            // 
            lblFilter.AutoSize = true;
            lblFilter.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblFilter.Location = new Point(28, 21);
            lblFilter.Name = "lblFilter";
            lblFilter.Size = new Size(72, 32);
            lblFilter.TabIndex = 1;
            lblFilter.Text = "Filter";
            // 
            // pnFooter
            // 
            pnFooter.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnFooter.BorderStyle = BorderStyle.FixedSingle;
            pnFooter.Controls.Add(btnApply);
            pnFooter.Controls.Add(label1);
            pnFooter.Dock = DockStyle.Bottom;
            pnFooter.Location = new Point(0, 622);
            pnFooter.Name = "pnFooter";
            pnFooter.Size = new Size(786, 68);
            pnFooter.TabIndex = 1;
            // 
            // btnApply
            // 
            btnApply.BackgroundColor = Color.FromArgb(248, 212, 187);
            btnApply.ButtonImage = null;
            btnApply.ButtonStyle = ReaLTaiizor.Controls.ParrotButton.Style.MaterialRounded;
            btnApply.ButtonText = "Apply";
            btnApply.ClickBackColor = Color.FromArgb(255, 212, 180);
            btnApply.ClickTextColor = Color.Black;
            btnApply.CornerRadius = 6;
            btnApply.Cursor = Cursors.Hand;
            btnApply.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnApply.Horizontal_Alignment = StringAlignment.Center;
            btnApply.HoverBackgroundColor = Color.FromArgb(248, 242, 197);
            btnApply.HoverTextColor = Color.Black;
            btnApply.ImagePosition = ReaLTaiizor.Controls.ParrotButton.ImgPosition.Left;
            btnApply.Location = new Point(613, 15);
            btnApply.Name = "btnApply";
            btnApply.Size = new Size(131, 38);
            btnApply.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnApply.TabIndex = 35;
            btnApply.TextColor = Color.Black;
            btnApply.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnApply.Vertical_Alignment = StringAlignment.Center;
            btnApply.Click += btnApply_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(28, 20);
            label1.Name = "label1";
            label1.Size = new Size(135, 25);
            label1.TabIndex = 1;
            label1.Text = "Working Form";
            // 
            // pnBody
            // 
            pnBody.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            pnBody.BorderStyle = BorderStyle.FixedSingle;
            pnBody.Controls.Add(panel1);
            pnBody.Controls.Add(pnType);
            pnBody.Controls.Add(pnLevel);
            pnBody.Controls.Add(tbFrom);
            pnBody.Controls.Add(lblSalaryRange);
            pnBody.Controls.Add(lblWorkForm);
            pnBody.Controls.Add(lblTypeCompany);
            pnBody.Controls.Add(lblSalary);
            pnBody.Controls.Add(lblLevel);
            pnBody.Controls.Add(tbTo);
            pnBody.Dock = DockStyle.Fill;
            pnBody.Location = new Point(0, 77);
            pnBody.Name = "pnBody";
            pnBody.Size = new Size(786, 545);
            pnBody.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnRemote);
            panel1.Controls.Add(btnAtOffice);
            panel1.Controls.Add(btnHybrid);
            panel1.Location = new Point(29, 436);
            panel1.Name = "panel1";
            panel1.Size = new Size(524, 80);
            panel1.TabIndex = 41;
            // 
            // btnRemote
            // 
            btnRemote.BackColor = Color.Transparent;
            btnRemote.FlatStyle = FlatStyle.Flat;
            btnRemote.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnRemote.Image = Properties.Resources.plus;
            btnRemote.ImageAlign = ContentAlignment.MiddleRight;
            btnRemote.Location = new Point(159, 17);
            btnRemote.Name = "btnRemote";
            btnRemote.Size = new Size(110, 38);
            btnRemote.TabIndex = 36;
            btnRemote.Text = "Remote";
            btnRemote.TextAlign = ContentAlignment.MiddleLeft;
            btnRemote.UseVisualStyleBackColor = false;
            // 
            // btnAtOffice
            // 
            btnAtOffice.BackColor = Color.Transparent;
            btnAtOffice.FlatStyle = FlatStyle.Flat;
            btnAtOffice.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnAtOffice.Image = Properties.Resources.plus;
            btnAtOffice.ImageAlign = ContentAlignment.MiddleRight;
            btnAtOffice.Location = new Point(3, 17);
            btnAtOffice.Name = "btnAtOffice";
            btnAtOffice.Size = new Size(115, 38);
            btnAtOffice.TabIndex = 36;
            btnAtOffice.Text = "At office";
            btnAtOffice.TextAlign = ContentAlignment.MiddleLeft;
            btnAtOffice.UseVisualStyleBackColor = false;
            // 
            // btnHybrid
            // 
            btnHybrid.BackColor = Color.Transparent;
            btnHybrid.FlatStyle = FlatStyle.Flat;
            btnHybrid.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHybrid.Image = Properties.Resources.plus;
            btnHybrid.ImageAlign = ContentAlignment.MiddleRight;
            btnHybrid.Location = new Point(310, 17);
            btnHybrid.Name = "btnHybrid";
            btnHybrid.Size = new Size(101, 38);
            btnHybrid.TabIndex = 36;
            btnHybrid.Text = "Hybrid";
            btnHybrid.TextAlign = ContentAlignment.MiddleLeft;
            btnHybrid.UseVisualStyleBackColor = false;
            // 
            // pnType
            // 
            pnType.Controls.Add(btnHeadHunter);
            pnType.Controls.Add(btnOutsource);
            pnType.Controls.Add(btnProduct);
            pnType.Controls.Add(btnNonIT);
            pnType.Controls.Add(btnServices);
            pnType.Location = new Point(28, 271);
            pnType.Name = "pnType";
            pnType.Size = new Size(654, 123);
            pnType.TabIndex = 40;
            // 
            // btnHeadHunter
            // 
            btnHeadHunter.BackColor = Color.Transparent;
            btnHeadHunter.FlatStyle = FlatStyle.Flat;
            btnHeadHunter.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnHeadHunter.Image = Properties.Resources.plus;
            btnHeadHunter.ImageAlign = ContentAlignment.MiddleRight;
            btnHeadHunter.Location = new Point(322, 3);
            btnHeadHunter.Name = "btnHeadHunter";
            btnHeadHunter.Size = new Size(146, 38);
            btnHeadHunter.TabIndex = 36;
            btnHeadHunter.Text = "HeadHunter";
            btnHeadHunter.TextAlign = ContentAlignment.MiddleLeft;
            btnHeadHunter.UseVisualStyleBackColor = false;
            // 
            // btnOutsource
            // 
            btnOutsource.BackColor = Color.Transparent;
            btnOutsource.FlatStyle = FlatStyle.Flat;
            btnOutsource.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnOutsource.Image = Properties.Resources.plus;
            btnOutsource.ImageAlign = ContentAlignment.MiddleRight;
            btnOutsource.Location = new Point(4, 3);
            btnOutsource.Name = "btnOutsource";
            btnOutsource.Size = new Size(134, 38);
            btnOutsource.TabIndex = 36;
            btnOutsource.Text = "Outsource";
            btnOutsource.TextAlign = ContentAlignment.MiddleLeft;
            btnOutsource.UseVisualStyleBackColor = false;
            // 
            // btnProduct
            // 
            btnProduct.BackColor = Color.Transparent;
            btnProduct.FlatStyle = FlatStyle.Flat;
            btnProduct.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnProduct.Image = Properties.Resources.plus;
            btnProduct.ImageAlign = ContentAlignment.MiddleRight;
            btnProduct.Location = new Point(172, 3);
            btnProduct.Name = "btnProduct";
            btnProduct.Size = new Size(111, 38);
            btnProduct.TabIndex = 36;
            btnProduct.Text = "Product";
            btnProduct.TextAlign = ContentAlignment.MiddleLeft;
            btnProduct.UseVisualStyleBackColor = false;
            // 
            // btnNonIT
            // 
            btnNonIT.BackColor = Color.Transparent;
            btnNonIT.FlatStyle = FlatStyle.Flat;
            btnNonIT.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnNonIT.Image = Properties.Resources.plus;
            btnNonIT.ImageAlign = ContentAlignment.MiddleRight;
            btnNonIT.Location = new Point(505, 3);
            btnNonIT.Name = "btnNonIT";
            btnNonIT.Size = new Size(121, 38);
            btnNonIT.TabIndex = 36;
            btnNonIT.Text = "Non - IT";
            btnNonIT.TextAlign = ContentAlignment.MiddleLeft;
            btnNonIT.UseVisualStyleBackColor = false;
            // 
            // btnServices
            // 
            btnServices.BackColor = Color.Transparent;
            btnServices.FlatStyle = FlatStyle.Flat;
            btnServices.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnServices.Image = Properties.Resources.plus;
            btnServices.ImageAlign = ContentAlignment.MiddleRight;
            btnServices.Location = new Point(4, 68);
            btnServices.Name = "btnServices";
            btnServices.Size = new Size(331, 38);
            btnServices.TabIndex = 36;
            btnServices.Text = "Services and Consulting solutions";
            btnServices.TextAlign = ContentAlignment.MiddleLeft;
            btnServices.UseVisualStyleBackColor = false;
            // 
            // pnLevel
            // 
            pnLevel.Controls.Add(btnJunior);
            pnLevel.Controls.Add(btnFresher);
            pnLevel.Controls.Add(btnSenior);
            pnLevel.Controls.Add(btnIntern);
            pnLevel.Location = new Point(29, 60);
            pnLevel.Name = "pnLevel";
            pnLevel.Size = new Size(622, 72);
            pnLevel.TabIndex = 40;
            // 
            // btnJunior
            // 
            btnJunior.BackColor = Color.Transparent;
            btnJunior.FlatStyle = FlatStyle.Flat;
            btnJunior.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnJunior.Image = Properties.Resources.plus;
            btnJunior.ImageAlign = ContentAlignment.MiddleRight;
            btnJunior.Location = new Point(146, 16);
            btnJunior.Name = "btnJunior";
            btnJunior.Size = new Size(98, 38);
            btnJunior.TabIndex = 36;
            btnJunior.Text = "Junior";
            btnJunior.TextAlign = ContentAlignment.MiddleLeft;
            btnJunior.UseVisualStyleBackColor = false;
            // 
            // btnFresher
            // 
            btnFresher.BackColor = Color.Transparent;
            btnFresher.FlatStyle = FlatStyle.Flat;
            btnFresher.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnFresher.Image = Properties.Resources.plus;
            btnFresher.ImageAlign = ContentAlignment.MiddleRight;
            btnFresher.Location = new Point(3, 16);
            btnFresher.Name = "btnFresher";
            btnFresher.Size = new Size(108, 38);
            btnFresher.TabIndex = 36;
            btnFresher.Text = "Fresher";
            btnFresher.TextAlign = ContentAlignment.MiddleLeft;
            btnFresher.UseVisualStyleBackColor = false;
            // 
            // btnSenior
            // 
            btnSenior.BackColor = Color.Transparent;
            btnSenior.FlatStyle = FlatStyle.Flat;
            btnSenior.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSenior.Image = Properties.Resources.plus;
            btnSenior.ImageAlign = ContentAlignment.MiddleRight;
            btnSenior.Location = new Point(280, 16);
            btnSenior.Name = "btnSenior";
            btnSenior.Size = new Size(101, 38);
            btnSenior.TabIndex = 36;
            btnSenior.Text = "Senior";
            btnSenior.TextAlign = ContentAlignment.MiddleLeft;
            btnSenior.UseVisualStyleBackColor = false;
            // 
            // btnIntern
            // 
            btnIntern.BackColor = Color.Transparent;
            btnIntern.FlatStyle = FlatStyle.Flat;
            btnIntern.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnIntern.Image = Properties.Resources.plus;
            btnIntern.ImageAlign = ContentAlignment.MiddleRight;
            btnIntern.Location = new Point(423, 16);
            btnIntern.Name = "btnIntern";
            btnIntern.Size = new Size(90, 38);
            btnIntern.TabIndex = 36;
            btnIntern.Text = "Intern";
            btnIntern.TextAlign = ContentAlignment.MiddleLeft;
            btnIntern.UseVisualStyleBackColor = false;
            // 
            // tbFrom
            // 
            tbFrom.LargeChange = 100;
            tbFrom.Location = new Point(222, 174);
            tbFrom.Name = "tbFrom";
            tbFrom.Size = new Size(218, 45);
            tbFrom.TabIndex = 39;
            tbFrom.TickFrequency = 2;
            tbFrom.Scroll += trackBar3_Scroll;
            // 
            // lblSalaryRange
            // 
            lblSalaryRange.AutoSize = true;
            lblSalaryRange.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblSalaryRange.Location = new Point(29, 176);
            lblSalaryRange.Name = "lblSalaryRange";
            lblSalaryRange.Size = new Size(115, 21);
            lblSalaryRange.TabIndex = 1;
            lblSalaryRange.Text = "$500 - $10,000";
            // 
            // lblWorkForm
            // 
            lblWorkForm.AutoSize = true;
            lblWorkForm.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblWorkForm.Location = new Point(28, 408);
            lblWorkForm.Name = "lblWorkForm";
            lblWorkForm.Size = new Size(135, 25);
            lblWorkForm.TabIndex = 1;
            lblWorkForm.Text = "Working Form";
            // 
            // lblTypeCompany
            // 
            lblTypeCompany.AutoSize = true;
            lblTypeCompany.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblTypeCompany.Location = new Point(29, 232);
            lblTypeCompany.Name = "lblTypeCompany";
            lblTypeCompany.Size = new Size(139, 25);
            lblTypeCompany.TabIndex = 1;
            lblTypeCompany.Text = "Type Company";
            // 
            // lblSalary
            // 
            lblSalary.AutoSize = true;
            lblSalary.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblSalary.Location = new Point(29, 135);
            lblSalary.Name = "lblSalary";
            lblSalary.Size = new Size(65, 25);
            lblSalary.TabIndex = 1;
            lblSalary.Text = "Salary";
            // 
            // lblLevel
            // 
            lblLevel.AutoSize = true;
            lblLevel.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblLevel.Location = new Point(29, 29);
            lblLevel.Name = "lblLevel";
            lblLevel.Size = new Size(56, 25);
            lblLevel.TabIndex = 1;
            lblLevel.Text = "Level";
            // 
            // tbTo
            // 
            tbTo.LargeChange = 100;
            tbTo.Location = new Point(433, 174);
            tbTo.Name = "tbTo";
            tbTo.Size = new Size(218, 45);
            tbTo.TabIndex = 39;
            tbTo.TickFrequency = 2;
            tbTo.Value = 10;
            tbTo.Scroll += trackBar4_Scroll;
            // 
            // FFilter
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(254, 232, 223);
            ClientSize = new Size(786, 690);
            Controls.Add(pnBody);
            Controls.Add(pnFooter);
            Controls.Add(pnHeader);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FFilter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FFilter";
            pnHeader.ResumeLayout(false);
            pnHeader.PerformLayout();
            pnFooter.ResumeLayout(false);
            pnFooter.PerformLayout();
            pnBody.ResumeLayout(false);
            pnBody.PerformLayout();
            panel1.ResumeLayout(false);
            pnType.ResumeLayout(false);
            pnLevel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tbFrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)tbTo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnHeader;
        private Label lblFilter;
        private Panel pnFooter;
        private Panel pnBody;
        private ReaLTaiizor.Controls.AirButton airButton1;
        private ReaLTaiizor.Controls.ParrotButton btnApply;
        private Label lblWorkForm;
        private Label lblTypeCompany;
        private Label lblSalary;
        private Label lblLevel;
        private Button btnFresher;
        private Label label1;
        private Button btnIntern;
        private Button btnSenior;
        private Button btnJunior;
        private TrackBar tbFrom;
        private TrackBar tbTo;
        private Label lblSalaryRange;
        private Button btnNonIT;
        private Button btnHeadHunter;
        private Button btnProduct;
        private Button btnOutsource;
        private Button btnServices;
        private Button btnHybrid;
        private Button btnRemote;
        private Button btnAtOffice;
        private Panel pnType;
        private Panel pnLevel;
        private Panel panel1;
    }
}
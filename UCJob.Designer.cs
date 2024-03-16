namespace WinFormProject
{
    partial class UCJob
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
            panel1 = new Panel();
            lblDTemplate = new Label();
            lblJBTemplate = new Label();
            lblDate = new Label();
            lblJobName = new Label();
            btnDelete = new Button();
            btnEdit = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(lblDTemplate);
            panel1.Controls.Add(lblJBTemplate);
            panel1.Controls.Add(lblDate);
            panel1.Controls.Add(lblJobName);
            panel1.Controls.Add(btnDelete);
            panel1.Controls.Add(btnEdit);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(812, 212);
            panel1.TabIndex = 0;
            // 
            // lblDTemplate
            // 
            lblDTemplate.AutoSize = true;
            lblDTemplate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDTemplate.Location = new Point(92, 74);
            lblDTemplate.Name = "lblDTemplate";
            lblDTemplate.Size = new Size(69, 32);
            lblDTemplate.TabIndex = 9;
            lblDTemplate.Text = "Date:";
            // 
            // lblJBTemplate
            // 
            lblJBTemplate.AutoSize = true;
            lblJBTemplate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblJBTemplate.Location = new Point(150, 15);
            lblJBTemplate.Name = "lblJBTemplate";
            lblJBTemplate.Size = new Size(127, 32);
            lblJBTemplate.TabIndex = 8;
            lblJBTemplate.Text = "Job Name:";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblDate.Location = new Point(17, 74);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(69, 32);
            lblDate.TabIndex = 7;
            lblDate.Text = "Date:";
            // 
            // lblJobName
            // 
            lblJobName.AutoSize = true;
            lblJobName.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblJobName.Location = new Point(17, 15);
            lblJobName.Name = "lblJobName";
            lblJobName.Size = new Size(127, 32);
            lblJobName.TabIndex = 6;
            lblJobName.Text = "Job Name:";
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.RosyBrown;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ControlText;
            btnDelete.Location = new Point(555, 151);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(112, 44);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnEdit
            // 
            btnEdit.FlatStyle = FlatStyle.Flat;
            btnEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnEdit.ForeColor = SystemColors.ControlText;
            btnEdit.Location = new Point(683, 151);
            btnEdit.Margin = new Padding(3, 4, 3, 4);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(112, 44);
            btnEdit.TabIndex = 4;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            // 
            // UCJob
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCJob";
            Size = new Size(812, 212);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        public Button btnDelete;
        public Button btnEdit;
        private Label lblJobName;
        public Label lblDTemplate;
        public Label lblJBTemplate;
        private Label lblDate;
    }
}

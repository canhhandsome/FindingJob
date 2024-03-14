using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject
{
    public partial class FJobRequire : Form
    {
        private int locaX = 60;
        private int locaY;
        private static int countRequir = 0;
        private Form currentFormChild = new Form();
        public FJobRequire()
        {
            InitializeComponent();
        }

        public Label Label1
        {
            set {label1.Text = value.ToString();}
        }
        
        private void AddRequirement()
        {
            countRequir++;
            Label label = new Label();
            ReaLTaiizor.Controls.HopeTextBox hopeTextBox = new ReaLTaiizor.Controls.HopeTextBox();
            pnJobRequirement.Controls.Add(label);
            pnJobRequirement.Controls.Add(hopeTextBox);
            label.Text = $"Requirement {countRequir.ToString()}";
            label.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label.ForeColor = SystemColors.ButtonHighlight;
            locaY += 10;
            label.Location = new Point(locaX, locaY);
            hopeTextBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            hopeTextBox.Hint = "Enter Requirement";
            hopeTextBox.Size = new Size(675, 38);
            locaY += 35;
            hopeTextBox.Location = new Point(locaX, locaY);
            label.Visible = true;
            hopeTextBox.Visible = true;
            locaY += 40;
        }

        private void btnAddRequire_Click(object sender, EventArgs e)
        {
            AddRequirement();
        }

        private void OpenChildForm(Form childForm)
        {
            foreach (Control control in this.Controls)
            {
                if (control == pnBody)
                    continue;
                control.Visible = false;
            }
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            pnBody.BackColor = Color.FromArgb(32, 41, 58);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FJobEdit());
        }
    }
}

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
    public partial class FPostJob : Form
    {
        private Form currentFormChild;
        private int locaX = 62;
        private int locaY = 0;
        public FPostJob()
        {
            InitializeComponent();
        }

        private void PostJob_Load(object sender, EventArgs e)
        {
        }

        private void AddJob()
        {
            Panel panel = new Panel();
            panel.Size = new Size(812, 80);
            panel.BorderStyle = BorderStyle.Fixed3D;
            panel.Visible = true;
            locaY += 100;
            panel.Location = new Point(locaX, locaY);
            Label lbl = new Label();
            panel.Controls.Add(lbl);
            lbl.Visible = true;
            lbl.Location = new Point(17, 13);
            lbl.Text = "Job Description";
            panel.BringToFront();
            Controls.Add(panel);
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

        private void btnPostingJob_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FJobEdit());
        }

        private void pnBody_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

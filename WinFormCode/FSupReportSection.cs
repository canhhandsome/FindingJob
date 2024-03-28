using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FSupReportSection : Form
    {
        private Form currentFormChild = new Form();
        public Panel panel = new Panel();
        public FSupReportSection(Panel panel)
        {
            InitializeComponent();
            this.panel = panel;
            foreach (Control control in this.Controls)
            {
                if (control is Panel)
                {
                    Panel panel2 = (Panel)control;
                    panel2.Click += panel1_Click;
                }
            }
        }
        public void OpenChildForm(Panel panel, Form childForm)
        {
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel.Controls.Add(childForm);
            panel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void panel1_Click(object sender, EventArgs e)
        {
            OpenChildForm(panel, new FReportDetail());
        }

    }
}

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
    public partial class FJobEdit : Form
    {
        private Form currentFormChild = new Form();
        private FPostJob fPostJob;

        public FJobEdit()
        {
            InitializeComponent();
            fPostJob = new FPostJob();
        }
        public string LblTitle
        {
            get { return lblTitle.Text; }
            set { lblTitle.Text = value; }
        }
        public string BtnPostJob
        {
            get { return btnPostJob.Text; }
            set { btnPostJob.Text = value; }
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

        private void btnJobRequire_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FJobRequire());
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FPostJob());
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            //fPostJob.JobName = txtJobName.Text;
            //OpenChildForm(fPostJob);
            //fPostJob.AddJob();
            fPostJob.AddJob(txtJobName.Text);
            OpenChildForm(fPostJob);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}

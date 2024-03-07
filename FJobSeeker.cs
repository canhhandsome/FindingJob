using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace WinFormProject
{
    public partial class FJobSeeker : Form
    {
        private Form currentFormChild = new Form();
        private Button selectedButton;

        public FJobSeeker()
        {
            InitializeComponent();
        }

        private void FJobSeeker_Load(object sender, EventArgs e)
        {
            GetAllButtons(panel2);
        }
        void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Click += button_Click;
                    if (button == btnLogOut)
                    {
                        button.Click += btnLogOut_Click_1;
                    }
                }
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton == selectedButton)
                return;

            if (selectedButton != null)
            {
                selectedButton.BackColor = Color.FromArgb(64, 64, 64);
                selectedButton.Enabled = true;
            }

            clickedButton.BackColor = Color.LightGray;
            clickedButton.Enabled = false;
            selectedButton = clickedButton;
        }

        private void OpenChildForm(Panel panel, Form childForm)
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

        private void btnJobAlert_Click(object sender, EventArgs e)
        {
            pnBody.Visible = true;
            pnSubBody.Visible = true;
            panel3.Visible = false;
            FSupJobSection fSupJobSection = new FSupJobSection();
            OpenChildForm(pnSubBody, fSupJobSection);
            FJobDetails fJobDetails = new FJobDetails();
            OpenChildForm(pnBody, fJobDetails);
        }

        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            pnBody.Visible = true;
            pnSubBody.Visible = false;
            pnBody.Dock = DockStyle.Fill;
            pnBody.BringToFront();
            FSearchJob fSearchJob = new FSearchJob();
            OpenChildForm(pnBody, fSearchJob);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            pnBody.Visible = false;
            pnSubBody.Visible = false;
            Panel panel = new Panel();
            this.Controls.Add(panel);
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
            FProfile fProfile = new FProfile();
            OpenChildForm(panel, fProfile);
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure to log out?", "Alert!!!", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                MessageBox.Show("Thank you for using our service!\nGoodbye and See you again");
                this.Hide();
                FLogin fLogin = new FLogin();
                fLogin.Closed += (s, args) => this.Close();
                fLogin.Show();
            }
            else if (dialogResult == DialogResult.No)
            {
                selectedButton.BackColor = Color.FromArgb(64, 64, 64);
                selectedButton.Enabled = true;
            }
        }
    }
}

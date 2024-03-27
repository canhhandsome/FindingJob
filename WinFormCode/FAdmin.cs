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
    public partial class FAdmin : Form
    {
        private Form currentFormChild = new Form();
        private Button selectedButton;

        public FAdmin()
        {
            InitializeComponent();
        }
        private void FAdmin_Load(object sender, EventArgs e)
        {
            GetAllButtons(panel2);
        }
        private void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Button)
                {
                    Button button = (Button)c;
                    button.Click += button_Click;
                    if (button == btnLogOut)
                    {
                        button.Click += btnLogOut_Click;
                    }
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
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
            childForm.Show(); ;
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            pnBody.Visible = true;
            pnBody.Dock = DockStyle.Fill;
            pnBody.BringToFront();
            FManageUser fManageUser = new FManageUser();
            OpenChildForm(pnBody, fManageUser);
        }

        private void btnJobListing_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            pnBody.Visible = true;
            //FSupJobSection fSupJobSection = new FSupJobSection(pnBody);
            //OpenChildForm(pnBody, fSupJobSection);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            pnBody.Controls.Clear();
            pnBody.Visible = true;
            FSupReportSection fSupReportSection = new FSupReportSection(pnBody);
            OpenChildForm(pnBody, fSupReportSection);
        }
    }
}

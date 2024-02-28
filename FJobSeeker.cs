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
                        button.Click += btnLogOut_Click;
                    }
                }
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!\nGoodbye and See you again");
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
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

            clickedButton.BackColor = Color.FromArgb(90, 48, 52);
            clickedButton.Enabled = false;
            selectedButton = clickedButton;
        }

        private void OpenChildForm(Panel panel, Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
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
            FSupJobSection fSupJobSection = new FSupJobSection();
            OpenChildForm(pnSubBody, fSupJobSection);
        }
    }
}

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
    public partial class FCompany : Form
    {
        private ReaLTaiizor.Controls.ParrotButton selectedButton;
        private Form currentFormChild;
        private Account account;
        private Company company = new Company();
        InformationDAO informationDAO = new InformationDAO();
        public FCompany(Account account)
        {
            InitializeComponent();
            this.account = account;
            //btnPostJob.PerformClick();
            company = new Company(informationDAO.FetchCommon(account));
            GetAllButtons(panel2);
        }


        void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is ReaLTaiizor.Controls.ParrotButton)
                {
                    ReaLTaiizor.Controls.ParrotButton button = (ReaLTaiizor.Controls.ParrotButton)c;
                    button.Click += button_Click;
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
            ReaLTaiizor.Controls.ParrotButton clickedButton = (ReaLTaiizor.Controls.ParrotButton)sender;

            if (clickedButton == selectedButton)
                return;

            if (selectedButton != null)
            {
                selectedButton.BackgroundColor = Color.FromArgb(236, 247, 251);
                selectedButton.Enabled = true;
            }

            clickedButton.BackgroundColor = Color.White;
            clickedButton.Enabled = false;
            selectedButton = clickedButton;
        }

        private void OpenChildForm(Form childForm)
        {
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
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnPostJob_Click(object sender, EventArgs e)
        {
            company = new Company(informationDAO.FetchCommon(account));
            OpenChildForm(new FPostJob(company.Jobs, company.INFO.ID));
        }
        private void btnSetting_Click(object sender, EventArgs e)
        {
            company = new Company(informationDAO.FetchCommon(account));
            OpenChildForm(new FProfileCompany(company));
        }

    }
}
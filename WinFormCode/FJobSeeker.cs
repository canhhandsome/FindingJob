﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;

namespace WinFormProject
{
    public partial class FJobSeeker : Form
    {
        private Form currentFormChild = new Form();
        private Guna.UI2.WinForms.Guna2Button selectedButton;
        private Information information = new Information();
        private JobSeeker jobSeeker = new JobSeeker();
        InformationDAO informationDAO = new InformationDAO();
        private Account account = new Account();

        public FJobSeeker(Account account)
        {
            InitializeComponent();
            this.account = account;
        }

        private void FJobSeeker_Load(object sender, EventArgs e)
        {
            GetAllButtons(panel2);
        }
        void GetAllButtons(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is Guna.UI2.WinForms.Guna2Button)
                {
                    Guna.UI2.WinForms.Guna2Button button = (Guna.UI2.WinForms.Guna2Button)c;
                    button.Click += button_Click;
                }
            }
        }


        private void button_Click(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2Button clickedButton = (Guna.UI2.WinForms.Guna2Button)sender;

            if (clickedButton == selectedButton)
                return;

            if (selectedButton != null)
            {
                selectedButton.FillColor = Color.Transparent;
                selectedButton.Font = new Font("Cooper Black", 12f);
                selectedButton.ForeColor = Color.White;
                selectedButton.Enabled = true;
            }

            clickedButton.FillColor = Color.FromArgb(220, 251, 251);
            clickedButton.Font = new Font("Cooper Black", 16.2f);
            clickedButton.ForeColor = Color.Black;
            //clickedButton.Enabled = false;
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
            jobSeeker = new JobSeeker(informationDAO.FetchCommon(account));
            pnBody.Controls.Clear();
            pnBody.Visible = true;
            FAlert fSupJobSection = new FAlert(jobSeeker);
            OpenChildForm(pnBody, fSupJobSection);
        }

        private void btnSearchJob_Click(object sender, EventArgs e)
        {
            jobSeeker = new JobSeeker(informationDAO.FetchCommon(account));
            pnBody.Visible = true;
            pnBody.Dock = DockStyle.Fill;
            pnBody.BringToFront();
            FSearchJob fSearchJob = new FSearchJob(jobSeeker.INFO.ID);
            OpenChildForm(pnBody, fSearchJob);
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            jobSeeker = new JobSeeker(informationDAO.FetchCommon(account));
            pnBody.Visible = true;
            pnBody.Dock = DockStyle.Fill;
            pnBody.BringToFront();
            FProfile fProfile = new FProfile(jobSeeker);
            OpenChildForm(pnBody, fProfile);
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
                selectedButton.BackColor = Color.Transparent;
                selectedButton.Font = new Font("Cooper Black", 12f);
                selectedButton.ForeColor = Color.White;
                selectedButton.Enabled = true;
            }
        }

    }
}

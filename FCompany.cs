﻿using System;
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
        private Button selectedButton;
        private Form currentFormChild;
        public FCompany()
        {
            InitializeComponent();
            btnPostJob.PerformClick();
        }

        private void FCompany_Load(object sender, EventArgs e)
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
                        button.Click -= btnLogOut_Click;
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

            clickedButton.BackColor = Color.FromArgb(32, 41, 58);
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
            OpenChildForm(new FPostJob());
        }

        private void btnEditJob_Click(object sender, EventArgs e)
        {
            FJobEdit fJobEdit = new FJobEdit();
            fJobEdit.LblTitle = "Editing a job";
            fJobEdit.BtnPostJob = "Save";
            OpenChildForm(fJobEdit);
        }

        private void btnApplicant_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant();
            OpenChildForm(fApplicant);
        }

    }
}

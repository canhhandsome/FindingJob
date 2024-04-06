using Guna.UI2.WinForms;
using Syncfusion.XPS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject.WinFormCode
{
    public partial class FJobSKills : Form
    {
        public event EventHandler<List<string>> ListReady;
        List<string> skills = new List<string>();
        public FJobSKills()
        {
            InitializeComponent();
        }

        private void FJobSKills_Load(object sender, EventArgs e)
        {
            SetAllButtonClick(pnBody);
        }


        public void SetAllButtonClick(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Guna2Button)
                {
                    Guna2Button button = (Guna2Button)control;
                    button.Click += button_Click;
                }
                else if (control is Panel)
                    SetAllButtonClick((Panel)control);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Guna2Button clickedButton = (Guna2Button)sender;

            if (clickedButton.Tag == null)
            {
                clickedButton.Tag = 0;
            }

            int buttonClickCount = (int)clickedButton.Tag;

            buttonClickCount++;

            if (buttonClickCount == 2)
            {
                clickedButton.Image = Properties.Resources.plus;
                clickedButton.FillColor = Color.Silver;
                buttonClickCount = 0;
                skills.Remove(clickedButton.Text);
                lblCountSkills.Text = (3 - skills.Count).ToString() + " Skill(s) remaining";
            }
            else if (buttonClickCount == 1)
            {
                if (skills.Count >= 3)
                {
                    MessageBox.Show("You can only choose 3 skills for each job!");
                    return;
                }
                clickedButton.Image = Properties.Resources.approve;
                clickedButton.FillColor = Color.FromArgb(248, 212, 187);
                skills.Add(clickedButton.Text);
                lblCountSkills.Text = (3 - skills.Count).ToString() + " Skill(s) remaining";
            }
            clickedButton.Tag = buttonClickCount;
        }

        private void ResetAllControls(Control parentControl)
        {
            skills.Clear();
            foreach (Control control in parentControl.Controls)
            {
                if (control is Guna2Button button)
                {
                    button.Image = Properties.Resources.plus; // Assuming this is the default image
                    button.FillColor = Color.Silver; // Assuming this is the default background color
                    button.Tag = 0;
                }
                else if (control is Panel)
                {
                    ResetAllControls(control);
                }
            }
            lblCountSkills.Text = (3 - skills.Count).ToString() + " Skill(s) remaining";
        }
        private void PassListBackToListener()
        {
            ListReady?.Invoke(this, skills);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetAllControls(pnBody);
            PassListBackToListener();
            this.Hide();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            PassListBackToListener();
            this.Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FFilter : Form
    {
        int from = 500;
        int to = 10000;
        private int buttonClickCount = 0;
        string salary = string.Empty;
        List<Job> jobs = new List<Job>();
        public FFilter(List<Job> jobs)
        {
            InitializeComponent();
            this.jobs = jobs;

            salary = @$"${from} - ${to}";
            SetAllButtonClick(pnBody);
        }

        public void SetAllButtonClick(Panel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is Button)
                {
                    Button button = (Button)control;
                    button.Click += button_Click;
                }
                else if (control is Panel)
                    SetAllButtonClick((Panel)control);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (clickedButton.Tag == null)
            {
                clickedButton.Tag = 0;
            }

            int buttonClickCount = (int)clickedButton.Tag;

            buttonClickCount++;

            if (buttonClickCount == 2)
            {
                clickedButton.Image = Properties.Resources.plus;
                clickedButton.BackColor = Color.Transparent;
                buttonClickCount = 0;
            }
            else if (buttonClickCount == 1)
            {
                clickedButton.Image = Properties.Resources.approve;
                clickedButton.BackColor = Color.FromArgb(248, 212, 187);
            }
            clickedButton.Tag = buttonClickCount;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            from = 500 + tbFrom.Value * 500;
            if (from >= to)
            {
                from = to - 500;

            }
            salary = @$"${from} - ${to}";
            lblSalaryRange.Text = salary;
            if (from >= to)
            {
                tbTo.Value = tbFrom.Value + 1;
            }
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            to = 10000 - Math.Abs(10 - tbTo.Value) * 500;
            if (to <= from)
            {
                to = from + 500;

            }
            salary = @$"${from} - ${to}";
            lblSalaryRange.Text = salary;
            if (to <= from)
            {
                tbFrom.Value = tbTo.Value - 1;
            }
        }

        private List<string> LevelSearch()
        {
            List<string> search = new List<string>();
            foreach (Control control in pnLevel.Controls)
            {
                if (control is Button)
                {
                    Button btn = (Button)control;
                    if (btn.Tag != null)
                        if (btn.Tag.ToString() == "1")
                            search.Add(btn.Text);
                }
            }
            return search;
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            List<string> selectedLevels = LevelSearch();
            if (selectedLevels.Count > 0)
            {
                jobs = jobs.Where(job => selectedLevels.Contains(job.Position)).ToList();
            }
        }
    }
}

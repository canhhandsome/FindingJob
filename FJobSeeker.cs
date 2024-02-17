﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Transitions;

namespace WinFormProject
{
    public partial class FJobSeeker : Form
    {
        public FJobSeeker()
        {
            InitializeComponent();
        }

        private void FJobSeeker_Load(object sender, EventArgs e)
        {
            pictureBox1.Click += (sender, e) =>
            {
                var t = new Transition(new TransitionType_EaseInEaseOut(350));
                if (flowLayoutPanel1.Width == 42)
                {
                    t.add(flowLayoutPanel1, "Width", 186);
                    t.add(panel2, "Width", panel2.Width - flowLayoutPanel1.Width + 42);
                    t.add(panel2, "Left", 186);
                    t.add(bigLabel1, "Left", panel2.Left);
                }
                else
                {
                    t.add(flowLayoutPanel1, "Width", 42);
                    t.add(panel2, "Width", panel2.Width+186-42);
                    t.add(panel2, "Left", 42);
                    t.add(bigLabel1, "Left", 42);
                }
                t.run();
            };
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using our service!\nGoodbye and See you again");
            this.Hide();
            FLogin fLogin = new FLogin();
            fLogin.Closed += (s, args) => this.Close();
            fLogin.Show();
        }

    }
}

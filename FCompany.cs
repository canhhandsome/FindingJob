using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public partial class FCompany : Form
    {
        public FCompany()
        {
            InitializeComponent();
        }

        private void FCompany_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flowLayoutPanel1.Width == 42)
            {
                flowLayoutPanel1.Width = 186;
            }
            else flowLayoutPanel1.Width = 42;
        }
    }
}

using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormProject
{
    public partial class FManageUser : Form
    {
        public FManageUser()
        {
            InitializeComponent();
        }

        private void FManageUser_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RowStyle rowStyle = new RowStyle(); 
            RowStyle temp = tableLayoutPanel1.RowStyles[tableLayoutPanel1.RowCount - 1];

            tableLayoutPanel1.RowCount++;
            tableLayoutPanel1.Height+=50;
            //add a new RowStyle as a copy of the previous one
            tableLayoutPanel1.RowStyles.Add(new RowStyle(temp.SizeType, temp.Height));
            //add your three    controls
            tableLayoutPanel1.Controls.Add(new Label() { Text = "address", Dock = DockStyle.Fill }, 0, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Contact Num" }, 1, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Xin chao" }, 2, tableLayoutPanel1.RowCount - 1);
            tableLayoutPanel1.Controls.Add(new Label() { Text = "Tam Biet" }, 3, tableLayoutPanel1.RowCount - 1);
        }

    }
}

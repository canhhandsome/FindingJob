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
    public partial class FRate : Form
    {
        Ratings Ratings;
        string js, com;
        public FRate(string js, string com)
        {
            InitializeComponent();
            this .js = js;
            this .com = com;    
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            Ratings = new Ratings(js, com, (int)rtStars.Value, DateTime.Now,rtxtContents.Text);
            this.Close();
        }

        public Ratings RATE
        { get { return Ratings; } }
    }
}

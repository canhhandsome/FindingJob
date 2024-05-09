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
    public partial class UCRates : UserControl
    {
        Ratings rate;
        public UCRates(Ratings rate)
        {
            InitializeComponent();
            this.rate = rate;
            FillInfor();
        }

        private void FillInfor()
        {
            JobSeekerDAO js = new JobSeekerDAO();
            ptbAvatar.Image = js.FetchImg(rate.JsID, "Avatar");
            lblNames.Text = js.FetchName(rate.JsID);
            lblTimeRates.Text = rate.Timerates.ToString("dd/MM/yyyy hh/mm/ss");
            lblContents.Text = rate.Contents;
            rtStars.Value = rate.Rate;
        }

    }
}

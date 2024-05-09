using PdfSharp.Charting;
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
    public partial class FRatings : Form
    {
        private string js;
        private Company com;
        FRate frate;
        List<Ratings> ratings =new List<Ratings>();
        Ratings rating = new Ratings();
        RatingDAO ratingDAO = new RatingDAO();
        public FRatings(string js, Company com)
        {
            InitializeComponent();
            this.js = js;
            this.com = com;
            ratings = ratingDAO.AllRatings(com.INFO.ID);
            FillInfor();
            frate = new FRate(js, com.INFO.ID);
            frate.btnRate.Click += btnRates_CLick;
        }


        public void FillInfor()
        {
            CompanyDAO companyDAO = new CompanyDAO();
            ptbAvatar.Image = companyDAO.FetchImg(com.INFO.ID, "Avatar");
            lblCompanyNameLeft.Text = com.INFO.Name;
            flpRatings.Controls.Clear();
            int count = 0;
            int total = 0;
            foreach (Ratings rate in ratings)
            {
                count++;
                total += rate.Rate;
                UCRates uc = new UCRates(rate);
                flpRatings.Controls.Add(uc);
            }
            decimal rates = ((decimal)total / (decimal)count);

            lblRate.Text = Math.Round(rates, 1).ToString();
            btnRatings.Text = count.ToString() + " Rating (s)";
        }

        private void btnRates_CLick(object sender, EventArgs e)
        {
            rating = frate.RATE;
            ratingDAO.RateCompany(rating);
            ratings.Add(rating);
            FillInfor();
        }

        private void btnRate_Click(object sender, EventArgs e)
        {
            frate.Show();
        }
    }
}

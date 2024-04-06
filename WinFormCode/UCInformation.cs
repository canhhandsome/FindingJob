using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormProject.WinFormCode;

namespace WinFormProject
{
    public partial class UCInformation : UserControl
    {
        private Job job = new Job();
        CompanyDAO companyDAO = new CompanyDAO();
        string jsID = string.Empty;
        Company company;
        public UCInformation(Job job, string jsID)
        {
            InitializeComponent();
            this.jsID = jsID;
            this.job = job;
            company = companyDAO.FetchCompanyInformationBasedOnID(job.CompanyID);
            FillInTemplate();
            PanelUtils.MakeRounded(this.flpBody, 30);
        }
        public void FillInTemplate()
        {
            lblFromT.Text = companyDAO.FetchName(job.CompanyID);
            lblDateT.Text = $"Posted {PublishTime()}";
            lblNameT.Text = job.Name;
            lblAddressT.Text = company.INFO.Address;
            lblWorkingFormT.Text = company.WorkingTimeBegin;
            if (company.Avatar != null) ptbCompanyPicture.Image = company.Avatar;

        }

        private string PublishTime()
        {
            TimeSpan timeDifference = DateTime.Now - job.DatePublish;

            if (timeDifference.TotalMinutes < 1)
            {
                return "Just now";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute(s) ago";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours} hour(s) ago";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays} day(s) ago";
            }
        }
        private void panel1_Click(object sender, EventArgs e)
        {
            FJobDetails jobDetails = new FJobDetails(job, jsID);
            jobDetails.Show();
        }


        private int radius = 60;
        [DefaultValue(60)]
        public int Radius
        {
            get { return radius; }
            set
            {
                radius = value;
                this.RecreateRegion();
            }
        }

        [System.Runtime.InteropServices.DllImport("gdi32.dll")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect,
            int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

        private GraphicsPath GetRoundRectagle(Rectangle bounds, int radius)
        {
            float r = radius;
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(bounds.Left, bounds.Top, r, r, 180, 90);
            path.AddArc(bounds.Right - r, bounds.Top, r, r, 270, 90);
            path.AddArc(bounds.Right - r, bounds.Bottom - r, r, r, 0, 90);
            path.AddArc(bounds.Left, bounds.Bottom - r, r, r, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void RecreateRegion()
        {
            var bounds = ClientRectangle;

            //using (var path = GetRoundRectagle(bounds, this.Radius))
            //    this.Region = new Region(path);

            //Better round rectangle
            this.Region = Region.FromHrgn(CreateRoundRectRgn(bounds.Left, bounds.Top,
                bounds.Right, bounds.Bottom, Radius, radius));
            this.Invalidate();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.RecreateRegion();
        }
    }
}


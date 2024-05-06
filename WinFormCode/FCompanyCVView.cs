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
using WinFormProject.OOPCODE;

namespace WinFormProject.WinFormCode
{
    public partial class FCompanyCVView : Form
    {
        WebBrowser pdfViewer = new WebBrowser();
        string companyid = string.Empty;
        CompanyLikeCV fcview = new CompanyLikeCV();
        CompanyLikeCVDao dao = new CompanyLikeCVDao();
        CV cv = new CV();
        CVDao cvDao = new CVDao();
        public FCompanyCVView(CV cv, string companyid)
        {
            InitializeComponent();
            this.Controls.Add(pdfViewer);
            pdfViewer.Dock = DockStyle.Fill;
            PDFHandler.DisplayPDFInWebBrowser(cv.CVDataProperty, ref pdfViewer);
            this.companyid = companyid;
            dao.FetchCompayLikeCV(companyid, fcview);
            this.cv = cv;
            FillInfor();
        }
        public void FillInfor()
        {
            if (fcview.CompanyId == string.Empty)
            {
                btnHeart.Image = Properties.Resources.DarkHeart;
            }
            else btnHeart.Image = Properties.Resources.RedHeart;
            lblLikes.Text = cv.Likes.ToString();
        }

        private void btnHeart_Click(object sender, EventArgs e)
        {
            if (fcview.CompanyId == string.Empty)
            {
                btnHeart.Image = Properties.Resources.RedHeart;
                fcview.CompanyId = companyid;
                fcview.JobseekerId = cv.JobSeekerID;
                int likes = cv.Likes + 1;
                cv.Likes = likes;
                dao.InserCompanyLikeCV(fcview);
                cvDao.UpdateCV(cv);
                lblLikes.Text = cv.Likes.ToString();
            }
            else
            {
                btnHeart.Image = Properties.Resources.DarkHeart;
                if(cv.Likes > 0 )
                {
                    int likes = cv.Likes - 1;
                    cv.Likes = likes;
                }
                dao.RemoveCompanyLikeCV(fcview);
                cvDao.UpdateCV(cv);
                fcview.CompanyId = string.Empty;
                fcview.JobseekerId = string.Empty;
                lblLikes.Text = cv.Likes.ToString();

            }
        }

    }
}

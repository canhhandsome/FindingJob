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

namespace WinFormProject
{
    public partial class UCApplicant : UserControl
    {
        JobSeekerDAO jsDAO = new JobSeekerDAO();
        JobDAO jobDAO = new JobDAO();
        Apply apply = new Apply();
        Job job = new Job();
        byte[] applicantAvatar = new byte[0];
        public UCApplicant(Apply apply, Job job)
        {
            InitializeComponent();
            this.apply = apply;
            this.job = job;
            this.MaximumSize = new System.Drawing.Size(469, 515);
            FillInTemplate();
            PanelUtils.MakeRounded(this.panel2, 30);
            PanelUtils.MakeRounded(this.panel1, 30);
        }
        public void FillInTemplate()
        {
            lblApplicantNameT.Text = jsDAO.FetchName(apply.JSeekerID);
            lblEmailT.Text = jobDAO.FetchName(apply.JobID);
            lblDateT.Text = apply.DATE.ToString("dd/MM/yyyy");
            applicantAvatar = jsDAO.FetchImg(apply.JSeekerID);
            ImageHandler.DisplayImage(applicantAvatar, ref ptbApplicantPicture);
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            InformationDAO informationDAO = new InformationDAO();
            FCV fcv = new FCV(new JobSeeker(informationDAO.GetCommonByID(apply.JSeekerID, "JobSeeker")));
            fcv.Show();
        }
        private void btnAnswer_Click(object sender, EventArgs e)
        {
            ReaLTaiizor.Controls.CyberButton button = (ReaLTaiizor.Controls.CyberButton)sender;
            ApplyDAO applyDao = new ApplyDAO();
            applyDao.UpdateStatus(button.TextButton, apply);
            FAnswer fAnswer = new FAnswer(apply, job);
            fAnswer.Show();
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

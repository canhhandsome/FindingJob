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

namespace WinFormProject.WinFormCode
{
    public partial class UCHistory : UserControl
    {
        Job job = new Job();
        JobDAO jobDAO = new JobDAO();

        public UCHistory(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(811, 260);
            this.job = job;
            lblJobNameT.Text = job.Name;
            lblDateT.Text = job.DatePublish.ToString();
            lblEndT.Text = job.DateEnd.ToString();
            lblStatusT.Text = job.Status;
        }
        public Job Job { get { return job; } }


        private int radius = 20;
        [DefaultValue(20)]
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

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant(Job);
            fApplicant.Show();
        }
    }
}

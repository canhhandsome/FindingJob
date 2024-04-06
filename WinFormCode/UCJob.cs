// UCJob.cs

using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using WinFormProject.WinFormCode;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject
{
    public partial class UCJob : UserControl
    {
        Job job = new Job();
        JobDAO jobDAO = new JobDAO();
        public UCJob(Job job)
        {
            InitializeComponent();
            this.MaximumSize = new System.Drawing.Size(508, 184);
            this.job = job;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            FJobEdit fJobEdit = new FJobEdit(job, job.CompanyID);
            fJobEdit.Show();
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            jobDAO.DoneJob(job.Jobid);
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant(job);
            fApplicant.Show();
        }

        private void UCJob_Load(object sender, EventArgs e)
        {
            lblJobNameT.Text = job.Name;
            lblStatusT.Text = job.Status;
            lblDateT.Text = "Posted " + PublishTime();
            lblEndT.Text = "Expired after " + ExpiredTime();
            foreach (string s in job.SkillList)
            {
                BtnSkill btnSkill = new BtnSkill();
                btnSkill.Text = s;
                btnSkill.Show();
                flpSkills.Width += btnSkill.Width + 10;
                flpSkills.Controls.Add(btnSkill);
            }
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

        private string ExpiredTime()
        {
            TimeSpan timeDifference =job.DateEnd - DateTime.Now;

            if (timeDifference.TotalMinutes < 0)
            {
                return $"{(int)timeDifference.TotalSeconds} second(s)";
            }
            else if (timeDifference.TotalMinutes < 60)
            {
                return $"{(int)timeDifference.TotalMinutes} minute(s)";
            }
            else if (timeDifference.TotalHours < 24)
            {
                return $"{(int)timeDifference.TotalHours} hour(s)";
            }
            else
            {
                return $"{(int)timeDifference.TotalDays} day(s)";
            }
        }

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
    }
}

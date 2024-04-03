// UCJob.cs

using System;
using System.ComponentModel;
using System.Drawing.Drawing2D;
using System.Threading.Tasks.Dataflow;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WinFormProject
{
    public partial class UCJob : UserControl
    {
        Job job = new Job();
        JobDAO jobDAO = new JobDAO();
        Form currentFormChild;
        Panel pnBody;
        public UCJob(Job job, Form currentFormChild, Panel pnBody)
        {
            InitializeComponent();
            this.currentFormChild = currentFormChild;
            this.pnBody = pnBody;
            this.MaximumSize = new System.Drawing.Size(812, 212);
            this.job = job;
        }

        public Job Job { get { return job; } }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            jobDAO.DoneJob(job.Jobid);
        }

        private void btnApplicants_Click(object sender, EventArgs e)
        {
            FApplicant fApplicant = new FApplicant(Job);
            fApplicant.Show();
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

        private void UCJob_Load(object sender, EventArgs e)
        {
            lblJobNameT.Text = job.Name;
            lblDateT.Text = job.DatePublish.ToString();
            lblEndT.Text = job.DateEnd.ToString("dd/MM/yyyy");
            lblStatusT.Text = job.Status;
        }
        private void OpenChildForm(Form childForm)
        {
            foreach (Control control in this.Controls)
            {
                if (control == pnBody)
                    continue;
                control.Visible = false;
            }
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnBody.Controls.Add(childForm);
            pnBody.Tag = childForm;
            pnBody.BackColor = Color.FromArgb(32, 41, 58);
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FJobEdit fJobEdit = new FJobEdit(job, job.CompanyID);
            OpenChildForm(fJobEdit);
        }
    }
}

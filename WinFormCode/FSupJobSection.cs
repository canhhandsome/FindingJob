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
    public partial class FSupJobSection : Form
    {
        public Job job = new Job();
        List<Alert> alerts = new List<Alert>();
        JobSeeker seeker = new JobSeeker();
        public FSupJobSection(JobSeeker jobSeeker)
        {
            InitializeComponent();
            seeker = jobSeeker;
            AlertDAO alertDAO = new AlertDAO();
            this.alerts = alertDAO.FetchAlert(jobSeeker.INFO.ID);
            foreach (Alert alert in alerts)
            {
                UCAlert uCAlert = new UCAlert(alert);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
        }



    }
}

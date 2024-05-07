﻿using System;
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
    public partial class FAlert : Form
    {
        public Job job = new Job();
        List<Alert> alerts = new List<Alert>();
        JobSeeker seeker = new JobSeeker();
        public FAlert(JobSeeker jobSeeker)
        {
            InitializeComponent();
            seeker = jobSeeker;
            AlertDAO alertDAO = new AlertDAO();
            this.alerts = alertDAO.FetchAlert(jobSeeker.INFO.ID);
            FillInfor(alerts);
        }
        private void FillInfor(List<Alert> alertlist)
        {
            flpAlert.Controls.Clear();
            foreach (Alert alert in alertlist)
            {
                UCAlert uCAlert = new UCAlert(alert);
                flpAlert.Controls.Add(uCAlert);
                flpAlert.Height += 255;
            }
        }

        private List<Alert> SearchAlert(string search)
        {
            JobDAO jDAO = new JobDAO();
            return alerts.Where(alert => jDAO.FetchName(alert.JobID).ToLower().Contains(search)).ToList();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                FillInfor(SearchAlert(txtSearch.Text.ToLower()));
            }
        }
    }
}

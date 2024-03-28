using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WinFormProject.OOPCODE;

namespace WinFormProject
{
    public partial class FCV : Form
    {
        JobSeeker jobseeker;
        WebBrowser pdfViewer = new WebBrowser();
        public FCV(JobSeeker jobseeker)
        {
            InitializeComponent();
            this.jobseeker = jobseeker;
            this.Controls.Add(pdfViewer);
            pdfViewer.Dock = DockStyle.Fill;
            PDFHandler.DisplayPDFInWebBrowser(jobseeker.CV, ref pdfViewer);
        }
    }
}

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
    public partial class FCV : Form
    {
        JobSeeker jobseeker;
        public FCV(JobSeeker jobseeker)
        {
            InitializeComponent();
            this.jobseeker = jobseeker;
            DisplayCV();
        }
        private void DisplayCV()
        {
            byte[] imageData = jobseeker.CV;
            // Check if byte array is not null and has data
            if (imageData != null && imageData.Length > 0)
            {
                try
                {
                    // Create MemoryStream from byte array
                    using (MemoryStream ms = new MemoryStream(imageData))
                    {
                        // Create Image from MemoryStream
                        Image img = Image.FromStream(ms);
                        
                        // Set the Image to the PictureBox
                        ptbCV.Image = img;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                // Clear the PictureBox if byte array is null or empty
                ptbCV.Image = null;
            }
        }
    }
}

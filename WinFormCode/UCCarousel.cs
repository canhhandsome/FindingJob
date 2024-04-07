using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject.WinFormCode
{
    public partial class UCCarousel : UserControl
    {
        List<Image> images = new List<Image>();
        int currentIndex = 0;
        public UCCarousel(List<Image> Images)
        {
            InitializeComponent();
            this.images = Images;
            //this.BackgroundImage = images[0]; 
        }
        public UCCarousel()
        {
            InitializeComponent();
        }

        private void btnLeftArrow_Click(object sender, EventArgs e)
        {
            if (images.Count > 1)
            {
                currentIndex = (currentIndex - 1 + images.Count) % images.Count;
                this.BackgroundImage = images[currentIndex];
            }
        }

        private void btnRightArrow_Click(object sender, EventArgs e)
        {
            if (images.Count > 1)
            {
                currentIndex = (currentIndex + 1) % images.Count;
                this.BackgroundImage = images[currentIndex];
            }
        }
    }
}

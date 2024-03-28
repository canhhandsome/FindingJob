using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormProject
{
    public static class ImageHandler
    {
        public static void DisplayImage(byte[] imageData, ref PictureBox ptb)
        {
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
                        ptb.Image = img;
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
                ptb.Image = null;
            }
        }
        public static byte[] ImageToByteArray(Image img)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png); // Saving as PNG for lossless compression
                return ms.ToArray();
            }
        }
        public static void ChoosePicture(ref PictureBox ptb)
        {
            OpenFileDialog openFileDiaglog = new OpenFileDialog();
            if (openFileDiaglog.ShowDialog() == DialogResult.OK)
            {
                ptb.Image = new Bitmap(openFileDiaglog.FileName);
            }
        }
        public static void DisplayPdfPreview(byte[] pdfBytes, PictureBox ptbCv)
        {
            // Convert PDF to image
            Image previewImage = ConvertPdfToImage(pdfBytes);

            // Display the image in PictureBox
            ptbCv.Image = previewImage;
        }

        private static Image ConvertPdfToImage(byte[] pdfBytes)
        {
            using (MemoryStream memoryStream = new MemoryStream(pdfBytes))
            {
                // Load PDF document
                PdfLoadedDocument loadedDocument = new PdfLoadedDocument(memoryStream);

                // Render first page as image
                Bitmap image = loadedDocument.ExportAsImage(0);

                // Dispose the document
                loadedDocument.Dispose();

                return image;
            }
        }
    }
}

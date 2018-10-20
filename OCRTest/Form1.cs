using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCRTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_OriginalImage;
        Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> m_ProcessedImage;

        private void Button_OpenImage_Click(object sender, EventArgs e)
        {
            string t_ImagePath = LibUtility.ClassUtility.OpenImageFile();
            m_OriginalImage = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(t_ImagePath);
            m_ProcessedImage = m_OriginalImage.Clone();

            ZoomPanROIPictureBox_OriginalImage.Image = m_OriginalImage.ToBitmap();
            ZoomPanROIPictureBox_ProcessedImage.Image = m_ProcessedImage.ToBitmap();

            System.Threading.Thread.Sleep(100);
            ZoomPanROIPictureBox_OriginalImage.FitImageToCenter();
            ZoomPanROIPictureBox_ProcessedImage.FitImageToCenter();

        }

        private void Button_StartStreaming_Click(object sender, EventArgs e)
        {
            Bitmap t_Temp = LibUtility.ClassUtility.GetImageFromURL();
            m_OriginalImage = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(t_Temp);
        }

        private void Button_ResetProcessed_Click(object sender, EventArgs e)
        {
            ZoomPanROIPictureBox_OriginalImage.FitImageToCenter();
            ZoomPanROIPictureBox_ProcessedImage.FitImageToCenter();
        }
    }
}

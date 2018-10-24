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
        Timer timer1 = new Timer();
        public Form1()
        {
            InitializeComponent();
            LibUtility.ClassUtility.InitialComboBox(ref ComboBox_ImageConvert, new string[] {"Color", "R", "G", "B", "Gray"});
            
            timer1.Tick += timer1_Tick;
            timer1.Interval = 100;
            //timer1.Enabled = true;
            
        }
        public void timer1_Tick(object sender, EventArgs e)
        {
            Bitmap ss = LibUtility.ClassUtility.GetImageFromURL();
            Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte> t_Image = new Emgu.CV.Image<Emgu.CV.Structure.Bgr, byte>(ss);
            m_ProcessedImage = t_Image.Mat;
            ZoomPanROIPictureBox_ProcessedImage.Image = m_ProcessedImage.Bitmap;
        }
        Emgu.CV.Mat m_OriginalImage = new Emgu.CV.Mat();
        Emgu.CV.Mat m_ProcessedImage = new Emgu.CV.Mat();

        private void Button_OpenImage_Click(object sender, EventArgs e)
        {
            string t_ImagePath = LibUtility.ClassUtility.OpenImageFile();
            m_OriginalImage = Emgu.CV.CvInvoke.Imread(t_ImagePath, Emgu.CV.CvEnum.ImreadModes.Unchanged);
            m_ProcessedImage = m_OriginalImage.Clone();
            //Emgu.CV.Mat ttImage;
            //ttImage = LibUtility.ClassUtility.ConvertImageColor(m_ProcessedImage, 2);
            ZoomPanROIPictureBox_OriginalImage.Image = m_OriginalImage.Bitmap;
            ZoomPanROIPictureBox_ProcessedImage.Image = m_ProcessedImage.Bitmap;
            
            ZoomPanROIPictureBox_OriginalImage.FitImageToCenter();
            ZoomPanROIPictureBox_ProcessedImage.FitImageToCenter();

        }

        private void Button_StartStreaming_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void Button_ResetProcessed_Click(object sender, EventArgs e)
        {
            ZoomPanROIPictureBox_OriginalImage.FitImageToCenter();
            ZoomPanROIPictureBox_ProcessedImage.FitImageToCenter();
        }

        private void ComboBox_ImageConvert_SelectedIndexChanged(object sender, EventArgs e)
        {
            m_ProcessedImage = m_OriginalImage;
            if (ComboBox_ImageConvert.SelectedText.ToString().CompareTo("Color") == 0)
            {
                m_ProcessedImage = LibUtility.ClassUtility.ConvertImageColor(m_ProcessedImage, (int)LibUtility.ClassUtility.E_ImageColor.e_Color);   
            }
            if (ComboBox_ImageConvert.SelectedItem.ToString().CompareTo("R") == 0)
            {
                m_ProcessedImage = LibUtility.ClassUtility.ConvertImageColor(m_ProcessedImage, (int)LibUtility.ClassUtility.E_ImageColor.e_R);
            }
            if (ComboBox_ImageConvert.SelectedItem.ToString().CompareTo("G") == 0)
            {
                m_ProcessedImage = LibUtility.ClassUtility.ConvertImageColor(m_ProcessedImage, (int)LibUtility.ClassUtility.E_ImageColor.e_G);
            }
            if (ComboBox_ImageConvert.SelectedItem.ToString().CompareTo("B") == 0)
            {
                m_ProcessedImage = LibUtility.ClassUtility.ConvertImageColor(m_ProcessedImage, (int)LibUtility.ClassUtility.E_ImageColor.e_B);
            }
            if (ComboBox_ImageConvert.SelectedItem.ToString().CompareTo("Gray") == 0)
            {
                m_ProcessedImage = LibUtility.ClassUtility.ConvertImageColor(m_ProcessedImage, (int)LibUtility.ClassUtility.E_ImageColor.e_Gray);
            }
            ZoomPanROIPictureBox_ProcessedImage.Image = m_ProcessedImage.Bitmap;
        }

        private void Button_GetROI_Click(object sender, EventArgs e)
        {
            //m_ProcessedImage.Dispose();
            Emgu.CV.Mat t_TempImage;
            //List<Rectangle> t_ROI = ZoomPanROIPictureBox_OriginalImage.GetROI();
            //t_TempImage = new Emgu.CV.Mat(m_OriginalImage, t_ROI[0]);
            //t_TempImage.CopyTo(m_ProcessedImage);
            //ZoomPanROIPictureBox_ProcessedImage.Image = m_ProcessedImage.Bitmap;
        }
        Emgu.CV.OCR.Tesseract m_Tesseract = new Emgu.CV.OCR.Tesseract();
        private void Button_InitialOCR_Click(object sender, EventArgs e)
        {
            LibUtility.ClassUtility.InitialOCR(ref m_Tesseract, ".","eng"  );
        }

        private void Button_DoOCR_Click(object sender, EventArgs e)
        {
            m_Tesseract.SetImage(m_ProcessedImage);
            m_Tesseract.Recognize();
            Emgu.CV.OCR.Tesseract.Character[] characters = m_Tesseract.GetCharacters();
            TextBox_Result.Text = m_Tesseract.GetOsdText() ;

        }

        private void Button_StopStreaming_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
}

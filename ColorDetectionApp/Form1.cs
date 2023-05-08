using Emgu.CV.Structure;
using Emgu.CV;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV.Util;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace ColorDetectionApp
{


    public partial class Form1 : Form
    {
        double highRed, highgreen, highBlue;
        double lowRed, lowGreen, lowBlue;
        Color lineColor;
        int stroke;
        String path;
        Bgr bgrHigh, bgrLow;


        Image<Bgr, byte> imageInput;
        Image<Bgr, byte> imageOutput;

        private void Form1_Load(object sender, EventArgs e)
        {

            bgrHigh = new Bgr(80, 255, 80);
            bgrLow = new Bgr(0, 100, 0);

            NumRedHigh.Value = 110;
            NumBlueHigh.Value = 110;
            NumGreenHigh.Value = 255;

            NumRedLow.Value = 0;
            NumBlueLow.Value = 0;
            NumGreenLow.Value = 100;

            NumRedHigh.Enabled = false;
            NumGreenHigh.Enabled = false;
            NumBlueHigh.Enabled = false;

            NumRedLow.Enabled = false;
            NumGreenLow.Enabled = false;
            NumBlueLow.Enabled = false;

            stroke = 3;
            lineColor = Color.Red;

        }

        private void NumRedHigh_ValueChanged(object sender, EventArgs e)
        {
            bgrHigh.Red = (double)NumRedHigh.Value;
        }

        private void NumGreenHigh_ValueChanged(object sender, EventArgs e)
        {
            bgrHigh.Green = (double)NumGreenHigh.Value;
        }

        private void NumBlueHigh_ValueChanged(object sender, EventArgs e)
        {
            bgrHigh.Blue = (double)NumBlueHigh.Value;
        }

        private void NumRedLow_ValueChanged(object sender, EventArgs e)
        {
            bgrLow.Red = (double)NumRedLow.Value;
        }

        private void NumGreenLow_ValueChanged(object sender, EventArgs e)
        {
            bgrLow.Green = (double)NumGreenLow.Value;
        }

        private void NumBlueLow_ValueChanged(object sender, EventArgs e)
        {
            bgrLow.Blue = (double)NumBlueLow.Value;
        }

        private void LineColor_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (LineColor.Text == "Red")
            {
                lineColor = Color.Red;
            }
            if (LineColor.Text == "Green")
            {
                lineColor = Color.Green;
            }
            if (LineColor.Text == "Blue")
            {
                lineColor = Color.Blue;
            }
        }

        private void LineStroke_ValueChanged(object sender, EventArgs e)
        {
            stroke = (int)LineStroke.Value;
        }

        private void coBoxColorDetect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (coBoxColorDetect.Text == "Green")
            {
                NumRedHigh.Enabled = false;
                NumGreenHigh.Enabled = false;
                NumBlueHigh.Enabled = false;

                NumRedLow.Enabled = false;
                NumGreenLow.Enabled = false;
                NumBlueLow.Enabled = false;

                bgrHigh = new Bgr(110, 255, 110);
                bgrLow = new Bgr(0, 100, 0);

                highRed = bgrHigh.Red;
                highgreen = bgrHigh.Green;
                highBlue = bgrHigh.Blue;

                lowRed = bgrLow.Red;
                lowGreen = bgrLow.Green;
                lowBlue = bgrLow.Blue;

                NumRedHigh.Value = decimal.Parse(highRed.ToString());
                NumBlueHigh.Value = decimal.Parse(highBlue.ToString());
                NumGreenHigh.Value = decimal.Parse(highgreen.ToString());

                NumRedLow.Value = decimal.Parse(lowRed.ToString());
                NumBlueLow.Value = decimal.Parse(lowBlue.ToString());
                NumGreenLow.Value = decimal.Parse(lowGreen.ToString());
            }
            if (coBoxColorDetect.Text == "Red")
            {
                NumRedHigh.Enabled = false;
                NumGreenHigh.Enabled = false;
                NumBlueHigh.Enabled = false;

                NumRedLow.Enabled = false;
                NumGreenLow.Enabled = false;
                NumBlueLow.Enabled = false;


                bgrHigh = new Bgr(110, 110, 255);
                bgrLow = new Bgr(0, 0, 100);

                highRed = bgrHigh.Red;
                highgreen = bgrHigh.Green;
                highBlue = bgrHigh.Blue;
                lowRed = bgrLow.Red;
                lowGreen = bgrLow.Green;
                lowBlue = bgrLow.Blue;

                NumRedHigh.Value = decimal.Parse(highRed.ToString());
                NumBlueHigh.Value = decimal.Parse(highBlue.ToString());
                NumGreenHigh.Value = decimal.Parse(highgreen.ToString());

                NumRedLow.Value = decimal.Parse(lowRed.ToString());
                NumBlueLow.Value = decimal.Parse(lowBlue.ToString());
                NumGreenLow.Value = decimal.Parse(lowGreen.ToString());
            }
            if (coBoxColorDetect.Text == "Blue")
            {
                NumRedHigh.Enabled = false;
                NumGreenHigh.Enabled = false;
                NumBlueHigh.Enabled = false;

                NumRedLow.Enabled = false;
                NumGreenLow.Enabled = false;
                NumBlueLow.Enabled = false;


                bgrHigh = new Bgr(255, 110, 110);
                bgrLow = new Bgr(100, 0, 0);

                highRed = bgrHigh.Red;
                highgreen = bgrHigh.Green;
                highBlue = bgrHigh.Blue;
                lowRed = bgrLow.Red;
                lowGreen = bgrLow.Green;
                lowBlue = bgrLow.Blue;

                NumRedHigh.Value = decimal.Parse(highRed.ToString());
                NumBlueHigh.Value = decimal.Parse(highBlue.ToString());
                NumGreenHigh.Value = decimal.Parse(highgreen.ToString());

                NumRedLow.Value = decimal.Parse(lowRed.ToString());
                NumBlueLow.Value = decimal.Parse(lowBlue.ToString());
                NumGreenLow.Value = decimal.Parse(lowGreen.ToString());

            }
            if (coBoxColorDetect.Text == "Custom...")
            {
                NumRedHigh.Enabled = true;
                NumGreenHigh.Enabled = true;
                NumBlueHigh.Enabled = true;

                NumRedLow.Enabled = true;
                NumGreenLow.Enabled = true;
                NumBlueLow.Enabled = true;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void OpenImage_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imageInput = new Image<Bgr, byte>(dialog.FileName);
                    path = dialog.FileName;
                    Mainpicture.Image = imageInput.AsBitmap();

                }
                else
                {
                    throw new Exception("No file selected.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void colorDetection(Bgr bgrHigh, Bgr bgrLow, Color lineColor, int stroke)
        {
            try
            {
                imageOutput = new Image<Bgr, byte>(path);

                // تشخیص رنگ 
                Image<Gray, byte> colorMask = imageOutput.InRange(bgrLow, bgrHigh);

                // پیدا کردن کانتورهای موجود در ماسک 
                VectorOfVectorOfPoint contours = new VectorOfVectorOfPoint();
                Mat hierarchy = new Mat();
                CvInvoke.FindContours(colorMask, contours, hierarchy, Emgu.CV.CvEnum.RetrType.External, Emgu.CV.CvEnum.ChainApproxMethod.ChainApproxSimple);

                // پیمایش کانتورها و رسم مربع
                for (int i = 0; i < contours.Size; i++)
                {
                    Rectangle rect = CvInvoke.BoundingRectangle(contours[i]);
                    int r = (int)lineColor.R;
                    int g = (int)lineColor.G;
                    int b = (int)lineColor.B;
                    CvInvoke.Rectangle(imageOutput, rect, new MCvScalar(b, g, r), stroke);
                }

                // نمایش تصویر
                Detectpicture.Image = null;
                Detectpicture.Image = imageOutput.ToBitmap();

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                colorDetection(bgrHigh, bgrLow, lineColor, stroke); 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


    }
}

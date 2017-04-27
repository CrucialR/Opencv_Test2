using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenCvSharp;


namespace Opencv_Test2
{
    public partial class Form1 : Form
    {
        IplImage src, result,src2;
        CvCapture webcam;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    

        private void 파일ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
     
        }

        private void contourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            using (Contour Sq = new Contour())
            using (IplImage temp = Sq.Squares(src))
            {
                result = temp.Clone();

            }
            pictureBoxIpl2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl2.ImageIpl = result;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            using (Square Sq = new Square())
            using (IplImage temp = Sq.Squares(src))
            {
                result = temp.Clone();

            }
            pictureBoxIpl2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl2.ImageIpl = result;
         
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void xOR비교검출ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            if (src2 == null) return;
            using (defection Sq = new defection())
            using (IplImage temp = Sq.defections(src,src2))
            {
                result = temp.Clone();

            }
            pictureBoxIpl2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl2.ImageIpl = result;
            

        }

        private void pictureBoxIpl2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxIpl3_Click(object sender, EventArgs e)
        {

        }

        private void firstImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                loadImage(openFileDialog1.FileName);
            }
            else
            {
                return;
            }
        }

        private void secondImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                loadImage2(openFileDialog2.FileName);
            }
            else
            {
                return;
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void loadImage(String filename)
        {
            src = new IplImage(filename, LoadMode.AnyColor);
            pictureBoxIpl1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl1.ImageIpl = src;
        }

        private void pictureBoxIpl1_Click(object sender, EventArgs e)
        {

        }

        private void grayToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 사각형찾기ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void adThresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (src == null) return;
            using (Histogram h = new Histogram())
            using (IplImage temp = h.findRed(src))
            {
                result = temp.Clone();

            }
            pictureBoxIpl4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl4.ImageIpl = result;
            using (Histogram h = new Histogram())
            using (IplImage temp = h.findGreen(src))
            {
                result = temp.Clone();

            }
            pictureBoxIpl5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl5.ImageIpl = result;
            using (Histogram h = new Histogram())
            using (IplImage temp = h.findBlue(src))
            {
                result = temp.Clone();

            }
            pictureBoxIpl6.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl6.ImageIpl = result;



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void pictureBoxIpl4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxIpl5_Click(object sender, EventArgs e)
        {

        }
     
        private void 시작ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            webcam = CvCapture.FromCamera(CaptureDevice.DShow, 0); //첫번째 입력장치에서 읽어오기
            timer1.Interval = 33;   //초당 30프레임 설정
            timer1.Enabled = true;

        }

        private void 정지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            if (webcam != null) webcam.Dispose();

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            src = webcam.QueryFrame();
            pictureBoxIpl1.ImageIpl = src;
        }

        private void pictureBoxIpl6_Click(object sender, EventArgs e)
        {

        }

        private void loadImage2(String filename)
        {
            src2 = new IplImage(filename, LoadMode.AnyColor);
            pictureBoxIpl3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxIpl3.ImageIpl = src2;
        }
    }
}

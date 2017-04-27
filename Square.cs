using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;
using System.Diagnostics;


namespace Opencv_Test2
{
    class Square :IDisposable
    {
        
        int Thresh = 30;
        IplImage squr;
        public IplImage Squares(IplImage src)
        {

            CvMemStorage storage = new CvMemStorage(0);
            
            DrawSquares(src, FindSquares(src, storage));
            return squr;

        }


        static CvPoint[] FindSquares(IplImage img, CvMemStorage storage)
        {
            double maxArea = 0;
            int maxIdx = 0;
            const int N = 11;
            const int Thresh = 50;
            CvSize sz = new CvSize(img.Width & -2, img.Height & -2);
            IplImage timg = img.Clone(); // make a copy of input image
            IplImage gray = new IplImage(sz, BitDepth.U8, 1);
            IplImage pyr = new IplImage(sz.Width / 2, sz.Height / 2, BitDepth.U8, 3);
            // create empty sequence that will contain points -
            // 4 points per square (the square's vertices)
            CvSeq<CvPoint> squares = new CvSeq<CvPoint>(SeqType.Zero, CvSeq.SizeOf, storage);

            // select the maximum ROI in the image
            // with the width and height divisible by 2
            timg.ROI = new CvRect(0, 0, sz.Width, sz.Height);

            // down-scale and upscale the image to filter out the noise
            Cv.PyrDown(timg, pyr, CvFilter.Gaussian5x5);
            Cv.PyrUp(pyr, timg, CvFilter.Gaussian5x5);
            IplImage tgray = new IplImage(sz, BitDepth.U8, 1);
            for (int c = 0; c < 3; c++)
            {
                // extract the c-th color plane
                timg.COI = c + 1;
                Cv.Copy(timg, tgray, null);

                // try several threshold levels
                for (int l = 0; l < N; l++)
                {
                    // hack: use Canny instead of zero threshold level.
                    // Canny helps to catch squares with gradient shading   
                    if (l == 0)
                    {
                        // apply Canny. Take the upper threshold from slider
                        // and set the lower to 0 (which forces edges merging) 
                        Cv.Canny(tgray, gray, 0, Thresh, ApertureSize.Size5);
                        // dilate canny output to remove potential
                        // holes between edge segments 
                        Cv.Dilate(gray, gray, null, 1);
                    }
                    else
                    {
                        // apply threshold if l!=0:
                        //     tgray(x,y) = gray(x,y) < (l+1)*255/N ? 255 : 0
                        Cv.Threshold(tgray, gray, (l + 1) * 255.0 / N, 255, ThresholdType.Binary);
                    }
                    for (int j = 0; j < 11; j++)
                    {
                        CvSeq<CvPoint> contours;
                        Cv.FindContours(gray, storage, out contours, CvContour.SizeOf, ContourRetrieval.List, ContourChain.ApproxSimple, new CvPoint(0, 0));
                        while (contours != null)
                        {
                        //    Debug.WriteLine("while문 시작");
                            CvSeq<CvPoint> result = Cv.ApproxPoly(contours, CvContour.SizeOf, storage, ApproxPolyMethod.DP, contours.ContourPerimeter() * 0.02, false);
                            double Area = Math.Abs(Cv.ContourArea(result));         
                            if (result.Total == 4 && Math.Abs(result.ContourArea(CvSlice.WholeSeq)) > 1000 && Area>maxArea)
                            {
                            //    Debug.WriteLine("사각형검출");
                                     maxArea = Area;
                                     maxIdx = j;
                                for (int i = 0; i < 4; i++)
                                {
                                    //Console.WriteLine(result[i]);
                                     squares.Push(result[i].Value);                               
                                }

                            }

                            contours = contours.HNext;
                        }
                    }
                    
                }
            }
            return squares.ToArray();
        }
        public void DrawSquares(IplImage img, CvPoint[] squares)
        {
            using (IplImage cpy = img.Clone())
            {
                for (int i = 0; i < squares.Length; i += 4)
                {
                    CvPoint[] pt = new CvPoint[4];
                    pt[0] = squares[i + 0];
                    pt[1] = squares[i + 1];
                    pt[2] = squares[i + 2];
                    pt[3] = squares[i + 3];
                    Cv.PolyLine(cpy, new CvPoint[][] { pt }, true, CvColor.Green, 2, LineType.AntiAlias, 0);
                }

                // show the resultant image
                squr = cpy.Clone();
            }

        }
        public void Dispose()
        {
            if (squr != null) Cv.ReleaseImage(squr);
        }

    }
}

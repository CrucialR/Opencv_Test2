using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using OpenCvSharp;

namespace Opencv_Test2
{
    class Histogram :IDisposable
    {
        public IplImage result;
        int r_threshold = 180;
        int g_threshold = 230;
        int b_threshold = 150;
        public IplImage  histogram(IplImage src)
        {
           
            CvMemStorage storage = new CvMemStorage(0);
            using (IplImage srcimg2 = new IplImage(src.Size, BitDepth.U8, 1)) 
            using (IplImage srcimg = new IplImage(src.Size, BitDepth.U8, 1))
            {
                src.CvtColor(srcimg,ColorConversion.RgbToGray);
                srcimg.Threshold(srcimg2, 127, 255, ThresholdType.BinaryInv);
           
                result = srcimg2.Clone();
             
            }
           
            //  Cv.AdaptiveThreshold(src, result, 255, AdaptiveThresholdType.GaussianC, ThresholdType.Binary);
      
    
            
         //  Cv.AdaptiveThreshold(src,result,2);
            return result;
        }


        public IplImage findRed(IplImage src)
        {
            
            CvMemStorage storage = new CvMemStorage(0);
           
            using (IplImage r = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage g = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage b = new IplImage(src.Size, BitDepth.U8, 1))
            {
                src.CvtColor(src, ColorConversion.BgrToRgb);
                Cv.Split(src, r, g, b, null);
            //    Cv.Threshold(r, r, r_threshold, 255, ThresholdType.BinaryInv);
                 result = r.Clone();
            }
            return result;
        }
        public IplImage findGreen(IplImage src)
        {

            CvMemStorage storage = new CvMemStorage(0);
            
            using (IplImage r = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage g = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage b = new IplImage(src.Size, BitDepth.U8, 1))
            {
                src.CvtColor(src, ColorConversion.BgrToRgb);
                Cv.Split(src, r, g, b, null);
            //    Cv.Threshold(g, g, g_threshold, 255, ThresholdType.BinaryInv);
                result = g.Clone();
            }
            return result;
        }
        public IplImage findBlue(IplImage src)
        {

            CvMemStorage storage = new CvMemStorage(0);
   
            using (IplImage r = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage g = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage b = new IplImage(src.Size, BitDepth.U8, 1))
            {
                src.CvtColor(src, ColorConversion.BgrToRgb);
                Cv.Split(src, r, g, b, null);
               // Cv.Threshold(b, b, b_threshold, 255, ThresholdType.);
                result = b.Clone();
            }
            return result;
        }
        public void Dispose()
        {
            if (result != null) Cv.ReleaseImage(result);
        }
    }
}
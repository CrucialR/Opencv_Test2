using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenCvSharp;


namespace Opencv_Test2
{
    class defection :IDisposable
    {
        
        IplImage result,dst;
        public IplImage defections(IplImage src, IplImage def)
        {
            CvMemStorage storage = new CvMemStorage(0);
            using (IplImage srcimg2 = new IplImage(src.Size, BitDepth.U8, 1))
            using (IplImage srcimg = new IplImage(src.Size, BitDepth.U8, 1))
            {
              //  src.CvtColor(srcimg, ColorConversion.RgbToGray);
               // def.CvtColor(srcimg2, ColorConversion.RgbToGray);
                result = src ^def;
                
                             
                result.CvtColor(srcimg, ColorConversion.RgbToGray);
                result.Threshold(result, 127, 255, ThresholdType.BinaryInv);
            }
            return result;
        }


        public void Dispose()
        {
            if (result != null) Cv.ReleaseImage(result);
          
        }



    }
}

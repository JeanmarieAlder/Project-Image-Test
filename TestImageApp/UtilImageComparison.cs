using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TestImageApp
{
    public static class UtilImageComparison
    {
        /// <summary>
        /// Comapre if the image is the same or not using an error margin (threshold)
        /// </summary>
        /// <param name="originalImage">The image that has been processed</param>
        /// <param name="resultImage">The expected result</param>
        /// <param name="threshold">The percentage of accepted mistakes e.g. 0.02 (0 for 100% comparison)</param>
        /// <returns></returns>
        public static bool CompareImageTheSame(Bitmap originalImage, Bitmap resultImage, double threshold)
        {
            //Test if the images exist
            if (originalImage == null || resultImage == null)
            {
                return false;
            }
            //Test if images reference are the same
            if (object.Equals(originalImage, resultImage))
            {
                return true;
            }
            //Test if the images size are the same
            if (!originalImage.Size.Equals(resultImage.Size)
                || !originalImage.PixelFormat.Equals(resultImage.PixelFormat))
            {
                return false;
            }

            //Initialize counters to calculate accuracy
            int totalGood = 0;
            int totalFail = 0;

            //runs through all pixels and compare them
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int x = 0; x < originalImage.Height; x++)
                {
                    //when the image pixel is not the same 
                    //we add a fail point, a good point otherwise
                    if (resultImage.GetPixel(i, x) != originalImage.GetPixel(i, x))
                    {
                        totalFail++;
                    }
                    else
                    {
                        totalGood++;
                    }

                }

            }
            //the pictures were similar if total of mistakes 
            //is less than the treshold percentage.
            if (Convert.ToDouble(totalFail) / (totalGood + totalFail) <= threshold)
            {
                return true;
            }
            return false;
        }
    }
}

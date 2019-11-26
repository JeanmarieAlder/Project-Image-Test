using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;

namespace TestImageApp
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// Comapre if the image is the same or not
        /// </summary>
        /// <param name="originalImage"></param>
        /// <param name="newImage"></param>
        /// <returns></returns>
        public int CompareImageTheSame(Bitmap originalImage, Bitmap newImage)
        {
            for (int i = 0; i < originalImage.Width; i++)
            {
                for (int x = 0; x < originalImage.Height; x++)
                {
                    //when the image pixel is not the same, it changed the picture
                    if (newImage.GetPixel(i, x) != originalImage.GetPixel(i, x))
                    {
                        return 0;
                    }

                }

            }
            //the pictures were similar
            return 1;
        }

        [TestMethod]
        public void TestSwapFilterNotSameImage()
        {
            /*Factorial Fa = new Factorial();
            Fa.Compute(0);
            int MyResult = 0;
            Assert.AreEqual(Fa.TheResult, MyResult);*/
        }

        [TestMethod]
        public void TestSwapFilterExpectedResult()
        {

        }

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}

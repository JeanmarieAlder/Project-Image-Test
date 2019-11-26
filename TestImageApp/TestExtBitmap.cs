using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ImageEdgeDetection;
using System.Drawing;


namespace TestImageApp
{
    /// <summary>
    /// Test Class for Laplacian3x3, Laplacian5x5 and LaplacianOfGaussian methods.
    /// </summary>
    [TestClass]
    public class TestExtBitmap
    {

        /// <summary>
        /// Test the method ExtBitmap.Laplacian3x3Filter (no grayscale)
        /// </summary>
        [TestMethod]
        public void TestLaplacian3x3Filter()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.laplacian_3x3);

            Bitmap actualResult = new Bitmap(ImageEdgeDetection.ExtBitmap.Laplacian3x3Filter(temp, false));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02), "The images did not match.");
        }

        /// <summary>
        /// Test the method ExtBitmap.Laplacian3x3Filter (grayscale)
        /// </summary>
        [TestMethod]
        public void TestLaplacian3x3FilterGrayscale()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.laplacian_3x3_grayscale);

            Bitmap actualResult = new Bitmap(ImageEdgeDetection.ExtBitmap.Laplacian3x3Filter(temp, true));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02));
        }

        /// <summary>
        /// Test the method ExtBitmap.Laplacian5x5Filter (no grayscale)
        /// </summary>
        [TestMethod]
        public void TestLaplacian5x5Filter()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.laplacian_5x5);

            Bitmap actualResult = new Bitmap(ImageEdgeDetection.ExtBitmap.Laplacian5x5Filter(temp, false));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02));
        }

        /// <summary>
        /// Test the method ExtBitmap.Laplacian5x5Filter (grayscale)
        /// </summary>
        [TestMethod]
        public void TestLaplacian5x5FilterGrayscale()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.laplacian_5x5_grayscale);

            Bitmap actualResult = new Bitmap(ImageEdgeDetection.ExtBitmap.Laplacian5x5Filter(temp, true));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02));
        }

        /// <summary>
        /// Test the method ExtBitmap.LaplacianOfGaussian
        /// </summary>
        [TestMethod]
        public void TestLaplacianOfGaussianFilter()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.laplacian_of_gaussian);

            Bitmap actualResult = new Bitmap(ImageEdgeDetection.ExtBitmap.LaplacianOfGaussianFilter(temp));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02));
        }
    }
}

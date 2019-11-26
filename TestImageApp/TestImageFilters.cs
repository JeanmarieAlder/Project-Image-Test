using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using ImageEdgeDetection;

namespace TestImageApp
{
    /// <summary>
    /// Test class for the swap and crazy filters methods.
    /// </summary>
    [TestClass]
    public class TestImageFilters
    {
        /// <summary>
        /// Test the method ImageFilers.ApplyFilterSwap
        /// </summary>
        [TestMethod]
        public void TestSwapFilter()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original_for_filters);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.swap_filter);

            Bitmap actualResult = new Bitmap(ImageEdgeDetection.ImageFilters.ApplyFilterSwap(temp));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02), "The images did not match.");
        }

        /// <summary>
        /// Test the method ImageFilers.ApplyFilterSwapDivide and ApplyFilterSwap.
        /// There two methods are required to make the crazy filter.
        /// </summary>
        [TestMethod]
        public void TestCrazyFilter()
        {
            Bitmap temp = new Bitmap(ResourceTestImages.original_for_filters);
            Bitmap expectedResult = new Bitmap(ResourceTestImages.crazy_filter);

            temp = ImageFilters.ApplyFilterSwapDivide(new Bitmap(temp), 1, 1, 2, 1);
            Bitmap actualResult = ImageFilters.ApplyFilterSwap(new Bitmap(temp));

            Assert.IsTrue(UtilImageComparison.CompareImageTheSame(actualResult, expectedResult, 0.02), "The images did not match.");
        }
    }
}

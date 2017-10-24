using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyColors;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class MyColorsUnitTest
    {
        [TestMethod]
        public void TestMethod1_colorName()
        {
            MyColor color = new MyColor(Color.Black);
            Assert.AreEqual(Color.Black.Name, color.Name);
        }

        [TestMethod]
        public void TestMethod1_colorHex()
        {
            MyColor color = new MyColor(Color.Black);
            Assert.AreEqual(Color.Black.ToArgb().ToString("X6"), color.HtmlHex);
        }
    }
}

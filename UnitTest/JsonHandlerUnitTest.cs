using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JsonHandler;
using Newtonsoft.Json;
using System.Drawing;

namespace UnitTest
{
    [TestClass]
    public class JsonHandlerUnitTest
    {
        static string testData =
                    "\"Black\"";

        [TestMethod]
        public void TestMethod1_ToSerializeJsonObject()
        {
            Color black = Color.Black;

            string data = JsonHandler.JsonHandler.ToSerializeJsonObject(black);
            Assert.AreEqual(data, testData);
        }

        [TestMethod]
        public void TestMethod1_ToDeserializeJsonObject()
        {
            Color black = Color.Black;

            Color test = JsonHandler.JsonHandler.ToDeserializeJsonObject<Color>(testData);
            Assert.AreEqual(test, black);
        }
    }
}

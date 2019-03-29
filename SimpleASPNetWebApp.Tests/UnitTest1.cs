using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SimpleASPNetWebApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string s = "1";
            Assert.IsTrue(s == "1");
        }

    }
}

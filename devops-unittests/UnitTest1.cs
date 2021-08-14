using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace devops_unittests
{
    [TestClass]
    public class UnitTest1
    {
        private const string fExpected = "Hello there, sailor!";

        [TestMethod]
        public void TestMethod1()
        {
            using(StringWriter sw = new StringWriter())
            {
                Console.SetOut(sw);
                devops_testing.Program.Main();

                string lResult = sw.ToString().Trim();
                Assert.AreEqual(fExpected, lResult);
            }
        }
    }
}

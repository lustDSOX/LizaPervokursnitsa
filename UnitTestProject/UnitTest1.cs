using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using REG_MARK_LIB;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestCheckMark()
        {
            var calc = new Class();
            string text = "а999аа999";
            bool answer = calc.CheckMark(text);

            Assert.AreEqual(true, answer);
        }

        [TestMethod]
        public void TestGetNextMarkAfter()
        {
            var calc = new Class();
            string text = "а999аа999";
            string answer = calc.GetNextMarkAfter(text);

            Assert.AreNotEqual(text, answer);
        }
    }
}

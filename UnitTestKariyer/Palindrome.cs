using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestKariyer
{
    [TestClass]
    public class Palindrome
    {
        KariyerTest.Palindrome testPalindrome = new KariyerTest.Palindrome();

        [TestMethod]
        public void Check1()
        {
            bool result = testPalindrome.Check("ABCCBA");

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Check2()
        {
            bool result = testPalindrome.Check("ABCDCBA");

            Assert.AreEqual(result, true);
        }

        [TestMethod]
        public void Check3()
        {
            bool result = testPalindrome.Check("EBCDCBA");

            Assert.AreEqual(result, false);
        }

        [TestMethod]
        public void Check4()
        {
            bool result = testPalindrome.Check("");

            Assert.AreEqual(result, false);
        }


    }
}

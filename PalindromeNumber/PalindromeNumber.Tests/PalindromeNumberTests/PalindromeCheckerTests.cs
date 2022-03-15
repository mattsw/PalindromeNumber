using Microsoft.VisualStudio.TestTools.UnitTesting;
using PalindromeNumber.Palindrome;

namespace PalindromeNumber.Tests.PalindromeNumberTests
{
    [TestClass]
    public class PalindromeCheckerTests
    {
        [TestMethod]
        public void PalindromeChecker_ShouldIdentifyPalindromeNumber()
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(121);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void PalindromeChecker_ShouldIdentifyIncorrectPalindromeNumber()
        {
            var sut = new PalindromeChecker();
            var result = sut.IsPalindrome(122);
            Assert.IsFalse(result);
        }
    }
}

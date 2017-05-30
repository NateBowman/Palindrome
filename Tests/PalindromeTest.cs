namespace Palindrome.Tests {
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class PalindromeTest {
        private readonly string[] falsePalindromes = new[]
        {
            "redivder",
            " none",
            " civi",
            " radr",
            " leve",
            " motor",
            " kayk",
            " reiver",
            " raecar",
            " reddr",
            " mada",
            "refr",
            "Mr. Ow ate my metal worm",
            "Was it a ca I saw?",
            "Go hang a salami, I'm a sausage hog",
            "Rats live on n evil star",
            "Live on time, emit ",
            "Step on pets",
            "1311",
            "165144561",
            "40",
            "AaB",
            "ab",
        };
        private readonly string[] truePalindromes = new[]
        {
            "redivider",
            " noon",
            " civic",
            " radar",
            " level",
            " rotor",
            " kayak",
            " reviver",
            " racecar",
            " redder",
            " madam",
            "refer",
            "Mr. Owl ate my metal worm",
            "Was it a cat I saw?",
            "Go hang a salami, I'm a lasagna hog",
            "Rats live on no evil star",
            "Live on time, emit no evil",
            "Step on no pets",
            "1331",
            "1654561",
            "4",
            "Aa",
            "a",
        };

        [TestMethod]
        public void WhenMixedCaseStringIsAPalindromeReturnTrue() {
            var str = "Racecar";
            Assert.IsTrue(str.IsPalindrome());
        }

        [TestMethod]
        public void WhenPunctuatedStringIsAPalindromeReturnTrue() {
            var str = "Race-car";
            Assert.IsTrue(str.IsPalindrome());
        }

        [TestMethod]
        public void WhenStringEmptyReturnTrue() {
            var str = "";
            Assert.IsTrue(str.IsPalindrome());
        }

        [TestMethod]
        public void WhenStringIsAPalindromeReturnTrue() {
            var str = "racecar";
            Assert.IsTrue(str.IsPalindrome());
        }

        [TestMethod]
        public void WhenStringIsNotAPalindromeReturnFalse() {
            var str = "peanuts";
            Assert.IsFalse(str.IsPalindrome());
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void WhenStringIsNullThrowArgumentNullException() {
            ((string)null).IsPalindrome();
            Assert.Fail("Did not throw ArgumentNullException");
        }

        [TestMethod]
        public void WhenStringIsOneCharReturnTrue() {
            var str = "a";
            Assert.IsTrue(str.IsPalindrome());
        }

        [TestMethod]
        public void WhenStringsAreAPalindromesReturnTrue() {
            foreach (var truePalindrome in truePalindromes) {
                Assert.IsTrue(truePalindrome.IsPalindrome(), $"failed on {truePalindrome}");
            }
        }

        [TestMethod]
        public void WhenStringsAreNotPalindromesReturnFalse() {
            foreach (var falsePalindrome in falsePalindromes) {
                Assert.IsFalse(falsePalindrome.IsPalindrome(), $"failed on {falsePalindrome}");
            }
        }
    }
}
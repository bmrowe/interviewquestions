using System;
using Xunit;
using palindromedetector;

namespace palindromedetectortests
{
    public class PalindromeDetectorTests
    {     
        [Fact]
        public void PalindromeDetectorRetunsTrue()
        {
            var detector = new PalindromeDetector();
            Assert.True(detector.IsPalindrome("a man a plan a canal panama"));
        }

        [Fact]
        public void PalindromeDetectorFindsLongestPalindromePhraseInText()
        {
            var detector = new PalindromeDetector();
            var text = "Have you heard the phrase a man a plan a canal panama?";

            var result = detector.FindLongestPalindrome(text);

            Assert.Equal("a man a plan a canal panama", result);
        }

    }
}
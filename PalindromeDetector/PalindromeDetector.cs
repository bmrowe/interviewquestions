using System;
using System.Collections.Generic;
using System.Linq;

namespace palindromedetector
{
    public class PalindromeDetector
    {
        public string FindLongestPalindromeInText(string text)
        {
            var sentences = text.Split(new []{'.', '!', '?'}, StringSplitOptions.RemoveEmptyEntries);
            var longestPalindrome = string.Empty;
            foreach(var sentence in sentences)
            {
                var palindrome = FindLongestMultiWordPalindrome(sentence);
                if(palindrome.Length > longestPalindrome.Length)
                {
                    longestPalindrome = palindrome;
                }
            }

            return longestPalindrome;
        }

        public bool IsPalindrome(string textToCheck)
        {
            textToCheck = textToCheck.ToLower();
            textToCheck = textToCheck.Replace(" ", "").Replace(",", "")
                                     .Replace(";", "").Replace(":", "")
                                     .Replace("'", "");

            var characterArray = textToCheck.ToCharArray();
            Array.Reverse(characterArray);
            var reversedText = new String(characterArray);

            return string.Equals(textToCheck, reversedText);
        }

        private string FindLongestMultiWordPalindrome(string sentence)
        {
            var longestPalindrome = string.Empty;

            var startIndex = 0;
           
            while(startIndex < sentence.Length-1)
            {
                var endIndex = sentence.Length;
                
                while(endIndex > startIndex + 1)
                {
                    var substring = sentence.Substring(startIndex, endIndex - startIndex);
                    endIndex--;

                    if(!StringStartsOrEndsWithSpace(substring) && IsPalindrome(substring) && substring.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = substring;
                    }
                }
                startIndex++;
            }

            return longestPalindrome;
        }

        private bool StringStartsOrEndsWithSpace(string text)
        {
            return (text[0] == ' ' || text[text.Length - 1] == ' ');  
        }
    }
}
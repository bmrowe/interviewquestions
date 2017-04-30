using System;
using System.Collections.Generic;
using System.Linq;

namespace palindromedetector
{
    public class PalindromeDetector
    {
        
        public string FindLongestPalindrome(string text)
        {
            var longestPalindrome = string.Empty;

            var startIndex = 0;
           
            while(startIndex < text.Length-1)
            {
                var endIndex = text.Length;
                
                while(endIndex > startIndex + 1)
                {
                    var substring = text.Substring(startIndex, endIndex - startIndex);
                    endIndex--;

                    if(!StringStartsOrEndsNonLetter(substring) 
                        && IsPalindrome(substring) 
                        && substring.Length > longestPalindrome.Length)
                    {
                        longestPalindrome = substring;
                    }
                }
                startIndex++;
            }

            return longestPalindrome;
        }

        public bool IsPalindrome(string textToCheck)
        {
            textToCheck = textToCheck.ToLower();
            textToCheck = textToCheck.Replace(".", "").Replace("?", "")
                                     .Replace("!", "").Replace(",", "")
                                     .Replace(" ", "").Replace(",", "")
                                     .Replace(";", "").Replace(":", "")
                                     .Replace("'", "");

            var characterArray = textToCheck.ToCharArray();
            Array.Reverse(characterArray);
            var reversedText = new String(characterArray);

            return string.Equals(textToCheck, reversedText);
        }

        
        private bool StringStartsOrEndsNonLetter(string text)
        {
            var symbols = new List<string>(){".", "?", "!", ",", " ", ",", ";", ":", "'"};

            return symbols.Contains(text[0].ToString()) || symbols.Contains(text[text.Length - 1].ToString());
        }
    }
}
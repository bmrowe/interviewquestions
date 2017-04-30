using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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

                    if(StringStartsAndEndsWithLetter(substring) && IsPalindrome(substring) 
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
            textToCheck = RemoveSymbolsFromString(textToCheck);

            var characterArray = textToCheck.ToCharArray();
            Array.Reverse(characterArray);
            var reversedText = new String(characterArray);

            return string.Equals(textToCheck, reversedText);
        }

        private string RemoveSymbolsFromString(string text)
        {
            var stringBuilder = new StringBuilder();
            foreach(var character in text)
            {
                if(Char.IsLetter(character)){
                    stringBuilder.Append(character);
                }
            }
            return stringBuilder.ToString();
        }
        
        private bool StringStartsAndEndsWithLetter(string text)
        {
            return Char.IsLetter(text[0]) && Char.IsLetter(text[text.Length - 1]);
        }
    }
}
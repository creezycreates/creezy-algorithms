using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCode.Easy.Palindromes
{
    public class PalindromeValidator
    {
        public bool IsPalindome(string s)
        {
            bool valid = false;
            StringBuilder text = new StringBuilder();
           

            foreach(char c in s)
            {
                if(char.IsLetterOrDigit(c))
                {
                    text.Append(char.ToLowerInvariant(c));
                }
            }

            string cleanedText = text.ToString().Trim();
            string reversedText = ReverseText(cleanedText);

            if(cleanedText == reversedText)
            {
                valid = true;
            }
            

            return valid;

        }

        private string ReverseText(string s)
        {
            string reversedText = "";
            if (s.Length > 0)
            {
                StringBuilder textBuilder = new StringBuilder();
                for (int i = s.Length - 1; i >= 0; i--)
                {
                    textBuilder.Append(s[i]);
                }
                reversedText = textBuilder.ToString();
            }
            return reversedText;
        }


    }
}

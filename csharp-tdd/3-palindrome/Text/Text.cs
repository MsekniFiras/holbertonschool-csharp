using System;
using System.Text.RegularExpressions;

namespace Text
{
    /// <summary>
    /// check Palindrome
    /// </summary>
    public class Str
    {
        /// <summary>
        /// check Palindrome
        /// </summary>
        /// <param name="s"> string to check</param>
        /// <returns> True or false </returns>
        public static bool IsPalindrome(string s)
        {
            int len;
            string revS = "";
            try
            {
                len = s.Length - 1;
            }
            catch
            {
                return false;
            }
            if (s.Length == 0)
                return true;
            while (len >= 0)
            {
                revS = revS + s[len];
                len--;
            }

            revS = Regex.Replace(revS, @"\W|_", string.Empty);
            s = Regex.Replace(s, @"\W|_", string.Empty);
            if (string.Compare(revS.ToLower(), s.ToLower()) == 0)
                return true;
            return false;
        }
    }
}

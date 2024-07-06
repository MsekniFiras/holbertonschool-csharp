using System;

namespace Text
{
    /// <summary>
    /// find first non repeating char
    /// </summary>
    public class Str
    {
        /// <summary>
        /// find first non repeating charachter 
        /// </summary>
        /// <param name="s">string to search </param>
        /// <returns>-1 or index of first non repeating char</returns>
        public static int UniqueChar(string s)
        {
            int len;
            int n = 0;
            int rep = 0;
            try
            {
                len = s.Length;
            }
            catch
            {
                return -1;
            }
            foreach (var elem in s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    if (s[i] == elem)
                    {
                        rep += 1;
                    };
                }
                if (rep == 1)
                {
                    return n;
                }
                rep = 0;
                n += 1;
            }
            return -1;
        }
    }
}

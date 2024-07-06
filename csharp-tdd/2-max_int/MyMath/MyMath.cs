using System;
using System.Collections.Generic;

namespace MyMath
{
    /// <summary>
    /// Find the max
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Function that finds the max integer in a list of integers
        /// </summary>
        /// <param name="nums">List of integers</param>
        /// <returns>Integer: the max integer</returns>
        public static int Max(List<int> nums)
        {
            int max = int.MinValue;
            if (nums.Count > 0)
            {
                foreach (var item in nums)
                {
                    if (max < item)
                        max = item;
                }
                return max;
            }
            else
                return 0;
        }
    }
}

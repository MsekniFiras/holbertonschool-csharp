using System;

/// <summary>
/// VectorMath Class
/// </summary>
    class VectorMath
    {
        /// <summary>
    /// Calculates dot product of two vectors
    /// </summary>
    /// <param name="vector1">first vector</param>
    /// <param name="vector2">second vector</param>
    /// <returns>dot product of the two vectors</returns>
        public static double DotProduct(double[] vector1, double[] vector2)
        {
        

            if (vector1.Length != vector2.Length ||
            vector1.Length < 2 || vector2.Length > 3 ||
            vector2.Length < 2 || vector2.Length > 3)
                return -1;
            double x = 0;
            for (int i = 0; i < vector1.Length; i++)
            {   
                x += vector1[i] * vector2[i];     
            }
            return x;
        }
    }

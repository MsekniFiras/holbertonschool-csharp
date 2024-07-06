using System;

namespace MyMath
{
    public class Matrix
    {
    /// <summary>
    /// Matrix operations
    /// </summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            /// <summary>
            /// Function that divides matrix elements by an integer
            /// </summary>
            /// <param name="matrix">matrix containing integers to be divided</param>
            /// <param name="num">Divider</param>
            /// <returns>New matrix containing divided elements</returns>
            if (matrix == null)
                return null;
            int [,] new_matrix = new int [matrix.GetLength(0), matrix.GetLength(1)];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    try
                    {
                        new_matrix[i,j] = matrix[i,j] / num;
                    }
                    catch
                    {
                        Console.WriteLine("Num cannot be 0");
                        return null;
                    }
                }
            }
            return new_matrix;
        }

    }
}

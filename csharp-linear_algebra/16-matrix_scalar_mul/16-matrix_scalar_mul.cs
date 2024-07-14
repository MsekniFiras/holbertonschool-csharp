using System;

/// <summary>
/// class MatrixMath
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiply matrix by scalar
    /// </summary>
    /// <param name="matrix"> Matrix 2D or 3D</param>
    /// <param name="scalar">Scalar</param>
    /// <returns>the product of matrice and scalar or -1 if not possible</returns>
	public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        if (matrix.Length < 2 || matrix.GetLength(0) != matrix.GetLength(1))
            return new double[,] { { -1 } };

        
        
        double[,] A = new double[matrix.GetLength(0), matrix.GetLength(1)];

        for(int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
                A[i, j] = matrix[i, j] * scalar; 
        }
        return A;
    }
}

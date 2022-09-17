using System;

public class Solution
{
    public bool IsToeplitzMatrix(int[][] matrix)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int tmp;
        for (int c = 0; c < cols - 1; c++)
        {
            tmp = matrix[0][c];
            int i = 1;
            int j = c + 1;
            while (i < rows & j < cols)
            {
                if (matrix[i][j] != tmp)
                    return false;
                ++i;
                ++j;
            }
        }
        for (int r = 1; r < rows - 1; r++)
        {
            tmp = matrix[r][0];
            int i = r + 1;
            int j = 1;
            while (i < rows & j < cols)
            {
                if (matrix[i][j] != tmp)
                    return false;
                ++i;
                ++j;
            }
        }
        return true;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        int[][] matrix = new int[][] { new int[] { 1, 2, 3, 4 }, new int[] { 5, 1, 2, 3 }, new int[] { 9, 5, 1, 2 } };
        Console.WriteLine("{0}", (new Solution()).IsToeplitzMatrix(matrix));
    }
}
using System;

namespace ZeroMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {
                new int[] {1,1,1,1},
                 new int[] {1,1,1,1},
                 new int[] {1,1,1,1},
                 new int[] {0,1,1,1},

            };
            ZeroMatrix(matrix);
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    Console.Write("{0} ", matrix[i][j]);
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");

            static int[][] ZeroMatrix(int[][] matrix)
            {
                if (matrix.Length < 1) return matrix;

                bool row = false;
                bool column = false;
                for (int i = 0; i < matrix[0].Length; i++)
                {
                    if (matrix[0][i] == 0) { row = true; break; }
                }
                for (int i = 0; i < matrix.Length; i++)
                {
                    if (matrix[i][0] == 0) { column = true; break; }
                }
                // find and mark zeroes in matrix [i][j]
                for (int i = 1; i < matrix.Length; i++)
                {
                    for (int j = 1; j < matrix[i].Length; j++)
                    {
                        if (matrix[i][j] == 0) { matrix[i][0] = 0; matrix[0][j] = 0; }
                    }
                }
                //set columns to zero
                for (int i = 1; i < matrix.Length; i++)
                {
                    if (matrix[i][0] == 0)
                    {
                        for (int j = 0; j < matrix[i].Length; j++)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
                //set rows to zero
                for (int j = 1; j < matrix[0].Length; j++)
                {
                    if (matrix[0][j] == 0)
                    {
                        for (int i = 0; i < matrix.Length; i++)
                        {
                            matrix[i][j] = 0;
                        }
                    }
                }
                if (row)
                    for (int i = 0; i < matrix[0].Length; i++)
                    {
                        matrix[0][i] = 0;
                    }
                if (column)
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        matrix[i][0] = 0;
                    }
                return matrix;
            }
        }
    }
}

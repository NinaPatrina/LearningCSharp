using System;

namespace RotateMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][]
            {new int[] {0,1,2,3},
            new int[] {4,5,6,7},
            new int[] {8,9,10,11},
            new int[] {12,13,14,15} }
                            ;
            int[][] matrix1 = new int[][]
            {new int[] {0,1},
            new int[] {2,3},
             }
                            ;
            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    Console.Write("{0} ,", matrix1[i][j]);
                }
                Console.WriteLine(" ");

            }
            RotateMatrix(matrix1);
            Console.WriteLine(" ");

            Console.WriteLine(" ");


            for (int i = 0; i < matrix1.Length; i++)
            {
                for (int j = 0; j < matrix1[i].Length; j++)
                {
                    Console.Write("{0} ,", matrix1[i][j]);
                }
                Console.WriteLine(" ");

            }

            static int[][] RotateMatrix(int[][] matrix)
            {
                if (matrix.Length <= 1) return matrix;
                for (int first = 0; first < matrix.Length - 1; first++)
                {
                    int last = matrix[first].Length - 1-first;
                    int add = 0;
                   
                    while (first + add < last)
                    {
                        int temp = matrix[first][first + add];
                        matrix[first][first + add] = matrix[last - add][first];
                        matrix[last - add][first] = matrix[last][last - add];
                        matrix[last][last - add] = matrix[first + add][last];
                        matrix[first + add][last] = temp;
                        add++;
                    }
                }
                return matrix;
            }
        }
    }
}

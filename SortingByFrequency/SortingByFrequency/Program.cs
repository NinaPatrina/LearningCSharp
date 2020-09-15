using System;
using System.Linq;


namespace SortingByFrequency
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 5, 2, 8, 5, 6, 8, 8 };
            int[] indexes = Enumerable.Range(0, arr.Length).ToArray();
            Array.Sort(arr, indexes);
            int[,] matrix = new int[2, arr.Length];
            int c = 0;
            int m = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int a = Math.Min(indexes[i], indexes[i + 1]);
                Matrix0(c, i, a, indexes, arr, matrix, out m, out matrix);
                Console.WriteLine(matrix[1, c]);
                c++;
                i = m;
            }
            for (int i = 0; i < c; i++)
            {
                int a = GetA(i, c,arr);
                Matrix1(a, i, matrix);
                i = i + a - 1;
            }
        }
        static int[,] Matrix0(int c, int m, int a, int[] indexes, int[] arr, int[,] matrix, out int m1, out int[,] matrix1))
        {
            matrix[0, c] = indexes[m];
            for (int i = m; i < arr.Length - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                {
                    matrix[0, c] = Math.Min(a, indexes[i + 1]);
                    a = Math.Min(a, indexes[i + 1]);
                }
                else
                    m1 = m;
                    matrix1 =  matrix;
            }
          
                m1= m;
                matrix1 = matrix;
        }
        static int GetA(int b, int c,int[] arr)
        {
            int a = 1;
            for (int i = b; i < c - 1; i++)
            {
                if (arr[i] == arr[i + 1])
                    a++;
                else
                    return a;
            }
            return a;
        }
        static int[,] Matrix1(int a, int i, int[,] matrix)
        {
            for (int j = i; j <= i + a - 1; j++)
            {
                matrix[1, j] = a;
                Console.WriteLine(matrix[1, j]);
            }
            return matrix;
        }
    }
}

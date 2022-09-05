using System;
using System.Text;

namespace Baekjoon.silver
{
    internal class _2740
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] a = new int[n[0]][];
            for(int i = 0; i < n[0]; i++)
                a[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] b = new int[m[0]][];
            for (int i = 0; i < m[0]; i++)
                b[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[,] c = new int[n[0],m[1]];

            for(int i = 0; i < n[0]; i++)
            {
                for(int j = 0; j < m[1]; j++)
                {
                    for (int k = 0; k < n[1]; k++)
                        c[i, j] += a[i][k] * b[k][j];
                }
            }

            for(int i = 0; i< c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                    stb.Append(c[i, j].ToString()+" ");
                stb.AppendLine();
            }

            Console.WriteLine(stb);
        }
    }
}

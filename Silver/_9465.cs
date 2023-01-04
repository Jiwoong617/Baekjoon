using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _9465
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                int[][] arr = new int[2][];
                int[][] score = new int[2][];
                for (int i = 0; i < 2; i++)
                {
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    score[i] = new int[n + 1];
                }

                score[0][0] = 0; score[1][0] = 0;
                score[0][1] = arr[0][0]; score[1][1] = arr[1][0];
                for(int i = 2; i<=n; i++)
                {
                    score[0][i] = Math.Max(score[1][i-1], score[1][i-2]) + arr[0][i-1];
                    score[1][i] = Math.Max(score[0][i-1], score[0][i-2]) + arr[1][i-1];
                }

                stb.AppendLine(Math.Max(score[0][n], score[1][n]).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}

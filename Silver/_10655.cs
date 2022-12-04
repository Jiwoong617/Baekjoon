using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _10655
    {
        static void Main_10655(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)> checkpoint = new List<(int, int)>();

            for(int i = 0; i< n; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                checkpoint.Add((arr[0], arr[1]));
            }

            List<int> distance = new List<int>();
            for(int i = 0; i<n-1; i++)
                distance.Add(Math.Abs(checkpoint[i].Item1 - checkpoint[i + 1].Item1) + Math.Abs(checkpoint[i].Item2 - checkpoint[i + 1].Item2));

            List<int> diff = new List<int>();
            for(int i = 0; i<n-2; i++)
            {
                int jump = Math.Abs(checkpoint[i].Item1 - checkpoint[i + 2].Item1) + Math.Abs(checkpoint[i].Item2 - checkpoint[i + 2].Item2);
                diff.Add(distance[i] + distance[i + 1] - jump);
            }

            int maxdiff = diff.Max();
            Console.WriteLine(distance.Sum() - maxdiff);
        }
    }
}

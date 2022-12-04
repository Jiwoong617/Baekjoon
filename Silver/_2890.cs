using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _2890
    {
        static void Main_2890(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            string[] arr = new string[n[0]];
            for (int i = 0; i < n[0]; i++)
                arr[i] = Console.ReadLine();

            List<(int, int)> list = new List<(int, int)>();
            for(int i = 0; i < n[0]; i++)
            {
                int count = 0;

                for(int j = n[1]-2; j>=0; j--)
                {
                    if (arr[i][j] != 'S' && arr[i][j] != '.')
                    {
                        list.Add((int.Parse(arr[i][j].ToString()), count));
                        break;
                    }
                    else if (arr[i][j] == '.')
                        count++;
                    else
                        break;
                }
            }

            var ranklist = list.OrderBy(x => x.Item2).ThenBy(x => x.Item1).ToArray();
            //Console.WriteLine(string.Join("\n", ranklist));

            int[] ranking = new int[9];
            int rank = 1;

            ranking[ranklist[0].Item1-1] = 1;
            for(int i = 1; i< 9; i++)
            {
                if (ranklist[i].Item2 != ranklist[i - 1].Item2)
                    rank++;

                ranking[ranklist[i].Item1-1] = rank;
            }

            for (int i = 0; i < 9; i++)
                Console.WriteLine(ranking[i]);
        }
    }
}

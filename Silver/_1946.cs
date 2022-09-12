using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.silver
{
    class _1946
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int j = 0; j<n; j++)
            {
                int num = int.Parse(Console.ReadLine());
                int[][] arr = new int[num][];

                for (int i = 0; i < num; i++)
                    arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                var arr2 = arr.OrderBy(x => x[0]).ThenBy(x => x[1]).ToArray();

                int count = 0;
                int temp = arr2[0][1];

                for (int i = 0; i < num; i++)
                {
                    if (arr2[i][1] <= temp)
                    {
                        count++;
                        temp = arr2[i][1];
                    }
                }
                stb.AppendLine(count.ToString());
            }
            Console.WriteLine(stb);
        }
    }
}

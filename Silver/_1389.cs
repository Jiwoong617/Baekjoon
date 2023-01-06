using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _1389
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[][] man = new int[n[0]][];

            int inf = 101;
            for (int i = 0; i < n[0]; i++)
            {
                man[i] = Enumerable.Repeat(inf, n[0]).ToArray();
                man[i][i] = 0;
            }

            for (int i = 0; i < n[1]; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                man[arr[0]-1][arr[1]-1] = 1;
                man[arr[1]-1][arr[0]-1] = 1;
            }

            for(int k = 0; k < n[0]; k++)
            {
                for(int i = 0; i < n[0]; i++)
                {
                    for(int j = 0; j < n[0]; j++)
                        man[i][j] = Math.Min(man[i][j], man[i][k] + man[k][j]);
                }
            }


            for (int i = 0; i < n[0]; i++)
            {
                man[i] = man[i].Select(x => (x == inf) ? 0 : x).ToArray();
                //Console.WriteLine(string.Join(" ", man[i]) + "\n");
            }

            int sum = man[0].Sum();
            int ans = 1;
            for(int i = 1; i < n[0]; i++)
            {
                int tempSum = man[i].Sum();
                if(tempSum < sum)
                {
                    ans = i + 1;
                    sum = tempSum;
                }
            }

            Console.WriteLine(ans);
        }
    }
}

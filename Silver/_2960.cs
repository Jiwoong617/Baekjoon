using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _2960
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Enumerable.Range(0, n[0]+1).ToArray();

            int count = 0;
            for(int i = 2; i <= n[0]; i++)
            {
                if (arr[i] == -1) continue;

                for (int j = i; j <= n[0]; j += i)
                {
                    if (arr[j] == -1) continue;

                    arr[j] = -1;
                    count++;
                    if(count == n[1])
                    {
                        Console.WriteLine(j);
                        return;
                    }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15657
    {
        static StringBuilder stb = new StringBuilder();
        static int[] n;
        static int[] arr;
        static int[] temp; //방문 후 담을 배열

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            temp = new int[n[1]];

            backt(0, 0);
            Console.WriteLine(stb);
        }

        static void backt(int idx, int deep)
        {
            if (deep == n[1])
            {
                foreach (int i in temp)
                    stb.Append($"{i} ");
                stb.AppendLine();
                return;
            }

            for (int i = idx; i < n[0]; i++)
            {
                temp[deep] = arr[i];
                backt(i, deep+1);
            }
        }
    }
}

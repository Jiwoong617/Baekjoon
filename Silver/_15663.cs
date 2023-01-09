using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15663
    {
        //static StringBuilder stb = new StringBuilder();
        static int[] n;
        static int[] arr;
        static bool[] visited;
        static int[] temp; //방문 후 담을 배열

        static HashSet<string> set = new HashSet<string>();

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            visited = new bool[n[0]];
            temp = new int[n[1]];

            backt(0);
            Console.WriteLine(string.Join("\n", set));
        }

        static void backt(int idx)
        {
            if (idx == n[1])
            {
                string s = "";
                foreach (int i in temp)
                    s += $"{i} ";

                set.Add(s);
                return;
            }

            for (int i = 0; i < n[0]; i++)
            {
                if (!visited[i])
                {
                    temp[idx] = arr[i];
                    visited[i] = true;
                    backt(idx + 1);
                    visited[i] = false;
                }
            }
        }
    }
}

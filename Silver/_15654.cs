using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15654
    {
        static StringBuilder stb = new StringBuilder();
        static int[] n;
        static int[] arr;
        static int[] temp; //방문 후 담을 배열
        static bool[] visited; //방문확인용

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            temp = new int[n[1]];
            visited = new bool[n[0]];

            backt(0);
            Console.WriteLine(stb);
        }

        static void backt(int idx)
        {
            if(idx == n[1])
            {
                foreach (int i in temp)
                    stb.Append($"{i} ");
                stb.AppendLine();
                return;
            }

            for (int i = 0; i<n[0]; i++)
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    temp[idx] = arr[i];
                    backt(idx+1);
                    visited[i] = false;
                }
            }
        }
    }
}

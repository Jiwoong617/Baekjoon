using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15666
    {
        //static StringBuilder stb = new StringBuilder();
        static int[] n;
        static int[] arr;
        static int[] temp; //방문 후 담을 배열

        static HashSet<string> set = new HashSet<string>();

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            temp = new int[n[1]];

            backt(0);
            Console.WriteLine(string.Join("\n", set));
        }

        static void backt(int idx)
        {
            if (idx == n[1])
            {
                string s = $"{temp[0]} ";
                int now = temp[0];

                for(int i =1; i < n[1]; i++)
                {
                    if (now > temp[i])
                        return;
                    else
                    {
                        s += $"{temp[i]} ";
                        now = temp[i];
                    }
                }

                set.Add(s);
                return;
            }

            for (int i = 0; i < n[0]; i++)
            {
                temp[idx] = arr[i];
                backt(idx + 1);
            }
        }
    }
}

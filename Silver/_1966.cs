using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1966
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int count;
            int idx;

            for(int i = 0; i<n; i++)
            {
                int sum = 1;
                Queue<(int, int)> que = new Queue<(int, int)>();
                int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                count = a[0];
                idx = a[1];
                int[] important = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int max_import;

                for (int j = 0; j < count; j++)
                    que.Enqueue((j, important[j]));

                max_import = que.Max(x => x.Item2);
                while(que.Count > 0)
                {
                    if(que.Peek().Item2 == max_import && que.Peek().Item1 == idx)
                        break;
                    else if(que.Peek().Item2 == max_import)
                    {
                        sum++;
                        que.Dequeue();
                        max_import = que.Max(x => x.Item2);
                    }
                    else
                        que.Enqueue(que.Dequeue());
                }

                stb.AppendLine(sum.ToString());
            }

            Console.WriteLine(stb);
        }
    }
}

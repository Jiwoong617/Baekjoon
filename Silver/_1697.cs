using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1697
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int max = 100001;
            int[] line = Enumerable.Repeat(0, max).ToArray();
            line[n[0]] = 1;

            Queue<int> que = new Queue<int>();
            que.Enqueue(n[0]);
            while(que.Count > 0)
            {
                int temp = que.Dequeue();

                if((temp-1 >= 0 && temp-1 < max) && line[temp-1] == 0)
                {
                    que.Enqueue(temp - 1);
                    line[temp - 1] = line[temp] + 1;
                }

                if ((temp + 1 >= 0 && temp + 1 < max) && line[temp + 1] == 0)
                {
                    que.Enqueue(temp + 1);
                    line[temp + 1] = line[temp] + 1;
                }

                if ((temp*2 >= 0 && temp*2 < max) && line[temp*2] == 0)
                {
                    que.Enqueue(temp*2);
                    line[temp*2] = line[temp] + 1;
                }

                if (line[n[1]] != 0)
                    break;
            }
            Console.WriteLine(line[n[1]]-1);
        }
    }
}

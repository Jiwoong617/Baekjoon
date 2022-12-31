using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Practice
{
    internal class _14698
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());

            int test = int.Parse(sr.ReadLine());
            long div = 1000000007;

            for (int _ = 0; _ < test; _++)
            {
                int n = int.Parse(sr.ReadLine());
                long[] arr = Array.ConvertAll(sr.ReadLine().Split(), long.Parse);

                if (n == 1)
                    stb.AppendLine("1");
                else
                {
                    // 6 * 48 * 140 * (48*140)
                    PriorityQueue<long, long> pq = new PriorityQueue<long, long>();
                    long ans = 1;

                    for (int i = 0; i < n; i++)
                        pq.Enqueue(arr[i], arr[i]);

                    while(pq.Count > 1)
                    {
                        long a = pq.Dequeue();
                        long b = pq.Dequeue();
                        long sum = a * b;

                        pq.Enqueue(sum, sum);
                        ans = (ans*(sum%div))%div;
                    }

                    stb.AppendLine(ans.ToString());
                }
            }
            
            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}

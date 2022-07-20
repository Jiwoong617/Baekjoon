using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1002
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();

            for (int i = 0; i < num; i++)
            {
                double[] n = Array.ConvertAll(Console.ReadLine().Split(), double.Parse);

                double distance = Math.Sqrt(Math.Pow(n[0] - n[3], 2) + Math.Pow(n[1] - n[4], 2));


                if (n[0] == n[3] && n[1] == n[4] && n[2] == n[5])
                    stb.AppendLine("-1");
                else if (distance > n[2] + n[5])
                    stb.AppendLine("0");
                else if (distance == n[2] + n[5])
                    stb.AppendLine("1");
                else if (n[2] == distance + n[5] || n[5] == distance + n[2])
                    stb.AppendLine("1");
                else if (n[2] > distance + n[5] || n[5] > distance + n[2])
                    stb.AppendLine("0");
                else if (n[2] < distance + n[5] || n[5] < distance + n[2])
                    stb.AppendLine("2");
                
            }
            Console.WriteLine(stb);
        }
    }
}

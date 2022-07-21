using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1004
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());

            for(int i = 0; i<n; i++)
            {
                int[] pos_dest = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int num = int.Parse(Console.ReadLine());
                int count = 0;

                for(int j = 0; j<num; j++)
                {
                    int[] star = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                    double pos_distance = Math.Sqrt(Math.Pow(pos_dest[0] - star[0], 2) + Math.Pow(pos_dest[1] - star[1], 2));
                    double dest_distance = Math.Sqrt(Math.Pow(pos_dest[2] - star[0], 2) + Math.Pow(pos_dest[3] - star[1], 2));

                    if (star[2] > pos_distance && star[2] > dest_distance)
                        continue;
                    else if (star[2] > pos_distance)
                        count++;
                    else if (star[2] > dest_distance)
                        count++;
                }

                stb.AppendLine(count.ToString());
            }
            Console.WriteLine(stb);
        }
    }
}

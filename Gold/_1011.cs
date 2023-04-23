using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _1011
    {
        //https://st-lab.tistory.com/79 보고 이해함
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int dis = n[1] - n[0];

                int max = (int)Math.Sqrt(dis);
                if (max == Math.Sqrt(dis))
                    stb.AppendLine((2*max - 1).ToString());
                else if (dis <= max * max + max)
                    stb.AppendLine((2 * max).ToString());
                else
                    stb.AppendLine((2 * max+1).ToString());
            }
            Console.WriteLine(stb);
        }
    }
}

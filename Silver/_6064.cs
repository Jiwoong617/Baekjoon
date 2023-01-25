using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _6064
    {
        static int gcd(int a, int b) => b == 0 ? a : gcd(b, a % b); //최대 공약수
        static int lcm(int a, int b) => a * b / gcd(a, b); //최대 공배수

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int test = int.Parse(Console.ReadLine());
            while(test-- > 0)
            {
                int[] mnxy = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                int m = mnxy[0]; int n = mnxy[1];
                int x = mnxy[2]; int y = mnxy[3];

                bool flag = false;
                for(int i = x; i<= lcm(m,n); i+=m)
                {
                    int t = i % n == 0 ? n : i % n;
                    if(t == y)
                    {
                        stb.AppendLine(i.ToString());
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                    stb.AppendLine("-1");
            }
            Console.WriteLine(stb);
        }
    }
}

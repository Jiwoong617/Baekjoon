using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baekjoon.Gold
{
    internal class _1987
    {
        static int[] n;
        static string[] s;
        static List<char> passed;
        static int ans;

        static int[] ud = { -1, 1, 0, 0 };
        static int[] lr = { 0, 0, -1, 1 };

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            s = new string[n[0]];
            passed = new List<char>();
            for (int i = 0; i < n[0]; i++)
                s[i] = Console.ReadLine();

            passed.Add(s[0][0]);
            DFS(0, 0);

            Console.WriteLine(ans);
        }

        static void DFS(int x, int y)
        {
            ans = Math.Max(ans, passed.Count);

            for (int i = 0; i<4; i++)
            {
                int x1 = x + ud[i];
                int y1 = y + lr[i];
                if(x1 >= 0 && y1 >= 0 && x1 < n[0] && y1 < n[1])
                {
                    if (!passed.Contains(s[x1][y1]))
                    {
                        passed.Add(s[x1][y1]);
                        DFS(x1, y1);
                        passed.Remove(s[x1][y1]);
                    }
                }
            }
        }
    }
}

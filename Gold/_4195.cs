using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _4195
    {
        static Dictionary<string, int> f;
        static int[] parent;
        static int[] friend;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());
            while(t-- > 0)
            {
                int n = int.Parse(Console.ReadLine());
                f = new Dictionary<string, int>();
                friend = Enumerable.Repeat(1, n*2).ToArray();
                parent = Enumerable.Range(0, n*2).ToArray();

                int count = 0;
                while (n-- > 0)
                {
                    string[] s = Console.ReadLine().Split();

                    foreach (string s2 in s)
                    {
                        if (!f.ContainsKey(s2))
                        {
                            f.Add(s2, count);
                            count++;
                        }
                    }
                    MakeUnion(f[s[0]], f[s[1]]);
                    //Console.WriteLine(string.Join(" ", friend));
                    stb.AppendLine(Math.Max( friend[FindP(f[s[0]])] , friend[FindP(f[s[1]])] ).ToString());
                }
            }
            Console.WriteLine(stb);
        }

        static int FindP(int n)
        {
            if (n == parent[n])
                return n;

            return parent[n] = FindP(parent[n]);
        }

        static void MakeUnion(int a, int b)
        {
            a = FindP(a);
            b = FindP(b);

            if (a == b)
                return;

            if (a > b)
            {
                parent[a] = b;
                friend[b] += friend[a];
                friend[a] = 1;
            }
            else
            {
                parent[b] = a;
                friend[a] += friend[b];
                friend[b] = 1;
            }
        }
    }
}

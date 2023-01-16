using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _1991
    {
        static StringBuilder stb = new StringBuilder();
        static (int,int)[] tree;
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            tree = new (int, int)[n];

            while(n-- > 0)
            {
                char[] s = Array.ConvertAll(Console.ReadLine().Split(), char.Parse);
                tree[Convert.ToInt32(s[0]) - 65] = (Convert.ToInt32(s[1]) - 65, Convert.ToInt32(s[2]) - 65);
            }

            PreOrder(0);
            stb.AppendLine();
            InOrder(0);
            stb.AppendLine();
            PostOrder(0);
            Console.WriteLine(stb);
        }

        static void PreOrder(int node)
        {
            if (node < 0)
                return;

            stb.Append((char)(node + 65));
            PreOrder(tree[node].Item1);
            PreOrder(tree[node].Item2);
        }

        static void InOrder(int node)
        {
            if (node < 0)
                return;

            InOrder(tree[node].Item1);
            stb.Append((char)(node + 65));
            InOrder(tree[node].Item2);
        }

        static void PostOrder(int node)
        {
            if (node < 0)
                return;

            PostOrder(tree[node].Item1);
            PostOrder(tree[node].Item2);
            stb.Append((char)(node + 65));
        }
    }
}

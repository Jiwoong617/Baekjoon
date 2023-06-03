using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    class Net
    {
        public int a;
        public int b;
        public int cost;
    }

    internal class _1922
    {
        static int[] root;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            root = Enumerable.Range(0, n+1).ToArray();

            int m = int.Parse(Console.ReadLine());
            PriorityQueue<Net, int> pq = new PriorityQueue<Net, int>();
            while(m-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                pq.Enqueue(new Net { a = arr[0], b = arr[1], cost = arr[2] }, arr[2]);
            }

            int ans = 0;
            while(pq.Count > 0)
            {
                Net net = pq.Dequeue();
                if (MakeUnion(net.a, net.b))
                    ans += net.cost;
            }

            Console.WriteLine(ans);
        }

        static int FindRoot(int n)
        {
            if (root[n] == n)
                return n;

            return root[n] = FindRoot(root[n]);
        }

        static bool MakeUnion(int a, int b)
        {
            a = FindRoot(a);
            b = FindRoot(b);

            if(a == b) return false;

            if (a > b)
                root[a] = b;
            else
                root[b] = a;

            return true;
        }
    }
}

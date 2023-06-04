using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    class House
    {
        public int a;
        public int b;
        public int cost;
    }

    internal class _1647
    {
        static int[] root;

        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            root = Enumerable.Range(0, n[0] + 1).ToArray();

            PriorityQueue<House, int> pq = new PriorityQueue<House, int>();
            while (n[1]-- > 0)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                pq.Enqueue(new House { a = arr[0], b = arr[1], cost = arr[2] }, arr[2]);
            }

            int ans = 0;
            int max = -1;
            while(pq.Count > 0)
            {
                House house = pq.Dequeue();

                if (MakeUnion(house.a, house.b))
                {
                    ans += house.cost;
                    max = Math.Max(max,house.cost);
                }
            }

            //도시 2개로 분할 -> 전부 연결 후 가중치 가장 높은 길 하나 끊어버림 됨
            Console.WriteLine(ans-max);
        }

        static int FindRoot(int n)
        {
            if (n == root[n])
                return n;

            return root[n] = FindRoot(root[n]);
        }

        static bool MakeUnion(int a, int b)
        {
            a = FindRoot(a);
            b = FindRoot(b);

            if (a == b) return false;

            if (a > b)
                root[a] = b;
            else
                root[b] = a;

            return true;
        }
    }
}

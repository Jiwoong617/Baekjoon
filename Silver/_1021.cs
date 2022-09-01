using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _1021
    {
        static void Main(String[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] m = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int sum = 0;

            List<int> deque = new List<int>();
            for (int i = 1; i <= n[0]; i++)
                deque.Add(i);

            for(int i = 0; i < n[1]; i++)
            {
                bool right = false;

                if (deque.IndexOf(m[i]) <= deque.Count/2)
                    right = true;

                while(deque.First() != m[i])
                {
                    if (right)
                    {
                        sum++;
                        deque.Add(deque.First());
                        deque.RemoveAt(0);
                    }
                    else
                    {
                        sum++;
                        deque.Insert(0, deque.Last());
                        deque.RemoveAt(deque.Count - 1);
                    }
                }

                if (deque.First() == m[i])
                    deque.RemoveAt(0);
            }

            Console.WriteLine(sum);
        }
    }
}

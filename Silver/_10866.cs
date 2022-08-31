using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.silver
{
    class _10866
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<int> deque = new List<int>();
            StringBuilder stb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                string[] a = Console.ReadLine().Split();
                string s = a[0];
                int num = 0;
                if (a.Length > 1)
                    num = int.Parse(a[1]);

                switch (s)
                {
                    case "push_front":
                        deque.Insert(0, num);
                        break;
                    case "push_back":
                        deque.Add(num); 
                        break;
                    case "pop_front":
                        if (deque.Count == 0)
                            stb.AppendLine("-1");
                        else
                        {
                            stb.AppendLine(deque.First().ToString());
                            deque.RemoveAt(0);
                        }
                        break;
                    case "pop_back":
                        if (deque.Count == 0)
                            stb.AppendLine("-1");
                        else
                        {
                            stb.AppendLine(deque.Last().ToString());
                            deque.RemoveAt(deque.Count - 1);
                        }
                        break;
                    case "size":
                        stb.AppendLine(deque.Count.ToString());
                        break;
                    case "empty":
                        if (deque.Count == 0)
                            stb.AppendLine("1");
                        else
                            stb.AppendLine("0");
                        break;
                    case "front":
                        if (deque.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(deque.First().ToString());
                        break;
                    case "back":
                        if (deque.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(deque.Last().ToString());
                        break;
                }
            }
            Console.WriteLine(stb);
        }
    }
}

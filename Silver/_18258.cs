using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _18258
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<int> que = new Queue<int>();
            StringBuilder stb = new StringBuilder();
            int temp = 0;

            for (int i = 0; i < n; i++)
            {
                string[] a = Console.ReadLine().Split();
                string s = a[0];
                int num = 0;
                if (a.Length > 1)
                    num = int.Parse(a[1]);

                switch (s)
                {
                    case "push":
                        que.Enqueue(num);
                        temp = num;
                        break;
                    case "pop":
                        if (que.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(que.Dequeue().ToString());
                        break;
                    case "size":
                        stb.AppendLine(que.Count.ToString());
                        break;
                    case "empty":
                        if (que.Count == 0)
                            stb.AppendLine("1");
                        else
                            stb.AppendLine("0");
                        break;
                    case "front":
                        if (que.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(que.Peek().ToString());
                        break;
                    case "back":
                        if (que.Count == 0)
                            stb.AppendLine("-1");
                        else
                            stb.AppendLine(temp.ToString());
                        break;
                }
            }
            Console.WriteLine(stb);
        }
    }
}

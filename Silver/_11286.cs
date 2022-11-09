using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _11286
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            PriorityQueue<int,int> plus = new PriorityQueue<int,int>();
            PriorityQueue<int,int> minus = new PriorityQueue<int,int>();

            for(int i = 0; i<n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if(num == 0)
                {
                    if (minus.Count > 0 && plus.Count > 0)
                    {
                        if (Math.Abs(minus.Peek()) > Math.Abs(plus.Peek()))
                            stb.AppendLine(plus.Dequeue().ToString());
                        else
                            stb.AppendLine(minus.Dequeue().ToString());
                    }
                    else if (minus.Count > 0)
                        stb.AppendLine(minus.Dequeue().ToString());
                    else if (plus.Count > 0)
                        stb.AppendLine(plus.Dequeue().ToString());
                    else
                        stb.AppendLine("0");
                }
                else
                {
                    if (num > 0)
                        plus.Enqueue(num, num);
                    else
                        minus.Enqueue(num, Math.Abs(num));
                }
            }

            Console.WriteLine(stb);
        }
    }
}

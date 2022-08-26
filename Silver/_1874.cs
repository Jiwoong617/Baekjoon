using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _1874
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();
            bool able = true;
            int now = 1;
            
            for(int i = 0; i<n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                
                if(stack.Count == 0 || stack.Peek() != num)
                {
                    for(int j = now; j<=num; j++)
                    {
                        stack.Push(j);
                        now++;
                        stb.AppendLine("+");
                    }
                }

                if(stack.Peek() == num)
                {
                    stack.Pop();
                    stb.AppendLine("-");
                }
                else if (stack.Peek() > num)
                {
                    able = false;
                }
            }

            if(able)
                Console.WriteLine(stb);
            if (!able)
                Console.WriteLine("NO");
        }
    }
}

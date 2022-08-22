using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _10773
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());

                if (a != 0)
                    stack.Push(a);
                else
                    stack.Pop();
            }
            Console.WriteLine(stack.Sum());
        }
    }
}

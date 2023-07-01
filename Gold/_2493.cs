using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _2493
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n =int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Stack<int> stack = new Stack<int>();
            stack.Push(0);
            stb.Append("0 ");
            for(int i = 1; i < n; i++)
            {
                while(stack.Count> 0)
                {
                    if (arr[stack.Peek()] > arr[i])
                    {
                        stb.Append($"{stack.Peek() + 1} ");
                        break;
                    }
                    stack.Pop();
                }
                if(stack.Count == 0)
                    stb.Append("0 ");

                stack.Push(i);
            }

            Console.WriteLine(stb);
        }
    }
}

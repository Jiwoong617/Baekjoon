using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _17298
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Stack<int> stack = new Stack<int>();
            int[] ans = new int[n];

            for(int i = n-1; i>=0; i--)
            {
                //스택에 들어있으면
                while (stack.Count > 0)
                {
                    //만약 스택 top이 지금보다 같거나 작으면 뽑기
                    if (stack.Peek() <= arr[i])
                        stack.Pop();
                    else //아니면 탈출
                        break;
                }

                //스택이 비었다면 현재보다 우측에 큰게 없으니까 -1
                if (stack.Count == 0)
                    ans[i] = -1;
                else //아니면 가장 우측 왼쪽꺼가 꼭대기에 있음
                    ans[i] = stack.Peek();

                stack.Push(arr[i]);
            }
            Console.WriteLine(string.Join(" ", ans));
        }
    }
}

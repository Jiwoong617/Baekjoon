using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _14002
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] count = Enumerable.Repeat(1, n).ToArray(); //최대 길이 담을 배열
            int maxidx = 0; //최대 길이 인덱스
            int maxlen = 1; //최대 길이
            Stack<int> stack = new Stack<int>();

            for(int i = 1; i< n; i++)
            {
                for(int j = 0; j<i; j++)
                {
                    if (arr[i] > arr[j])
                        count[i] = Math.Max(count[i], count[j]+1);
                }

                if(maxlen < count[i])
                {
                    maxlen= count[i];
                    maxidx = i;
                }
            }

            stb.AppendLine(maxlen.ToString());
            for(int i = maxidx; i>= 0; i--)
            {
                if (count[i] == maxlen)
                {
                    stack.Push(arr[i]);
                    maxlen--;
                }
            }

            while (stack.Count > 0)
                stb.Append($"{stack.Pop()} ");

            Console.WriteLine(stb);
        }
    }
}

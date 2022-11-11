using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _5525
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int len = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();
            //string io = string.Concat(Enumerable.Repeat("IO", n)) + "I";
            //Console.WriteLine(io);

            Queue<int> que = new Queue<int>();
            for(int i = 0; i<len; i++)
            {
                if (s[i] == 'I')
                    que.Enqueue(i);
            }

            int ans = 0;
            int temp = que.Dequeue(); //이전 I인덱스
            int count = 0;
            while (que.Count > 0)
            {
                if (que.Peek() - temp == 2)
                    count++;
                else
                    count = 0;

                if (count >= n)
                    ans++;

                temp = que.Dequeue();
            }

            Console.WriteLine(ans);
        }
    }
}

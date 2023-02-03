using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _14501
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] arr = new int[n][];
            for (int i = 0; i < n; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int[] money = new int[n+2]; //시작, 끝 0
            for(int i = n; i> 0; i--)
            {
                if (arr[i-1][0] > n+1 - i)
                    money[i] = money[i+1];
                else
                    money[i] = Math.Max(arr[i-1][1] + money[i + arr[i-1][0]], money[i+1]);
            }
            Console.WriteLine(money[1]);
        }
    }
}

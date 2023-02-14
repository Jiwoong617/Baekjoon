using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _9657
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //1 - s
            //2 - c
            //3 - s
            //4 - s
            //5 - s
            //6 - s
            //7 - c
            //8 - s
            //9 - c
            //10 - s
            //11 - s
            //12 - s
            //13 - s
            //14 - c
            //7로 나눌때 0, 2이면 창영이가 이김
            Console.WriteLine((n % 7 == 0 || n % 7 == 2) ? "CY" : "SK");
        }
    }
}

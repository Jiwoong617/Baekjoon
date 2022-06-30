using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _2292
    {
        static void Main(string[] agrs)
        {
            int num = int.Parse(Console.ReadLine());
            int hive = 1;
            int sum = 1;
            while (true)
            {                
                if (sum >= num)
                    break;
                sum += (hive * 6);
                hive++;
            }
            Console.Write(hive);
        }
    }
}

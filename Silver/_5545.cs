using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    class _5545
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); //토핑 종류 수
            int[] cost = Array.ConvertAll(Console.ReadLine().Split(), int.Parse); //도우가격, 토핑가격
            int dow = int.Parse(Console.ReadLine()); //열량
            int[] topping = new int[n]; //토핑
            for (int i = 0; i < n; i++)
                topping[i] = int.Parse(Console.ReadLine());
            Array.Sort(topping);

            double sum = dow;
            int num = 1;
            for(int i = n-1; i>=0; i--)
            {
                double temp = sum + topping[i];
                if (temp / (cost[0] + cost[1] * num) > sum / (cost[0] + cost[1] * (num-1)))
                {
                    sum = temp;
                    num++;
                }
                else
                    break;

            }

            Console.WriteLine((int)(sum / (cost[0] + cost[1] * (num-1))));
        }   
    }
}

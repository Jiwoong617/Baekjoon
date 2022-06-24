using System;
using System.Collections.Generic;
using System.Text;
using System.Linq; //배열 max 쓰기위해

namespace Baekjoon
{
    class _1541
    {
        static void Main(string[] args)
        {            
            int a = int.Parse(Console.ReadLine());
            string[] n = Console.ReadLine().Split();
            double[] num = new double[a];
            double avr = 0;

            for (int i= 0; i<a; i++)
                num[i] = Convert.ToDouble(n[i]);

            double m = num.Max();

            for (int j = 0; j<num.Length; j++)
            {
                num[j] = num[j] / m * 100;
                avr += num[j];
            }
            avr /= a;


            Console.WriteLine(avr);

        }
    }
}

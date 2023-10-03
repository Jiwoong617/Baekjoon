using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _11444
    {
        static Dictionary<long, long> fibo = new Dictionary<long, long>();

        static void Main(string[] args)
        {
            long n = long.Parse(Console.ReadLine());
            fibo[0] = 0; fibo[1] = 1; fibo[2] = 1;
            Console.WriteLine(Fibo(n));
        }

        static long Fibo(long n)
        {
            if (n < 3)
                return fibo[n];

            if(n%2 == 0)
            {
                long num1 = fibo.ContainsKey(n / 2 - 1) ? fibo[n / 2 - 1] : Fibo(n / 2 - 1);
                long num2 = fibo.ContainsKey(n / 2) ? fibo[n / 2] : Fibo(n / 2);
                fibo[n] = (2 * num1 * num2 + num2 * num2) % 1000000007;
            }
            else
            {
                long num1 = fibo.ContainsKey((n + 1) / 2) ? fibo[(n + 1) / 2] : Fibo((n + 1) / 2);
                long num2 = fibo.ContainsKey((n - 1) / 2) ? fibo[(n - 1) / 2] : Fibo((n - 1) / 2);
                fibo[n] = (num1 * num1 + num2 * num2) % 1000000007;
            }
            return fibo[n];
        }
    }
}

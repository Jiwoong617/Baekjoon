using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _24416
    {
        static int sum;
        static int dynamic_sum;
        static int[] arr;

        static void Main(string[] args)
        {
            sum = 0;
            dynamic_sum = 0;
            arr = new int[41];
            arr[0] = 0;
            int n = int.Parse(Console.ReadLine());
            fibo(n);
            dynamic_fibo(n);

            Console.WriteLine($"{sum} {dynamic_sum}");
        }

        static int fibo(int n)
        {
            if (n == 1 || n == 2)
            {
                sum++;
                return 1;
            }
            else
                return (fibo(n - 1) + fibo(n - 2));
        }

        static void dynamic_fibo(int n)
        {
            if (n == 1 || n == 2)
                arr[n] = 1;
            for(int i =3; i<=n; i++)
            {
                dynamic_sum++;
                arr[i] = arr[i - 2] + arr[i - 1];
            }
        }
    }
}

using System;

namespace Baekjoon
{
    class _1110
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int num2 = num;
            int sum = 0;

            while (true)
            {
                int a = (num2 % 10) * 10;
                int b = (num2 / 10 + num2 % 10) % 10;
                num2 = a + b;
                sum++;

                if (num2 == num)
                    break;
            }
            Console.WriteLine(sum);
        }
    }
}

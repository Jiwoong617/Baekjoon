using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    class _4673_1
    {
        static void Main(string[] args)
        {
            for (int a = 1; a <= 10000; a++)
                Self_num(a);
        }

        static void Self_num(int a)
        {
            bool self = true;
            for (int i = 1; i<=a; i++)
            {
                self = true;
                int sum = i;
                int n = i;

                for (int j = 0; j < i.ToString().Length; j++)
                {
                    sum += (n % 10);
                    n /= 10;
                }

                if (sum == a)
                {
                    self = false;
                    break;
                }

            }

            if (self)
                Console.WriteLine(a);
        }
    }
}

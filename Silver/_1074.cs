using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1074
    {
        static int count = 0;
        static int[] n;

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int num = (int)Math.Pow(2, n[0]);

            find_z(num, 0, 0);
            Console.WriteLine(count);
        }

        static void find_z(int num, int x, int y)
        {
            if(num < 1)
            {
                //Console.WriteLine($"{x} {y} = {count}");
                return;
            }
            else
            {
                num /= 2;
                // 1사분
                if (n[1] < x + num && n[2] < y + num)
                    find_z(num, x, y);
                // 2사분
                else if (n[1] < x+num && n[2] >= y + num)
                {
                    count += num * num;
                    find_z(num, x, y + num);
                }
                // 3사분
                else if (n[1] >= x+num && n[2] < y + num)
                {
                    count += (2 * num * num);
                    find_z(num, x + num, y);
                }
                // 4사분
                else
                {
                    count += (3 * num * num);
                    find_z(num, x + num, y + num);
                }
            }
        }
    }
}

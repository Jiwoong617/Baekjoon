using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _17300
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            bool[] check = new bool[10];


            (int, int) temp;
            bool flag = true;
            for(int i = 0; i< n-1; i++)
            {
                temp = (arr[i], arr[i + 1]);

                if (temp == (1, 3) || temp == (3, 1))
                {
                    if (!check[2])
                        flag = false;
                }
                else if (temp == (1, 7) || temp == (7, 1))
                {
                    if (!check[4])
                        flag = false;
                }
                else if (temp == (7, 9) || temp == (9, 7))
                {
                    if (!check[8])
                        flag = false;
                }
                else if (temp == (3, 9) || temp == (9, 3))
                {
                    if (!check[6])
                        flag = false;
                }
                else if (temp == (2, 8) || temp == (8, 2))
                {
                    if (!check[5])
                        flag = false;
                }
                else if (temp == (4, 6) || temp == (6, 4))
                {
                    if (!check[5])
                        flag = false;
                }
                else if (temp == (1, 9) || temp == (9, 1))
                {
                    if (!check[5])
                        flag = false;
                }
                else if (temp == (3, 7) || temp == (7, 3))
                {
                    if (!check[5])
                        flag = false;
                }
                else if (check[arr[i + 1]])
                    flag = false;
                else if (arr[i] == arr[i + 1])
                    flag = false;

                check[arr[i]] = true;
                if (!flag)
                    break;
            }

            if (flag)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}

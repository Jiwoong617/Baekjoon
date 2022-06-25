using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    class _4344
    {
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            string[][] a = new string[size][];
            double[] num = new double[size];

            for (int i = 0; i < size; i++)
                a[i] = Console.ReadLine().Split();

            for (int i = 0; i < size; i++)
            {
                int per = 0;

                for (int j = 1; j <= Convert.ToInt32(a[i][0]); j++)
                {
                    num[i] += Convert.ToDouble(a[i][j]);
                }
                num[i] /= Convert.ToInt32(a[i][0]);

                for (int k = 1; k <= Convert.ToInt32(a[i][0]); k++)
                {
                    if (Convert.ToDouble(a[i][k]) > num[i])
                        per += 1;
                }
                num[i] = (double)per/Convert.ToDouble(a[i][0]) * 100;
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("{0:#0.000}%",num[i]);
            }
               
        }
    }
}

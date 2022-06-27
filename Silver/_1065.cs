using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    class _1065
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for (int i = 1; i <= num; i++)
            {
                if (Hansu(i.ToString()))
                    count++;
            }

            Console.WriteLine(count);
        }

        static bool Hansu(string n)
        {
            if (n.Length < 3)
                return true;

            int[] a = new int[n.Length];

            for (int i = 0; i < n.Length; i++)
            {
                a[i] = int.Parse(n[i].ToString()); //또는 Convert.ToInt32(n[i]);
            }

            if ((a[0] - a[1]) == (a[1] - a[2]))
                return true;
            else
                return false;
        }
    }
}

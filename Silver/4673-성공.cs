using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon
{
    class _4673_2
    {
        static void Main()
        {
            int[] s = new int[10000];
            for (int i = 0; i<10000; i++)
                s[i]= Self(i);

            bool isSelf = true;
            for (int i = 0; i< 10000; i++)
            {
                for (int j = 0; j < s.Length; j++)
                {
                    if (i == s[j])
                    {
                        isSelf = false;
                        break;
                    }
                    else
                        isSelf = true;

                }
                if (isSelf)
                    Console.WriteLine(i);
            }
        }

        static int Self(int n)
        {
            int sum = n;
            int a = n;
            for (int k = 0; k < n.ToString().Length; k++)
            {                
                sum += (a%10);
                a /= 10;
            }
            return sum;
        }
    }
}


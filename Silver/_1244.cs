using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _1244
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] swt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int t = int.Parse(Console.ReadLine());
            for(int test = 0; test < t; test++)
            {
                int[] man = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                if (man[0] == 1)
                {
                    int num = man[1];
                    while (num <= n)
                    {
                        if (swt[num - 1] == 1)
                            swt[num - 1] = 0;
                        else
                            swt[num - 1] = 1;

                        num += man[1];
                    }
                }
                else
                {
                    int left = man[1] - 2;
                    int right = man[1];
                    while(left >= 0 && right < n)
                    {
                        if (swt[left] != swt[right])
                            break;

                        left--;
                        right++;
                    }

                    for (int i = left+1; i<right; i++)
                    {
                        if (swt[i] == 0)
                            swt[i] = 1;
                        else
                            swt[i] = 0;
                    }
                }
            }

            int count = 1;
            for(int i = 0; i<n; i++)
            {
                if (count <= 20)
                    stb.Append($"{swt[i]} ");
                else
                {
                    stb.AppendLine();
                    stb.Append($"{swt[i]} ");
                    count = 1;
                }
                count++;
            }

            Console.WriteLine(stb);
        }
    }
}

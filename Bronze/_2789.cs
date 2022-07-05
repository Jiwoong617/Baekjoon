using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Bronze
{
    class _2798
    {
        static void Main(string[] args)
        {
            int[] num = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int temp = 0;

            for(int i = 0; i<num[0]-2; i++)
            {
                for(int j = i+1; j<num[0]-1; j++)
                {
                    for(int k = j+1; k<num[0]; k++)
                    {
                        if ((arr[i] + arr[j] + arr[k]) > temp && (arr[i] + arr[j] + arr[k]) <= num[1])
                            temp = (arr[i] + arr[j] + arr[k]);
                    }
                }
            }
            Console.WriteLine(temp);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _9095
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[11];
            //1 2 3
            arr[0] = 1; arr[1] = 2; arr[2] = 4;
            for (int i = 3; i < 11; i++)
                arr[i] = arr[i - 1] + arr[i - 2] + arr[i - 3];

            for(int i = 0; i< n; i++)
            {
                int num = int.Parse(Console.ReadLine());
                stb.AppendLine(arr[num-1].ToString());
            }
            Console.WriteLine(stb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15655
    {
        static int[] n;
        static int[] temp;
        static int[] arr;
        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            temp = new int[n[1]];
            arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            Array.Sort(arr);

            BacT(0, 0);
            Console.WriteLine(stb);
        }
        
        static void BacT(int count, int t)
        {
            if(count >= n[1])
            {
                stb.AppendLine(string.Join(' ', temp));
                return;
            }

            for(int i = t; i< n[0]; i++)
            {
                temp[count] = arr[i];
                BacT(count+1, i+1);
            }
        }
    }
}

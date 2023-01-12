using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _2467
    {
        static void Main(string[] args)
        {
            int n =int.Parse(Console.ReadLine());
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);


            (int, int) ans = (0, n-1);

            int left = 0;
            int right = n - 1;
            int liquid = 2000000000;
            while(left < right)
            {
                int sum = arr[left] + arr[right];
                if(liquid >= Math.Abs(sum))
                {
                    liquid= Math.Abs(sum);
                    ans = (left, right);
                }

                if (sum > 0)
                    right--;
                else
                    left++;
            }

            Console.WriteLine(arr[ans.Item1]+" "+arr[ans.Item2]);
        }
    }
}

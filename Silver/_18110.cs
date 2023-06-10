using System;

namespace Baekjoon
{
    internal class _18110
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for(int i = 0; i<n; i++)
                a[i]= int.Parse(Console.ReadLine());
            Array.Sort(a);

            if(n == 0)
            {
                Console.WriteLine(0);
                return;
            }

            double ave = n * 0.15;
            int num = ave - (int)ave >= 0.5 ? (int)ave + 1 : (int)ave;
            double sum = a[num..(n - num)].Sum();
            sum /= (n - num * 2);
            Console.WriteLine(sum-(int)sum >= 0.5?(int)sum+1:(int)sum);
        }
    }
}

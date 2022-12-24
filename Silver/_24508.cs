using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _24508
    {
        static void Main(string[] args)
        {
            int[] nkt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] nadori = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            long sum = nadori.Sum();
            if (sum % nkt[1] != 0)
                Console.WriteLine("NO");
            else if (sum == 0)
                Console.WriteLine("YES");
            else
            {
                Array.Sort(nadori);
                int left = 0;
                int right = nkt[0] - 1;
                for (int i = 0; i < nkt[2]; i++)
                {
                    while (nadori[left] <= 0)
                        left++;

                    nadori[left]--;
                    nadori[right]++;

                    if (nadori[right] == nkt[1])
                    {
                        nadori[right] = 0;
                        right--;
                    }

                    if (left >= right)
                        break;
                }

                if (nadori.Sum() == 0)
                    Console.WriteLine("YES");
                else
                    Console.WriteLine("NO");
            }
        }
    }
}

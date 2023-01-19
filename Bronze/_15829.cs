using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Bronze
{
    internal class _15829
    {
        static void Main(String[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[] c = Console.ReadLine().ToCharArray();

            //97 = a
            long ans = 0;
            long pow = 1;
            for(int i = 0; i< n; i++)
            {   
                ans += (c[i]-96) * pow % 1234567891;
                pow = pow * 31 % 1234567891;
            }
            Console.WriteLine(ans % 1234567891);
        }
    }
}

using System;

namespace Baekjoon
{
    internal class _1476
    {
        static void Main(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int y = 1;
            while ((y - n[0]) % 15 != 0 || (y - n[1]) % 28 != 0 || (y - n[2]) % 19 != 0)
                y++;
            Console.WriteLine(y);
        }
    }
}

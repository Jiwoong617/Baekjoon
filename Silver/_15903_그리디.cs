using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15903
    {
        static void Main_15903(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            long[] card = Array.ConvertAll(Console.ReadLine().Split(), long.Parse);

            Array.Sort(card);
            for(int i = 0; i< n[1]; i++)
            {
                card[0] += card[1];
                card[1] = card[0];
                Array.Sort(card);
            }

            Console.WriteLine(card.Sum());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace BaekJoon.Silver
{
    internal class _9658
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            bool[] game = new bool[1001]; //true - 상근 win, false - 창영 win
            game[1] = game[3] = false; game[2] = game[4] = true;

            //1개 남으면 이김
            for (int i = 5; i <= n; i++)
            {
                if (game[i - 1] && game[i - 3] && game[i - 4])
                    game[i] = false;
                else
                    game[i] = true;
            }
            Console.WriteLine(game[n] ? "SK" : "CY");
        }
    }
}

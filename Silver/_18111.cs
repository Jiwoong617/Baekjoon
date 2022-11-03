using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _18111
    {
        static void Main_18111(string[] args)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int have = n[2]; //가진 흙

            int[][] arr = new int[n[0]][];
            for(int i = 0; i< n[0]; i++)
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            int time = -1;
            int high = -1;
            for(int earth = 0; earth<257; earth++)
            {
                int dig = 0; //파기
                int put = 0; //놓기

                for(int i = 0; i < n[0]; i++)
                {
                    for(int j = 0; j < n[1]; j++)
                    {
                        if (arr[i][j] > earth)
                            dig += (arr[i][j] - earth);
                        else if (arr[i][j] < earth)
                            put += (earth - arr[i][j]);
                    }
                }

                if(have + dig >= put)
                {
                    if (time == -1)
                        time = dig * 2 + put;

                    if(time >= dig * 2 + put)
                    {
                        time = dig * 2 + put;
                        high = Math.Max(high, earth);
                    }
                }
            }

            Console.WriteLine($"{time} {high}");
        }
    }
}

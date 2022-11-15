using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    class _25597
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            //n[0] = X미터, n[1] = T초
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int one_div = 0;
            int four_div = 0;
            int eight_div = 0;
            int count = 0;
            int time = n[1];

            if (n[0]%8 == 0 && n[0]/8 <= n[1])
                eight_div = n[0]/8;
            else if (n[0] % 4 == 0 && n[0] / 4 <= n[1])
                four_div = n[0] / 4;
            else if (n[0] <= n[1])
                one_div = n[0];
            else if ((n[0] % 8) % 4 == 0 && (n[0] / 8) + ((n[0] % 8) / 4) <= n[1])
            {
                eight_div = n[0] / 8;
                n[0] %= 8;
                four_div = n[0] / 4;
            }
            else if ((n[0]/8) + (n[0]%8) <= n[1])
            {
                eight_div = n[0] / 8;
                n[0] %= 8;
                one_div = n[0];
            }
            else if ((n[0] / 4) + (n[0] % 4) <= n[1])
            {
                four_div = n[0] / 4;
                n[0] %= 4;
                one_div = n[0];
            }
            else if ((n[0] / 8) + ((n[0] % 8) / 4) + ((n[0] % 8) % 4) <= n[1])
            {
                eight_div = n[0] / 8;
                n[0] %= 8;
                four_div = n[0] / 4;
                n[0] %= 4;
                one_div = n[0];
            }
            else
            {
                Console.WriteLine(-1);
                return;
            }

            int[] arr = {one_div, four_div, eight_div};
            List<(int, int)> list = new List<(int, int)> ();
            for(int i = 0; i<3; i++)
            {
                int num;
                if (i == 0)
                    num = 1;
                else if (i == 1)
                    num = 4;
                else
                    num = 8;    

                if(arr[i] != 0)
                {
                    count++;
                    list.Add((time - arr[i], num));
                    time -= arr[i];
                }
            }

            stb.AppendLine(count.ToString());
            for (int i = list.Count - 1; i >= 0; i--)
                stb.AppendLine($"{list[i].Item1} {list[i].Item2}");

            Console.WriteLine(stb);
        }
    }
}

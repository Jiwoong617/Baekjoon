using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _25206
    {
        static float sum;
        static float total;

        static void Main(string[] args)
        {
            for(int i = 0; i<20; i++)
                Cal(Console.ReadLine().Split());
            Console.WriteLine(sum / total);
        }

        static void Cal(string[] s)
        {
            if (s[2] == "P") return;

            float h = float.Parse(s[1]);
            total += h;
            switch (s[2])
            {
                case "A+":
                    sum += 4.5f * h;
                    return;
                case "A0":
                    sum += 4.0f * h;
                    return;
                case "B+":
                    sum += 3.5f * h;
                    return;
                case "B0":
                    sum += 3.0f * h;
                    return;
                case "C+":
                    sum += 2.5f * h;
                    return;
                case "C0":
                    sum += 2.0f * h;
                    return;
                case "D+":
                    sum += 1.5f * h;
                    return;
                case "D0":
                    sum += h;
                    return;
            }
        }
    }
}

using System;

namespace BaekJoon.Silver
{
    internal class _9655
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string s = n % 2 == 1 ? "SK" : "CY";
            Console.WriteLine(s);
        }
    }
}

using System;

namespace _2525
{
    class _2525
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine().Split();
            int c = int.Parse(Console.ReadLine());

            int a = int.Parse(s[0]);
            int b = int.Parse(s[1]) + c;

            while (b >= 60)
            {
                a++;
                b -= 60;
                if (a >= 24)
                    a -= 24;
            }
            Console.WriteLine("{0} {1}", a,b);
        }
    }
}

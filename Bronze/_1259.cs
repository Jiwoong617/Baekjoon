using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Bronze
{
    internal class _1259
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            string s = Console.ReadLine();
            while (s != "0")
            {
                string ss = string.Concat(s.Reverse().ToArray());
                if (s == ss)
                    stb.AppendLine("yes");
                else
                    stb.AppendLine("no");
                s = Console.ReadLine();
            }
            Console.WriteLine(stb);
        }
    }
}

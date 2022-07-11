using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1181
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            StringBuilder stb = new StringBuilder();

            string[] arr = new string[num];
            for (int i = 0; i < num; i++)
                arr[i] = Console.ReadLine();

            var str = arr.OrderBy(x => x.Length).ThenBy(x => x).ToArray();

            for(int i = 0; i<num; i++)
            {
                string temp = "";
                if (i > 0)
                    temp = str[i - 1];
                if (str[i] == temp)
                    continue;

                stb.AppendLine(str[i]);
            }
            Console.WriteLine(stb);
        }
    }
}

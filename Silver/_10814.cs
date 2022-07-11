using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _10814
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            (int, string)[] arr = new (int, string)[num]; //튜플형 배열
            
            StringBuilder stb = new StringBuilder();
            for(int i = 0; i<num; i++)
            {
                string[] str = Console.ReadLine().Split();
                arr[i] = (int.Parse(str[0]), str[1]);
            }

            var ar = arr.OrderBy(x => x.Item1).ToArray();

            for (int i = 0; i < num; i++)
                stb.AppendLine($"{ar[i].Item1} {ar[i].Item2}");
            Console.WriteLine(stb);
        }
    }
}

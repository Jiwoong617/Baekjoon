using System;
using System.Text;

namespace BaekJoon.Bronze
{
    internal class _8958
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            while(n-- > 0)
            {
                string[] ss = Console.ReadLine().Split('X', StringSplitOptions.RemoveEmptyEntries);
                int ans = 0;
                foreach (string s in ss)
                    ans = s.Length == 1 ? ans+1 : ans += (s.Length+1)*s.Length/2;
                stb.AppendLine($"{ans}");
            }
            Console.WriteLine(stb);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Practice
{
    class _22867
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<(int, int)> time = new List<(int, int)>();

            for(int i = 0; i< n; i++)
            {
                string[] s = Console.ReadLine().Split();
                string[] s1 = s[0].Split(':');  
                int s11 = int.Parse(s1[0]) * 3600000;
                int s12 = int.Parse(s1[1]) * 60000;
                double s13 = double.Parse(s1[2]) * 1000;

                string[] s2 = s[1].Split(':');
                int s21 = int.Parse(s2[0]) * 3600000;
                int s22 = int.Parse(s2[1]) * 60000;
                double s23 = double.Parse(s2[2]) * 1000;

                time.Add((s11+s12+(int)s13, 1)); //들어오는거 1
                time.Add((s21+s22+(int)s23, -1)); //나가는거 -1
            }

            time = time.OrderBy(x => x.Item1).ThenBy(x => x.Item2).ToList();

            int now = 0;
            int ans = 0;
            for (int i = 0; i < time.Count; i++)
            {
                now += time[i].Item2; //실시간 in out 확인
                ans = Math.Max(ans, now); //값의 최대
            }
            Console.WriteLine(ans);
        }
    }
}

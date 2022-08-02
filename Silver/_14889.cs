using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _14889
    {
        static int[][] team;
        static int n;
        static bool[] visit;
        static int ans = 200;

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            team = new int[n][];
            visit = new bool[n];

            for (int i = 0; i<n; i++)
                team[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            dfs(0, 0);
            Console.WriteLine(ans);
        }

        static void dfs(int count, int now)
        {
            int steam = 0;
            int lteam = 0;

            if (count == n/ 2)
            {
                for(int i = 0; i<n; i++)
                {
                    for(int j = i+1; j<n; j++)
                    {
                        if(visit[i] == true && visit[j] == true)
                            steam += (team[i][j]+team[j][i]);

                        if (visit[i] == false && visit[j] == false)
                            lteam += (team[i][j] + team[j][i]);
                    }
                }

                int temp = Math.Abs(steam - lteam);
                ans = Math.Min(ans, temp);

                return;
            }

            for(int i = now; i < n; i++)
            {
                if (!visit[i])
                {
                    visit[i] = true;
                    dfs(count + 1,i+1);
                    visit[i] = false;
                }
            }
        }
    }
}

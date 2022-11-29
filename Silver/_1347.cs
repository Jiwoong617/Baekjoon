using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.silver
{
    class _1347
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();

            int n = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            List<(int, int)> mapping = new List<(int, int)>();
            int ud = 0; //위아래 -> 아래로 가면 +1 위로 가면 -1
            int lr = 0; //왼오 -> 오른쪽 +1, 왼쪽 -1
            mapping.Add((ud, lr));
            char lookat = 'S';

            for(int i = 0; i<n; i++)
            {
                if (s[i] == 'R')
                {
                    switch (lookat)
                    {
                        case 'S':
                            lookat = 'W';
                            break;
                        case 'W':
                            lookat = 'N';
                            break;
                        case 'N':
                            lookat = 'E';
                            break;
                        case 'E':
                            lookat = 'S';
                            break;
                    }
                }
                else if (s[i] == 'L')
                {
                    switch (lookat)
                    {
                        case 'S':
                            lookat = 'E';
                            break;
                        case 'W':
                            lookat = 'S';
                            break;
                        case 'N':
                            lookat = 'W';
                            break;
                        case 'E':
                            lookat = 'N';
                            break;
                    }
                }
                else
                {
                    switch (lookat)
                    {
                        case 'S':
                            ud++;
                            break;
                        case 'W':
                            lr--;
                            break;
                        case 'N':
                            ud--;
                            break;
                        case 'E':
                            lr++;
                            break;
                    }
                    mapping.Add((ud, lr));
                }
            }

            int minUD = mapping.Min(x => x.Item1) < 0 ? Math.Abs(mapping.Min(x => x.Item1)) : 0;
            int minLR = mapping.Min(x => x.Item2) < 0 ? Math.Abs(mapping.Min(x => x.Item2)) : 0;
            for(int i = 0; i<mapping.Count; i++)
                mapping[i] = (mapping[i].Item1 + minUD, mapping[i].Item2+minLR);

            int uplen = mapping.Max(x => x.Item1);
            int rightlen = mapping.Max(x => x.Item2);
            bool[,] arr = new bool[uplen + 1, rightlen + 1];
            for (int i = 0; i < mapping.Count; i++)
                arr[mapping[i].Item1, mapping[i].Item2] = true;

            for(int i = 0; i < uplen+1; i++)
            {
                for(int j = 0; j<rightlen+1; j++)
                {
                    if (arr[i, j])
                        stb.Append(".");
                    else
                        stb.Append("#");
                }
                stb.AppendLine();
            }

            Console.WriteLine(stb);
        }
    }
}

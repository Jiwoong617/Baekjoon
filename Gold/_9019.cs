using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _9019
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int t = int.Parse(Console.ReadLine());

            while(t-- > 0)
            {
                int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                bool[] visited = new bool[10000];
                visited[n[0]] = true;
                Queue<(int, string)> que = new Queue<(int, string)>();
                que.Enqueue((n[0], ""));

                while(que.Count> 0)
                {
                    (int, string) temp = que.Dequeue();
                    if(temp.Item1 == n[1])
                    {
                        stb.AppendLine(temp.Item2);
                        break;
                    }

                    int d = temp.Item1 * 2 % 10000;
                    if (!visited[d])
                    {
                        que.Enqueue((d, temp.Item2 + 'D'));
                        visited[d] = true;
                    }

                    int s = temp.Item1 == 0 ? 9999 : temp.Item1 - 1;
                    if (!visited[s])
                    {
                        que.Enqueue((s, temp.Item2 + 'S'));
                        visited[s] = true;
                    }

                    int l = temp.Item1*10%10000 + temp.Item1*10/10000;
                    if (!visited[l])
                    {
                        que.Enqueue((l, temp.Item2 + "L"));
                        visited[l] = true;
                    }

                    int r = temp.Item1%10*1000 + temp.Item1/10;
                    if (!visited[r])
                    {
                        que.Enqueue((r, temp.Item2 + "R"));
                        visited[r] = true;
                    }
                }
            }
            Console.WriteLine(stb);
        }
    }
}

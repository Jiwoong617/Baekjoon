using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _4803
    {
        static bool[] visited;
        static List<int>[] list;

        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            int testCase = 0;
            while (true)
            {
                int[] arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                if (arr[0] == 0 && arr[1] == 0) break;
                testCase++;

                visited = new bool[arr[0] + 1];
                list = new List<int>[arr[0] + 1];
                for (int i = 1; i <= arr[0]; i++)
                    list[i] = new List<int>();
                int treeCount = 0;

                for(int i = 0; i < arr[1]; i++)
                {
                    int[] input = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
                    list[input[0]].Add(input[1]);
                    list[input[1]].Add(input[0]);
                }

                for(int i = 1; i <= arr[0]; i++)
                {
                    if (!visited[i])
                        if(DFS(i, 0))
                            treeCount++;
                }

                if (treeCount == 0)
                    stb.AppendLine($"Case {testCase}: No trees.");
                else if (treeCount == 1)
                    stb.AppendLine($"Case {testCase}: There is one tree.");
                else
                    stb.AppendLine($"Case {testCase}: A forest of {treeCount} trees.");
            }

            Console.WriteLine(stb);
            sw.Close();
            sr.Close();
        }

        static bool DFS(int now, int before)
        {
            visited[now] = true;
            foreach (int p in list[now])
            {
                if (p == before) continue; //간선 패스
                if (visited[p]) return false; //사이클 탐지
                if (!DFS(p, now)) return false;
            }

            return true;
        }
    }
}

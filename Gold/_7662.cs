using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _7662
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StringBuilder stb = new StringBuilder();
            int t1 = int.Parse(sr.ReadLine());
            while(t1-- > 0)
            {
                PriorityQueue<long, long> MaxQ = new();
                PriorityQueue<long, long> MinQ = new();
                Dictionary<long, long> inputNum = new();

                int t2 = int.Parse(sr.ReadLine());
                while (t2-- > 0)
                {
                    string[] s = sr.ReadLine().Split();
                    char c = char.Parse(s[0]);
                    long n = long.Parse(s[1]);

                    if(c.Equals('I'))
                    {
                        MaxQ.Enqueue(-n, -n);
                        MinQ.Enqueue(n, n);

                        if (inputNum.ContainsKey(n))
                            inputNum[n]++;
                        else
                            inputNum.Add(n, 1);
                    }
                    else if (c.Equals('D'))
                    {
                        if(n == 1)
                        {
                            while(MaxQ.Count > 0 && inputNum[-MaxQ.Peek()] == 0)
                                MaxQ.Dequeue();

                            if(MaxQ.Count > 0)
                            {
                                inputNum[-MaxQ.Peek()]--;
                                MaxQ.Dequeue();
                            }
                        }
                        else if (n == -1)
                        {
                            while (MinQ.Count > 0 && inputNum[MinQ.Peek()] == 0)
                                MinQ.Dequeue();

                            if (MinQ.Count > 0)
                            {
                                inputNum[MinQ.Peek()]--;
                                MinQ.Dequeue();
                            }
                        }
                    }
                }

                while (MaxQ.Count > 0 && inputNum[-MaxQ.Peek()] == 0)
                    MaxQ.Dequeue();
                while (MinQ.Count > 0 && inputNum[MinQ.Peek()] == 0)
                    MinQ.Dequeue();


                if (MinQ.Count == 0 || MaxQ.Count == 0)
                    stb.AppendLine("EMPTY");
                else
                    stb.AppendLine($"{-MaxQ.Dequeue()} {MinQ.Dequeue()}");
            }
            sw.WriteLine(stb);
            sr.Close();
            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon
{
    class _18706
    {
        static void Main_18706(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine());
            for(int i = 0; i< n; i++)
            {
                //0커피, 1사람수
                int[] cp = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

                //사전에 넣기
                Dictionary<string, List<int>> dic = new Dictionary<string, List<int>>();
                for(int j = 0; j < cp[0]; j++)
                {
                    string[] s = Console.ReadLine().Split();
                    dic[s[0]] = new List<int>();
                    dic[s[0]].Add(int.Parse(s[1]));
                    dic[s[0]].Add(int.Parse(s[2]));
                    dic[s[0]].Add(int.Parse(s[3]));
                }

                //사람 생성
                for(int j = 0; j < cp[1]; j++)
                {
                    string[] person = Console.ReadLine().Split();
                    string coffee = person[2];
                    int pay = 100 / cp[1]; //배달비 100/사람 수

                    //가격
                    switch (person[1])
                    {
                        case "small":
                            pay += dic[coffee][0];
                            break;
                        case "medium":
                            pay += dic[coffee][1];
                            break;
                        case "large":
                            pay += dic[coffee][2];
                            break;
                    }

                    //5로 나눴을 때
                    if (pay % 5 == 4)
                        pay++;
                    else if (pay % 5 == 1)
                        pay--;

                    stb.AppendLine($"{person[0]} {pay}");
                }
            }
            Console.WriteLine(stb);
        }
    }
}

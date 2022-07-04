using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _17478
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(jaegue(num, 0));
        }

        public static string jaegue(int num, int start)
        {
            if (start < num) 
            {
                if (start == 0)
                    Console.WriteLine("어느 한 컴퓨터공학과 학생이 유명한 교수님을 찾아가 물었다.");
                string underbar = string.Concat(Enumerable.Repeat("____", start));
                string one = "\"재귀함수가 뭔가요?\"";
                string two = "\"잘 들어보게. 옛날옛날 한 산 꼭대기에 이세상 모든 지식을 통달한 선인이 있었어.";
                string three = "마을 사람들은 모두 그 선인에게 수많은 질문을 했고, 모두 지혜롭게 대답해 주었지.";
                string four = "그의 답은 대부분 옳았다고 하네. 그런데 어느 날, 그 선인에게 한 선비가 찾아와서 물었어.\"";
                Console.WriteLine(underbar + one + "\n" + underbar + two + "\n" + underbar + three + "\n" + underbar + four);
                return jaegue(num, start + 1);
            }
            else
            {
                if (num == start)
                {
                    string underbar = string.Concat(Enumerable.Repeat("____", num));
                    string one = "\"재귀함수가 뭔가요?\"";
                    string two = "\"재귀함수는 자기 자신을 호출하는 함수라네\"";
                    Console.WriteLine(underbar + one + "\n" + underbar + two);
                    return jaegue(num, start+1);
                }
                else
                {
                    if(num >= 0) 
                    {
                        string underbar = string.Concat(Enumerable.Repeat("____", num));
                        string three = "라고 답변하였지.";
                        Console.WriteLine(underbar + three);
                        return jaegue(num - 1, start);
                    }
                }
            }
            return "";
        }
    }
}

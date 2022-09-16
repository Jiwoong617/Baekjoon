using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Baekjoon.Silver
{
    class _1543
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string s = Console.ReadLine();
            int count = 0;
            //첫번째 방법
            /*
            for(int i = 0; i<= str.Length - s.Length; i++)
            {                
                if(str[i..(i+s.Length)] == s)
                {
                    count++;
                    i += s.Length-1;
                }
            }
            Console.WriteLine(count);
            */

            //두번째 방법
            count = str.Replace(s, "A").Count(x => x == 'A');
            Console.WriteLine(count);
        }
    }
}

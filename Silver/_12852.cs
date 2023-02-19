using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _12852
    {
        static void Main(string[] args)
        {
            StringBuilder stb = new StringBuilder();
            int n = int.Parse(Console.ReadLine()); ;
            int[] arr = new int[n + 1]; arr[1] = 0;
            int[] step = new int[n + 1];

            for(int i = 2; i<=n; i++)
            {
                arr[i] = arr[i - 1] + 1;
                if (i % 3 == 0)
                {
                    step[i] = arr[i] < arr[i / 3] + 1 ? 1 : 3;
                    arr[i] = Math.Min(arr[i], arr[i / 3] + 1);
                }
                if (i % 2 == 0)
                {
                    switch (step[i])
                    {
                        case 0:
                        case 1:
                            step[i] = arr[i] < arr[i / 2] + 1 ? 1 : 2;
                            break;
                        case 3:
                            step[i] = arr[i] < arr[i / 2] + 1 ? 3 : 2;
                            break;
                    }

                    arr[i] = Math.Min(arr[i], arr[i / 2] + 1);
                }
                if (step[i] == 0)
                    step[i] = 1;
            }
            //Console.WriteLine(string.Join(" ", step));
            stb.AppendLine(arr[n].ToString());

            stb.Append($"{n} ");
            while(step[n] > 0)
            {
                switch (step[n])
                {
                    case 1:
                        n--;
                        break;
                    case 2:
                        n /= 2;
                        break;
                    case 3:
                        n /= 3;
                        break;
                }
                stb.Append($"{n} ");
            }
            Console.WriteLine(stb);
        }
    }
}

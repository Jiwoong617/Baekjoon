using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Gold
{
    internal class _1107
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int n = int.Parse(Console.ReadLine());
            int[] arr;
            if(n != 0)
                arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            else
                arr = new int[0];

            bool[] isActive = Enumerable.Repeat(true, 10).ToArray();
            foreach(int i in arr)
                isActive[i] = false;

            int[] from100 = new int[500001];
            from100[100] = 0; from100[101] = 1; from100[99] = 1; from100[102] = 2;
            int[] fromEdge = new int[1000002];
            fromEdge[100] = 0; fromEdge[101] = 1; fromEdge[99] = 1; fromEdge[102] = 2;

            int channel;
            bool flag;

            //100에서 출발
            for(int i = 98; i>=0; i--)
            {
                channel = i;
                flag = true;

                if(i == 0)
                {
                    if (isActive[0])
                        from100[0] = 1;
                    else
                        from100[0] = from100[1] + 1;
                    continue;
                }

                while(channel > 0)
                {
                    int Rnum = channel % 10;
                    channel /= 10;

                    if (!isActive[Rnum])
                    {
                        flag = false;
                        break;
                    }
                }

                if (!flag)
                    from100[i] = from100[i + 1] + 1;
                else
                    from100[i] = i.ToString().Length;
            }
            for (int i = 103; i < 500001; i++)
            {
                channel = i;
                flag = true;
                while (channel > 0)
                {
                    int Rnum = channel % 10;
                    channel /= 10;

                    if (!isActive[Rnum])
                    {
                        flag = false;
                        break;
                    }
                }

                if (!flag)
                    from100[i] = from100[i - 1] + 1;
                else
                    from100[i] = i.ToString().Length;
            }


            //0에서 100, 100만에서 100;
            if (isActive[0])
                fromEdge[0] = 1;
            else
                fromEdge[0] = 100;

            if (isActive[1] && isActive[0])
                fromEdge[1000001] = 7;
            else
                fromEdge[1000001] = 1000001-100;

            for (int i = 1; i<99; i++)
            {
                channel = i;
                flag = true;
                while (channel > 0)
                {
                    int Rnum = channel % 10;
                    channel /= 10;

                    if (!isActive[Rnum])
                    {
                        flag = false;
                        break;
                    }
                }

                if (!flag)
                    fromEdge[i] = fromEdge[i - 1] + 1;
                else
                    fromEdge[i] = i.ToString().Length;
            }

            for(int i = 1000000; i>102; i--)
            {
                channel = i;
                flag = true;
                while (channel > 0)
                {
                    int Rnum = channel % 10;
                    channel /= 10;

                    if (!isActive[Rnum])
                    {
                        flag = false;
                        break;
                    }
                }

                if (!flag)
                    fromEdge[i] = fromEdge[i + 1] + 1;
                else
                    fromEdge[i] = i.ToString().Length;
            }

            Console.WriteLine(Math.Min(fromEdge[num], from100[num]));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _20055
    {
        static int[] n;
        static int[] belt;
        static bool[] canMove;
        static int inputPos = 0;
        static int outPos;
        static Queue<int> q = new Queue<int>();

        static void Main(string[] args)
        {
            n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            belt = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            canMove = Enumerable.Repeat(true, 2 * n[0]).ToArray();
            outPos = n[0] - 1;

            int step = 1;
            while (Step4())
                step++;

            Console.WriteLine(step);
        }

        static void Step1()
        {
            inputPos = (inputPos + 2 * n[0] - 1) % (2 * n[0]);
            outPos = (outPos + 2 * n[0] - 1) % (2 * n[0]);

            int count = q.Count;
            for (int i = 0; i<count; i++)
            {
                int pos = q.Dequeue();
                if (pos == outPos)
                    canMove[pos] = true;
                else
                    Step2(pos);
            }

            Step3();
        }

        static void Step2(int robotPos)
        {
            int nextPos = (robotPos + 1) % (2 * n[0]);

            if (belt[nextPos] > 0 && canMove[nextPos] == true)
            {
                canMove[robotPos] = true;

                belt[nextPos]--;
                if (nextPos != outPos)
                {
                    canMove[nextPos] = false;
                    q.Enqueue(nextPos);
                }
            }
            else
                q.Enqueue(robotPos);
        }

        static void Step3()
        {
            if (belt[inputPos] > 0)
            {
                belt[inputPos]--;
                canMove[inputPos] = false;
                q.Enqueue(inputPos);
            }
        }

        static bool Step4()
        {
            Step1();

            if (belt.Count(x => x == 0) >= n[1])
                return false;

            return true;
        }
    }
}

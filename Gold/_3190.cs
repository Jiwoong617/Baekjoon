using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _3190
    {
        static int n;
        static int[,] board; // 0 - 빈 곳, 1 - 뱀, 2 - 사과
        static char dir = 'R';
        static Queue<(int, int)> q = new Queue<(int, int)>();

        static void Main(string[] args)
        {
            n = int.Parse(Console.ReadLine());
            board = new int[n, n];

            int k = int.Parse(Console.ReadLine());
            for(int i = 0; i<k; i++)
            {
                int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
                board[arr[0] - 1, arr[1] - 1] = 2;
            }

            int l = int.Parse(Console.ReadLine());
            Queue<(int, char)> oper = new Queue<(int, char)>();
            while(l-- > 0)
            {
                string[] s = Console.ReadLine().Split();
                oper.Enqueue((int.Parse(s[0]), s[1][0]));
            }

            board[0, 0] = 1;
            q.Enqueue((0, 0));
            int time = 0;
            while (true)
            {
                time++;
                if (!SnakeMove())
                    break;

                if(oper.Count > 0)
                {
                    int t = oper.Peek().Item1;
                    if (time >= t)
                    {
                        ChangeDir(oper.Peek().Item2);
                        oper.Dequeue();
                    }
                }
            }

            Console.WriteLine(time);
        }

        static bool SnakeMove()
        {
            (int, int) head = q.Peek();
            int len = q.Count;

            int x = head.Item1;
            int y = head.Item2;

            switch (dir)
            {
                case 'R':
                    y++;
                    break;
                case 'L':
                    y--;
                    break;
                case 'U':
                    x--;
                    break;
                case 'D':
                    x++;
                    break;
            }

            if (x < 0 || y < 0 || x >= n || y >= n || board[x,y] == 1)
                return false;

            if (board[x,y] == 2)
            {
                board[x, y] = 1;

                q.Enqueue((x, y));
                for (int i = 0; i < len; i++)
                    q.Enqueue(q.Dequeue());
            }
            else
            {
                board[x, y] = 1;

                q.Enqueue((x, y));
                for (int i = 0; i < len-1; i++)
                    q.Enqueue(q.Dequeue());

                (int, int) rm = q.Dequeue();
                board[rm.Item1, rm.Item2] = 0;
            }

            return true;
        }

        static void ChangeDir(char to)
        {
            switch (dir)
            {
                case 'R':
                    dir = to == 'D' ? 'D' : 'U';
                    break;
                case 'L':
                    dir = to == 'D' ? 'U' : 'D';
                    break;
                case 'U':
                    dir = to == 'D' ? 'R' : 'L';
                    break;
                case 'D':
                    dir = to == 'D' ? 'L' : 'R';
                    break;
            }
        }
    }
}

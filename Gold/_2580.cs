using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Baekjoon.Gold
{
    internal class _2580
    {
        static int[][] board = new int[9][];
        static bool isFinished = false;

        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++)
                board[i] = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

            Sudoku(0, 0);
            for (int i = 0; i < 9; i++)
                Console.WriteLine(string.Join(" ", board[i]));
        }

        static void Sudoku(int x, int y)
        {
            if(y == 9) { Sudoku(x + 1, 0); return; }
            if(x == 9) { isFinished = true; return; }

            if (board[x][y] == 0)
            {
                for(int i = 1; i<10; i++)
                {
                    if(Check(x, y, i))
                    {
                        board[x][y] = i;
                        Sudoku(x, y + 1);
                    }

                    if (isFinished) return;
                }

                board[x][y] = 0;
                return;
            }

            Sudoku(x, y + 1);
        }

        static bool Check(int x, int y, int num)
        {
            for(int i = 0; i<9; i++)
            {
                if (board[x][i] == num) return false;
                if (board[i][y] == num) return false;
            }


            int a = x / 3 * 3;
            int b = y / 3 * 3;
            for(int i = a; i<a+3; i++)
            {
                for (int j = b; j < b + 3; j++)
                    if (board[i][j] == num) return false;
            }

            return true;
        }
    }
}

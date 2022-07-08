using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Baekjoon.Bronze
{
    class _10989
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            int num = int.Parse(sr.ReadLine());
            int[] arr = new int[10001];

            for (int i = 0; i < 10001; i++)
                arr[i] = 0;

            //카운트 정렬
            for (int i = 0; i < num; i++)
                arr[int.Parse(sr.ReadLine())]++;

            for(int i =0; i<10001; i++)
            {
                for(int j = 0; j< arr[i]; j++)
                {
                    sw.WriteLine(i);
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BaekJoon.Silver
{
    internal class _15656
    {
        static int[] n;
        static int[] arr;
        static int[] temp;
        static StringBuilder stb = new StringBuilder();

        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(Console.OpenStandardOutput());
            StreamReader sr = new StreamReader(Console.OpenStandardInput());
            n = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            arr = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
            temp = new int[n[1]];
            Array.Sort(arr);

            BackT(0);
            sw.WriteLine(stb);
            sw.Close();
            sr.Close();
        }

        static void BackT(int count)
        {
            if(count == n[1])
            {
                stb.AppendLine(string.Join(" ", temp));
                return;
            }

            for(int i = 0; i < n[0]; i++)
            {
                temp[count] = arr[i];
                BackT(count + 1);
            }
        }
    }
}

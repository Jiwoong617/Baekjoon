using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Baekjoon.silver
{
    internal class _1793
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new StringBuilder();
            StreamReader sr = new StreamReader(Console.OpenStandardInput());

            BigInteger[] arr = new BigInteger[251];
            arr[0] = 1; arr[1] = 1; arr[2] = 3;
            for (int i = 3; i < 251; i++)
                arr[i] = arr[i - 1] + 2 * arr[i - 2];

            while(true)
            {
                if (sr.EndOfStream)
                    break;
                string s = sr.ReadLine();
                sb.AppendLine(arr[int.Parse(s)].ToString());
            }

            Console.WriteLine(sb);
            sr.Close();
        }
    }
}

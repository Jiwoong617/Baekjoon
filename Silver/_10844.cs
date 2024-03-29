using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Silver
{
    class _10844
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] arr = new int[n,10];
            /*
            10 12 
            21 23 
            32 35 
            43 45 
            54 56
            65 67 
            76 78 
            87 89 
            98

            101 121 123
            210 212 234 232
            321 323 343 345
            432 434 456 454
            543 545 565 567
            654 656 678 676
            765 767 787 789
            876 878 898
            989 987

            1010 1012 1210 1212 1232 1234
            2101 2121 2123 2321 2323 2343 2345
            3210 3212 3232 3234 3434 3432 3454 3456
            4321 4323 4343 4345 4543 4545 4565 4567
            5432 5434 5454 5456 5654 5656 5676 5678
            6543 6545 6565 6567 6765 6767 6787 6789
            7654 7656 7676 7678 7876 7878 7898
            8765 8767 8787 8789 8987 8989
            9876 9878 9898
        
            10101 10121 10123 10210 10212 10232 10234 12101 12321 12323 12343 12345
            98765 98767 98787 98789 98989
            */
            //자리수가 0이면 1, 9면 8, 2~8은 앞뒤로 2개씩
            for (int i = 1; i < 10; i++)
                arr[0, i] = 1;

            for(int i = 1; i<n; i++)
            {
                for(int j = 0; j<10; j++)
                {
                    if (j == 0)
                        arr[i,j] = arr[i - 1,1] % 1000000000;
                    else if (j == 9)
                        arr[i,j] = arr[i - 1,8] % 1000000000;
                    else
                        arr[i,j] = (arr[i - 1,j - 1] + arr[i - 1,j + 1]) % 1000000000;
                }
            }

            long sum = 0;
            for (int i = 0; i < 10; i++)
                sum += arr[n - 1, i];
            Console.WriteLine(sum% 1000000000);
        }
    }
}

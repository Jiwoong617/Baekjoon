using System;
using System.Collections.Generic;
using System.Text;

namespace Baekjoon.Gold
{
    class _2110
    {
        static void Main(string[] arsg)
        {
            int[] n = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            int[] arr = new int[n[0]];
            for (int i = 0; i < n[0]; i++)
                arr[i] = int.Parse(Console.ReadLine());

            Array.Sort(arr);
            int start = 1; //집들간 최소 거리
            int end = arr[n[0] - 1] - arr[0]; //집들간 최대 거리

            while(start <= end)
            {
                int mid = (start + end) / 2;

                int count = 1; //첫번째 집 설치
                int house = arr[0]; //현재 설치된 집

                for(int i = 1; i<n[0]; i++)
                {
                    //직전에 설치한집 - 현재 집 거리가 mid보다 크면 공유기 설치, 설치한 집을 현재집으로
                    if(arr[i] - house >= mid)
                    {
                        count++;
                        house = arr[i];
                    }
                }

                //설치 개수가 갖고있는 공유기보다 작으면 범위 줄이기
                if (count < n[1])
                    end = mid-1;
                else //크면 범위 늘리기
                    start = mid+1;
            }

            Console.WriteLine(start-1);
        }
    }
}

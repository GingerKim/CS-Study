using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 배열 실습 교재 p157
같은 타입의 데이터로 이루어진 가장 기본적인 자료구조
배열을 구성하는 데이터를 원소라고 하며 각 원소의 번호를 인덱스
배열은 foreach문으로 반복 처리

변수를 이어붙힌 것


namespace Chapter3
{
    internal class _5_Array
    {
        {
            ////////////////////////
            ///배열의 기본
            ///////////////////////

            ///배열(Array)
            int[] arr1 = new int[3]; //3개 짜리 공간으로 3개의 데이터를 취급 가능, index 0 1 2

            arr1[0] = 1;
            arr1[1] = 2;
            arr1[2] = 3;

            //배열 출력

            for (int i=0; i<3; i++)
            {
                Console.WriteLine("arr1 {0}번째 데이터 : {i}", i+1, arr1[i]);
            }
            //배열 생성 초기화
            int[]    nums   = { 1, 2, 3, 4, 5}; // 정수 
            char[]   chars  = { 'A', 'B', 'C'}; // 단순 글자 한 두개 -> 되도록 복수형으로 네이밍할 것
            string[] cities = { "서울", "대전", "대구", "부산", "광주"}; // 단어 위주

            //배열 길이
            Console.WriteLine("nums 길이 : "+nums.Length); 
            Console.WriteLine("chars 길이 : "+chars.Length); 
            Console.WriteLine("cities 길이 : "+cities.Length); 

            //배열 반복문
            foreach (int num in nums)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            foreach (char c in chars)
            {
                Console.Write(c + " ");
            }
            Console.WriteLine();

            foreach(string city in cities)
            {
                Console.Write(city + " ");
            }
            Console.WriteLine();

            ////////////////////////
            ///디자인 배열
            ///////////////////////

            // 1차원 배열 -> 가로 줄
            int[] arr1d = { 10, 20, 30, 40, 50, 60 };

            int total = 0;

            foreach(int num in arr1d)
            {
                total += num;

            }


            Console.WriteLine("arr1d 종합;" + total);
            // 2차원 배열 -> 가로세로줄 XY


            Console.WriteLine("arr2d[0,0] : " + arr2d[0, 0]);
            Console.WriteLine("arr2d[0,2] : " + arr2d[0, 2]);
            Console.WriteLine("arr2d[1,2] : " + arr2d[1, 2]);
            Console.WriteLine("arr2d[2,3] : " + arr2d[2, 3]);

            // 3차원 배열 -> 가로세로 높이 XYZ
            int[,,] arr3d =
                {
                {
                {1, 2, 3},
                {4, 5, 6},
                {7, 8, 9}
                },
                {
                {10,11,12},
                {13,14,15},
                {16,17,18}
                },
                {
                {19,20,21},
                {22,23,24},
                {25,26,27}
                }
                }
                //3,5,11,17,25 출력
            Console.WriteLine("arr3d[0,0,2] : " + arr3d[0, 0, 2]);
            Console.WriteLine("arr3d[0,1,1] : " + arr3d[0, 1, 1]);
            Console.WriteLine("arr3d[1,0,1] : " + arr3d[1, 0, 1]);
            Console.WriteLine("arr3d[1,2,1] : " + arr3d[1, 2, 1]);
            Console.WriteLine("arr3d[2,2,0] : " + arr3d[2, 2, 0]);


*/
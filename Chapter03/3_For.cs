using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 조건문 Switch 실습 교재 p127
*/

namespace Chapter3
{
    internal class _3_For
    {
        static void Main2(string[] args)
        {
            //for문
            for (int i=1; i<=5; i++) /*초기식 조건식 증감식*/
            {
                Console.WriteLine("{0}회 반복...");
            }
            //1부터 10까지의 합
            int sum = 0;

            for (int k = 1; k <= 10; k++)
            {
                sum = k; // sum + sum + k
            }

            Console.WriteLine("1부터 10까지의 합 :" + sum);

            //1부터 10까지의 짝수합
            int tot = 0;

            for (int k=1; k<=10; k++)
            {
                if (k % 2 == 0)
                {
                    tot += k;
                }
            }

            Console.WriteLine("1부터 10까지 짝수합 : " + tot);

            //중첩 for문
            for(int a=1; a<=3; a++)
            {
                Console.WriteLine("a : " + a);

                for(int b=1; b<=4; b++)
                {
                    Console.WriteLine("b : " + b);

                    for(int c=1; c<=5; c++)
                    {
                        Console.WriteLine("c: " + c);
                    }
                }
            }
            

            //구구단
            for(int x=2; x<=9; x++)
            {
                Console.WriteLine("{0}단 시작", x);
                for(int y=1; y<=9; y++)
                {
                    int z = x * y;

                    Console.WriteLine("{0} * {1} = {2}", x, y, z);
                }
            }

            //별삼각형
            for (int start = 1; start <= 10; start++)
            {
                for (int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();//줄바꿈
            }

            //역별삼각형1
            for (int start = 1; start <= 10; start++)
            {
                for (int end = 10; start <= end; end--)
                {
                    Console.Write("★");
                }
                Console.WriteLine();//줄바꿈
            }

            //역별삼각형2
            for (int start = 10; start >= 1; start--)
            {
                for(int end = 1; end <= start; end++)
                {
                    Console.Write("★");
                }
                Console.WriteLine();//줄바꿈
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 반복문 while 실습 교재 p162
*/

namespace Chapter3
{
    internal class _4_While
    {
        static void Main2(string[] args)
        {
            // 1부터 10까지 합
            //초기식//
            int sum = 0;
            int k = 1;

            while(k<=10)//조건식 -> 조건이 거짓이면 한번도 실행 안할 수 있음
            {
                sum += k;
                k++;
            }

            Console.WriteLine("1부터 10까지의 합 : " + sum);


            // do ~ while // 조건이 거짓이라도 1번은 무조건 반복실행하는 반복문
            int total = 0;
            int i = 1;

            do
            {
                if (i % 2 == 0)
                {
                    total += i;
                }
                i++;
            }
            while (i <= 10);

            Console.WriteLine("1부터 10까지 짝수합 : " + total);

            // break
            int num = 1; //1부터 시작

            while (true)
            {
                if(num % 5 == 0 && num % 7 == 0) //5를 나눴을때 0이거나 7을 나눴을때 0이거나
                {
                    break; //반복문 종료
                }
                num++; //1씩 계속 더함
            }


            Console.WriteLine("5와 7의 최소공배수: "+num); //나눠졌을때 출력 계속


            // continue
            int tot = 0;
            int j = 0;

            while (j <= 10) //j가 홀수일 때
            {
                j++;

                if (j % 2 == 1) //j가 짝수일 때
                {
                        continue;
                }
                tot += j;
            }
            Console.WriteLine("1부터 10까지 짝수합 : " + tot);
        }
    }
}

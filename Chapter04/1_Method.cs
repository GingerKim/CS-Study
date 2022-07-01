using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 매서도 실습 교재 p
일련의 코드 로직을 모듈화한 구조체 -> 일종의 함수
일반적인 함수를 말하며 객체지향 프로그래밍에서 매서드라고 부른다.
매서드는 정의하고 호출한다
*/


namespace Chapter4
{
    internal class _1_Method
    {
        static void Main(string[] args)
        {
            // 매서드 호출 (호출을 나중에 함)
            int r1 = f(1);
            int r2 = f(2);
            int r3 = f(3);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);


            int t1 = sum(1, 10);
            int t2 = sum(1, 100);
            int t3 = sum(start:1, end:1000);

            Console.WriteLine("t1: "+t1);
            Console.WriteLine("t1: "+t1);
            Console.WriteLine("t1: "+t1);


        }// main end

        //↓매서드 정의(정의 먼저)
        public static int f(int x) //매서드 앞은 무조건 퍼블릭 // int x는 대입할 숫자
        {
            int y = 2 * x + 3;
            return y;
        }

        public static int sum(int start, int end)
        {
            int total = 0;

            for (int k= start; k <= end; k++)
            {
                total += k;
            }

            return total;
        }

    } 
}

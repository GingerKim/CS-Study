using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/02
* 이름 : 김진재
* 내용 : C# 변수 실습하기 교재 p.79
*/


namespace Chapter2
{
    internal class _1_Variable
    {
        static void Main1(string[] args)
        {
            ///////////////////////
            //변수
            ///////////////////////
            int num1; // 선언
            num1 = 1; // 대입

            int num2 = 2; // 선언과 초기화
            int num3 = num1 + num2; // 연산

            Console.WriteLine("num3 :" + num3); // 결과확인




            ///////////////////////
            //상수
            ///////////////////////
            
            const double PI = 3.141592;
            const int num = 10;

            //num = 20;
            //num = 30;

            Console.WriteLine("num : " + num);
            Console.WriteLine("PI :" + PI);

        }
    }
}

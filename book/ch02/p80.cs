using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/08
* 이름 : 김진재
* 내용 : 정수 변수 생성 교재 p.80
* 정수 자료형
*/
namespace book.ch02
{
    internal class p80
    {
        static void Main1(string[] args)
        {
            int a = 10;
            int b = 5;

            Console.WriteLine(a + b); // int a와 int b를 더함
            Console.WriteLine(a - b); // int a에서 int b를 뺌
            Console.WriteLine(a * b); // int a와 int b를 곱함
            Console.WriteLine(a / b); // int a와 int b를 나눔
            Console.WriteLine(a % b); // int a와 int b의 나머지
        }
    }
}

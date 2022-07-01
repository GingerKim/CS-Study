using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/08
* 이름 : 김진재
* 내용 : 불(BOOL) 논리연산자 교재 p.78
* 논리 부정 연산자, 논리합 연산자, 논리곱 연산자
* 불과 논리연산자
*/
namespace book.ch02
{
    internal class p78
    {
        static void Main1(string[] args)
        {
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
        }
    }
}


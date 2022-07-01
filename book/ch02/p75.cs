using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/08
* 이름 : 김진재
* 내용 : 불(BOOL) 논리연산자 교재 p.75
* 논리 부정 연산자, 논리합 연산자, 논리곱 연산자
* 
*/
namespace book.ch02
{
    internal class p75
    {
        static void Main1(string[] args)
        {   // 논리부정 연산자
            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52 < 273));
            Console.WriteLine(!(52 > 273));

            // !는 논리 부정 연산자의 역할을 하는데 이를 앞에 붙이면
            // 뒤의 결과 값을 모두 부정하고 반대로 출력한다.
            // !인 논리 부정 연산자는 피연산자를 하나만 갖는데 이를 단항 연산자라고 부른다.
            // 반대로 피연산자가 두 개이면 이항 연산자, 세 개이면 삼항 연산자
            // 논리 부정 연산자!는 단항 연산자이지만
            // 논리합 연산자 ||와 논리곱 연산자 &&는 이항 연산자다.

            // 논리합 연산자
            /* true true = true
             * true false = true
             * false true = true
             * false false = false
             * 논리합 연산자는 두 개의 피연산자 중에 하나만 true이면 전체가 true가 된다.
             * o o = o
             * o x = o
             * x x = x
             * or이라고 부른다.
            
            // 논리곱 연산자
            /* true true = true
             * true false = false
             * false true = false
             * false false = false
             * 논리곱 연산자는 모두 true이어야만 전체가 true가 된다.
             * o o = o
             * o x = x
             * x x = x
             * and라고도 부른다.
             */
            
        }
    }
}

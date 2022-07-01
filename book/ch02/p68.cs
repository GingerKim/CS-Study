using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/03
* 이름 : 김진재
* 내용 : 기본 자료형(실수)의 연산 교재 p.68
*/

namespace book.ch02
{
    internal class p68
    {
        static void Main2(string[] args)
        {
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);
            //실수에도연산자들을 사용할 수 있으나 소숫점이 있는 숫자에 연산자를 사용시
            //어떠한 결과가 나올지 예측하기 어려워 사용하지 않는 것으로 추천한다.
        }
    }
}

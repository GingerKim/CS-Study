using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 문자열 연결 연산자와 문자선택 교재 p.71
*/


namespace book.ch02
{
    internal class p71
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("가나다" + "카타");
            //문자열을 합칠 수 있다.

            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[2]);
            Console.WriteLine("안녕하세요"[3]);
            Console.WriteLine("안녕하세요"[4]);
            //제일 첫 글자를 0부터 시작하는 안녕하세요는 안0 녕1 하2 세3 요4로 숫자 순서에 해당되는 글자를 선택할 수 있다.
        }
    }
}

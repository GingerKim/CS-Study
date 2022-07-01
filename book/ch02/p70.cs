using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 기본 자료형(문자열) 교재 p.70
*/

namespace book.ch02
{
    internal class p70
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("안녕하세요");

            //문자의 집합을 문자열이라고 부른다.
            //C#은 큰 따옴표를 사용해 문자열을 생성한다.

            Console.WriteLine("안\t녕하세요");
            //\t은 탭키를 누른 것처럼 수평으로 길이거 늘어난다.

            Console.WriteLine("안\n녕하세요");
            //\n은 엔터친 것처럼 행이 바뀐다.

            Console.WriteLine("안\\녕하세\\요");
            //역슬래시 두개를 하나로 출력함

            Console.WriteLine("안\"녕하세\"요");
            //역슬래시 뒤에 붙는 따옴표는 큰 따옴표로 역할을 함

            //예제

            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("한빛\"아\"카데미");

    }
    }
}

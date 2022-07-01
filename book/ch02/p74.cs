using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/08
* 이름 : 김진재
* 내용 : 불(BOOL) 비교연산자 교재 p.74
*/

namespace book.ch02
{
    internal class p74
    {
        static void Main1(string[] args)
        {
        Console.WriteLine(52 < 273); // 오른쪽이 크다 O
        Console.WriteLine(52 > 273); // 왼쪽이 크다 X
        Console.WriteLine(273 == 273); // 양쪽이 같다 O
        Console.WriteLine(52 <= 273); // 오른쪽이 크거나 같다 O
        Console.WriteLine(52 != 273); // 양쪽이 다르다 O
        }
    }
}

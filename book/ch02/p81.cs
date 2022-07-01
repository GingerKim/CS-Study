using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/09
* 이름 : 김진재
* 내용 : 오버플로우 교재 p.81
* 자료형 int의 범위를 넘어가면 숫자가 오류가 발생한다.
*/
namespace book.ch02
{
    internal class p81
    {
        static void Mai1n(string[] args)
        {
            int a = 2147483640;
            int b = 52273;

            Console.WriteLine(a + b);
        }
    }
}
/* -2147431383이 나오게 되는데 이는 int의 자료형 범위를
 * 벗어나서 발생하는 현상으로 양수에서의 한계를 넘어 음수로 표현되는 것
 * 이러한 현상을 오버플로우Overflow라고 한다.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/02
 * 이름 : 김진재
 * 내용 : C# 개발환경 설정 및 Hello World 출력
 */


namespace Chapter1
{
    internal class _1_HelloWorld /* 숫자로 시작할 수 없기 때문에 언더바가 한번 더 붙음 */
    {

        static void Main(string[] args)
        {
            // 기본출력 한 줄씩 따로 출력
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello C#!");

            // 서식출력 같은 줄에 출력(\t, \n 등이 서식)
            Console.Write("Hello");
            Console.Write("Korea");

            Console.Write("Hello\t");
            Console.Write("Korea\n");
            
            // 포멧출력 {0}에 hello 등을 할당
            Console.WriteLine("{0}, {1}", "Hello", "Busan");
        }
    }
}

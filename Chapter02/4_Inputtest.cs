using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
* 날짜 : 2022/06/03
* 이름 : 김진재
* 내용 : 
*/


namespace Chapter2
{
    internal class _4_Inputtest
    {
        static void Main2(string[] args)
        {
            // 이름 입력
            Console.Write("이름: ");
            string name = Console.ReadLine();

            // 나이 입력
            Console.WriteLine("나이: ");
            string age = Console.ReadLine();
            
            // 주소 입력
            Console.WriteLine("주소: ");
            string addr = Console.ReadLine();

            Console.WriteLine("================");
            Console.WriteLine("이름 : " +name);
            Console.WriteLine("나이 : " +age);
            Console.WriteLine("주소 : " +addr);

        }
    }
}

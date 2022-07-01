using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 매서드 오버로딩 실습 교재 275p
*
* 메서드 오버로딩(OverLoading)
*  같은 이름의 매서드를 매개변수로 구분한 매서드
*  매서드 반환 타입은 오버로딩에 영향을 미치지 않는다.
*  
*

namespace Chapter4
{
    internal class _3_MethodOverload
    {
        static void Main2(string[] args)
        {
            int r1 = Plus(1, 2);
            int r2 = Plus(1, 2, 3);
            double r3 = Plus(1.01, 2.3);
            string r4 = Plus("Hello", "World");

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);
            Console.WriteLine("r4 : "+r4);


            public static int Plus(int a, int b)
            { 
                return a + b; 
            }

            public static int Plus(int a, int b, int c)
            { 
                return a + b + c; 
            }

            public static int Plus(double a, double b)
            {
                return a + b; 
            }

            public static int Plus(string a, string b)
            { 
                return 0; 
            }


        }
    }
}
*/
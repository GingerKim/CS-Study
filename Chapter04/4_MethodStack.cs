using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
* 날짜 : 2022/06/07
* 이름 : 김진재
* 내용 : 매서드 출력전용 매개변수 실습 교재 275p
*
* 
*/

namespace Chapter4
{
    internal class _4_MethodStack
    {
        static void Main1(string[] args)
        {
            int result = 0;
            int n1 = 1;
            int n2 = 10;

            result = sum(n1, n2);

            Console.WriteLine("result :" +result);  
        }
        public static int sum(int start, int end)
        {
            int total = 0;

            for (int k= start; k<=end; k++)
            {
                total += k;
            }    
            return total;


        }
    }
}

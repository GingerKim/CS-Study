using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/21
 * 이름 : 김진재
 * 내용 : 람다 실습하기 교재 p500
 * 
 * 람다식(Lambda)
 * - 함수적 프로그래밍을 지원하기 위한 문법 식
 * - 대리자를 조금 더 간편하게 사용하기 위한 식(익명 메서드)
 *
 */

namespace Chapter09
{
    internal class _2_Lamdba
    {
        static void Main(string[] args)
        {
            //반환이 있는 람다식(Func 대리자)
            Func<string> f1 = () => {
                return "f1 실행";
            };
            Func<int, string> f2 = (x) => {
                return "f2 x :" + x;
            };
            Func<int, int, string> f3 = (x, y) => {
                return $"f3 x: {x}, y: {y}";
            }; //int 둘은 제네릭, 매개변수, string은 반환 타입

            string r1 = f1();
            string r2 = f2(3);
            string r3 = f3(3, 4);

            Console.WriteLine("r1 : " + r1);
            Console.WriteLine("r2 : " + r2);
            Console.WriteLine("r3 : " + r3);

            //반환이 없는 람다식(Action 대리자)
            Action           a1 = ()     => { Console.WriteLine("a1 실행"); };
            Action<int>      a2 = (x)    => { Console.WriteLine("a2 x : " + x); };
            Action<int, int> a3 = (x, y) => {
                Console.WriteLine($"a3 x : {x}, y : {y}");
            };
                
            a1();
            a2(3);
            a3(3,4);


            //람다식 활용
            List<int> dataset = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            dataset.ForEach((n) => {
                Console.WriteLine(n + "");
            });


        }
    }
}


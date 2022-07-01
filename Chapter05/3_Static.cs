using Chapter5.Sub3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/08
 * 이름 : 김진재
 * 내용 : 클래스 변수, 클래스 매서드 실습 교재 p225
 * 
 * 클래스 변수, 매서드(정적 변수, 매서드)
 *  static 변수, Data 영역 메모리 공간에 하나의 클래스로 과닐
 * 클래스 타입(객체 생성 X)으로 직접 참조
 * 
 * 싱글톤 객체
 *  싱글톤 객체는 하나의 인스턴스만을 갖도록 보장하는 객체이다.
 *  싱글톤 객체를 활용해서 메모리 절약과 성능 향상을 기대할 수 있다.
 */

namespace Chapter5
{
    class Increment
    {
        public int num1;
        public static int num2;

        public Increment()
        {
            num1++;
            num2++;
            Console.WriteLine("num1 : {0}, num2 : {1}", num1, num2);
        }

        public static void Add()
        {
            // static 메서드(클래스 메서드)는 non-static 변수를 참조할 수 없다.
            //num1++;
            num2++;

            Console.WriteLine("num2 : "+num2);
        }

        internal class _3_Static
        {
            static void Main3(string[] args)
            {
                Increment inc1 = new Increment();
                Increment inc2 = new Increment();
                Increment inc3 = new Increment();

                //클래스 변수, 클래스 메서드 실행
                Increment.num2 = 10;
                Increment.Add();

                //Car 객체 생성
                Car car1 = new Car("현대차", "검은색", 0);
                Car car2 = new Car("기아차", "흰색", 0);
                Car car3 = new Car("폭스바겐", "검은색", 0);

                car1.Show();
                car2.Show();
                car3.Show();

                // Calc 싱글톤 객체 가져오기
                Calc c1 = Calc.Instance;
                Calc c2 = Calc.Instance;
                Calc c3 = Calc.Instance;
                Calc c4 = Calc.Instance;

                int r1 = c1.Plus(1, 2);
                int r2 = c2.Minus(1, 2);
                int r3 = c3.Multi(2, 3);
                int r4 = c4.Div(4, 2);

                Console.WriteLine("r1 : " +r1);
                Console.WriteLine("r2 : " +r2);
                Console.WriteLine("r3 : " +r3);
                Console.WriteLine("r4 : " +r4);
            }
        }
    }
}

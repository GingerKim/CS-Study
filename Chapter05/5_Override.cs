using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/09
 * 이름 : 김진재
 * 내용 : 오버라이드 실습하기 교재 p331
 *
 *오버라이드(OVerride)
 * 부모클래스의 메서드를 자식클래스에서 다시 재정의(덮어쓰기) 하는 것
 * 오버라이드를 통해 다형성을 실현한다.
 *
 *
 */



namespace Chapter5
{
    class AAA
    {
        public void Method1()
        {
            Console.WriteLine("AAA : Method1 ...");
        }
        public virtual void Method2()
        {
            Console.WriteLine("AAA : Method2 ...");
        }
        public void Method3()
        {
            Console.WriteLine("AAA : Method3 ...");
        }
    }
    class BBB : AAA
    {
        // method Hiding : BBB의 method1이 AAA의 method1을 숨김
        public void Method1()
        {
            Console.WriteLine("BBB : Method1 ...");
        }

        //method override : BBB의 method의 AAA의 method2를 덮어씌움
        public override void Method2()
        {
            Console.WriteLine("BBB : Method2 ...");
        }
        //method Overload : BBB의 method3와 AAA의 method3를 매개변수로 구분
        public void Method3(int a)
        {
            Console.WriteLine("BBB : Method3 ...");
        }
    }
    class CCC : BBB
    {
        //method hiding : CCC의 method1이 BBB의 method1을 숨김
        public new void Method1()
        {
            Console.WriteLine("CCC : Method1 ...");
        }
        //method override : CCC의 method2가 BBB의 method2를 덮어씌움
        public override void Method2()
        {
            Console.WriteLine("CCC : Method2 ...");
        }
        //method override : CCC의 method3이 AAA의 method3을 덮어씌움
        public void Method3()
        {
            Console.WriteLine("CCC : Method3 ...");
        }
    }

    internal class _5_Override
    {
        static void Main5(string[] args)
        {
            AAA a = new AAA();
            BBB b = new BBB();
            CCC c = new CCC();

            a.Method1();
            a.Method2();
            a.Method3();
            Console.WriteLine();

            b.Method1();
            b.Method2();
            b.Method3();
            Console.WriteLine();

            c.Method1();
            c.Method2();
            c.Method3(1);
            Console.WriteLine();

        }
    }
}

using Chapter5.Sub4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/09
 * 이름 : 김진재
 * 내용 : 클래스 상속 실습하기 교재 p331
 * 
 * 상속은 기존의 클래스가 가지고 잇는 필드와 매서드를 그대로 물려 받은 자식 클래스를 정의하는 것
 *  ㄴ기존의 클래스의 속성과 기능을 그대로 파생 클래스로 물려줘 클래스를 확장하는 문법
 * 공통적인 내용을 부모 클래스에 두고 자식 클래스에서 상속 받아 일관되고 효율적인 프로그래밍을 수행한다.
*/

namespace Chapter5
{
    class Parent
    {
        private int num1;
        private int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Plus()
        {
            return num1 + num2;
        }
    }

    class Child : Parent
    {
        private int num3;
        private int num4;

        public Child(int num1, int num2, int num3, int num4) : base(num1, num2)
        {
            this.num3 = num3;
            this.num4 = num4;
        }

        public int Minus()
        {
            return num3 - num4;
        }
    }

    internal class _4_Inheritance
    {
        static void Main4(string[] args)
        {
            // 상속 객체 생성
            Child c1 = new Child(1, 2, 3, 4);
            Child c2 = new Child(10, 20, 30, 40);

            Console.WriteLine("c1 Plus : " + c1.Plus());
            Console.WriteLine("c1 Minus : " + c1.Minus());
            Console.WriteLine("c2 Plus : " + c2.Plus());
            Console.WriteLine("c2 Minus : " + c2.Minus());

            Sedan sedan = new Sedan("그랜저", "검정색", 0, 2000);
            Truck truck = new Truck("봉고", "파란색", 0, 1);

            sedan.SpeedUp(40);
            sedan.Show();

            truck.SpeedUp(70);
            truck.Show();

            // Account 상속 객체 생성
            StockAccount kb = new StockAccount("kb증권", "10-110-1", "김유식", 1000, "삼성전자", 0, 0);
            kb.Deposit(1000000);
            kb.buy(10, 70000);
            kb.sell(5, 75000);
            kb.Show();
        }
    }
}
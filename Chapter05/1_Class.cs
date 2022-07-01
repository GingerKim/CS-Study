using Chapter5.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 : 2022/06/08
* 이름 : 김진재
* 내용 : 클래스와 객체 실습하기 p203
*
* 클래스와 객체
* 클래스는 객체를 생성하는 구조체이며 필드와 메서드로 구성된다.
* 객체는 클래스의 실제 인스턴스이며 new 연산자로 생성한다.
*
*
*/

namespace Chapter5
{
    internal class _1_Class
    {
        static void Main1(string[] args)
        {
            // 객체 생성
            Car sonata = new Car();

            // 객체 초기화
            sonata.name = "소나타";
            sonata.color = "흰색";
            sonata.speed = 0;

            //객체 기능
            sonata.SpeedUp(10);
            sonata.SpeedUp(50);
            sonata.SpeedDown(20);
            sonata.Show();

            //객체 생성(BMW, 검정색)
            Car bmw = new Car();
            bmw.name = "bmw 520d";
            bmw.color = "검정색";
            bmw.speed = 0;

            bmw.SpeedUp(10);
            bmw.SpeedUp(90);
            bmw.SpeedDown(30);
            bmw.Show();


            // Account 객체생성
            Account kb = new Account();

            // 초기화
            kb.bank = "국민은행";
            kb.id = "101-12-1234";
            kb.name = "김유신";
            kb.balance = 10000;

            // 기능
            kb.Deposit(25000);
            kb.Withdraw(1500);
            kb.Show();

            // Account 객체생성2
            Account nh = new Account();
            nh.bank = "농협";
            nh.id = "120-11-1424";
            nh.name = "김춘추";
            nh.balance = 30000;

            nh.Deposit(70000);
            nh.Withdraw(20000);
            nh.Show();
        }
    }
}

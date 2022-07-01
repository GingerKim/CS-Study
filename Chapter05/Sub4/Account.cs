using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub4
{
    internal class Account
    {
        // 속성 - private 캡슐화 적용
        protected string bank;//은행명
        protected string id; //계좌주
        protected string name; //입금주
        protected int balance; //잔액


        // 생성자 - 캡슐화 된 속성을 초기화하기 위한 매서드
        public Account(string bank, string id, string name, int balance)
        {
            this.bank = bank;
            this.id = id;
            this.name = name;
            this.balance = balance;
        }



        // 기능
        public void Deposit(int money)
        {
            this.balance += money;
        }

        public void Withdraw(int money)
        {
            this.balance -= money;
        }

        public void Show()
        {
            Console.WriteLine("==============");
            Console.WriteLine("은행명   : "+bank);
            Console.WriteLine("계좌번호 : "+id);
            Console.WriteLine("입금주   : "+name);
            Console.WriteLine("현재잔액 : "+balance);
            Console.WriteLine("==============");
        }
        

    }
}

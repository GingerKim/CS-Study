using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub4
{
    internal class Sedan : Car
    {
        private int cc;

        public Sedan(string name, string color, int speed, int cc) : base(name, color, speed)
        {
            this.cc = cc;
        }

        public void Show()
        {
            Console.WriteLine("========================");
            Console.WriteLine("차량명 : " +name);
            Console.WriteLine("차량색 : " +color);
            Console.WriteLine("차량속도 : " +speed);
            Console.WriteLine("차량배기량 : " +cc);
            Console.WriteLine("========================");
        }
    }
}

// 상속되었다고 해도 캡슐화 되어있을 경우 상속개체가 부모계체를 참조하지 못함. 때문에 프로텍트로 바꿔줘야함(private->protected)

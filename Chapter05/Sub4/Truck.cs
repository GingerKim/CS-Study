using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub4
{
    internal class Truck : Car
    {
        private int capacity;

        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public void Show()
        {
            Console.WriteLine("========================");
            Console.WriteLine("트럭명 : " +name);
            Console.WriteLine("트럭색 : " +color);
            Console.WriteLine("트럭속도 : " +speed);
            Console.WriteLine("트럭적재량 : " +capacity);
            Console.WriteLine("-----------------------");
        }
    }
}

// 상속되었다고 해도 캡슐화 되어있을 경우 상속개체가 부모계체를 참조하지 못함. 때문에 프로텍트로 바꿔줘야함(private->protected)
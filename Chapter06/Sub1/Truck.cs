using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Sub1
{
    internal class Truck : Car
    {
        private int capacity;
        
        public Truck(string name, string color, int speed, int capacity) : base(name, color, speed)
        {
            this.capacity = capacity;
        }

        public override void SpeedUp(int speed)
        {
            Console.WriteLine("Truck SpeedUp ...");
            base.speed += speed;
        }

        public override void SpeedDown(int speed)
        {
            Console.WriteLine("Truck SpeedDown ...");
            base.speed -= speed;
        }

        public void show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("트럭명 : "+name);
            Console.WriteLine("트럭색 : "+color);
            Console.WriteLine("트럭속도 : "+speed);
            Console.WriteLine("트럭적재량 : "+capacity);
            Console.WriteLine("--------------------");
        }

    }
}

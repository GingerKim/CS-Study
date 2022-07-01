using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 클래스 변수(정적 변수)
 * static 변수, data영역 메모리 공간에 하나의 클래스 변수로 관리
 * 클래스 타입(객체 생성 X)으로 직접 참조
 */

namespace Chapter5.Sub4
{
    internal class Car
    {
        // 속성(필드)
        protected string name;
        protected string color;
        protected int speed;

        // 생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }


        //기능(메서드)
        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }

        public void SpeedDown(int speed)
        {
            this.speed -= speed;
        }

        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("차량속도 : "+speed);
        }
    }
}
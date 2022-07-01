using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
 * 클래스 변수(정적 변수)
 * static 변수, data영역 메모리 공간에 하나의 클래스 변수로 관리
 *클래스 타입(객체 생성 X)으로 직접 참조
*
 *
 */

namespace Chapter5.Sub3
{
    internal class Car
    {
        // 속성(필드)
        private string name;
        private string color;
        private int speed;
        private static int count;

        // Getter, Setter --> C#에서는 프로퍼티
        public string Name { get { return name; } set { name = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Speed{
            get
            {
                return speed;
            }
            set 
            {
                if (value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없습니다.");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            } 
        }
        
        // 생성자
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
            count++;
        }

        // 소멸자
        ~Car()
        {
            Console.WriteLine("{0} Car 소멸자 실행...", name);
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
            Console.WriteLine("전체 차량 수 : "+count);
        }
    }
}
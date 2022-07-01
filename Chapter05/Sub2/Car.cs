using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub2
{
    internal class Car //class에는 그룹이라는 뜻도 있다. 이하는 class의 멤버들이라는 뜻이기도 함
        //현재 이하와 같이 6개로 구성되어있음 //public은 생략도 가능함
    {
        // 속성(필드) 멤버 변수
        private string name;
        private string color;
        private int speed;

        /* Getter, Setter --> C#에서는 프로퍼티
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }        
        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }
        public string Speed
        {
            get
            {
                return speed;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("speeed는 0보다 작을 순 없다.");
                    speed = 0;
                }
                else
                {
                    speed = value;
                }
            }
        }
        */

        // Getter, Setter --> C#에서는 프로퍼티
        public string Name { get { return name; } set { name = value; } }
        public string Color { get { return color; } set { color = value; } }
        public int Speed
        {
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
        }



        // 소멸자 //객체가 소멸할 때 //프로그램 종료시
        ~Car()
        {
            Console.WriteLine("{0} Car 소멸자 실행...", name);
        }



        // 기능(메서드) 멤버 메서드
        public void SpeedUp(int speed)//위 스피드와는 같지 않은 그냥 동명임 _언더바를 붙여 구분 가능
        {
            this.speed += speed; //this를 붙이면 위 public int speed의 speed라는 뜻
        }
        public void SpeedDown(int speed)//위 스피드와는 같지 않은 그냥 동명임 _언더바를 붙여 구분 가능
        {
            this.speed -= speed; //this를 붙이면 위 public int speed의 speed라는 뜻
        }
        public void Show()
        {
            Console.WriteLine("=================");
            Console.WriteLine("차량명 : "+name); //this.name이지만 생략
            Console.WriteLine("차량색 : "+color);//this.color이지만 생략
            Console.WriteLine("차량속도 : "+speed);//this.speed이지만
        }
    }
}

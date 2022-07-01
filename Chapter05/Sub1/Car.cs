using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub1
{
    internal class Car //class에는 그룹이라는 뜻도 있다. 이하는 class의 멤버들이라는 뜻이기도 함
        //현재 이하와 같이 6개로 구성되어있음 //public은 생략도 가능함
    {
        // 속성(필드) 멤버 변수
        public string name;
        public string color;
        public int speed;
        
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
            Console.WriteLine("차량명 : "+name); //this.name이지만 생략
            Console.WriteLine("차량색 : "+color);//this.color이지만 생략
            Console.WriteLine("차량속도 : " +speed);//this.speed이지만 생략
        }
    }
}

using Chapter5.Sub5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/09
 * 이름 : 김진재
 * 내용 : 다형성(폴리모르피즘) 실습하기 교재 p340
 *
 *다형성(Polymorphism)
 * 상속 관계에서 오버라이드를 활용해
 * 부모클래스의 기능이 자식 클래스에서
 * 여러 기능으로 변할 수 있는 성질을 말한다.
 * 
 *  ex) 고양이과 -> 호랑이/사자/고양이 등
 *  
 * 생성된 객체의 타입선언을 부모 클래스 타입으로 선언
 * 
 * 
 * 객체지향 프로그래밍에서는 다형성을 활용해서
 * 프로그램의 반복을 줄이고 유연성을 높인다.
 *
 */
namespace Chapter5
{
    internal class _6_Polymorphism
    {
        static void Main6(string[] args)
        {
            // 객체 생성
            Animal a1 = new Tiger();
            Animal a2 = new Eagle();
            Animal a3 = new Shark(); //각각의 이름이 아닌 Animal이 낫다

            a1.Move();
            a2.Move();
            a3.Move();

            // 객체타입 캐스팅
            Tiger tiger = (Tiger) a1;
            Eagle eagle = (Eagle) a2;
            Shark shark = (Shark) a3;

            tiger.Hunt();
            eagle.Hunt();
            shark.Hunt();
            
            // 객체티입 확인
            if (a1 is Tiger)
            {
                Console.WriteLine("a1은 Tiger입니다.");
            }

            if (a2 is Eagle)
            {
                Console.WriteLine("a2은 Eagle입니다.");
            }

            if (a3 is Shark)
            {
                Console.WriteLine("a3은 Shark입니다.");
            }

        }
    }
}

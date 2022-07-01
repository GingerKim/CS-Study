using Chapter06.Sub2;
using Chapter6.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/13
 * 이름 : 김철학
 * 내용 : 인터페이스 실습 교재 p425
 * 
 *  인터페이스(Interface)
 *  - 클래스 간의 공통의 통일된 표준 규격을 통해 클래스 구조를 설계하는 방법
 *  - 인터페이스를 활용해서 다중 상속을 구현한다.
 *  - 인터페이스를 활용해서 객체 간의 결합도를 완화하는 효과를 갖는다.
 * 
 *  A와 B를 연결하는 교두보 역할을 함
 *  직접 A와 B가 연결되면 결합도가 높아지는 문제가 생김
 */
namespace Chapter6
{
    internal class _2_Interface
    {
        static void Main2(string[] args)
        {
            // 인터페이스 공통 클래스 구조 설계
            IRemoteControl lg = new LGRemocon();
            IRemoteControl samsung = new SamsungRemocon();

            lg.PowerOn();
            lg.ChDown();
            lg.SoundUp();
            lg.PowerOff();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundDown();
            samsung.PowerOff();

            // 인터페이스를 활용한 다중상속
            TV tv = new TV();
            tv.PowerOn();
            tv.Booting();
            tv.Access();

            // 인터페이스를 활용한 결합도 완화
            Bulb bulb = new Bulb();
            ISocket socket = new Cable(bulb);

            socket.SwitchOn();
            socket.SwitchOff();



        }
    }
}


/*



*/

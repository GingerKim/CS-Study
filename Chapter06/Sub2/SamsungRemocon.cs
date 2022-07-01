using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Sub2
{
    internal class SamsungRemocon : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("Samsung Channel Down");
        }

        public void ChUp()
        {
            Console.WriteLine("Samsung Channel Up");
        }

        public void PowerOff()
        {
            Console.WriteLine("Samsung Power Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("Samsung Power On");
        }

        public void SoundDown()
        {
            Console.WriteLine("Samsung Sound Down");
        }

        public void SoundUp()
        {
            Console.WriteLine("Samsung Sound Up");
        }
    }
}

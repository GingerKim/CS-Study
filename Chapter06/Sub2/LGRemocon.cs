using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter6.Sub2
{
    internal class LGRemocon : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("LG Channel down");
        }

        public void ChUp()
        {
            Console.WriteLine("LG Channel up");
        }

        public void PowerOff()
        {
            Console.WriteLine("LG Power Off");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG Power On");
        }

        public void SoundDown()
        {
            Console.WriteLine("LG Sound Down");
        }

        public void SoundUp()
        {
            Console.WriteLine("LG Sound up");
        }
    }
}

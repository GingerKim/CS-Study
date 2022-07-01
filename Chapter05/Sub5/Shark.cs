using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub5
{
    internal class Shark : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Shark swim... ");
        }
        public void Hunt()
        {
            Console.WriteLine("Shark Hunt...");
        }
    }
}

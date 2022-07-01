using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub5
{
    internal class Tiger : Animal
    {
        public override void Move()
        {
            Console.WriteLine("Tiger Run...");
        }
        public void Hunt()
        {
            Console.WriteLine("Tiger Hunt...");
        }
    }
}

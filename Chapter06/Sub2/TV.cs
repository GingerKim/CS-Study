using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06.Sub2
{
    internal class TV : internet, IComputer
    {
        public void PowerOn()
        {
            Console.WriteLine("TV PowerOn...");
        }

        public void Booting()
        {
            Console.WriteLine("TV Booting...");
        }
        public void AccessInternet()
        {
            base.Access();
        }
    }
}

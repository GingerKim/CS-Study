using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter5.Sub3
{
    internal class Calc
    {
        private static Calc instance = new Calc();
        public static Calc Instance { get { return instance; } }
        private Calc() { }

        public int Plus(int x, int y) 
        {
            return x + y;
        }
        public int Minus(int x, int y)
        {
            return x - y;
        }
        public int Multi(int x, int y)
        {
            return x * y;
        }
        public int Div(int x, int y)
        {
            return x / y;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter06.Sub3
{
    internal class Banana
    {
        private string country;
        private int price;

        public Banana(string country, int price)
        {
            this.country = country;
            this.price = price;
        }

        public void show()
        {
            Console.WriteLine("바나나 원산지 :" + country);
            Console.WriteLine("바나나 가격 :" + price);
            }
    }
}


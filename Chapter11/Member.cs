using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter11
{
    internal class Member
    {
        private string uid;
        private string name;
        private string hp;
        private int age;

        public Member(string uid, string name, string hp, int age)
        {
            this.Uid = uid;
            this.Name = name;
            this.Hp = hp;
            this.Age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public string Hp { get => hp; set => hp = value; }
        public int Age { get => age; set => age = value; }
    }
}
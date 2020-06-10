using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Cat
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public Cat() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠냠"); }
        public void sleep() { Console.WriteLine("Zzz"); }
        public void Meow() { Console.WriteLine("냥"); }
    }
}

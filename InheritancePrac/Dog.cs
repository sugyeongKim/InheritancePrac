using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Dog
    {
        public int Age { get; set; }
        public string Color { get; set; }
        public Dog() { this.Age = 0; }

        public void Eat() { Console.WriteLine("냠냠냠"); }
        public void sleep() { Console.WriteLine("Zzz"); }
        public void bark() { Console.WriteLine("멍멍"); }
    }
}

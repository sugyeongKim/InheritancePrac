using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePrac
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dog> dogs =
                new List<Dog> { new Dog(), new Dog(), new Dog() };
            List<Cat> cats =
                new List<Cat> { new Cat(), new Cat(), new Cat() };

            foreach( Dog dog in dogs)
            {
                dog.Eat();
                dog.sleep();
                dog.bark();
            }

            foreach (Cat cat in cats)
            {
                cat.Eat();
                cat.sleep();
                cat.Meow();
            }
        }
    }
}

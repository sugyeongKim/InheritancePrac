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
            //List<Animal> animals =
            //    new List<Animal>
            //    {
            //        new Dog(), new Cat(), new Cat(),
            //        new Dog(), new Dog(), new Cat()
            //    };

            //foreach( var items in animals)
            //{
            //    items.Eat();
            //    items.Sleep();

            //    var dog = items as Dog;
            //    if (dog != null) { dog.Bark(); }

            //    var cat = items as Cat;
            //    if (cat != null) { cat.Meow(); }

            //}

            Child child = new Child(11);
        }
    }
}

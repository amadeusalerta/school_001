using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_12_23_03
{
    class Animal_001
    {
        public void eat()
        {
            Console.WriteLine("The animal is eating");
        }
    }

    class Dog : Animal_001
    {
        public void Bark()
        {
            Console.WriteLine("Dog is Barking!");
        }
    }

    class Cat : Animal_001
    {
        public void Meow()
        {
            Console.WriteLine("GATO");
        }
    }

    public class Program_002
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Meow();
            cat.eat();
        }
    }
}

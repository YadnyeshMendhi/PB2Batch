using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class AnimalMock
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Dog : AnimalMock
    {
        public void Bark()
        {
            Console.WriteLine("Barking ");
        }

    }
    class Inheritance
    {

        static void Main(String[] args)
        {

            Dog b = new Dog();
            b.eat();
            b.Bark();
        }
    }
}

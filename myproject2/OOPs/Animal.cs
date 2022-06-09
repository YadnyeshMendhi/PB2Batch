using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
       
    }
    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking ");
        }
        
    }
    class BabyDog : Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping");

        }
        
    }
    class Inheritance
    {

        static void Main(String [] args)
        {

            BabyDog b = new BabyDog();
            b.eat();
            b.Bark();
            b.Weep();

        }



    }
}

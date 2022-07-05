using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.OOPs
{

    class Bird
    { 
        public virtual void eat()
        {
            Console.WriteLine("Bird is eating");
        }
    }

    class Sparrow : Bird
    {
        public override void eat()
        {
            base.eat();
            Console.WriteLine("Sparrow is eating ");
        }


    }

    class Overriding
    { 
        static void Main(String [] args)
        {
            Sparrow spa = new Sparrow();
            spa.eat();

            /*Bird b = new Sparrow();
            b.eat();*/
           
        }
    }

    //Another Example

    class baseClass
    {
        public virtual void Greetings()
        {
            Console.WriteLine("baseClass Saying Hello!");
        }
    }
    class subClass : baseClass
    {
        public override void Greetings()
        {
            base.Greetings();
            Console.WriteLine("subClass Saying Hello!");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            baseClass obj1 = new subClass();
            obj1.Greetings();
            Console.ReadLine();
        }
    }
}

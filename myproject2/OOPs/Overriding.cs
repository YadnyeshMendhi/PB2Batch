using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
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
            Console.WriteLine("Sparrow is eating ");
        }


    }

    class Overriding
    { 
        static void Main(String [] args)
        {
           /* Sparrow spa = new Sparrow();
            spa.eat();*/

            Bird b = new Sparrow();
            b.eat();
           
        }
    }
}

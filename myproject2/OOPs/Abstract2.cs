using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{

    public abstract class animal
    {
        //abstract method (does not have a body)
        public abstract void animalSound();

        // Regular method
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }
    public class pig : animal
    {
        public override void animalSound()
        {
            Console.WriteLine("pig says : wee wee");
        }
    }

    class Abstract2
    {
        public static void Main(string[] args)
        {
            pig p = new pig();
            p.animalSound();
            p.sleep();

        }
    }
}

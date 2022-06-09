using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{

    public abstract class animal
    {
        //abstract method
        public abstract void animalSound();

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

        }
    }
}

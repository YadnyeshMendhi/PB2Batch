using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.OOPs
{
    class StaticMethodOverloading
    {

        static void Main(String [] args)
        {

            abc.calculate(2, 3);
            abc.calculate(3.4f, 5.4f);



        }
    }
    public static class abc
    { 

        public static void calculate(int a , int b)
        {
            Console.WriteLine(a+b);
        }
        public static void calculate(float a, float b) 
        {
            Console.WriteLine(a/b);
        }
   
    }
}

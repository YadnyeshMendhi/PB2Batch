using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ConstructorOverloading
    {

        ConstructorOverloading()
        {
            Console.WriteLine("Hii this is default");
        }

        ConstructorOverloading(int c , int d)
        {
            Console.WriteLine("Hello this is default");
        }

        static  void Main(string [] args)
        {

            ConstructorOverloading d = new ConstructorOverloading();
            ConstructorOverloading d1 = new ConstructorOverloading(4 ,5);


        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class HomeWork1
    {
        static void Main(string[] args)
        {



            int a = 2;
            int b = 2;
            int c = 2;

            int x = a++ + b++ + c++;
            Console.WriteLine(x+" "+ a +" "+b);

            x = ++a + ++b + ++c;
            Console.WriteLine(x + " " + a + " " + b);

            x = ++a - ++b - ++c;
            Console.WriteLine(x + " " + a + " " + b);

            x = --a - b++ - c--;
            Console.WriteLine(x + " " + a + " " + b);

            x = ++c - a - --b + a--;
            Console.WriteLine(x + " " + a + " " + b);


        }
    }
}

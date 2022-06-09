using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Swapping
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap numbers a="+a+" b="+b);
            a = a + b; // 15(10 + 5)
            b = a - b; //5(10 - 5)
            a = a - b; //10(15 - 5)
            Console.WriteLine("After swap numbers a="+a+" b="+b);

        }
    }
}

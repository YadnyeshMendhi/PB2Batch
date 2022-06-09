using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class CUBE
    {
        static void Main(string[] args)
        {
            int i, cube;
            Console.WriteLine("Enter any number  :");
            i = Convert.ToInt32(Console.ReadLine());

            cube = i * i * i;

            Console.WriteLine("The cube of given number is : " +cube);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayEvenOdd
    {

       static void Main(String [] args)
        {
            int[] a = { 2, 3, 6, 7, 9, 7 };


            Console.WriteLine("Even Numbers");
            for(int i = 0; i <a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {

                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("/////////////////");

            Console.WriteLine("Odd Numbers");
            for(int i  =0; i<a.Length; i++)
            {
                if(a[i]%2 != 0)
                {
                    Console.WriteLine(+a[i]);
                }
            }
        }
    }
}

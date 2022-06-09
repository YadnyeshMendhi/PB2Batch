using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class EvenSumArray
    {

        static void Main(String [] args)
        {

            Console.WriteLine("Enter size of array");
            int size = Convert.ToInt32(Console.ReadLine());


            int[] a = new int[size];
            int sum = 0;

            Console.WriteLine("Enter arrays elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());


            }

            Console.WriteLine("///////////////////");

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] % 2 == 0)
                {
                    sum = sum + a[i];
                }
            }
            Console.WriteLine("Sum of even = " + sum);
        }
    }
    
}

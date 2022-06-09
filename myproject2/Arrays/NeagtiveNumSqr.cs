using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class NeagtiveNumSqr
    {

        static void Main(String [] args)
        {

            Console.WriteLine("Enter the Size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];

            Console.WriteLine("Enter the elements of array");

            for(int i=0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a);
            }

            for(int i=0; i<a.Length; i++)
            {
                if (a[i] < 0)
                {
                    a[i] = a[i] * a[i];
                }
            }
            foreach(int num in a)
            {
                Console.WriteLine(num);
            }


        }
    }
}

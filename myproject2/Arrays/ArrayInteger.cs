using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayInteger
    {

        static void Main(String[] args)
        {

            int[] marks = { 1, 2, 3, 4, 5, };

            int[] a = new int[6];

            Console.WriteLine("Enter Array Elements");

            for(int i = 0; i<a.Length; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("............");
            for(int i = 0; i<a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();

      




        }
    }
}

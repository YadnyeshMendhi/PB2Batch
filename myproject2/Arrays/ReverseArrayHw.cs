using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ReverseArrayHw
    {

        static void Main(String [] args)
        {
            int[] a1 = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine(String.Join(" , " , a1));

            Console.WriteLine(".......................");
            int j = a1.Length - 1;

            for(int i =a1.Length-1; i>=0; i--)
            {
                Console.WriteLine(a1[i] + " ");
            }

            for(int i = 0; i<a1.Length/2; i++)
            {
                int temp = a1[i];
                a1[i] = a1[j];
                a1[j] = temp;
            }

            for(int i = 0; i <a1.Length; i++)
            {
                Console.WriteLine(a1[i] + "  ");
            }
        }
    }
}

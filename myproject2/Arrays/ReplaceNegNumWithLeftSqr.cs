using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ReplaceNegNumWithLeftSqr
    {

        static void Main(String [] args)
        {
            int[] a = { 12, 3, -19, 29, 5, -61, 44, 7, 49 };

            Console.WriteLine("Original Array");
            Console.WriteLine("..............................");
            Console.WriteLine(String.Join(" " , a));

            Console.WriteLine();

            for(int i=0; i<a.Length; i++)
            {
                if(a[i] < 0)
                {
                    a[i] = a[i - 1] * a[i - 1];
                }
            }
            Console.WriteLine("Immidiate Left Element Square");
            Console.WriteLine(".............................");
            Console.WriteLine(String.Join(" " , a));
        }
    }
}

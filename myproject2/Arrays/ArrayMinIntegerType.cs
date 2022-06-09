using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayMinIntegerType
    {
        static void Main(String [] args)
        {
            int[] a = { 4, 3, 6, 2, 0, 4, 7, };

            int Min = a[0];

            for(int i=a.Length-1 ; i>0; i--)
            {
                if (Min > a[i])
                {
                    Min = a[i];
                }
            }

            Console.WriteLine("Min Integer is = " + Min);
        }
    }
}

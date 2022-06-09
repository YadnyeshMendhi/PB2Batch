using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayMaxIntegerType
    {

        static void Main(String [] args)
        {
            int[] num = { 4, 6, 3, 8, 2, 9, };

            int Max = num[0];

            for(int i = 0; i<num.Length; i++)
            {
                if (Max < num[i])
                {
                   Max = num[i];
                }
            }
            Console.WriteLine("Max Integer is = " + Max);
        }
    }
}

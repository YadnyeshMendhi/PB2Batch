using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayNegative
    {

        static void Main(String [] args)
        {
            int[] n = { 2, -5, 4, -8, 7 };

            for (int i = 0; i <n.Length; i++)
            {
                if (n[i] < 0)
                {
                    n[i] = n[i] * n[i];
                }
               
            }
           /* for(int i = 0; i<n.Length; i++)
            {
                Console.WriteLine(n[i]);
            }*/


            foreach(int num in n)
            {
                Console.WriteLine(num);
            }
        }
    }
}

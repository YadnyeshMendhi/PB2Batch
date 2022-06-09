using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayMinCharType
    {

        static void Main(String [] args)
        {
            char[] Min = { 'A', 'D', 'E', 'x', 'z', 'R' };

            char c =  Min[0];

            for(int i=Min.Length - 1; i>0; i--)
            {
                if(c > Min[i])
                {
                    c = Min[i];
                }
            }

            Console.WriteLine("Minimum Character is = " +c);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ForWhileDowhile
    {
        static void Main(String[] args)
        {
            // print numbers 1 to 10 in for , while and do while loop
            // initialisation , condition and increment


            // For Loop
            Console.WriteLine("For Loop");
            for(int i = 1; i<= 5; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("..............................");
            Console.WriteLine("While Loop");
            // while loop

            int k = 1;
            while (k <= 5)
            {
                Console.WriteLine(k);
                k++;//k = k+1//k-- k = k-1
            }

            Console.WriteLine("................................");

            // Do While Loop
            Console.WriteLine("Do While Loop");

            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 5);
        }
    }
}

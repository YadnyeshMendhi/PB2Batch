using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class PrintSeriesMock
    {


        static void Main(String [] args)
        {

            //1 , 3 , 7 , 15 , 31


            int i, n, print = 0;
            Console.WriteLine("Enter the Limit");
             n = Convert.ToInt32(Console.ReadLine());

            for(i = 1; i <= n; i++)
            {
                print = print * 2 + 1;
                Console.WriteLine(print);
            }
        }
    }
}

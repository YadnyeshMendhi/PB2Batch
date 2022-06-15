using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Searching
    {

        static void Main(String [] args)
        {
            int[] a = { 5, 8, 3, 9, 2 };

            Console.WriteLine("Enter element for searching ");


            int num = Convert.ToInt32(Console.ReadLine());

            //int count = 0;
            bool IsPrime = false;
            for(int i = 0; i<a.Length; i++)
            {

                if (num == a[i])
                {
                    //count = 1;
                    IsPrime = true;
                    break;
                }
            }

            if(IsPrime == true)
            {
                Console.WriteLine("Number is present");
            }
            else
            {
                Console.WriteLine("Number is not present");
            }


            int[] a1 = { 3, 4, 8, 5, 7, 2 };

            Console.WriteLine("Enter Elements for searching");
            int num1 = Convert.ToInt32(Console.ReadLine());


            int count = 0;

            for(int i = 0; i<a.Length; i++)
            {
                if(num1 == 0)
                {
                    count = 1;
                    break;
                }
            }
            if(count == 1)
            {
                Console.WriteLine("Number is Present");
            }
            else
            {
                Console.WriteLine("Number is not present");
            }



        }
    }
}

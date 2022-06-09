using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Assignment2
    {

        static void Main(String[] args)
        {
            /*
                         1
                         21
                         321
                         4321
                         54321
            */

            /*
                        int i, j;
                        for (i = 1; i <= 5; i++)
                        {
                            for (j = i; j >= 1; j--)
                            {
                                Console.Write(j);
                            }
                            Console.WriteLine();

                        }*/
            /*
                1
                22
                333
                4444
                55555
                        int n = 5;
                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write(i);
                            }
                            Console.WriteLine();

                        } */
/*
            // WAP to calculate x y where x is base and y is index without using readymade function.
*//*
            int Base = 3;
            int exponent = 4;

            long result = 1;

            while (exponent != 0)
            {
                result *= Base;
                --exponent;
            }

            Console.WriteLine("Answer = " + result);
*/

            //WAP to accept mobile number and count frequency of digit
            //Frequency : the number of times something happens in a particular period

            /*  int digit, count = 0;
              Console.WriteLine("Enter mobile number");
              long num =long.Parse(Console.ReadLine());
              Console.WriteLine("Enter any digit");
              digit = Convert.ToInt32(Console.ReadLine());
              while(num > 0)
              {
                  count = (num % 10 == digit) ? count + 1 : count;
                  num = num / 10;

              }
              Console.WriteLine("Occurences of given digit in number = " +count);*/

            int d;
            Console.WriteLine("Enter Nth Term");
            int n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                d = i * i - 1;
                Console.Write(d + " ");
            }
            


        }
    }


}

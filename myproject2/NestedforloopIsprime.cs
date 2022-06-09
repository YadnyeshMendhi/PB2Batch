using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NestedforloopIsprime
    {
        static void Main(string[] args)
        {


            int num;
            int factor;
            int i;
            Boolean isPrime;

            for (num = 1; num < 10; num++)
            {
                isPrime = true;
                factor = 0;

                for (i = 2; i <= num / 2; i++)
                {
                    if ((num % i) == 0)
                    {
                        isPrime = false;
                        factor = i;
                    }

                    if (isPrime)
                    {
                        Console.WriteLine(num + " is a prime ");
                    }
                    

                }
            }
        }
    }
}


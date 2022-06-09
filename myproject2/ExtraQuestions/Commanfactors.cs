using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExtraQuestions
{
    class Commanfactors
    {

        static void Main(String [] args)
        {
            int a = 6;
            int b = 8;
            //1,2,3,6

            int min = a < b ? a : b;

            //comman factors

            for (int divisor = 1; divisor <= a && divisor <= b; divisor++)
            {
                if(a%divisor==0 && b % divisor == 0)
                {
                    Console.WriteLine(divisor);
                }
            }

        }
    }
}

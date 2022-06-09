using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class KrishnamurthiNum
    {
        static void Main(String[] args)
        {

            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;

            int sum = 0;
            while (num > 0)
            {
                int n = num % 10;
                int fact = 1;
                for (int i = 1; i <= n; i++)
                {
                    fact = fact * i;
                }

                sum = sum + fact;
                num = num / 10;
            }

            num = temp;

            if (num == sum)
            {
                Console.WriteLine("Number is Krishnamurthi number");

            }
            else
            {
                Console.WriteLine("Number is not krishnamurthi number"); ;
            }
        }





    }
}

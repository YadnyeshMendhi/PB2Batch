using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class KrishnamurthyNumber
    {
        static void Main(String [] args)
        {
            int sum = 0, temp;
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            temp = num;
            

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
                Console.WriteLine("Number is not Krishnamurthy number");
            }


           
        }
    }
}

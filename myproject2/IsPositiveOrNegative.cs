using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class IsPositiveOrNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter any Number  :");
            num= Convert.ToInt32(Console.ReadLine());


            if(num>0)
            {
                Console.WriteLine("Is an Positive Number : " +num);
            }
            else if(num < 0)
            {
                Console.WriteLine("Is an Negative Number : " +num);
            }
            else
            {
                Console.WriteLine("Is an Zero : " +num);
            }
        }
    }
}

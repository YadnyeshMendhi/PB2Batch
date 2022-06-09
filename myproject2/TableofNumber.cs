using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class TableofNumber
    {
        static void Main(String[] args)
        {
            Console.Write("Enter the number and get a table of that number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("...................................");


            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num+"*"+i+ "=" +(num*i));
            }
        }
    }
}

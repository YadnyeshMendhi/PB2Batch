using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NestedForloop2
    {
        static void Main(String [] args)
        {

            
            for(char  i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }


            /*
            for(int i = 4; i >= 1; --i)
            {
                for(int j = 1; i<= i; ++j)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            */
            /*
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 4; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();

            }
            */


            for (int i = 1; i <= 4; i++)
            {
                for (int k = 4; k > i; k--)
                {
                    Console.Write("  ");
                }
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(" *");
                }
                Console.WriteLine();
            }




        }
    }
}

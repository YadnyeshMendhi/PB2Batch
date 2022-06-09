using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NestedForloop
    { 
        static void Main(String [] args)
        {
            /*
            for(int i = 1; i <=4; ++i)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
               
            }

            */
           /*
            for(int i = 1; i <= 5; ++i)
            {
                for(int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            
            */
            /*
            for(int i= 1; i <= 4; i++)
            {
                for(int j = 1; j<=4; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            */
            /*
            for(int i = 1; i <= 5; i++)
            {
                for(int j = 1; j <=i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            */

            for(char i ='A'; i<= 'D'; i++)
            {
                for(char j= 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }



           
        }
    }
}

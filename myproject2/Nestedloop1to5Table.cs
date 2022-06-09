using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Nestedloop1to5Table
    {
        static void Main(string[] args)
        {
            
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(j*i);
                }
                Console.WriteLine("   ");
                
            }
        }
    }
}

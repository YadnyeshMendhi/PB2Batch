using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NestedForloopChar
    {
        static void Main(string[] args)
        {
            /*
            for(char i = 'A'; i <= 'D'; i++)
            {
                for(char j = 'A'; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
            */

            for (char i = 'D'; i >= 'A'; i--)
            {
                for (char j = 'D'; j >= i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }

    }
}

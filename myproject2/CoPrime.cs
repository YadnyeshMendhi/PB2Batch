using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class CoPrime
    {

        static void Main(String [] args)
        {
            int a = 15;
            int j;
            for(int i = 1; i <= a; i++)
            {
                int c = 0;
                for (j = 1; j < i; j++)
                {
                    if(a%j==0 && i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine($"coprime pair is {i} {a}");
                }
            }
        }
    }
}

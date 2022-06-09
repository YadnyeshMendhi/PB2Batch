using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class ArrowPattern
    {
        static void Main(String [] args)
        {
            int n = 5;

            for(int i = 0; i< 2*n; i++)
            {
                int col = i > n ? 2 * n - i : i;

                int spaces = n - col;
                for(int s = 0; s<spaces; s++)
                {
                    Console.Write(" ");

                }
                for(int j = 0; j < col; j++)
                {
                    Console.Write("  *  ");
                }
                Console.WriteLine();
            }
        }
    }
}

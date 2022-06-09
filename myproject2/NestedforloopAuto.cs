using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class NestedforloopAuto
    {
        static void Main(string[] args)
        {

            int row, col;
            Console.WriteLine("Enter rows");
            row = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter columns ");
            col = Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= row; i++)
            {
                for(int j = 1; j <= col; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}

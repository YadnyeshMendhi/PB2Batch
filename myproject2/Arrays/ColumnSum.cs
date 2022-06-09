using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ColumnSum
    {

        static void Main(String[] args)
        {


            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {
                int colsum = 0;
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    colsum = colsum + a[j, i];
                }

                Console.Write("colsum = " + colsum);
                Console.WriteLine();
            }
        }
    }
}

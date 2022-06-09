using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class RowSum
    {

        static void Main(String[] args)
        {


            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i <a.GetLength(0); i++)
            {
                int rowsum = 0;
                for(int j = 0; j<a.GetLength(1); j++)
                {
                    rowsum = rowsum + a[i, j];
                }

                Console.Write("sum = " +rowsum);
                Console.WriteLine();
            }
        }

    }
}

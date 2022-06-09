using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ColumnMin
    {


        static void Main(String[] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };

            for (int i = 0; i < a.GetLength(0); i++)
            {

                int colMin = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (colMin > a[j, i])
                    {
                        colMin = a[j, i];
                    }
                }
                Console.WriteLine("colMin is = " + colMin);
            }
        }
    }
}

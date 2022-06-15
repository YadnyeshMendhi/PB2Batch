using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ColumnMax
    {

        static void Main(String[] args)
        {

            int[,] a = new int[4,3] { { 6, 7, 8 }, { 4, 9, 5 }, { 7, 8, 9 }, { 5,3,7} };


            for (int i = 0; i < a.GetLength(0); i++)
            {

                int colmax = a[i, 0];
                for (int j = 0; j < a.GetLength(1); j++)
                {

                    if (colmax < a[j,i])
                    {
                        colmax = a[j,i];

                    }
                }
                Console.WriteLine("colmax is = " + colmax);
            }
        }
    }
}

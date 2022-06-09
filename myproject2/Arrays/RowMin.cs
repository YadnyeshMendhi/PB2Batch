using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class RowMin
    {

       static void Main(String [] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 6, 7, 8 } };

            for(int i=0; i<a.GetLength(0); i++)
            {

                int rowMin = a[i, 0];
                for(int j=0; j<a.GetLength(1); j++)
                {
                    if (rowMin > a[i, j])
                    {
                        rowMin = a[i, j];
                    }
                }
                Console.WriteLine("rowMin is = " +rowMin);
            }
        }
    }
}

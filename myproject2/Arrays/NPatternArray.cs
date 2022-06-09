using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class NPatternArray
    {

        static void Main(String [] args)
        {
            int[,] a = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    ///int n = 5;
                    if (i == 0 || j == 0 || i==a.GetUpperBound(0) || j == a.GetUpperBound(1))
                   //if(j==1 || j==n || i==j)
                    {
                        Console.Write(a[i,j] +" ");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}

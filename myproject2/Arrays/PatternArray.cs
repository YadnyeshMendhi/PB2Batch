using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class PatternArray
    {


        static void Main(String [] args)
        {

            int[,] a = new int[3,3] { { 1, 2, 3 },
                                    { 4, 5, 6 },
                                     { 7, 8, 9 }};

            int n = 5;
            for (int i = 0; i < a.GetLength(0); i++)
            {

                for (int j = 0; j < a.GetLength(1); j++)
                {
                  if(j==1 || j == n || i==a.GetUpperBound(0) || j==a.GetLowerBound(1))
                  {
                        Console.Write(a[i,j]);
                  }
                  Console.WriteLine();
                }
            }
        }
    }
}

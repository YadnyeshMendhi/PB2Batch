using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class RowMax
    {

        static void Main(String [] args)
        {
            int[,] a = new int[,] { { 6, 7 , 8 }, { 4, 9 , 5 } , { 7, 8, 9 } };


            for(int i=0; i<a.GetLength(0); i++)
            {

                int rowmax = a[i, 0]; 
                for(int j=0; j<a.GetLength(1); j++)
                {

                    if(rowmax<a[i, j])
                    {
                        rowmax = a[i, j];
                        
                    }

                }

                Console.WriteLine("rowmax is = " +rowmax);
               
              
               
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class TwodArray1
    {

       static void Main(String [] args)
        {
            int[,] a = new int[2, 2];
            /*
                        a[0, 0] = 12;
                        a[0, 1] = 13;
                        a[1, 0] = 15;
                        a[1, 1] = 17;*/


            Console.WriteLine("Enter array elements");

            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for (int i = 0; i <a.GetLength(0); i++)
            {
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    Console.Write(a[i , j] +" ");
                }             
                Console.WriteLine();
            }
            Console.WriteLine("..................................");

            foreach(int i in a)
            {
                Console.WriteLine(i + " ");
            }


        }
    }
}

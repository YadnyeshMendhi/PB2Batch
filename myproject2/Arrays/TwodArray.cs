using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class TwodArray
    {

        static void Main(String[] args)
        {
            int[,] a = new int[2, 2];
            int[,] a1 = new int[2, 2];

            Console.WriteLine("Enter Array Elements");

            for(int i = 0; i<a.GetLength(0); i++)
            {
                for(int j = 0; j<a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i <a.GetLength(0); i++)
            {
                for (int j = 0; j <a.GetLength(1); j++)
                {
                    Console.Write(a[i , j] + " ");
                }
            }


            Console.WriteLine("Enter Array Elements");

            for (int i = 0; i <a1.GetLength(0); i++)
            {
                for (int j = 0; j <a1.GetLength(1); j++)
                {
                    a1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i <a1.GetLength(0); i++)
            {
                for (int j = 0; j <a1.GetLength(1); j++)
                {
                    Console.Write(a1[i , j] + " ");
                }
                
            }
          
            int sum = 0;
            for(int i = 0; i<a.GetLength(0); i++)
            {
                for(int j = 0; j<a.GetLength(1); j++)
                {
                    sum =  a[i, j] + a1[i, j];
                }
            }
            Console.WriteLine("sum is = "+sum);

        }
    }
}

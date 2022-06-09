using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class SumOfArray
    {

        static void Main(String [] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };


            //int  = Convert.ToInt32(Console.ReadLine());
            //int sum = 0;
            bool isPrime = true;
            for (int i=2; i<arr.Length; i++)
            {
                if (arr[i] % i == 0)
                {
                    isPrime = false;
                    
                }
               // sum = sum + arr[i];

              /*  for (int j = 0; j < arr.Length; j++) 
                {
                    sum = sum + arr[i];

                }*/

            }
            //Console.WriteLine(String.Join(" "  ,sum));

            if(isPrime == true)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }
        }
    }
}

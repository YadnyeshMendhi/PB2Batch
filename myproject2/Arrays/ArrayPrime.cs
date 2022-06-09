using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ArrayPrime
    {

        static void Main(String[] args)
        {

           
            int[] arr = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.WriteLine("pick the prime number form given array");

            for(int i=0; i<arr.Length; i++)
            {
                for(int j=2; j<arr[i]; j++)
                {
                    if (arr[i] % j == 0)
                    {
                        Console.WriteLine("{ 0} : is not primenumber" ,+arr[i]);
                        break;
                    }
                    if (j == arr[i])
                    {
                        Console.WriteLine("{0} : is a prime number" , +arr[i]);
                    }

                }
            }
            
            
               
            
        }
    }
}

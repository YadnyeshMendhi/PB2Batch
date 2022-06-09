using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class ReverseArray
    {

        static void Main(String [] args)
        {
           /* int[] a = { 11, 22, 33, 44, 55 };

            Console.WriteLine(String.Join(",", a));

            Console.WriteLine("...................");
            for(int i = a.Length-1; i>=0; i--)
            { 
 
                Console.Write(a[i] + " ");   

            }
            Console.WriteLine("...................");
            Console.WriteLine(String.Join(",", a));
            int j = a.Length - 1;


            for(int i = 0; i <a.Length/2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }
            Console.WriteLine("/////////////////////");


            for(int i = 0; i<a.Length; i++)
            {
                Console.WriteLine(a[i] + "  ");
            }

*/

            /* for(int i = 0; i<a1.Length/2; i++)
             {
                 int temp = a[i];
                 a[i] = a[j];
                 a[j] = temp;
             }

             for(int i = 0; i<a.Length; i++)
             {
                 Console.WriteLine(a[i] +" ,");
             }*/

            //i d array

            int[] a1 = { 1, 2, 3, 4, 5, 6, 7, 8 };

            Console.WriteLine(String.Join(" , ", a1));

            Console.WriteLine("............................");


            for(int i = a1.Length-1; i>=0; i--)
            {
                Console.Write(a1[i] + " , ");
            }
        }
    }
}

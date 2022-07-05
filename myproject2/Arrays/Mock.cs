using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arrays
{
    class Mock
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6 };

            // output 4,5,6,1,2,3
           /* for (int i = a.Length - 1; i >= 0; i--)
            {

                Console.Write(a[i] + " ");

            }*/
            //Console.WriteLine(String.Join(",", a));
            //Console.WriteLine("..............................");
            int j = a.Length/2;


            for (int i = 0; i < a.Length/2; i++,j++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
            }


            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + "  ");
            }

        }
    }
}

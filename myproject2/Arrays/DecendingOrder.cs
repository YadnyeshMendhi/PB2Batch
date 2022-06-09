using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class DecendingOrder
    {

        static void Main(String[] args)
        {
            Console.WriteLine("Enter the size of array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] a = new int[size];

            Console.WriteLine("Enter array elements");

            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(String.Join(" ", a));

            Console.WriteLine("...................................");

            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
                }
            }
            Console.WriteLine(String.Join(" ", a));
        }
    }
}

    


using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class MergeArray
    {

        static void Main(String[] args)
        {
            int[] a = { 11, 12, 13, 14 };
            int[] b = { 10, 20, 30, 40 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;

            for (int i = 0; i < a.Length; i++)
            {
                c[k] = a[i];
                k++;
            }
            for (int i = 0; i < b.Length; i++)
            {
                c[k] = b[i];
            }
            for (int i = 0; i < c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}

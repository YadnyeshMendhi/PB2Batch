using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2.Arrays
{
    class ProrigoPractice
    {
        static void Main(string[] args)
        {
            int[][] a = new int[2][];

            a[0] = new int[4] { 6, 1, 4, 3 };
            a[1] = new int[3] { 9, 2, 7 };
            Console.WriteLine(a[1].GetUpperBound(0));



            int i, j;
            i = 100;
            j = 200;
            while (++i < --j) ;
            Console.WriteLine("Midpoint is="+i);
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arrays
{
    class Replace0To1
    {

        static void Main(String [] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };


            int replace =  a[0];


            for(int i = 0; i<a.Length; i++)
            {
                if (a[i] == 0)
                {
                    a[i] = 1;
                }

            }
            Console.WriteLine(String.Join(" " ,a));
           


        }
    }
}

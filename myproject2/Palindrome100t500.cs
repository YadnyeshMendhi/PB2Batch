﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class Palindrome100t500
    {

        static void Main(String [] args)
        {
            int num, n, rev_no, r;
            Console.WriteLine("Palindrome Number from 1 to 500");
            for (num = 1; num <= 500; num++)
            {
                rev_no = 0;
                n = num;
                while (n != 0)
                {
                    r = n % 10;
                    rev_no = rev_no * 10 + r;
                    n = n / 10;
                }
                if (num == rev_no)
                    Console.Write(num + " ");
            }
            Console.ReadKey();
        }
    }
}

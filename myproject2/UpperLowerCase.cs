using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class UpperLowerCase
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("enter Character");
            ch = Console.ReadLine()[0];


            if (ch >= 'A' && ch <= 'Z')
            {
                ch = (char)(ch + 32);
            }
            else
            {
                ch = (char)(ch - 32);
            }

            Console.WriteLine(ch);
        }
    }
}

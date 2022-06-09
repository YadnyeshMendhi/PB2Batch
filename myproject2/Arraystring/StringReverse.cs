using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class StringReverse
    {

        static void Main(string [] args)
        {
            String str = "India is my country";
            String reverse = " ";

            for(int i=str.Length-1; i>=0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);

        }
    }
}

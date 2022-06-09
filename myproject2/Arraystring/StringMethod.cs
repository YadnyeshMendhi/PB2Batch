using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class StringMethod
    {
        static void Main(String[] args)
        {
            char ch;
            String str = "India is country";
            int l = str.Length;


            Console.WriteLine("No of char from string = " + l);


            String[] mywords = str.Split(" ");
            foreach (String st in mywords)
            {
                Console.WriteLine(st);
            }


        }

    }
}

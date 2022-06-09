using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class ReverseStringUsingMethod
    {

        public String doReverse(String str)
        {
            char[] ch = str.ToCharArray();
            Array.Reverse(ch);

            String st = new string(ch);
            return st;

           /* return new String(ch)*/
        }

        static void Main(string [] args)
        {
            Console.WriteLine("Enter the String");
            String s = Console.ReadLine();
            ReverseStringUsingMethod rev = new ReverseStringUsingMethod();
            Console.WriteLine(rev.doReverse(s));
        }

    }
}

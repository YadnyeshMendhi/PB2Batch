using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class ReverseWord
    {

        static void Main(string[] args)
        {
            String str = "India is my country";

            String[] mywords = str.Split(" ");

            String reverseString = " ";

            for(int i=0; i<mywords.Length; i++)
            {
                String s = mywords[i];
                String reverseMyword = " ";

                for(int j=s.Length-1; j>=0; j--)
                {
                    reverseMyword = reverseMyword + s[j];
                }
                reverseString = reverseString + reverseMyword + " ";
            }
            Console.WriteLine(reverseString);
        }
    }
}

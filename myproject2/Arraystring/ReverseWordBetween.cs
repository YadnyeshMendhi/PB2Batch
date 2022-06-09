using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class ReverseWordBetween
    {

        static void Main(string [] args)
        {
            String s = "My country is india Country";

            String[] str = s.Split(" ");

            String reverseWord = " ";

            for(int i=1; i<str.Length; i++)
            {
                String word = str[i];
                String reverse = " ";
               for(int j=word.Length-1; j>=0; j--)
                {
                    reverse = reverse + word[j];
                }
                reverseWord = reverseWord + reverse + " ";

            }
            Console.WriteLine(reverseWord);

            Console.WriteLine(str[0] +" "+ reverseWord + " "+str[str.Length-1]);
        }
    }
}

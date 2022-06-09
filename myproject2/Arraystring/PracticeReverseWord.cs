using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class PracticeReverseWord
    {

        static void Main(string[] args)
        {
            String str = "India is my country";

            String[] myword = str.Split(" ");

            String reverseString = " ";

            for (int i = 1; i < myword.Length; i++)
            {
                String s = myword[i];
                String reverseMyword = " ";
                for (int j = s.Length - 1; j >= 0; j--)
                {
                    reverseMyword = reverseMyword + s[j];
                }
                reverseString = reverseString + reverseMyword + " ";  
            }
            Console.WriteLine(reverseString);
            Console.WriteLine(str[0]+" "+reverseString+" "+str[str.Length - 1]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class CountVowels
    {

        static void Main(string[] args)
        {
            String str = "Microsoft Windows";

            int Vowelcount = 0;

            for(int i=0; i<str.Length; i++)
            {
                if (str[i] == 'a' || str[i] == 'e' || str[i] == 'i' || str[i] == 'o' || str[i] == 'u' ||
                    str[i] == 'A' || str[i] == 'E' || str[i] == 'I' || str[i] == 'O' || str[i] == 'U')
                {
                    Vowelcount++;

                }
                
            }
            Console.WriteLine("Vowels in the string = " +Vowelcount);
        }
    }
}

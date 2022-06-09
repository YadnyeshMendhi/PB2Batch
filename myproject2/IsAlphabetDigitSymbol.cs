using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class IsAlphabetDigitSymbol
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter any character : ");
            //  ch = Convert.ToChar(Console.ReadLine());
            ch = Console.ReadLine()[0];

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine("is an Alphabet : " +ch);

            }

            else if(ch >= '0' && ch <= '9')
            {
                Console.WriteLine("is an Digit : " +ch);
            }
            else
            {
                Console.WriteLine("is an Special character :" +ch);
            }

        }
    }
}

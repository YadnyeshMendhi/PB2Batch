using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class CountDigits
    {

        static void Main(string [] args)
        {

            Console.WriteLine("Enter String");
            String str = Console.ReadLine();


            int CountDigit = 0;

            for(int i=0; i<str.Length; i++)
            {
                if(str[i] == '0' || str[i] == '1' || str[i] == '2' || str[i] == '3' || str[i] == '4' ||
                    str[i] == '5' || str[i] == '6' || str[i] == '7' || str[i] == '8' || str[i] == '9')
                {
                    CountDigit++;
                }
            }
            Console.WriteLine("Digit in the string = " +CountDigit);
        }
    }
}

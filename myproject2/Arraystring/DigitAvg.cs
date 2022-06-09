using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class DigitAvg
    {

        static void Main(string [] args)
        {
            Console.WriteLine("Enter a String ");
            String str = Console.ReadLine();

            int count = 0;
            int alpha = 0;
            int symbol = 0;
            int sum = 0;

            for(int i=0; i<str.Length; i++)
            {
                if (Char.IsLetter(str[i]))//str[i]>'a' && str[i]<'z' || str[i]>'A' && str[i]<'Z'
                {
                    alpha++;
                }
                else if (char.IsDigit(str[i]))//str[i]>'0' && str[i]<'9'
                {
                    count++;

                    int x = (int)(Char.GetNumericValue(str[i]));
                    sum = sum + x;

                   /* int x = int.Parse(str[i].ToString());
                    sum = sum + x;*/
                }
                else
                {
                    symbol++;
                }
            }
            Console.WriteLine("Number of Digits = " +count);
            Console.WriteLine("Number of Alphabets = " +alpha);
            Console.WriteLine("Number of Symbols =" +symbol);

            Console.WriteLine("Sum of digit = "+sum);

            try
            {
                int avg = sum / count;
                Console.WriteLine("Average = " + avg);
            }
            catch(DivideByZeroException d)
            {
                Console.WriteLine("An Exception has occured : {0} " , d.Message );
            }


           /* int x = (int)(char.GetNumericValue(str[i]));
            sum = sum + x;*/
        }
    }
}

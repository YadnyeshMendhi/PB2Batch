using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Arraystring
{
    class Sum1_3Digits
    {

        static void Main(String[] args)
        {
            String s = "1234567";

           
            int sum = 0;
            int sum1 = 0;
            int count = 0;
            int count1 = 0;

            char[] ch = s.ToCharArray();
            for(int i=0; i< 3; i++)
            {
                if(char.IsDigit(s[i]))
                {

                    count++;
                    int x = (int)(Char.GetNumericValue(s[i]));
                    sum = sum + x;
                }
            }
            Console.WriteLine(sum);

            char[] ch1 = s.ToCharArray();
            for (int i = 4; i < 7; i++)
            {
                if (char.IsDigit(s[i]))
                {

                    count1++;
                    int x = (int)(Char.GetNumericValue(s[i]));
                    sum1 = sum1 + x;
                }
            }
            Console.WriteLine(sum1);


            if(sum == sum1)
            {
                Console.WriteLine("Valid string");
            }
            else
            {
                Console.WriteLine("Not valid string");
            }
        }
    }
}

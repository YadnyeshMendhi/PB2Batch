using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.ExtraQuestions
{
    class ArithmeticProgression
    {

        static void Main(String [] args)
        {
            Console.WriteLine("Enter 2nd number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num2 = Convert.ToInt32(Console.ReadLine());


            int different = 5;
            int nth = 7;
            int first = num1 - different;
            int AP = first + (nth - 1) * 5;
            Console.WriteLine(AP);

            /*
                        int nth = 7;
                        int difference = 5;

                        //Formula t7 = a +(n-1) * 5

                        int ap = num1 + (7 - 1) * 5;
                        Console.WriteLine(ap);*/
        }
    }
}

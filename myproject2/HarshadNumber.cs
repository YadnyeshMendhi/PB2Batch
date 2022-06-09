using System;
using System.Collections.Generic;
using System.Text;

namespace myproject2
{
    class HarshadNumber
    {

        static void Main(String [] args)
        {
            Console.WriteLine("Enter any positive number : ");

            int inputNumber = Convert.ToInt32(Console.ReadLine());

            checkForHarshad(inputNumber);
        }
        private static void checkForHarshad(int inputNumber)
        {

            int copyOfInputNumber = inputNumber;

            int sum = 0;

            int lastDigit = 0;

            //Calculating the sum of digits of inputNumber

            while (inputNumber != 0)
            {
                lastDigit = inputNumber % 10;

                sum = sum + lastDigit;

                inputNumber = inputNumber / 10;
            }

            //Checking whether inputNumber is divisible by sum

            if ((copyOfInputNumber % sum) == 0)
            {
                Console.WriteLine(copyOfInputNumber + " is a Harshad number");
            }
            else
            {
                Console.WriteLine(copyOfInputNumber + " is not a Harshad number");
            }
        }
    }
}

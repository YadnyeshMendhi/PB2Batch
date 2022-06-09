using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class DisariumNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int temp = num;
            int count = 0;
            while(num > 0)
            {
                count++;
                num = num / 10;

            }
            Console.WriteLine(count);
            num = temp;
            int sum = 0;
            while(num > 0)
            {
                int r = num % 10;
                int power = 1;
                for(int i = 1; i <= count; i++)
                {
                    power = power * i;
                }
                sum = sum + power;
                num = num / 10;
                count--;

            }
            Console.WriteLine(sum);
            num = temp;

            if(num == sum)
            {
                Console.WriteLine("Number is Disarium number");
            }
            else
            {
                Console.WriteLine("Numer is not Disarium number");
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class BloodDonationEligible
    {
        static void Main(string[] args)
        {
            int age, weight;
            Console.WriteLine("Enter Age");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Weight ");
            weight = Convert.ToInt32(Console.ReadLine());

            if(age > 18 && weight > 50)
            {
                Console.WriteLine("person is eligible for blood donation");
            }
            else
            {
                Console.WriteLine("Not Eligible");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class WeekdayORweekend
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a day of week");
            String day = Console.ReadLine();

            if(day == "monday")
            {
                Console.WriteLine("weekday");
            }
            else if(day == "tuesday")
            {
                Console.WriteLine("weekday");
            }
            else if(day == "wednsday")
            {
                Console.WriteLine("weekday");

            }
            else if(day == "thursday")
            {
                Console.WriteLine("weekday");
            }
            else if(day == "friday")
            {
                Console.WriteLine("weekday");
            }
            else
            {
                Console.WriteLine("weekend");
            }
        }
    }
}

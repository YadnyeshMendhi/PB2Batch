using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Enums
{
    class EnumSwitchStatement
    {
        /*enum level
        { 
            low,
            medium,
            high
        }
        static void Main(String[] args)
        {
            level l = level.medium;
            switch(l)
            {
                case level.low:
                    Console.WriteLine("low level");
                    break;
                case level.medium:
                    Console.WriteLine("medium level");
                    break;
                case level.high:
                    Console.WriteLine("high level");
                    break;
                default:
                    Console.WriteLine("input wrong");
                    break;
*/

        enum day
        { 
            monday,
            tuesday,
            wedusday,
            thursday,
            friday,
            saturday,
            sunday
        }
        static void Main(String[] args)
        {
            /* day d = day.sunday;*//*
            int myvar = (int)day.sunday;
            Console.WriteLine(myvar);*/
            day d = day.monday;
            switch (d)
            {
                case day.monday:
                    Console.WriteLine("weekday");
                    break;
                case day.tuesday:
                    Console.WriteLine("weekday");
                    break;
                case day.wedusday:
                    Console.WriteLine("weekday");
                    break;
                case day.thursday:
                    Console.WriteLine("weekday");
                    break;
                case day.friday:
                    Console.WriteLine("weekday");
                    break;
                case day.saturday:
                    Console.WriteLine("weekend");
                    break;

                case day.sunday:
                    Console.WriteLine("weekend");
                    break;
                default:
                    Console.WriteLine("your input was wrong");
                    break;
            }

        }
    }
}
    
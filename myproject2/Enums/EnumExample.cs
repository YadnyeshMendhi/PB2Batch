using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Enums
{
    class EnumExample
    {
        enum Days { mon , tue , wed , thur , fri , sat , sun}






        static void Main(String[] args)
        {
            int WeekdayStart = (int)Days.mon;
            int WeekdayEnd = (int)Days.fri;


            Console.WriteLine("Monday : {0}" , WeekdayStart);
            Console.WriteLine("Friday : {0}" , WeekdayEnd);
           
        }
    }
}

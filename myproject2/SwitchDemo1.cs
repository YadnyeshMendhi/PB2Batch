using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class SwitchDemo1
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number  : ");
            num = Convert.ToInt32(Console.ReadLine());



            switch (num)
            {
                case 1: Console.WriteLine("one");
                    break;
                case 2: Console.WriteLine("two");
                    break;
                case 3: Console.WriteLine("three");
                    break;
                case 4: Console.WriteLine("four");
                    break;
                case 5: Console.WriteLine("five");
                    break;
                default : Console.WriteLine("invalid unput");
                    break;

            }
        }
    }
}

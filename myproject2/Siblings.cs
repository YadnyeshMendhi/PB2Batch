using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class Siblings
    {
        static void Main(string[] args)
        {
            int older, younger , person = 0;
            Console.WriteLine("Enter number of older siblings");
            older = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of younmger child");
            younger = Convert.ToInt32(Console.ReadLine());



            if(person == 0)
            {
                Console.WriteLine("Only child");
            }
           else if(person == younger)
            {
                Console.WriteLine("Oldest child");
            }
            else if (person == older)
            {
                Console.WriteLine("youngest child");
            }
            else if (person == older && person == younger)
            {
                Console.WriteLine("middle child");
            }
          
        }
    }
}

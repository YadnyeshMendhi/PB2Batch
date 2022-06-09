using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1
{
    class CheckAlphabet
    {
        static void Main(string[] args)
        {


            char Char;
            Console.WriteLine("INPUT YOUR VALUE : ");
            Char = Convert.ToChar(Console.ReadLine());


            if ((Char > 'a' && Char < 'z') || (Char > 'A' && Char < 'Z'))
            {

                Console.WriteLine("Alphabet");

            }
            else
            {
                Console.WriteLine("Not alphabet");
            }


        }
    }
}

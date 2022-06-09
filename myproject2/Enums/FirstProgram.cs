using System;
using System.Collections.Generic;
using System.Text;

namespace MyProject1.Enums
{
    class FirstProgram
    {
        enum level
        { 
            //Readonly
            Low,
            Medium, 
            High
        }

        static void Main(String[] args)
        {
            level l = level.High;
            Console.WriteLine(l);
            
        }
       
    }
}
